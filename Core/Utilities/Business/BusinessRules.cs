using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) // İş kurallarını logic altında çağırıryoruz -Check...- tipi olanlar.
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic; // Logic yani check.. tipi kuralları businessa gönderiyoruz.
                }
            }
            return null; // Bir sorun yoksa boş dönüyor.
        }
    }
}
