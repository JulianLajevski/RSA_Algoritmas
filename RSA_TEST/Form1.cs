using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;

namespace RSA_TEST
{
    public partial class Form1 : Form
    {
        int p;
        int q;
        int n;
        int fn;
        
        public Form1()
        {
            InitializeComponent();
            
        }


        private static List<int> getPrimeNumbers(int num)
        {
            List<int> primeNum = new List<int>();
            for (int i = 2; i <= num; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.WriteLine("{0} ", i);
                    primeNum.Add(i);
                }
            }
            return primeNum;

        }


        private static int DBD(int a, int b)
        {

            // Everything divides 0
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            // base case
            if (a == b)
                return a;

            // a is greater
            if (a > b)
                return DBD(a - b, b);
            return DBD(a, b - a);

        }

        private int privateKey(int d)
        {
            string line;
            List<int> publicKey = new List<int>();
            StreamReader file = new StreamReader(@"C:\Users\Admin\source\repos\RSA_algoritmas\RSA_algoritmas\publicKey.txt");
            while ((line = file.ReadLine()) != null)
            {
                publicKey.Add(int.Parse(line));

            }

            int e = publicKey[1];

            while (d * e % fn != 1)
            {
                d++;
            }
            return d;
        }

        private List<int> decryption()
        {
            
            string mesg = decryptionTextBox.Text;
            List<int> encryptedMsgDec = new List<int>();
            

            foreach (char l in mesg)
            {
                encryptedMsgDec.Add(l);
            }

            int e = eFind();
            int d = privateKey(fn);
            List<int> decryptedMsgInt = new List<int>();
            foreach (int num in encryptedMsgDec)
            {
                BigInteger big = BigInteger.Pow(num, d);
                int dec = (int)(big % n);
                decryptedMsgInt.Add(dec);
            }

            return decryptedMsgInt;
        }

        private void encryption()
        {
            int e = eFind();
            List<int> publicKey = new List<int>();
            publicKey.Add(n);
            publicKey.Add(e);

            List<int> message = new List<int>();
            List<int> encryptedMessage = new List<int>();

            foreach (int a in publicKey)
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Admin\source\repos\RSA_algoritmas\RSA_algoritmas\publicKey.txt", true))
                {
                    writer.WriteLine(a);
                }
            }

            foreach (char l in encryptionTextBox.Text)
            {
                message.Add(l);
            }

            foreach (int n in message)
            {
                BigInteger big = BigInteger.Pow(n, publicKey[1]);
                int enc = (int)(big % publicKey[0]);
                encryptedMessage.Add(enc);
            }

            string stringEncMessage = fromASCIIToString(encryptedMessage);

            using (StreamWriter writer = new StreamWriter(@"C:\Users\Admin\source\repos\RSA_algoritmas\RSA_algoritmas\encrypted.txt", true))
            {
                writer.WriteLine(stringEncMessage);
            }

            resultTextBox.Text = stringEncMessage;
        }

        private int eFind()
        {
            int e = 0;
            List<int> primeList = getPrimeNumbers(fn);

            foreach (int num in primeList)
            {
                if (DBD(num, fn) == 1)
                {
                    e = num;
                    break;
                }
            }

            return e;
        }

        private string fromASCIIToString(List<int> intList)
        {
            string message = null;

            foreach (int a in intList)
            {
                byte[] numbers = { (byte)a };
                message += (char)a;
            }

            return message;
        }

        private void decryptionButton_Click(object sender, EventArgs e)
        {
            this.p = int.Parse(pTextBox.Text);
            this.q = int.Parse(qTextBox.Text);
            this.n = p * q;
            this.fn = (p - 1) * (q - 1);
            finalMessageText.Text = fromASCIIToString(decryption());
        }

        private void encryptionButton_Click(object sender, EventArgs e)
        {
            this.p = int.Parse(pTextBox.Text);
            this.q = int.Parse(qTextBox.Text);
            this.n = p * q;
            this.fn = (p - 1) * (q - 1);
            encryption();
        }

        private void fromFileButton_Click(object sender, EventArgs e)
        {
            string line;
            string mesg = null;
            StreamReader file = new StreamReader(@"C:\Users\Admin\source\repos\RSA_algoritmas\RSA_algoritmas\encrypted.txt");
            while ((line = file.ReadLine()) != null)
            {
                mesg = line;

            }
            decryptionTextBox.Text = mesg;
        }

    }
}
