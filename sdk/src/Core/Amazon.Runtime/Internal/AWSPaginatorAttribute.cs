using System;

namespace Amazon.Runtime.Internal
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class AWSPaginatorAttribute : Attribute
    {
        public string[] InputToken { get; set; }
        public string LimitKey { get; set; }
        public string[] OutputToken { get; set; }
    }
}