using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Write the word");
        string word = Console.ReadLine()?.ToUpper();

        string[] lines = new string[5];

        for (int i = 0; i < word.Length; i++)
        {
            switch (word[i])
            {
                case 'A':
                    lines[0] += "  A  ";
                    lines[1] += " A A ";
                    lines[2] += "AAAAA";
                    lines[3] += "A   A";
                    lines[4] += "A   A";
                    break;
                case 'B':
                    lines[0] += "BBBB ";
                    lines[1] += "B   B";
                    lines[2] += "BBBB ";
                    lines[3] += "B   B";
                    lines[4] += "BBBB ";
                    break;
                case 'C':
                    lines[0] += " CCCC ";
                    lines[1] += "C     ";
                    lines[2] += "C     ";
                    lines[3] += "C     ";
                    lines[4] += " CCCC ";
                    break;
                case 'D':
                    lines[0] += "DDDD  ";
                    lines[1] += "D   D ";
                    lines[2] += "D    D";
                    lines[3] += "D   D ";
                    lines[4] += "DDDD  ";
                    break;
                case 'E':
                    lines[0] += "EEEEE ";
                    lines[1] += "E     ";
                    lines[2] += "EEEEE ";
                    lines[3] += "E     ";
                    lines[4] += "EEEEE ";
                    break;
                case 'F':
                    lines[0] += "FFFFF ";
                    lines[1] += "F     ";
                    lines[2] += "FFFF  ";
                    lines[3] += "F     ";
                    lines[4] += "F     ";
                    break;
                case 'G':
                    lines[0] += " GGGG ";
                    lines[1] += "G     ";
                    lines[2] += "G  GG ";
                    lines[3] += "G    G";
                    lines[4] += " GGGG ";
                    break;
                case 'H':
                    lines[0] += "H   H ";
                    lines[1] += "H   H ";
                    lines[2] += "HHHHH ";
                    lines[3] += "H   H ";
                    lines[4] += "H   H ";
                    break;
                case 'I':
                    lines[0] += "IIIII ";
                    lines[1] += "  I   ";
                    lines[2] += "  I   ";
                    lines[3] += "  I   ";
                    lines[4] += "IIIII ";
                    break;
                case 'J':
                    lines[0] += "JJJJJ ";
                    lines[1] += "   J  ";
                    lines[2] += "   J  ";
                    lines[3] += "J  J  ";
                    lines[4] += " JJ   ";
                    break;
                case 'K':
                    lines[0] += "K   K ";
                    lines[1] += "K  K  ";
                    lines[2] += "KKK   ";
                    lines[3] += "K  K  ";
                    lines[4] += "K   K ";
                    break;
                case 'L':
                    lines[0] += "L     ";
                    lines[1] += "L     ";
                    lines[2] += "L     ";
                    lines[3] += "L     ";
                    lines[4] += "LLLLL ";
                    break;
                case 'M':
                    lines[0] += "M     M";
                    lines[1] += "MM   MM";
                    lines[2] += "M M M M";
                    lines[3] += "M  M  M";
                    lines[4] += "M     M";
                    break;
                case 'N':
                    lines[0] += "N     N";
                    lines[1] += "NN    N";
                    lines[2] += "N N   N";
                    lines[3] += "N  N  N";
                    lines[4] += "N   N N";
                    break;
                case 'O':
                    lines[0] += " OOO  ";
                    lines[1] += "O   O ";
                    lines[2] += "O   O ";
                    lines[3] += "O   O ";
                    lines[4] += " OOO  ";
                    break;
                case 'P':
                    lines[0] += "PPPP  ";
                    lines[1] += "P   P ";
                    lines[2] += "PPPP  ";
                    lines[3] += "P     ";
                    lines[4] += "P     ";
                    break;
                case 'Q':
                    lines[0] += " QQQQ ";
                    lines[1] += "Q   Q ";
                    lines[2] += "Q   Q ";
                    lines[3] += "Q  QQ ";
                    lines[4] += " QQQ Q";
                    break;
                case 'R':
                    lines[0] += "RRRR  ";
                    lines[1] += "R   R ";
                    lines[2] += "RRRR  ";
                    lines[3] += "R  R  ";
                    lines[4] += "R   R ";
                    break;
                case 'S':
                    lines[0] += " SSSS ";
                    lines[1] += "S     ";
                    lines[2] += " SSSS ";
                    lines[3] += "     S";
                    lines[4] += " SSSS ";
                    break;
                case 'T':
                    lines[0] += "TTTTT ";
                    lines[1] += "  T   ";
                    lines[2] += "  T   ";
                    lines[3] += "  T   ";
                    lines[4] += "  T   ";
                    break;
                case 'U':
                    lines[0] += "U   U ";
                    lines[1] += "U   U ";
                    lines[2] += "U   U ";
                    lines[3] += "U   U ";
                    lines[4] += " UUU  ";
                    break;
                case 'V':
                    lines[0] += "V     V";
                    lines[1] += "V     V";
                    lines[2] += " V   V ";
                    lines[3] += "  V V  ";
                    lines[4] += "   V   ";
                    break;
                case 'W':
                    lines[0] += "W     W";
                    lines[1] += "W     W";
                    lines[2] += "W  W  W";
                    lines[3] += "W W W W";
                    lines[4] += "W     W";
                    break;
                case 'X':
                    lines[0] += "X   X ";
                    lines[1] += " X X  ";
                    lines[2] += "  X   ";
                    lines[3] += " X X  ";
                    lines[4] += "X   X ";
                    break;
                case 'Y':
                    lines[0] += "Y   Y ";
                    lines[1] += " Y Y  ";
                    lines[2] += "  Y   ";
                    lines[3] += "  Y   ";
                    lines[4] += "  Y   ";
                    break;
                case 'Z':
                    lines[0] += "ZZZZZ ";
                    lines[1] += "   Z  ";
                    lines[2] += "  Z   ";
                    lines[3] += " Z    ";
                    lines[4] += "ZZZZZ ";
                    break;
                default:
                    lines[0] += "      ";
                    lines[1] += "      ";
                    lines[2] += "      ";
                    lines[3] += "      ";
                    lines[4] += "      ";
                    break;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }
}
