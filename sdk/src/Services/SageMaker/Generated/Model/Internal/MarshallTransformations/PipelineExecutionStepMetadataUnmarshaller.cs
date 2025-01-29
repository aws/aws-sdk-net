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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PipelineExecutionStepMetadata Object
    /// </summary>  
    public class PipelineExecutionStepMetadataUnmarshaller : IJsonUnmarshaller<PipelineExecutionStepMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public PipelineExecutionStepMetadata Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            PipelineExecutionStepMetadata unmarshalledObject = new PipelineExecutionStepMetadata();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AutoMLJob", targetDepth))
                {
                    var unmarshaller = AutoMLJobStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.AutoMLJob = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Callback", targetDepth))
                {
                    var unmarshaller = CallbackStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.Callback = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ClarifyCheck", targetDepth))
                {
                    var unmarshaller = ClarifyCheckStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.ClarifyCheck = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Condition", targetDepth))
                {
                    var unmarshaller = ConditionStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.Condition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EMR", targetDepth))
                {
                    var unmarshaller = EMRStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.EMR = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Endpoint", targetDepth))
                {
                    var unmarshaller = EndpointStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EndpointConfig", targetDepth))
                {
                    var unmarshaller = EndpointConfigStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.EndpointConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Fail", targetDepth))
                {
                    var unmarshaller = FailStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.Fail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Lambda", targetDepth))
                {
                    var unmarshaller = LambdaStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.Lambda = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Model", targetDepth))
                {
                    var unmarshaller = ModelStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.Model = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProcessingJob", targetDepth))
                {
                    var unmarshaller = ProcessingJobStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.ProcessingJob = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("QualityCheck", targetDepth))
                {
                    var unmarshaller = QualityCheckStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.QualityCheck = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RegisterModel", targetDepth))
                {
                    var unmarshaller = RegisterModelStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.RegisterModel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrainingJob", targetDepth))
                {
                    var unmarshaller = TrainingJobStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.TrainingJob = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TransformJob", targetDepth))
                {
                    var unmarshaller = TransformJobStepMetadataUnmarshaller.Instance;
                    unmarshalledObject.TransformJob = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TuningJob", targetDepth))
                {
                    var unmarshaller = TuningJobStepMetaDataUnmarshaller.Instance;
                    unmarshalledObject.TuningJob = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PipelineExecutionStepMetadataUnmarshaller _instance = new PipelineExecutionStepMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PipelineExecutionStepMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}