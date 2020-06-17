using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal ilksayi = Decimal.Parse(textBox1.Text); //Kullanıcıdan istenilen değeri "textBox1" den alıp decimal türünden "ilksayi" değişkenine atarız.
            decimal ikincisayi = Math.Floor(Decimal.Parse(textBox1.Text));//"textBox1" deki değeri virgüldeki kısmı atıp alt değerini alır.Örneğin(4.9-->4.0).
            decimal ucuncusayi = ilksayi - ikincisayi;//Burda ise ilksayi dan ikincisayi çıkartıp virgüllü kısmını almasını sağlar.
            int zaman = 0;
            //Bu döngüde ise virgülden sonraki kaç basamak olduğunu alıp sonraki işlemlerde kullanmak içindir.
            while (ucuncusayi%1!=0) {
                ucuncusayi = ucuncusayi * 10;
                zaman++;
            }

            int payda =Convert.ToInt32(Math.Pow(10,zaman));//Burda ise basamak sayısına oranla payda değerini "payda" adlı değikene atamada yardımcı olur.
            int pay = Convert.ToInt32(ucuncusayi); // Bu kısımda ise "ucuncusayi" adlı değişkeni int türüne dönüştürmek "pay" adlı değişkene atadık.
            int i = 2;
            //Alttaki döngüde ise sürekli bölme işlemi ile pay ve payda değerlerini belirli bir sınırda sadeleştirme işlemi yapılır. 
            while (pay >= i &&  payda >= i ) {
                if (pay % i == 0 && payda % i == 0)
                {
                    pay = pay / i;
                    payda = payda / i;

                }
                else {
                    i = i + 1;
                }
            }
            textBox2.Text = ikincisayi + " " + pay + "/" + payda; //"textBox2" adlı textbox içine sırası ile tam değeri sonra pay ve payda değerlerini yazdırdık.

        }
    }
}
