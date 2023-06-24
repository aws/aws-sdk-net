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
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TunnelOption Object
    /// </summary>  
    public class TunnelOptionUnmarshaller : IUnmarshaller<TunnelOption, XmlUnmarshallerContext>, IUnmarshaller<TunnelOption, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TunnelOption Unmarshall(XmlUnmarshallerContext context)
        {
            TunnelOption unmarshalledObject = new TunnelOption();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("dpdTimeoutAction", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DpdTimeoutAction = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("dpdTimeoutSeconds", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.DpdTimeoutSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("enableTunnelLifecycleControl", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.EnableTunnelLifecycleControl = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ikeVersionSet/item", targetDepth))
                    {
                        var unmarshaller = IKEVersionsListValueUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.IkeVersions.Add(item);
                        continue;
                    }
                    if (context.TestExpression("logOptions", targetDepth))
                    {
                        var unmarshaller = VpnTunnelLogOptionsUnmarshaller.Instance;
                        unmarshalledObject.LogOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("outsideIpAddress", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OutsideIpAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("phase1DHGroupNumberSet/item", targetDepth))
                    {
                        var unmarshaller = Phase1DHGroupNumbersListValueUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Phase1DHGroupNumbers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("phase1EncryptionAlgorithmSet/item", targetDepth))
                    {
                        var unmarshaller = Phase1EncryptionAlgorithmsListValueUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Phase1EncryptionAlgorithms.Add(item);
                        continue;
                    }
                    if (context.TestExpression("phase1IntegrityAlgorithmSet/item", targetDepth))
                    {
                        var unmarshaller = Phase1IntegrityAlgorithmsListValueUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Phase1IntegrityAlgorithms.Add(item);
                        continue;
                    }
                    if (context.TestExpression("phase1LifetimeSeconds", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Phase1LifetimeSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("phase2DHGroupNumberSet/item", targetDepth))
                    {
                        var unmarshaller = Phase2DHGroupNumbersListValueUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Phase2DHGroupNumbers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("phase2EncryptionAlgorithmSet/item", targetDepth))
                    {
                        var unmarshaller = Phase2EncryptionAlgorithmsListValueUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Phase2EncryptionAlgorithms.Add(item);
                        continue;
                    }
                    if (context.TestExpression("phase2IntegrityAlgorithmSet/item", targetDepth))
                    {
                        var unmarshaller = Phase2IntegrityAlgorithmsListValueUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Phase2IntegrityAlgorithms.Add(item);
                        continue;
                    }
                    if (context.TestExpression("phase2LifetimeSeconds", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Phase2LifetimeSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("preSharedKey", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PreSharedKey = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("rekeyFuzzPercentage", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.RekeyFuzzPercentage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("rekeyMarginTimeSeconds", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.RekeyMarginTimeSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("replayWindowSize", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.ReplayWindowSize = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("startupAction", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StartupAction = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tunnelInsideCidr", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TunnelInsideCidr = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tunnelInsideIpv6Cidr", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TunnelInsideIpv6Cidr = unmarshaller.Unmarshall(context);
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

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TunnelOption Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static TunnelOptionUnmarshaller _instance = new TunnelOptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TunnelOptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}