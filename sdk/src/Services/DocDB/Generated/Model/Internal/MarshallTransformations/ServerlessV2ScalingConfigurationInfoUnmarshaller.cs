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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DocDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DocDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServerlessV2ScalingConfigurationInfo Object
    /// </summary>  
    public class ServerlessV2ScalingConfigurationInfoUnmarshaller : IXmlUnmarshaller<ServerlessV2ScalingConfigurationInfo, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ServerlessV2ScalingConfigurationInfo Unmarshall(XmlUnmarshallerContext context)
        {
            ServerlessV2ScalingConfigurationInfo unmarshalledObject = new ServerlessV2ScalingConfigurationInfo();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("MaxCapacity", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.MaxCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinCapacity", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.MinCapacity = unmarshaller.Unmarshall(context);
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

        private static ServerlessV2ScalingConfigurationInfoUnmarshaller _instance = new ServerlessV2ScalingConfigurationInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServerlessV2ScalingConfigurationInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}