using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ_MOTIVATION_TEST.Models
{
    class UserClass
    {
        private string _identificationNumber;
        private int _numberTest;
        private double[] _resultsTest;

        public UserClass(string ident_number, string numb_test)
        {
            _identificationNumber = ident_number;
            if (numb_test == "Интеллектуальные характеристики")
            {
                _numberTest = 1;
                _resultsTest = new double[4];
            }
            else
            {
                _numberTest = 2;
                _resultsTest = new double[8];
            }
        }
    }
}
