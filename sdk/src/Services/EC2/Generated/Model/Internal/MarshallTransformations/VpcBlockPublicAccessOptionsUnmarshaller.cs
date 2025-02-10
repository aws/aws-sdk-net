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
    /// Response Unmarshaller for VpcBlockPublicAccessOptions Object
    /// </summary>  
    public class VpcBlockPublicAccessOptionsUnmarshaller : IXmlUnmarshaller<VpcBlockPublicAccessOptions, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VpcBlockPublicAccessOptions Unmarshall(XmlUnmarshallerContext context)
        {
            VpcBlockPublicAccessOptions unmarshalledObject = new VpcBlockPublicAccessOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("awsAccountId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AwsAccountId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("awsRegion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AwsRegion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("exclusionsAllowed", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ExclusionsAllowed = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("internetGatewayBlockMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InternetGatewayBlockMode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("lastUpdateTimestamp", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.LastUpdateTimestamp = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("managedBy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ManagedBy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("reason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Reason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
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

        private static VpcBlockPublicAccessOptionsUnmarshaller _instance = new VpcBlockPublicAccessOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VpcBlockPublicAccessOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}