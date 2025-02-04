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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AttributeSummary Object
    /// </summary>  
    public class AttributeSummaryUnmarshaller : IXmlUnmarshaller<AttributeSummary, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AttributeSummary Unmarshall(XmlUnmarshallerContext context)
        {
            AttributeSummary unmarshalledObject = new AttributeSummary();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("attributeName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AttributeName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("mostFrequentValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MostFrequentValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("numberOfMatchedAccounts", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.NumberOfMatchedAccounts = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("numberOfUnmatchedAccounts", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.NumberOfUnmatchedAccounts = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("regionalSummarySet/item", targetDepth))
                    {
                        var unmarshaller = RegionalSummaryUnmarshaller.Instance;
                        if (unmarshalledObject.RegionalSummaries == null)
                        {
                            unmarshalledObject.RegionalSummaries = new List<RegionalSummary>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.RegionalSummaries.Add(item);
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

        private static AttributeSummaryUnmarshaller _instance = new AttributeSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AttributeSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}