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
    /// Response Unmarshaller for NatGatewayAddress Object
    /// </summary>  
    public class NatGatewayAddressUnmarshaller : IXmlUnmarshaller<NatGatewayAddress, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NatGatewayAddress Unmarshall(XmlUnmarshallerContext context)
        {
            NatGatewayAddress unmarshalledObject = new NatGatewayAddress();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("allocationId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AllocationId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("associationId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AssociationId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("failureMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FailureMessage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("isPrimary", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IsPrimary = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkInterfaceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("privateIp", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PrivateIp = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("publicIp", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PublicIp = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
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

        private static NatGatewayAddressUnmarshaller _instance = new NatGatewayAddressUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NatGatewayAddressUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}