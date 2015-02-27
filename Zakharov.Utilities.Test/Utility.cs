using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zakharov.Utilities.Test {
    [TestClass]
    public class TDateTime {
        /// <summary>Тестирование создания неполной даты и времени</summary>
        [TestMethod]
        public void CreateToday() {
            CDateTime c_dtToday = new CDateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            Assert.IsTrue(c_dtToday.Day == DateTime.Now.Day);
        }
    }
}
