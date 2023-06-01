// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Write the word");
        string word = Console.ReadLine()?.ToUpper();        // Зчитування введеного користувачем слова

        Console.WindowWidth = 120; // Задає ширину консольного вікна
        Console.BufferWidth = 120; // Задає ширину буфера консолі

        string image = ""; // Змінна для збереження псевдографічного зображення

        // Формування псевдографічного зображення на основі введеного слова
        foreach (char c in word)
        {
            switch (c)
            {
                case 'A':
                    image += "  A  \n A A \nAAAAA\nA   A\nA   A\n\n";
                    break;
                case 'B':
                    image += "BBBB \nB   B\nBBBB \nB   B\nBBBB \n\n";
                    break;
                case 'C':
                    image += " CCCC \nC     \nC     \nC     \n CCCC \n\n";
                    break;
                case 'D':
                    image += "DDDD  \nD   D \nD    D\nD   D \nDDDD  \n\n";
                    break;
                case 'E':
                    image += "EEEEE \nE     \nEEEEE \nE     \nEEEEE \n\n";
                    break;
                case 'F':
                    image += "FFFFF \nF     \nFFFF  \nF     \nF     \n\n";
                    break;
                case 'G':
                    image += " GGGG \nG     \nG  GG \nG    G\n GGGG \n\n";
                    break;
                case 'H':
                    image += "H   H \nH   H \nHHHHH \nH   H \nH   H \n\n";
                    break;
                case 'I':
                    image += "IIIII \n  I   \n  I   \n  I   \nIIIII \n\n";
                    break;
                case 'J':
                    image += "JJJJJ \n   J  \n   J  \nJ  J  \n JJ   \n\n";
                    break;
                case 'K':
                    image += "K   K \nK  K  \nKKK   \nK  K  \nK   K \n\n";
                    break;
                case 'L':
                    image += "L     \nL     \nL     \nL     \nLLLLL \n\n";
                    break;
                case 'M':
                    image += "M     M\nMM   MM\nM M M M\nM  M  M\nM     M\n\n";
                    break;
                case 'N':
                    image += "N     N\nNN    N\nN N   N\nN  N  N\nN   N N\n\n";
                    break;
                case 'O':
                    image += " OOOO \nO    O\nO    O\nO    O\n OOOO \n\n";
                    break;
                case 'P':
                    image += "PPPP  \nP   P \nPPPP  \nP     \nP     \n\n";
                    break;
                case 'Q':
                    image += " QQQQ \nQ    Q\nQ    Q\nQ   QQ\n QQQQ \n     Q \n\n";
                    break;
                case 'R':
                    image += "RRRR  \nR   R \nRRRR  \nR  R  \nR   R \n\n";
                    break;
                case 'S':
                    image += " SSSS \nS     \n SSSS \n     S\n SSSS \n\n";
                    break;
                case 'T':
                    image += "TTTTT \n  T   \n  T   \n  T   \n  T   \n\n";
                    break;
                case 'U':
                    image += "U   U \nU   U \nU   U \nU   U \n UUU  \n\n";
                    break;
                case 'V':
                    image += "V     V\nV     V\nV     V\n V   V \n  V V  \n\n";
                    break;
                case 'W':
                    image += "W     W\nW     W\nW  W  W\nW W W W\nW     W\n\n";
                    break;
                case 'X':
                    image += "X     X\n X   X \n  XXX  \n X   X \nX     X\n\n";
                    break;
                case 'Y':
                    image += "Y     Y\n Y   Y \n  YYY  \n   Y   \n   Y   \n\n";
                    break;
                case 'Z':
                    image += "ZZZZZ \n    Z  \n   Z   \n  Z    \nZZZZZ \n\n";
                    break;
                default:
                    image += "Невідомий символ\n\n";
                    break;
            }
        }

        Console.WriteLine(image);
    }
}

