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
    /// Response Unmarshaller for ActiveVpnTunnelStatus Object
    /// </summary>  
    public class ActiveVpnTunnelStatusUnmarshaller : IXmlUnmarshaller<ActiveVpnTunnelStatus, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ActiveVpnTunnelStatus Unmarshall(XmlUnmarshallerContext context)
        {
            ActiveVpnTunnelStatus unmarshalledObject = new ActiveVpnTunnelStatus();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ikeVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IkeVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("phase1DHGroup", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Phase1DHGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("phase1EncryptionAlgorithm", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Phase1EncryptionAlgorithm = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("phase1IntegrityAlgorithm", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Phase1IntegrityAlgorithm = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("phase2DHGroup", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Phase2DHGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("phase2EncryptionAlgorithm", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Phase2EncryptionAlgorithm = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("phase2IntegrityAlgorithm", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Phase2IntegrityAlgorithm = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("provisioningStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ProvisioningStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("provisioningStatusReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ProvisioningStatusReason = unmarshaller.Unmarshall(context);
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

        private static ActiveVpnTunnelStatusUnmarshaller _instance = new ActiveVpnTunnelStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActiveVpnTunnelStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}