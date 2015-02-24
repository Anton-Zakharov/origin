using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakharov.Utilities.Entity {
    /// <summary>Сущность</summary>    
    public class CEntity<T> where T : struct {
        /// <summary>Идентификатор сущности.</summary>
        [Key]
        public T Id { get; set; }
        /// <summary>Дата и время создания сущности</summary>
        private DateTime m_dtCreated = new DateTime(1900, 1, 1);
        /// <summary>Дата и время создания сущности</summary>
        public DateTime Created {
            get {
                return m_dtCreated;
            }
            private set {
                m_dtCreated = value;
            }
        }

        /// <summary>Создание объекта.</summary>
        /// <param name="x_bConstructed">true, если в конструкторе необходимо инициализировать свойства сущности</param>
        public CEntity(bool x_bConstructed) {
            if (x_bConstructed)
                // Определение даты и времени создания сущности.
                m_dtCreated = DateTime.Now;
        }
        /// <summary>Создание объекта.</summary>
        public CEntity() {

        }
    }
}
