using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakharov.Utilities {
    /// <summary>
    /// Сущность
    /// </summary>
    public class CEntity {
        /// <summary>Идентификатор сущности.</summary>
        [Key]
        public int Id { get; set; }
        /// <summary>Дата создания сущности</summary>
        public DateTime CreatedAt { get; set; }
    }
}
