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
    /// Response Unmarshaller for VpcEndpointAssociation Object
    /// </summary>  
    public class VpcEndpointAssociationUnmarshaller : IXmlUnmarshaller<VpcEndpointAssociation, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VpcEndpointAssociation Unmarshall(XmlUnmarshallerContext context)
        {
            VpcEndpointAssociation unmarshalledObject = new VpcEndpointAssociation();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("associatedResourceAccessibility", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AssociatedResourceAccessibility = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("associatedResourceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AssociatedResourceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("dnsEntry", targetDepth))
                    {
                        var unmarshaller = DnsEntryUnmarshaller.Instance;
                        unmarshalledObject.DnsEntry = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("failureCode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FailureCode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("failureReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("id", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("privateDnsEntry", targetDepth))
                    {
                        var unmarshaller = DnsEntryUnmarshaller.Instance;
                        unmarshalledObject.PrivateDnsEntry = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("resourceConfigurationGroupArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceConfigurationGroupArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("serviceNetworkArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceNetworkArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("serviceNetworkName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceNetworkName = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("vpcEndpointId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcEndpointId = unmarshaller.Unmarshall(context);
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

        private static VpcEndpointAssociationUnmarshaller _instance = new VpcEndpointAssociationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VpcEndpointAssociationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}