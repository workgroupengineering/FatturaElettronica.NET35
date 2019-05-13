namespace System.Reflection
{
    static class ReflectionExtentsions
    {
        public static void SetValue(this PropertyInfo property,  object obj, object value)
        {
            property.SetValue(obj, value, null);
        }
    }
}
