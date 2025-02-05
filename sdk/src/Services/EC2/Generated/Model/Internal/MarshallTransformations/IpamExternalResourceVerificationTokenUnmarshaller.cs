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
    /// Response Unmarshaller for IpamExternalResourceVerificationToken Object
    /// </summary>  
    public class IpamExternalResourceVerificationTokenUnmarshaller : IXmlUnmarshaller<IpamExternalResourceVerificationToken, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public IpamExternalResourceVerificationToken Unmarshall(XmlUnmarshallerContext context)
        {
            IpamExternalResourceVerificationToken unmarshalledObject = new IpamExternalResourceVerificationToken();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ipamArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipamExternalResourceVerificationTokenArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamExternalResourceVerificationTokenArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipamExternalResourceVerificationTokenId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamExternalResourceVerificationTokenId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipamId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipamRegion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamRegion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("notAfter", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.NotAfter = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("tokenName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TokenName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tokenValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TokenValue = unmarshaller.Unmarshall(context);
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

        private static IpamExternalResourceVerificationTokenUnmarshaller _instance = new IpamExternalResourceVerificationTokenUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IpamExternalResourceVerificationTokenUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}