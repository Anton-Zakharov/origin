﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakharov.Origin.Model {
    public class Person {
        /// <summary>Идентификатор родственника.</summary>
        [Key]
        public int Id { get; set; }
        /// <summary>Фамилия родственника.</summary>
        public string Surname { get; set; }
    }
}