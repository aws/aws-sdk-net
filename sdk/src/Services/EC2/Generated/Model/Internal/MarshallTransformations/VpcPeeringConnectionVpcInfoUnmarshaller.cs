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
    /// Response Unmarshaller for VpcPeeringConnectionVpcInfo Object
    /// </summary>  
    public class VpcPeeringConnectionVpcInfoUnmarshaller : IXmlUnmarshaller<VpcPeeringConnectionVpcInfo, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VpcPeeringConnectionVpcInfo Unmarshall(XmlUnmarshallerContext context)
        {
            VpcPeeringConnectionVpcInfo unmarshalledObject = new VpcPeeringConnectionVpcInfo();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("cidrBlock", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CidrBlock = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("cidrBlockSet/item", targetDepth))
                    {
                        var unmarshaller = CidrBlockUnmarshaller.Instance;
                        if (unmarshalledObject.CidrBlockSet == null)
                        {
                            unmarshalledObject.CidrBlockSet = new List<CidrBlock>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.CidrBlockSet.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ipv6CidrBlockSet/item", targetDepth))
                    {
                        var unmarshaller = Ipv6CidrBlockUnmarshaller.Instance;
                        if (unmarshalledObject.Ipv6CidrBlockSet == null)
                        {
                            unmarshalledObject.Ipv6CidrBlockSet = new List<Ipv6CidrBlock>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Ipv6CidrBlockSet.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("peeringOptions", targetDepth))
                    {
                        var unmarshaller = VpcPeeringConnectionOptionsDescriptionUnmarshaller.Instance;
                        unmarshalledObject.PeeringOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("region", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
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

        private static VpcPeeringConnectionVpcInfoUnmarshaller _instance = new VpcPeeringConnectionVpcInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VpcPeeringConnectionVpcInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}