using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Runtime.SharedInterfaces
{
    public interface ICoreAmazonSQS
    {
#if BCL
        Dictionary<string, string> GetAttributes(string queueUrl);

        void SetAttributes(string queueUrl, Dictionary<string, string> attributes);
#endif
    }
}
