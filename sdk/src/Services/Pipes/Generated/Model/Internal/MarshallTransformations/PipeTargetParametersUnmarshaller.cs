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
    /// Response Unmarshaller for PipeTargetParameters Object
    /// </summary>  
    public class PipeTargetParametersUnmarshaller : IUnmarshaller<PipeTargetParameters, XmlUnmarshallerContext>, IUnmarshaller<PipeTargetParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PipeTargetParameters IUnmarshaller<PipeTargetParameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PipeTargetParameters Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PipeTargetParameters unmarshalledObject = new PipeTargetParameters();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BatchJobParameters", targetDepth))
                {
                    var unmarshaller = PipeTargetBatchJobParametersUnmarshaller.Instance;
                    unmarshalledObject.BatchJobParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CloudWatchLogsParameters", targetDepth))
                {
                    var unmarshaller = PipeTargetCloudWatchLogsParametersUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchLogsParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EcsTaskParameters", targetDepth))
                {
                    var unmarshaller = PipeTargetEcsTaskParametersUnmarshaller.Instance;
                    unmarshalledObject.EcsTaskParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventBridgeEventBusParameters", targetDepth))
                {
                    var unmarshaller = PipeTargetEventBridgeEventBusParametersUnmarshaller.Instance;
                    unmarshalledObject.EventBridgeEventBusParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HttpParameters", targetDepth))
                {
                    var unmarshaller = PipeTargetHttpParametersUnmarshaller.Instance;
                    unmarshalledObject.HttpParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputTemplate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputTemplate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KinesisStreamParameters", targetDepth))
                {
                    var unmarshaller = PipeTargetKinesisStreamParametersUnmarshaller.Instance;
                    unmarshalledObject.KinesisStreamParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LambdaFunctionParameters", targetDepth))
                {
                    var unmarshaller = PipeTargetLambdaFunctionParametersUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RedshiftDataParameters", targetDepth))
                {
                    var unmarshaller = PipeTargetRedshiftDataParametersUnmarshaller.Instance;
                    unmarshalledObject.RedshiftDataParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SageMakerPipelineParameters", targetDepth))
                {
                    var unmarshaller = PipeTargetSageMakerPipelineParametersUnmarshaller.Instance;
                    unmarshalledObject.SageMakerPipelineParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SqsQueueParameters", targetDepth))
                {
                    var unmarshaller = PipeTargetSqsQueueParametersUnmarshaller.Instance;
                    unmarshalledObject.SqsQueueParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StepFunctionStateMachineParameters", targetDepth))
                {
                    var unmarshaller = PipeTargetStateMachineParametersUnmarshaller.Instance;
                    unmarshalledObject.StepFunctionStateMachineParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PipeTargetParametersUnmarshaller _instance = new PipeTargetParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PipeTargetParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}