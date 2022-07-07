using System;
using System.ComponentModel.DataAnnotations;

namespace ASHK.SRTApp.Common.Model
{
    public class RawTire
    {
        [Display(Name = "ИД")]
        public Guid ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Наименование краткое")]
        public string ShortName { get; set; }
        [Display(Name = "Вес")]
        public float WeightNominal { get; set; }
        [Display(Name = "Допуск максимум")]
        public float limitMax { get; set; }
        [Display(Name = "Допуск минимум")]
        public float limitMin { get; set; }
        public RawTire(Guid ID, string Name, string ShortName, float WeightNominal, float limitMax, float limitMin)
        {
            this.ID = ID;
            this.Name = Name;
            this.ShortName = ShortName;
            this.WeightNominal = WeightNominal;
            this.limitMax = limitMax;
            this.limitMin = limitMin;
        }

    }
}
