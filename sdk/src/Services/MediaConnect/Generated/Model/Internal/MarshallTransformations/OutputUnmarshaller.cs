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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Output Object
    /// </summary>  
    public class OutputUnmarshaller : IUnmarshaller<Output, XmlUnmarshallerContext>, IUnmarshaller<Output, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Output IUnmarshaller<Output, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Output Unmarshall(JsonUnmarshallerContext context)
        {
            Output unmarshalledObject = new Output();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("bridgeArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BridgeArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bridgePorts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.BridgePorts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataTransferSubscriberFeePercent", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DataTransferSubscriberFeePercent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("destination", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Destination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encryption", targetDepth))
                {
                    var unmarshaller = EncryptionUnmarshaller.Instance;
                    unmarshalledObject.Encryption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("entitlementArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntitlementArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listenerAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ListenerAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mediaLiveInputArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaLiveInputArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mediaStreamOutputConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MediaStreamOutputConfiguration, MediaStreamOutputConfigurationUnmarshaller>(MediaStreamOutputConfigurationUnmarshaller.Instance);
                    unmarshalledObject.MediaStreamOutputConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("port", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transport", targetDepth))
                {
                    var unmarshaller = TransportUnmarshaller.Instance;
                    unmarshalledObject.Transport = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpcInterfaceAttachment", targetDepth))
                {
                    var unmarshaller = VpcInterfaceAttachmentUnmarshaller.Instance;
                    unmarshalledObject.VpcInterfaceAttachment = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OutputUnmarshaller _instance = new OutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618