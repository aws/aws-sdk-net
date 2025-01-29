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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridge.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridge.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Target Object
    /// </summary>  
    public class TargetUnmarshaller : IJsonUnmarshaller<Target, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Target Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Target unmarshalledObject = new Target();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AppSyncParameters", targetDepth))
                {
                    var unmarshaller = AppSyncParametersUnmarshaller.Instance;
                    unmarshalledObject.AppSyncParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BatchParameters", targetDepth))
                {
                    var unmarshaller = BatchParametersUnmarshaller.Instance;
                    unmarshalledObject.BatchParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeadLetterConfig", targetDepth))
                {
                    var unmarshaller = DeadLetterConfigUnmarshaller.Instance;
                    unmarshalledObject.DeadLetterConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EcsParameters", targetDepth))
                {
                    var unmarshaller = EcsParametersUnmarshaller.Instance;
                    unmarshalledObject.EcsParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HttpParameters", targetDepth))
                {
                    var unmarshaller = HttpParametersUnmarshaller.Instance;
                    unmarshalledObject.HttpParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Input", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Input = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InputPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InputTransformer", targetDepth))
                {
                    var unmarshaller = InputTransformerUnmarshaller.Instance;
                    unmarshalledObject.InputTransformer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KinesisParameters", targetDepth))
                {
                    var unmarshaller = KinesisParametersUnmarshaller.Instance;
                    unmarshalledObject.KinesisParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RedshiftDataParameters", targetDepth))
                {
                    var unmarshaller = RedshiftDataParametersUnmarshaller.Instance;
                    unmarshalledObject.RedshiftDataParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RetryPolicy", targetDepth))
                {
                    var unmarshaller = RetryPolicyUnmarshaller.Instance;
                    unmarshalledObject.RetryPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RunCommandParameters", targetDepth))
                {
                    var unmarshaller = RunCommandParametersUnmarshaller.Instance;
                    unmarshalledObject.RunCommandParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SageMakerPipelineParameters", targetDepth))
                {
                    var unmarshaller = SageMakerPipelineParametersUnmarshaller.Instance;
                    unmarshalledObject.SageMakerPipelineParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SqsParameters", targetDepth))
                {
                    var unmarshaller = SqsParametersUnmarshaller.Instance;
                    unmarshalledObject.SqsParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TargetUnmarshaller _instance = new TargetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TargetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}