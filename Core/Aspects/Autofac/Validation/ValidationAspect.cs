using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir validator tip değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType); // Reflection var burada -Activator.CreateInstance- carvalidatorın mesela çalışma anında bir instancenı oluşturuyor.
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; // carvalidatorın base tipini bul -AbstractValidator- generic argumenın ilkini bul -car-
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);// İnvocation -method- parameterlerinden entitytypenide olanlrı bul -CarMangerda bu car-  
            foreach (var entity in entities) // Bunları gez ve alttaki toolu kullanarak validate et.
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
