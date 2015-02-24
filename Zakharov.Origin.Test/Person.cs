using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zakharov.Origin.Model;
using System.Data.Entity;
using System.Linq;
using Zakharov.Utilities;

namespace Zakharov.Origin.Test {
    [TestClass]
    public class TPerson {
        /// <summary>Тестирование создания родственника</summary>
        [TestMethod]
        public void InsertPerson() {
            using (CContext c_ocContext = new CContext()) {
                CPerson c_peSomeone = new CPerson("Иванов", "Петр", "Сергеевич",new CDateTime(2010,1,2));
                c_ocContext.Persons.Add(c_peSomeone);
                Assert.IsTrue(c_ocContext.SaveChanges() > 0);
            }
        }
        /// <summary>Тестирование выборки родственников</summary>
        [TestMethod]
        public void SelectPersons() {
            using (CContext c_ocContext = new CContext()) {
                Assert.IsTrue(c_ocContext.Persons.Count() > 0);
            }
        }
        /// <summary>Тестирование удаления родственников</summary>
        [TestMethod]
        public void DeletePerson() {
            using (CContext c_ocContext = new CContext()) {
                CPerson c_peSomeone = c_ocContext.Persons.FirstOrDefault();
                Assert.IsNotNull(c_peSomeone);
                c_ocContext.Persons.Remove(c_peSomeone);
                Assert.IsTrue(c_ocContext.SaveChanges() > 0);
            }
        }
    }
}
