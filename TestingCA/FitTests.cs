using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;
using fit.Fixtures;

namespace TestingCA
{
    public class FitTests : ColumnFixture
    {
        public string gender;
        public int age;

        public CalcPrem ts = new CalcPrem();

        public double calcPremium()
        {
            return ts.CalcPremium(age, gender);
        }

    }
}
