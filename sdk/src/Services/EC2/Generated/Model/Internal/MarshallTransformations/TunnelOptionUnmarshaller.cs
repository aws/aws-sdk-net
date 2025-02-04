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
    /// Response Unmarshaller for TunnelOption Object
    /// </summary>  
    public class TunnelOptionUnmarshaller : IXmlUnmarshaller<TunnelOption, XmlUnmarshallerContext>
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
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.DpdTimeoutSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("enableTunnelLifecycleControl", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EnableTunnelLifecycleControl = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ikeVersionSet/item", targetDepth))
                    {
                        var unmarshaller = IKEVersionsListValueUnmarshaller.Instance;
                        if (unmarshalledObject.IkeVersions == null)
                        {
                            unmarshalledObject.IkeVersions = new List<IKEVersionsListValue>();
                        }
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
                        if (unmarshalledObject.Phase1DHGroupNumbers == null)
                        {
                            unmarshalledObject.Phase1DHGroupNumbers = new List<Phase1DHGroupNumbersListValue>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Phase1DHGroupNumbers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("phase1EncryptionAlgorithmSet/item", targetDepth))
                    {
                        var unmarshaller = Phase1EncryptionAlgorithmsListValueUnmarshaller.Instance;
                        if (unmarshalledObject.Phase1EncryptionAlgorithms == null)
                        {
                            unmarshalledObject.Phase1EncryptionAlgorithms = new List<Phase1EncryptionAlgorithmsListValue>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Phase1EncryptionAlgorithms.Add(item);
                        continue;
                    }
                    if (context.TestExpression("phase1IntegrityAlgorithmSet/item", targetDepth))
                    {
                        var unmarshaller = Phase1IntegrityAlgorithmsListValueUnmarshaller.Instance;
                        if (unmarshalledObject.Phase1IntegrityAlgorithms == null)
                        {
                            unmarshalledObject.Phase1IntegrityAlgorithms = new List<Phase1IntegrityAlgorithmsListValue>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Phase1IntegrityAlgorithms.Add(item);
                        continue;
                    }
                    if (context.TestExpression("phase1LifetimeSeconds", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Phase1LifetimeSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("phase2DHGroupNumberSet/item", targetDepth))
                    {
                        var unmarshaller = Phase2DHGroupNumbersListValueUnmarshaller.Instance;
                        if (unmarshalledObject.Phase2DHGroupNumbers == null)
                        {
                            unmarshalledObject.Phase2DHGroupNumbers = new List<Phase2DHGroupNumbersListValue>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Phase2DHGroupNumbers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("phase2EncryptionAlgorithmSet/item", targetDepth))
                    {
                        var unmarshaller = Phase2EncryptionAlgorithmsListValueUnmarshaller.Instance;
                        if (unmarshalledObject.Phase2EncryptionAlgorithms == null)
                        {
                            unmarshalledObject.Phase2EncryptionAlgorithms = new List<Phase2EncryptionAlgorithmsListValue>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Phase2EncryptionAlgorithms.Add(item);
                        continue;
                    }
                    if (context.TestExpression("phase2IntegrityAlgorithmSet/item", targetDepth))
                    {
                        var unmarshaller = Phase2IntegrityAlgorithmsListValueUnmarshaller.Instance;
                        if (unmarshalledObject.Phase2IntegrityAlgorithms == null)
                        {
                            unmarshalledObject.Phase2IntegrityAlgorithms = new List<Phase2IntegrityAlgorithmsListValue>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Phase2IntegrityAlgorithms.Add(item);
                        continue;
                    }
                    if (context.TestExpression("phase2LifetimeSeconds", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
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
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.RekeyFuzzPercentage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("rekeyMarginTimeSeconds", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.RekeyMarginTimeSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("replayWindowSize", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
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