/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InsightRuleContributor Object
    /// </summary>  
    public class InsightRuleContributorUnmarshaller : IXmlUnmarshaller<InsightRuleContributor, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InsightRuleContributor Unmarshall(XmlUnmarshallerContext context)
        {
            InsightRuleContributor unmarshalledObject = new InsightRuleContributor();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ApproximateAggregateValue", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.ApproximateAggregateValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Datapoints/member", targetDepth))
                    {
                        var unmarshaller = InsightRuleContributorDatapointUnmarshaller.Instance;
                        if (unmarshalledObject.Datapoints == null)
                        {
                            unmarshalledObject.Datapoints = new List<InsightRuleContributorDatapoint>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Datapoints.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Keys/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.Keys == null)
                        {
                            unmarshalledObject.Keys = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Keys.Add(item);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static InsightRuleContributorUnmarshaller _instance = new InsightRuleContributorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InsightRuleContributorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}