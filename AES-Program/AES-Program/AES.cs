﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_Program
{
    public partial class AES : Form
    {
        public AES()
        {
            InitializeComponent();
        }
        private static byte[] Pz = new byte[16];//Plaintext Block size
        private static byte[] Cz = new byte[16];//Cipher Block size
        private static byte[] RKey = new byte[176];//number of key per round
        private static byte Nr = 0;//number of rounds
        private static byte[,] State = new byte[4, 4];//State matrix
        private static byte[] key = new byte[16];//key size
      

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

        private void InvSubBytes()// InvSubBytes
        {
            int i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    State[i, j] = getISBox(State[i, j]);

                }
            }
        }
        private static byte SBox(int value)
        {
            byte[] sbox = new byte[256] {
 	                        //0     1    2      3     4    5     6     7      8    9     A      B    C     D     E     F 
                             0x63, 0x7c, 0x77, 0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 0x01, 0x67, 0x2b, 0xfe, 0xd7, 0xab, 0x76, //0 
                             0xca, 0x82, 0xc9, 0x7d, 0xfa, 0x59, 0x47, 0xf0, 0xad, 0xd4, 0xa2, 0xaf, 0x9c, 0xa4, 0x72, 0xc0, //1 
                             0xb7, 0xfd, 0x93, 0x26, 0x36, 0x3f, 0xf7, 0xcc, 0x34, 0xa5, 0xe5, 0xf1, 0x71, 0xd8, 0x31, 0x15, //2 
                             0x04, 0xc7, 0x23, 0xc3, 0x18, 0x96, 0x05, 0x9a, 0x07, 0x12, 0x80, 0xe2, 0xeb, 0x27, 0xb2, 0x75, //3 
                             0x09, 0x83, 0x2c, 0x1a, 0x1b, 0x6e, 0x5a, 0xa0, 0x52, 0x3b, 0xd6, 0xb3, 0x29, 0xe3, 0x2f, 0x84, //4 
                             0x53, 0xd1, 0x00, 0xed, 0x20, 0xfc, 0xb1, 0x5b, 0x6a, 0xcb, 0xbe, 0x39, 0x4a, 0x4c, 0x58, 0xcf, //5 
                             0xd0, 0xef, 0xaa, 0xfb, 0x43, 0x4d, 0x33, 0x85, 0x45, 0xf9, 0x02, 0x7f, 0x50, 0x3c, 0x9f, 0xa8, //6 
                             0x51, 0xa3, 0x40, 0x8f, 0x92, 0x9d, 0x38, 0xf5, 0xbc, 0xb6, 0xda, 0x21, 0x10, 0xff, 0xf3, 0xd2, //7 
                             0xcd, 0x0c, 0x13, 0xec, 0x5f, 0x97, 0x44, 0x17, 0xc4, 0xa7, 0x7e, 0x3d, 0x64, 0x5d, 0x19, 0x73, //8 
                             0x60, 0x81, 0x4f, 0xdc, 0x22, 0x2a, 0x90, 0x88, 0x46, 0xee, 0xb8, 0x14, 0xde, 0x5e, 0x0b, 0xdb, //9 
                             0xe0, 0x32, 0x3a, 0x0a, 0x49, 0x06, 0x24, 0x5c, 0xc2, 0xd3, 0xac, 0x62, 0x91, 0x95, 0xe4, 0x79, //A 
                             0xe7, 0xc8, 0x37, 0x6d, 0x8d, 0xd5, 0x4e, 0xa9, 0x6c, 0x56, 0xf4, 0xea, 0x65, 0x7a, 0xae, 0x08, //B 
                             0xba, 0x78, 0x25, 0x2e, 0x1c, 0xa6, 0xb4, 0xc6, 0xe8, 0xdd, 0x74, 0x1f, 0x4b, 0xbd, 0x8b, 0x8a, //C 
                             0x70, 0x3e, 0xb5, 0x66, 0x48, 0x03, 0xf6, 0x0e, 0x61, 0x35, 0x57, 0xb9, 0x86, 0xc1, 0x1d, 0x9e, //D 
                             0xe1, 0xf8, 0x98, 0x11, 0x69, 0xd9, 0x8e, 0x94, 0x9b, 0x1e, 0x87, 0xe9, 0xce, 0x55, 0x28, 0xdf, //E 
                             0x8c, 0xa1, 0x89, 0x0d, 0xbf, 0xe6, 0x42, 0x68, 0x41, 0x99, 0x2d, 0x0f, 0xb0, 0x54, 0xbb, 0x16 }; //F 


            byte resnum = sbox[value];
            return resnum;
        }//SBOX
        private static byte getISBox(int num)
        {
            byte[] rsbox = new byte[256]
                { 0x52, 0x09, 0x6a, 0xd5, 0x30, 0x36, 0xa5, 0x38, 0xbf, 0x40, 0xa3, 0x9e, 0x81, 0xf3, 0xd7, 0xfb
                , 0x7c, 0xe3, 0x39, 0x82, 0x9b, 0x2f, 0xff, 0x87, 0x34, 0x8e, 0x43, 0x44, 0xc4, 0xde, 0xe9, 0xcb
                , 0x54, 0x7b, 0x94, 0x32, 0xa6, 0xc2, 0x23, 0x3d, 0xee, 0x4c, 0x95, 0x0b, 0x42, 0xfa, 0xc3, 0x4e
                , 0x08, 0x2e, 0xa1, 0x66, 0x28, 0xd9, 0x24, 0xb2, 0x76, 0x5b, 0xa2, 0x49, 0x6d, 0x8b, 0xd1, 0x25
                , 0x72, 0xf8, 0xf6, 0x64, 0x86, 0x68, 0x98, 0x16, 0xd4, 0xa4, 0x5c, 0xcc, 0x5d, 0x65, 0xb6, 0x92
                , 0x6c, 0x70, 0x48, 0x50, 0xfd, 0xed, 0xb9, 0xda, 0x5e, 0x15, 0x46, 0x57, 0xa7, 0x8d, 0x9d, 0x84
                , 0x90, 0xd8, 0xab, 0x00, 0x8c, 0xbc, 0xd3, 0x0a, 0xf7, 0xe4, 0x58, 0x05, 0xb8, 0xb3, 0x45, 0x06
                , 0xd0, 0x2c, 0x1e, 0x8f, 0xca, 0x3f, 0x0f, 0x02, 0xc1, 0xaf, 0xbd, 0x03, 0x01, 0x13, 0x8a, 0x6b
                , 0x3a, 0x91, 0x11, 0x41, 0x4f, 0x67, 0xdc, 0xea, 0x97, 0xf2, 0xcf, 0xce, 0xf0, 0xb4, 0xe6, 0x73
                , 0x96, 0xac, 0x74, 0x22, 0xe7, 0xad, 0x35, 0x85, 0xe2, 0xf9, 0x37, 0xe8, 0x1c, 0x75, 0xdf, 0x6e
                , 0x47, 0xf1, 0x1a, 0x71, 0x1d, 0x29, 0xc5, 0x89, 0x6f, 0xb7, 0x62, 0x0e, 0xaa, 0x18, 0xbe, 0x1b
                , 0xfc, 0x56, 0x3e, 0x4b, 0xc6, 0xd2, 0x79, 0x20, 0x9a, 0xdb, 0xc0, 0xfe, 0x78, 0xcd, 0x5a, 0xf4
                , 0x1f, 0xdd, 0xa8, 0x33, 0x88, 0x07, 0xc7, 0x31, 0xb1, 0x12, 0x10, 0x59, 0x27, 0x80, 0xec, 0x5f
                , 0x60, 0x51, 0x7f, 0xa9, 0x19, 0xb5, 0x4a, 0x0d, 0x2d, 0xe5, 0x7a, 0x9f, 0x93, 0xc9, 0x9c, 0xef
                , 0xa0, 0xe0, 0x3b, 0x4d, 0xae, 0x2a, 0xf5, 0xb0, 0xc8, 0xeb, 0xbb, 0x3c, 0x83, 0x53, 0x99, 0x61
                , 0x17, 0x2b, 0x04, 0x7e, 0xba, 0x77, 0xd6, 0x26, 0xe1, 0x69, 0x14, 0x63, 0x55, 0x21, 0x0c, 0x7d };

            return rsbox[num];
        }//InvSBox()

        private void ShiftRows()// ShiftRows
        {
            {
                byte[,] temp = new byte[4, 4];
                for (int i = 0; i < 4; i++)  // copy State into temp[]
                {
                    for (int j = 0; j < 4; j++)
                    {
                        temp[i, j] = State[i, j];
                    }
                }

                for (int i = 1; i < 4; i++)  // shift temp into State
                {
                    for (int j = 0; j < 4; j++)
                    {
                        State[i, j] = temp[i, (j + i) % 4];
                    }
                }
            }
        }
        private void InvShiftRows()// InvShiftRows()
        {
            byte[,] temp = new byte[4, 4];
            for (int i = 0; i < 4; i++)  // copy State into temp[]
            {
                for (int j = 0; j < 4; j++)
                {
                    temp[i, j] = State[i, j];
                }
            }
            for (int i = 1; i < 4; i++)  // shift temp into State
            {
                for (int j = 0; j < 4; j++)
                {
                    State[i, (j + i) % 4] = temp[i, j];
                }
            }
        }  


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

        private void InvMixColumns()// InvMixColumns
        {

            int i;
            byte a, b, c, d;
            for (i = 0; i < 4; i++)
            {

                a = State[0, i];
                b = State[1, i];
                c = State[2, i];
                d = State[3, i];


                State[0, i] = (byte)((int)Multi(a, 0x0e) ^ Multi(b, 0x0b) ^ Multi(c, 0x0d) ^ Multi(d, 0x09));
                State[1, i] = (byte)((int)Multi(a, 0x09) ^ Multi(b, 0x0e) ^ Multi(c, 0x0b) ^ Multi(d, 0x0d));
                State[2, i] = (byte)((int)Multi(a, 0x0d) ^ Multi(b, 0x09) ^ Multi(c, 0x0e) ^ Multi(d, 0x0b));
                State[3, i] = (byte)((int)Multi(a, 0x0b) ^ Multi(b, 0x0d) ^ Multi(c, 0x09) ^ Multi(d, 0x0e));
            }
        }


        private static byte xtime(int b)
        {
            int x = (b << 1) ^ (((b >> 7) & 1) * 0x1b);
            return (byte)x;
        }//xtime operator
        public static int Multi(int x, int y)
        {
            int m = ((y & 1) * x) ^ ((y >> 1 & 1) * xtime(x)) ^ ((y >> 2 & 1) * xtime(xtime(x))) ^ ((y >> 3 & 1) * xtime(xtime(xtime(x)))) ^ ((y >> 4 & 1) * xtime(xtime(xtime(xtime(x)))));
            return m;
        }//Multi operator

        private static void AddRoundKey(int round)// AddRoundKey
        {
            int i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    State[j, i] ^= RKey[round * 4 * 4 + i * 4 + j];
                }
            }
        }


        public static byte Rcon(int value)
        {


            byte[] Rcon = new byte[] {
                             0x8d, 0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x80, 0x1b, 0x36 };
            byte result = Rcon[value];
            return result;
        }//Roundcon()
        private static void KeyExp()//Key Expansion
        {
            int i, j;
            byte[] temp = new byte[4];
            byte k;

            for (i = 0; i < 4; i++)
            {
                RKey[i * 4] = key[i * 4];
                RKey[i * 4 + 1] = key[i * 4 + 1];
                RKey[i * 4 + 2] = key[i * 4 + 2];
                RKey[i * 4 + 3] = key[i * 4 + 3];
            }

            // All other round keys are found from the previous round keys.
            while (i < 44)
            {
                for (j = 0; j < 4; j++)
                {
                    temp[j] = RKey[(i - 1) * 4 + j];
                }
                if (i % 4 == 0)
                {
                    

                    //  RotWord
                    {
                        k = temp[0];
                        temp[0] = temp[1];
                        temp[1] = temp[2];
                        temp[2] = temp[3];
                        temp[3] = k;
                    }

                   
                    // Subword()
                    {
                        temp[0] = SBox(temp[0]);
                        temp[1] = SBox(temp[1]);
                        temp[2] = SBox(temp[2]);
                        temp[3] = SBox(temp[3]);
                    }

                    temp[0] = (byte)((int)temp[0] ^ (int)Rcon(i / 4));
                }

                RKey[i * 4 + 0] = (byte)((int)RKey[(i - 4) * 4 + 0] ^ temp[0]);
                RKey[i * 4 + 1] = (byte)((int)RKey[(i - 4) * 4 + 1] ^ temp[1]);
                RKey[i * 4 + 2] = (byte)((int)RKey[(i - 4) * 4 + 2] ^ temp[2]);
                RKey[i * 4 + 3] = (byte)((int)RKey[(i - 4) * 4 + 3] ^ temp[3]);
                i++;
            }

        }
        private void Encrypt()//تابع التشفير
        {
         
            byte[] textByte = Encoding.Default.GetBytes(plaintxt.Text);
            var hexString = BitConverter.ToString(textByte);
            hexString = hexString.Replace("-", "");
            byte[] m = StringToByteArray(hexString);

            Pz = m;

            byte[] keyByte = Encoding.Default.GetBytes(keytxt.Text);

            var hexString1 = BitConverter.ToString(keyByte);

            hexString1 = hexString1.Replace("-", "");

            byte[] n = StringToByteArray(hexString1);
            key = n;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    State[j, i] = Pz[i * 4 + j];
                }
            }

            KeyExp();
            AddRoundKey(0);

            for (Nr = 1; Nr < 10; Nr++)
            {
                SubBytes();
                ShiftRows();
                MixColumns();
                AddRoundKey(Nr);
            }

            SubBytes();
            ShiftRows();
            AddRoundKey(10);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Cz[i * 4 + j] = State[j, i];
                }
            }
            string h;
            h = ByteArrayToString(Cz);
            ciphertxt.Text = h;
        }
        private void Decrypt()//تابع فك التشفير
        {

            byte[] m = StringToByteArray(ciphertxt.Text);

            m = Cz;
            byte[] keyByte = Encoding.Default.GetBytes(keytxt.Text);
            var hexString1 = BitConverter.ToString(keyByte);
            hexString1 = hexString1.Replace("-", "");

            byte[] n = StringToByteArray(hexString1);

            key = n;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    State[j, i] = Cz[i * 4 + j];
                }
            }

            KeyExp();
            AddRoundKey(10);
            Console.WriteLine(" ");
            for (Nr = 9; Nr > 0; Nr--)
            {
                InvShiftRows();
                InvSubBytes();
                AddRoundKey(Nr);
                InvMixColumns();
            }

            InvShiftRows();
            InvSubBytes();
            AddRoundKey(0);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Pz[i * 4 + j] = State[j, i];
                }

            }

            string ascii = Encoding.ASCII.GetString(Pz);
            originaltxt.Text = ascii;
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }//Convert String To array of bytes

        public static string ByteArrayToString(byte[] by)
        {
            StringBuilder hex = new StringBuilder(by.Length * 2);
            foreach (byte b in by)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }//Convert array of bytes To String


        private void encryptbtn_Click(object sender, EventArgs e)
        {
            Encrypt();
            if (plaintxt.Text.Length != 16)
            {
                MessageBox.Show("Please Enter 16 character for Text");
                return;
            }
            if (keytxt.Text.Length != 16)
            {
                MessageBox.Show("Please Enter 16 character for Key");
                return;
            }
        }//Encrypt button

        private void decryptbtn_Click(object sender, EventArgs e)
        {
            Decrypt();
        }//Decrypt button


    }
}
