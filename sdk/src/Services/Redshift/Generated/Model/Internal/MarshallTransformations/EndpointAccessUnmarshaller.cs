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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EndpointAccess Object
    /// </summary>  
    public class EndpointAccessUnmarshaller : IXmlUnmarshaller<EndpointAccess, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EndpointAccess Unmarshall(XmlUnmarshallerContext context)
        {
            EndpointAccess unmarshalledObject = new EndpointAccess();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Address", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Address = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClusterIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EndpointCreateTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.EndpointCreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EndpointName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EndpointName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EndpointStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EndpointStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Port", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourceOwner", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceOwner = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SubnetGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SubnetGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VpcEndpoint", targetDepth))
                    {
                        var unmarshaller = VpcEndpointUnmarshaller.Instance;
                        unmarshalledObject.VpcEndpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VpcSecurityGroups/VpcSecurityGroup", targetDepth))
                    {
                        var unmarshaller = VpcSecurityGroupMembershipUnmarshaller.Instance;
                        if (unmarshalledObject.VpcSecurityGroups == null)
                        {
                            unmarshalledObject.VpcSecurityGroups = new List<VpcSecurityGroupMembership>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.VpcSecurityGroups.Add(item);
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

        private static EndpointAccessUnmarshaller _instance = new EndpointAccessUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EndpointAccessUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}