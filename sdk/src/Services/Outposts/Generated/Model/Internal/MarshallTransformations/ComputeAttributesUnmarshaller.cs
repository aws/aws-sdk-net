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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ComputeAttributes Object
    /// </summary>  
    public class ComputeAttributesUnmarshaller : IUnmarshaller<ComputeAttributes, XmlUnmarshallerContext>, IUnmarshaller<ComputeAttributes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ComputeAttributes IUnmarshaller<ComputeAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ComputeAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            ComputeAttributes unmarshalledObject = new ComputeAttributes();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("HostId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HostId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceFamilies", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InstanceFamilies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceTypeCapacities", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetInstanceTypeCapacity, AssetInstanceTypeCapacityUnmarshaller>(AssetInstanceTypeCapacityUnmarshaller.Instance);
                    unmarshalledObject.InstanceTypeCapacities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxVcpus", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxVcpus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ComputeAttributesUnmarshaller _instance = new ComputeAttributesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComputeAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}