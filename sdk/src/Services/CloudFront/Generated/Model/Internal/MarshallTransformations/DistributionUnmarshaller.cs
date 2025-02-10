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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Distribution Object
    /// </summary>  
    public class DistributionUnmarshaller : IXmlUnmarshaller<Distribution, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Distribution Unmarshall(XmlUnmarshallerContext context)
        {
            Distribution unmarshalledObject = new Distribution();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ActiveTrustedKeyGroups", targetDepth))
                    {
                        var unmarshaller = ActiveTrustedKeyGroupsUnmarshaller.Instance;
                        unmarshalledObject.ActiveTrustedKeyGroups = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ActiveTrustedSigners", targetDepth))
                    {
                        var unmarshaller = ActiveTrustedSignersUnmarshaller.Instance;
                        unmarshalledObject.ActiveTrustedSigners = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AliasICPRecordals/AliasICPRecordal", targetDepth))
                    {
                        if (unmarshalledObject.AliasICPRecordals == null)
                        {
                            unmarshalledObject.AliasICPRecordals = new List<AliasICPRecordal>();
                        }
                        var unmarshaller = AliasICPRecordalUnmarshaller.Instance;
                        unmarshalledObject.AliasICPRecordals.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("ARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DistributionConfig", targetDepth))
                    {
                        var unmarshaller = DistributionConfigUnmarshaller.Instance;
                        unmarshalledObject.DistributionConfig = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DomainName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DomainName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Id", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InProgressInvalidationBatches", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.InProgressInvalidationBatches = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LastModifiedTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
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
        private static DistributionUnmarshaller _instance = new DistributionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DistributionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}