using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public partial class LifecycleRuleUnmarshaller : IXmlUnmarshaller<LifecycleRule, XmlUnmarshallerContext>
    {
        private static void FilterCustomUnmarshall(XmlUnmarshallerContext context, LifecycleRule rule)
        {
            var predicateList = LifecycleFilterPredicateListUnmarshaller.Instance.Unmarshall(context);

            if (predicateList.Count == 1)
            {
                rule.Filter = new LifecycleFilter()
                {
                    LifecycleFilterPredicate = predicateList[0]
                };
            }
            else if (predicateList.Count > 1)
            {
                var requestId = context.ResponseData.GetHeaderValue("x-amzn-RequestId");
                var message = "The Filter element must contain at most one 'Prefix', 'Tag', or 'And' predicate.";
                throw new AmazonUnmarshallingException(requestId, context.CurrentPath, context.ResponseBody, message, null);
            }
            return;
        }
    }
}
