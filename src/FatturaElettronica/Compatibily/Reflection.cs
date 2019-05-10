using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

#if NET35
namespace System.Reflection
{
    
    static class ReflectionExtensions
    {
        public static TypeInfo GetTypeInfo(this Type source)
        {
            return new TypeInfo(source);
        }

        readonly static object[] EmptyArray = new object[0];

        public static PropertyInfo[] GetRuntimeProperties(this Type type)
        {
            return type.GetProperties();
        }

        public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo member, bool inherit = false)
            where T : Attribute
        {
            return (member.GetCustomAttributes(typeof(T), false) ?? EmptyArray)
                .OfType<T>();
        }

        public static T GetCustomAttribute<T>(this MemberInfo member, bool inherit = false)
            where T : Attribute
        {
            return (member.GetCustomAttributes(typeof(T), false) ?? EmptyArray).OfType<T>().Single();
        }

        public static IEnumerable<MethodInfo> GetRuntimeMethods(this Type type)
        {
            return type.GetMethods();
        }
    }

}
#endif