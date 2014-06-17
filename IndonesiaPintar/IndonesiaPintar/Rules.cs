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
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace IndonesiaPintar
{
    public class Rules
    {
        [TestMethod]
        Public boolean checkResult(int result, int expectedResult)
        {
            Boolean accepted = false;
            If (result==expectedResult)
            {
                accepted =true;
            }
            Return accepted;
        }
    }
}