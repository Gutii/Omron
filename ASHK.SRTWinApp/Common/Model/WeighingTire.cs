using System;
using System.ComponentModel.DataAnnotations;

namespace ASHK.SRTApp.Common.Model
{
    public class WeighingTire
    {
        [Display(Name = "ИД")]
        public Int64 ID { get; set; }
        [Display(Name = "ИД пользователя")]
        public int IDPercoUser { get; set; }
        [Display(Name = "ФИО")]
        public string FullFIO { get; set; }
        [Display(Name = "ИД покрышки")]
        public Guid IDTire { get; set; }
        [Display(Name = "Покрышка")]
        public string NameTire { get; set; }
        [Display(Name = "Наименование краткое")]
        public string ShortName { get; set; }
        [Display(Name = "Вес номинальный")]
        public float WeightNominal { get; set; }
        [Display(Name = "Допуск максимум")]
        public float limitMax { get; set; }
        [Display(Name = "Допуск минимум")]
        public float limitMin { get; set; }
        [Display(Name = "ИД статуса")]
        public int IDStatus { get; set; }
        [Display(Name = "Статус")]
        public string Status { get; set; }
        [Display(Name = "Код")]
        public string Code { get; set; }
        [Display(Name = "Вес")]
        public float Weight { get; set; }
        [Display(Name = "Дата создания")]
        public DateTime CreateData { get; set; }
        public WeighingTire()
        {
        }

    }
}
