using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zakharov.Utilities;
using Zakharov.Utilities.Entity;

namespace Zakharov.Origin.Model {
    /// <summary>Родственник</summary>
    [Table("Persons")]
    public class CPerson : CEntity<long> {
        /// <summary>Фамилия родственника.</summary>
        public string LastName { get; set; }
        /// <summary>Имя родственника.</summary>
        public string FirstName { get; set; }
        /// <summary>Отчество родственника.</summary>
        public string MiddleName { get; set; }
        public CDateTime BirthDate { get; set; }
        /// <summary>Создание объекта</summary>
        /// <param name="x_sLastName">фамилия родственника</param>
        /// <param name="x_sFirstName">имя родственника</param>
        /// <param name="x_sMiddleName">отчество родственника</param>
        public CPerson(string x_sLastName, string x_sFirstName, string x_sMiddleName, CDateTime x_dtBirthDate)
            : base(true) {
            LastName = x_sLastName;
            FirstName = x_sFirstName;
            MiddleName = x_sMiddleName;
            BirthDate = x_dtBirthDate;
        }
        /// <summary>
        /// Создание объекта
        /// </summary>
        public CPerson() {

        }
    }
}
