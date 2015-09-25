using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Just_Search;
using NUnit.Framework;

namespace Just_Search_UnitTest {
    [TestFixture]
    class MenuFactoryTest {
        public void TestCreateMenu()
        {
            var html = Properties.Resources.JustEatMenuUnitTest;
            Menu menu = new MenuFactory().CreateMenu(html);
        }
    }
}
