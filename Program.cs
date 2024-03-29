﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Huffman
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "h shdh s dsh dhsh dalsdasdk a";
            HuffmanTree huffmanTree = new HuffmanTree();

            
            huffmanTree.Build(input);

            
            BitArray encoded = huffmanTree.Encode(input);

            Console.Write("Encoded: ");
            foreach (bool bit in encoded)
            {
                Console.Write((bit ? 1 : 0) + "");
            }
            Console.WriteLine();

           
            string decoded = huffmanTree.Decode(encoded);

            Console.WriteLine("Decoded: " + decoded);

            Console.ReadLine();
        }
    }
}