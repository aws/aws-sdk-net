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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EcsTaskOverride Object
    /// </summary>  
    public class EcsTaskOverrideUnmarshaller : IJsonUnmarshaller<EcsTaskOverride, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public EcsTaskOverride Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            EcsTaskOverride unmarshalledObject = new EcsTaskOverride();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ContainerOverrides", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<EcsContainerOverride, EcsContainerOverrideUnmarshaller>(EcsContainerOverrideUnmarshaller.Instance);
                    unmarshalledObject.ContainerOverrides = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Cpu", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Cpu = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EphemeralStorage", targetDepth))
                {
                    var unmarshaller = EcsEphemeralStorageUnmarshaller.Instance;
                    unmarshalledObject.EphemeralStorage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExecutionRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InferenceAcceleratorOverrides", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<EcsInferenceAcceleratorOverride, EcsInferenceAcceleratorOverrideUnmarshaller>(EcsInferenceAcceleratorOverrideUnmarshaller.Instance);
                    unmarshalledObject.InferenceAcceleratorOverrides = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Memory", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Memory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TaskRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskRoleArn = unmarshaller.Unmarshall(context, ref reader);
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