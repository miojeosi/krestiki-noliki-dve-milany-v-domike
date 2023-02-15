using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] arr = new string[9];

        private bool checkWinX, checkWinO;  //да нет 


        private bool check =  true; //
        private int count = 0;

        public MainWindow()
        {
            InitializeComponent();


        }




        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if(check == true)
            {


                button.Content = "X";
              //check = true;
                check = false;
                count++;


            }
            else
            {
                button.Content = "O";
                //check =  false;
                check = true;
                count++;
            }


            button.IsEnabled = false;


            my.Text = count.ToString();
            string buttonContent = button.Content.ToString();


            int btnNum = int.Parse(button.Tag.ToString());


            arr[btnNum] = buttonContent;

            checkWinX = CheckWinCross(arr);
            checkWinO = CheckWinZero(arr);



            if (checkWinX == true)
            {
                b1.IsEnabled = false;
                b2.IsEnabled = false;
                b3.IsEnabled = false;
                b4.IsEnabled = false;

                b5.IsEnabled = false;
                b6.IsEnabled = false;
                b7.IsEnabled = false;
                b8.IsEnabled = false;

                b9.IsEnabled = false;

                my.Text = "победили крестики";


            }


            if (checkWinO == true)
            {
                b1.IsEnabled = false;
                b2.IsEnabled = false;
                b3.IsEnabled = false;
                b4.IsEnabled = false;
                b5.IsEnabled = false;
                b6.IsEnabled = false;
                b7.IsEnabled = false;
                b8.IsEnabled = false;
                b9.IsEnabled = false;

                my.Text = "победили нолики";

            }


            if (count == 9 && checkWinX == false && checkWinO == false)
            {
                b1.IsEnabled = false;
                b2.IsEnabled = false;
                b3.IsEnabled = false;
                b4.IsEnabled = false;
                b5.IsEnabled = false;
                b6.IsEnabled = false;
                b7.IsEnabled = false;
                b8.IsEnabled = false;
                b9.IsEnabled = false;

                my.Text = "ничья";

            }
        }






        public void refresch(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;
            b7.IsEnabled = true;
            b8.IsEnabled = true;
            b9.IsEnabled = true;


            b1.Content = "";
            b2.Content = "";
            b3.Content = "";
            b4.Content = "";
            b5.Content = "";
            b6.Content = "";
            b7.Content = "";
            b8.Content = "";
            b9.Content = "";


            for (int j = 0; j < arr.Length; j++)
            {

                arr[j] =  null; //для да нет


            }


            my.Text = "";

            count = 0;
        }

        private bool CheckWinCross(string[] arr)
        {
            if (arr[0] == "X" && arr[1] == "X" && arr[2] == "X")      //ряд 1
                return  true;

            else

                if (arr[3] ==  "X" && arr[4] == "X"  && arr[5] == "X") //ряд2
                return true;
            else
                if (arr[6] == "X" && arr[7] == "X" && arr[8] == "X") //рряд3
                return true;
            else


                if (arr[0] == "X" && arr[3] == "X"  && arr[6] == "X") //ряд верт 1
                return true;
            else
                if (arr[1] == "X" && arr[4] == "X" && arr[7] == "X") // ряд верт 2
                return true;
            else
            if (arr[2] == "X" && arr[5] == "X" && arr[8]  == "X")  //ряд верт 3
                return  true;


            else
                if (arr[0] == "X" && arr[4] == "X" && arr[8] == "X") // скось
                return true;
            else
                if (arr[2] == "X" && arr[4] == "X" && arr[6] == "X") //скось
                return true;



            return false;
        }









        private bool CheckWinZero(string[] arr)
        {
            if (arr[0] == "O" && arr[1] == "O" && arr[2] == "O")
                return true;
            else
               if (arr[3] == "O" && arr[4] == "O" && arr[5] == "O")
                return true;
            else
               if (arr[6] == "O" && arr[7] ==  "O" && arr[8] == "O")
                
                return true;
            else
               if (arr[0] == "O" && arr[3] == "O" && arr[6] == "O")
                return true;
            else
               if (arr[1] == "O" && arr[4] == "O" && arr[7] == "O")
                return  true;
            else
           if (arr[2] == "O" && arr[5] == "O" && arr[8] == "O")
                return true;
            else
              
            if (arr[0] == "O" && arr[4] == "O" && arr[8] == "O")
                return true;
            else
               if (arr[2] == "O" && arr[4] == "O" && arr[6] == "O")
                return true;



            return false;
        }
    }
}
