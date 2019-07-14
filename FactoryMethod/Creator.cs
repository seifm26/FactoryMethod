using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Creator
    {
        // این متد بر اساس نوع ورودی انتخاب مناسب را انجام و باز می‌گرداند
        public abstract IProduct FactoryMethod(string type);
    }
}
