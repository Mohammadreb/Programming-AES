

# Symmetric block cipher (AES)
we  will Learn about the Advanced Standard Encryption (AES) encryption algorithm
As one of the most important standards adopted globally at the present time as a symmetric encryption algorithm.
The project will lead to fixing the most important theoretical concepts related to cryptography,  by implementing this standard algorithm as a good sample.
## Key Expansion
 A C# script to generate the keys for the block cipher rounds AES, meaning the Expansion Key component,
 assuming that this cipher consists of 10 rounds of addition
 Pre-round.Transformation  
 this  program take  as input an encryption key of size 128 bits
 and returns as output 11 keys of size 128 bits.
 ### Result:
![key Expansion ](https://i.postimg.cc/76j5QFs8/1.jpg)

## Pre-round Transformation

A C# script to execute the initial round of the block cipher    AES 

This program  take as  input a block of size 128 bits with a key of size 128 bits and returns as output a block of size 128 bits after Perform required component operations.
###  Result:
![Pre-round Transformation ](https://i.postimg.cc/3xj20xLy/2.jpg)

## Round
A C# script to execute one round of Block cipher rounds( AES)
This program takes a 128-bit block as input and returns a 128-bit block as output after executing the basic round operations.
It also assumes whether the round is final or not.

###  Result: 
![AES Round ](https://i.postimg.cc/4djr7PdQ/3.jpg)

## AES-Program
This program contains all the components programmed in the previous files in order to build the complete AES block cipher
###  Result: 
![AES Round ](https://i.postimg.cc/N0sYBd9y/4.jpg)

## You can check the solution through this website

https://www.codeusingjava.com/tools/aes
