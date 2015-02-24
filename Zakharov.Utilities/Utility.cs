using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakharov.Utilities {
    /// <summary>Неполные дата и время</summary>
    [ComplexType]
    public class CDateTime {
        /// <summary>Возвращает день месяца, представленный этим экземпляром</summary>
        /// <remarks>Если день месяца не известен, то возвращается значение 0</remarks>
        public int Day {
            get {
                if (m_sDateTime.Length >= 8) {
                    int c_iDay = 0;
                    if (Int32.TryParse(m_sDateTime, out c_iDay))
                        return c_iDay;
                    else
                        return 0;
                }
                else
                    return 0;
            }
        }
        /// <summary>Дата и время в виде строки в формате ISO 8601</summary>
        /// <remarks>Формат представления даты и и времени ГГГГММДД нн:мм:сс.ммм</remarks>
        private string m_sDateTime = "";
        /// <summary>Дата и время в виде строки в формате ISO 8601</summary>
        /// <remarks>Формат представления даты и и времени ГГГГММДД нн:мм:сс.ммм</remarks>
        public string DateTime { get; set; }
        public CDateTime(int x_iYear, int x_iMonth, int x_iDay) {
            DateTime = String.Format("{0:0000}{1:00}{2:00}",x_iYear,x_iMonth,x_iDay);
        }
    }
}