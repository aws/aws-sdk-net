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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.DocDB.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.DocDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServerlessV2PlatformVersionInfo Object
    /// </summary>
    public partial class ServerlessV2PlatformVersionInfoUnmarshaller : IXmlUnmarshaller<ServerlessV2PlatformVersionInfo, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ServerlessV2PlatformVersionInfo Unmarshall(XmlUnmarshallerContext context)
        {
            ServerlessV2PlatformVersionInfo unmarshalledObject = new ServerlessV2PlatformVersionInfo();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("IsDefault", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IsDefault = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ServerlessV2FeaturesSupport", targetDepth))
                    {
                        var unmarshaller = ServerlessV2FeaturesSupportUnmarshaller.Instance;
                        unmarshalledObject.ServerlessV2FeaturesSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ServerlessV2PlatformVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServerlessV2PlatformVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ServerlessV2PlatformVersionDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServerlessV2PlatformVersionDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Status", targetDepth))
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

        private static ServerlessV2PlatformVersionInfoUnmarshaller _instance = new ServerlessV2PlatformVersionInfoUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ServerlessV2PlatformVersionInfoUnmarshaller Instance => _instance;
    }
}
