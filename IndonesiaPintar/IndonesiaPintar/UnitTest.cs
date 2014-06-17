using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace IndonesiaPintar
{
    public class UnitTest
    {
        Public void testPenjumlahan()
        {
            Rules rules = new Rules();
            int expectedResult = txtangka3.getText();//nilai angka yg diharapkan sbagai hasil, bisa inputan atau emang nilai konstan
            
            int c = SkorPemain //skor
            boolean accepted = rules.checkResult(c, expectedResult);
            If(accepted)
            {
                System.out.println("the result is as expected. Result ="+c+" and the expected result is "+expectedResult);
            }
            Else
            {
                System.out.println("the result is not as expected.Result ="+c+" and the expected result is "+expectedResult); 
            }
        }
    }
}