using System.Dynamic;
using System.Collections.Generic;
using System.ComponentModel;

namespace zbd_net.helpers {
    public static class Helpers {
        public static ExpandoObject ToExpando(this object anonymousObject)
{
            IDictionary<string, object> expando = new ExpandoObject();
            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(anonymousObject))
            {
                var obj = propertyDescriptor.GetValue(anonymousObject);
                expando.Add(propertyDescriptor.Name, obj);
            }

            return (ExpandoObject)expando;
        }
    }
}
