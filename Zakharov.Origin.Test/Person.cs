using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zakharov.Origin.Model;

namespace Zakharov.Origin.Test {
    [TestClass]
    public class TPerson {
        [TestMethod]
        public void insert() {
            using (COriginContext c_ocContext = new COriginContext()) {
                CPerson c_peSomeone = new CPerson() { 
                    Surname = "Иванов" };
                c_ocContext.Persons.Add(c_peSomeone);
                int c_iSaved=c_ocContext.SaveChanges();
                Assert.IsTrue(c_iSaved == 1);
            }
        }
    }
}
