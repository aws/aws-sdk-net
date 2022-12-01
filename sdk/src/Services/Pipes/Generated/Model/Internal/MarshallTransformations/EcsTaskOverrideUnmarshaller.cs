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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EcsTaskOverride Object
    /// </summary>  
    public class EcsTaskOverrideUnmarshaller : IUnmarshaller<EcsTaskOverride, XmlUnmarshallerContext>, IUnmarshaller<EcsTaskOverride, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EcsTaskOverride IUnmarshaller<EcsTaskOverride, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EcsTaskOverride Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EcsTaskOverride unmarshalledObject = new EcsTaskOverride();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ContainerOverrides", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EcsContainerOverride, EcsContainerOverrideUnmarshaller>(EcsContainerOverrideUnmarshaller.Instance);
                    unmarshalledObject.ContainerOverrides = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Cpu", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Cpu = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EphemeralStorage", targetDepth))
                {
                    var unmarshaller = EcsEphemeralStorageUnmarshaller.Instance;
                    unmarshalledObject.EphemeralStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InferenceAcceleratorOverrides", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EcsInferenceAcceleratorOverride, EcsInferenceAcceleratorOverrideUnmarshaller>(EcsInferenceAcceleratorOverrideUnmarshaller.Instance);
                    unmarshalledObject.InferenceAcceleratorOverrides = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Memory", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Memory = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EcsTaskOverrideUnmarshaller _instance = new EcsTaskOverrideUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EcsTaskOverrideUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}