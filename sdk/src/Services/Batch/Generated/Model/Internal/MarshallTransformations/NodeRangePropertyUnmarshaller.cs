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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NodeRangeProperty Object
    /// </summary>  
    public class NodeRangePropertyUnmarshaller : IUnmarshaller<NodeRangeProperty, XmlUnmarshallerContext>, IUnmarshaller<NodeRangeProperty, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NodeRangeProperty IUnmarshaller<NodeRangeProperty, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public NodeRangeProperty Unmarshall(JsonUnmarshallerContext context)
        {
            NodeRangeProperty unmarshalledObject = new NodeRangeProperty();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("consumableResourceProperties", targetDepth))
                {
                    var unmarshaller = ConsumableResourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.ConsumableResourceProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("container", targetDepth))
                {
                    var unmarshaller = ContainerPropertiesUnmarshaller.Instance;
                    unmarshalledObject.Container = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ecsProperties", targetDepth))
                {
                    var unmarshaller = EcsPropertiesUnmarshaller.Instance;
                    unmarshalledObject.EcsProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eksProperties", targetDepth))
                {
                    var unmarshaller = EksPropertiesUnmarshaller.Instance;
                    unmarshalledObject.EksProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InstanceTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetNodes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetNodes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static NodeRangePropertyUnmarshaller _instance = new NodeRangePropertyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NodeRangePropertyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}