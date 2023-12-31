﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Round
{
    public partial class Round : Form
    {
        public Round()
        {
            InitializeComponent();
        }
        private static byte[] Pz = new byte[16];//Plaintext Block size
        private static byte[] Cz = new byte[16];//Cipher Block size
        private static byte[] RKey = new byte[176];//number of key per round
        private static byte Nr = 0;//number of rounds
        private byte[,] State = new byte[4, 4];//State matrix
        
        // This method replaces each byte of the cluster in the order of the SBox. It provides an irreversible transformation of blocks during encryption
        private void SubBytes()// SubBytes
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    State[j, i] = SBox(State[j, i]);
                }
            }
        }
        private static byte SBox(int value) //SBOX
        {
            byte[] sbox = new byte[256] {  // populate the Sbox matrix [16,16]
                  /* 0     1     2     3     4     5     6     7     8     9     a     b     c     d     e     f */
              /*0*/  0x63, 0x7c, 0x77, 0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 0x01, 0x67, 0x2b, 0xfe, 0xd7, 0xab, 0x76,
              /*1*/  0xca, 0x82, 0xc9, 0x7d, 0xfa, 0x59, 0x47, 0xf0, 0xad, 0xd4, 0xa2, 0xaf, 0x9c, 0xa4, 0x72, 0xc0,
              /*2*/  0xb7, 0xfd, 0x93, 0x26, 0x36, 0x3f, 0xf7, 0xcc, 0x34, 0xa5, 0xe5, 0xf1, 0x71, 0xd8, 0x31, 0x15,
              /*3*/  0x04, 0xc7, 0x23, 0xc3, 0x18, 0x96, 0x05, 0x9a, 0x07, 0x12, 0x80, 0xe2, 0xeb, 0x27, 0xb2, 0x75,
              /*4*/  0x09, 0x83, 0x2c, 0x1a, 0x1b, 0x6e, 0x5a, 0xa0, 0x52, 0x3b, 0xd6, 0xb3, 0x29, 0xe3, 0x2f, 0x84,
              /*5*/  0x53, 0xd1, 0x00, 0xed, 0x20, 0xfc, 0xb1, 0x5b, 0x6a, 0xcb, 0xbe, 0x39, 0x4a, 0x4c, 0x58, 0xcf,
              /*6*/  0xd0, 0xef, 0xaa, 0xfb, 0x43, 0x4d, 0x33, 0x85, 0x45, 0xf9, 0x02, 0x7f, 0x50, 0x3c, 0x9f, 0xa8,
              /*7*/  0x51, 0xa3, 0x40, 0x8f, 0x92, 0x9d, 0x38, 0xf5, 0xbc, 0xb6, 0xda, 0x21, 0x10, 0xff, 0xf3, 0xd2,
              /*8*/  0xcd, 0x0c, 0x13, 0xec, 0x5f, 0x97, 0x44, 0x17, 0xc4, 0xa7, 0x7e, 0x3d, 0x64, 0x5d, 0x19, 0x73,
              /*9*/  0x60, 0x81, 0x4f, 0xdc, 0x22, 0x2a, 0x90, 0x88, 0x46, 0xee, 0xb8, 0x14, 0xde, 0x5e, 0x0b, 0xdb,
              /*a*/  0xe0, 0x32, 0x3a, 0x0a, 0x49, 0x06, 0x24, 0x5c, 0xc2, 0xd3, 0xac, 0x62, 0x91, 0x95, 0xe4, 0x79,
              /*b*/  0xe7, 0xc8, 0x37, 0x6d, 0x8d, 0xd5, 0x4e, 0xa9, 0x6c, 0x56, 0xf4, 0xea, 0x65, 0x7a, 0xae, 0x08,
              /*c*/  0xba, 0x78, 0x25, 0x2e, 0x1c, 0xa6, 0xb4, 0xc6, 0xe8, 0xdd, 0x74, 0x1f, 0x4b, 0xbd, 0x8b, 0x8a,
              /*d*/  0x70, 0x3e, 0xb5, 0x66, 0x48, 0x03, 0xf6, 0x0e, 0x61, 0x35, 0x57, 0xb9, 0x86, 0xc1, 0x1d, 0x9e,
              /*e*/  0xe1, 0xf8, 0x98, 0x11, 0x69, 0xd9, 0x8e, 0x94, 0x9b, 0x1e, 0x87, 0xe9, 0xce, 0x55, 0x28, 0xdf,
              /*f*/  0x8c, 0xa1, 0x89, 0x0d, 0xbf, 0xe6, 0x42, 0x68, 0x41, 0x99, 0x2d, 0x0f, 0xb0, 0x54, 0xbb, 0x16 };
            byte resnum = sbox[value];
            return resnum;
        }


        // The ShiftRows() function shifts the rows in the state to the left.
        private void ShiftRows()// ShiftRows
        {
            {
                byte[,] temp = new byte[4, 4];
                for (int i = 0; i < 4; i++)  // copy State into temp[]
                {
                    for (int j = 0; j < 4; j++)
                    {
                        temp[i, j] = this.State[i, j];
                    }
                }

                for (int i = 1; i < 4; i++)  // shift temp into State
                {
                    for (int j = 0; j < 4; j++)
                    {
                        this.State[i, j] = temp[i, (j + i) % 4];
                    }
                }
            }  
        }

        // MixColumns function mixes the columns of the state matrix
        private void MixColumns()// MixColumns
        {
            int i;
            byte Tmp, tt, t;
            for (i = 0; i < 4; i++)
            {
                t = State[0, i];
                Tmp = (byte)((int)State[0, i] ^ State[1, i] ^ State[2, i] ^ State[3, i]);
                tt = (byte)((int)State[0, i] ^ State[1, i]);
                tt = (byte)((int)xtime(tt));
                State[0, i] ^= (byte)((int)tt ^ Tmp);
                tt = (byte)((int)State[1, i] ^ State[2, i]);
                tt = (byte)((int)xtime(tt));
                State[1, i] ^= (byte)((int)tt ^ Tmp);
                tt = (byte)((int)State[2, i] ^ State[3, i]);
                tt = (byte)((int)xtime(tt));
                State[2, i] ^= (byte)((int)tt ^ Tmp);
                tt = (byte)((int)State[3, i] ^ t);
                tt = (byte)((int)xtime(tt));
                State[3, i] ^= (byte)((int)tt ^ Tmp);
            }
        }
        private static byte xtime(int b)
        {
            int x = (b << 1) ^ (((b >> 7) & 1) * 0x1b);
            return (byte)x;
        }//xtime operator


        // The round key is added to the state by an XOR function.
        private void AddRoundKey(int round)// AddRoundKey
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    this.State[i, j] = (byte)((int)this.State[i, j] ^ (int)RKey[round * 4 * 4 + i * 4 + j]);
                }
            }
        }


        private void Encrypte()// تابع تشفير إدخال 16 بايت
        {
            byte[] P = StringToByteArray(plaintxt.Text);//Convert the Plaintext (input textbox) to an array of bytes

            Pz = P;

            for (int i = 0; i < 4; i++) //Add bytes into the state matrix column by column, and within each column, from top to bottom
            {
                for (int j = 0; j < 4; j++)
                {
                    State[j, i] = Pz[i * 4 + j];
                }
            }

            AddRoundKey(0);//add Primary round key

            for (Nr = 1; Nr < 10; Nr++) //main round loop
            {
                SubBytes();
                ShiftRows();
                MixColumns();
                AddRoundKey(Nr);
            }

            SubBytes();
            ShiftRows();
            AddRoundKey(10);

            for (int i = 0; i < 4; i++)//Extract encrypted bytes from State matrix 
            {
                for (int j = 0; j < 4; j++)
                {
                    Cz[i * 4 + j] = State[j, i];
                }
            }

            string C;//Show in (output textbox) The Encrypted result as a string 
            C = ByteArrayToString(Cz);
            ciphertxt.Text = C;

        }
        public static byte[] StringToByteArray(String hex)//Convert String To array of bytes
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
        public static string ByteArrayToString(byte[] by)//Convert array of bytes To String  
        {
            StringBuilder hex = new StringBuilder(by.Length * 2);
            foreach (byte b in by)
                hex.AppendFormat("{0:x2} ", b);
            return hex.ToString();
        }

        private void encryptbtn_Click(object sender, EventArgs e)//EncryptButton
        {
             Encrypte();
        }
    }
}
