using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; } // Methodların önünde çalışan ve çeşitli işlemleri yerine getiren Aop yapısı oluşturcağız.
        // Bu da hem çeşitli kurallarımızı. doğrulamalarımızı vs. attribute şeklinde tutacağız ve  business dışında tutacak hemde bize fonksiyonellik kazandırmış olacak.


        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
