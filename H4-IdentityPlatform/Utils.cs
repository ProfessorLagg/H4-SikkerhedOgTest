﻿using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace H4_IdentityPlatform {
    public static class Utils {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToBinaryString(this byte b) {
            switch (b) {
                case 000: return "00000000";
                case 001: return "00000001";
                case 002: return "00000010";
                case 003: return "00000011";
                case 004: return "00000100";
                case 005: return "00000101";
                case 006: return "00000110";
                case 007: return "00000111";
                case 008: return "00001000";
                case 009: return "00001001";
                case 010: return "00001010";
                case 011: return "00001011";
                case 012: return "00001100";
                case 013: return "00001101";
                case 014: return "00001110";
                case 015: return "00001111";
                case 016: return "00010000";
                case 017: return "00010001";
                case 018: return "00010010";
                case 019: return "00010011";
                case 020: return "00010100";
                case 021: return "00010101";
                case 022: return "00010110";
                case 023: return "00010111";
                case 024: return "00011000";
                case 025: return "00011001";
                case 026: return "00011010";
                case 027: return "00011011";
                case 028: return "00011100";
                case 029: return "00011101";
                case 030: return "00011110";
                case 031: return "00011111";
                case 032: return "00100000";
                case 033: return "00100001";
                case 034: return "00100010";
                case 035: return "00100011";
                case 036: return "00100100";
                case 037: return "00100101";
                case 038: return "00100110";
                case 039: return "00100111";
                case 040: return "00101000";
                case 041: return "00101001";
                case 042: return "00101010";
                case 043: return "00101011";
                case 044: return "00101100";
                case 045: return "00101101";
                case 046: return "00101110";
                case 047: return "00101111";
                case 048: return "00110000";
                case 049: return "00110001";
                case 050: return "00110010";
                case 051: return "00110011";
                case 052: return "00110100";
                case 053: return "00110101";
                case 054: return "00110110";
                case 055: return "00110111";
                case 056: return "00111000";
                case 057: return "00111001";
                case 058: return "00111010";
                case 059: return "00111011";
                case 060: return "00111100";
                case 061: return "00111101";
                case 062: return "00111110";
                case 063: return "00111111";
                case 064: return "01000000";
                case 065: return "01000001";
                case 066: return "01000010";
                case 067: return "01000011";
                case 068: return "01000100";
                case 069: return "01000101";
                case 070: return "01000110";
                case 071: return "01000111";
                case 072: return "01001000";
                case 073: return "01001001";
                case 074: return "01001010";
                case 075: return "01001011";
                case 076: return "01001100";
                case 077: return "01001101";
                case 078: return "01001110";
                case 079: return "01001111";
                case 080: return "01010000";
                case 081: return "01010001";
                case 082: return "01010010";
                case 083: return "01010011";
                case 084: return "01010100";
                case 085: return "01010101";
                case 086: return "01010110";
                case 087: return "01010111";
                case 088: return "01011000";
                case 089: return "01011001";
                case 090: return "01011010";
                case 091: return "01011011";
                case 092: return "01011100";
                case 093: return "01011101";
                case 094: return "01011110";
                case 095: return "01011111";
                case 096: return "01100000";
                case 097: return "01100001";
                case 098: return "01100010";
                case 099: return "01100011";
                case 100: return "01100100";
                case 101: return "01100101";
                case 102: return "01100110";
                case 103: return "01100111";
                case 104: return "01101000";
                case 105: return "01101001";
                case 106: return "01101010";
                case 107: return "01101011";
                case 108: return "01101100";
                case 109: return "01101101";
                case 110: return "01101110";
                case 111: return "01101111";
                case 112: return "01110000";
                case 113: return "01110001";
                case 114: return "01110010";
                case 115: return "01110011";
                case 116: return "01110100";
                case 117: return "01110101";
                case 118: return "01110110";
                case 119: return "01110111";
                case 120: return "01111000";
                case 121: return "01111001";
                case 122: return "01111010";
                case 123: return "01111011";
                case 124: return "01111100";
                case 125: return "01111101";
                case 126: return "01111110";
                case 127: return "01111111";
                case 128: return "10000000";
                case 129: return "10000001";
                case 130: return "10000010";
                case 131: return "10000011";
                case 132: return "10000100";
                case 133: return "10000101";
                case 134: return "10000110";
                case 135: return "10000111";
                case 136: return "10001000";
                case 137: return "10001001";
                case 138: return "10001010";
                case 139: return "10001011";
                case 140: return "10001100";
                case 141: return "10001101";
                case 142: return "10001110";
                case 143: return "10001111";
                case 144: return "10010000";
                case 145: return "10010001";
                case 146: return "10010010";
                case 147: return "10010011";
                case 148: return "10010100";
                case 149: return "10010101";
                case 150: return "10010110";
                case 151: return "10010111";
                case 152: return "10011000";
                case 153: return "10011001";
                case 154: return "10011010";
                case 155: return "10011011";
                case 156: return "10011100";
                case 157: return "10011101";
                case 158: return "10011110";
                case 159: return "10011111";
                case 160: return "10100000";
                case 161: return "10100001";
                case 162: return "10100010";
                case 163: return "10100011";
                case 164: return "10100100";
                case 165: return "10100101";
                case 166: return "10100110";
                case 167: return "10100111";
                case 168: return "10101000";
                case 169: return "10101001";
                case 170: return "10101010";
                case 171: return "10101011";
                case 172: return "10101100";
                case 173: return "10101101";
                case 174: return "10101110";
                case 175: return "10101111";
                case 176: return "10110000";
                case 177: return "10110001";
                case 178: return "10110010";
                case 179: return "10110011";
                case 180: return "10110100";
                case 181: return "10110101";
                case 182: return "10110110";
                case 183: return "10110111";
                case 184: return "10111000";
                case 185: return "10111001";
                case 186: return "10111010";
                case 187: return "10111011";
                case 188: return "10111100";
                case 189: return "10111101";
                case 190: return "10111110";
                case 191: return "10111111";
                case 192: return "11000000";
                case 193: return "11000001";
                case 194: return "11000010";
                case 195: return "11000011";
                case 196: return "11000100";
                case 197: return "11000101";
                case 198: return "11000110";
                case 199: return "11000111";
                case 200: return "11001000";
                case 201: return "11001001";
                case 202: return "11001010";
                case 203: return "11001011";
                case 204: return "11001100";
                case 205: return "11001101";
                case 206: return "11001110";
                case 207: return "11001111";
                case 208: return "11010000";
                case 209: return "11010001";
                case 210: return "11010010";
                case 211: return "11010011";
                case 212: return "11010100";
                case 213: return "11010101";
                case 214: return "11010110";
                case 215: return "11010111";
                case 216: return "11011000";
                case 217: return "11011001";
                case 218: return "11011010";
                case 219: return "11011011";
                case 220: return "11011100";
                case 221: return "11011101";
                case 222: return "11011110";
                case 223: return "11011111";
                case 224: return "11100000";
                case 225: return "11100001";
                case 226: return "11100010";
                case 227: return "11100011";
                case 228: return "11100100";
                case 229: return "11100101";
                case 230: return "11100110";
                case 231: return "11100111";
                case 232: return "11101000";
                case 233: return "11101001";
                case 234: return "11101010";
                case 235: return "11101011";
                case 236: return "11101100";
                case 237: return "11101101";
                case 238: return "11101110";
                case 239: return "11101111";
                case 240: return "11110000";
                case 241: return "11110001";
                case 242: return "11110010";
                case 243: return "11110011";
                case 244: return "11110100";
                case 245: return "11110101";
                case 246: return "11110110";
                case 247: return "11110111";
                case 248: return "11111000";
                case 249: return "11111001";
                case 250: return "11111010";
                case 251: return "11111011";
                case 252: return "11111100";
                case 253: return "11111101";
                case 254: return "11111110";
                case 255: return "11111111";
                default: throw new UnreachableException();
            }
        }

        public static int RoundUpToNearestMultiple(int numToRound, int multiple) {
            if (multiple <= 1) { return numToRound; }
            int remainder = numToRound % multiple;
            if (remainder == 0) { return numToRound; }
            return numToRound + multiple - remainder;
        }

        public static string Base64Encode(byte[] bytes) {
            BitArray bitArray = new BitArray(bytes);
            byte[] charByte = new byte[0];
            bitArray.CopyTo(charByte, 0);
            throw new NotImplementedException();
        }

        public static async Task<T> RunAsync<T>(Func<T> func) {
            Task<T> task = new Task<T>(func);
            task.Start();
            await task.WaitAsync(CancellationToken.None);
            return task.Result;
        }

        public static T RunSync<T>(Func<Task<T>> func) {
            Task<T> task = func.Invoke();
            task.Start();
            task.Wait();
            return task.Result;
        }
    }
}
