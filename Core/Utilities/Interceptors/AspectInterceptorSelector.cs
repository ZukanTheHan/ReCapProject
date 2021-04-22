using Castle.DynamicProxy;
using System;
using System.Linq;
using System.Reflection;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector // Bu sistmede oluşturulan attributelerin -classlar, methodlar- okunmasını sağlıyor.
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList(); 
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);
            /*classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger)));*/ // Otomatik olarak bütün sistemem loglama ekleme işlemini yapıyor ama loglama altyapısı ister.

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}
