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
    /// Response Unmarshaller for HyperParameterTuningJobSearchEntity Object
    /// </summary>  
    public class HyperParameterTuningJobSearchEntityUnmarshaller : IJsonUnmarshaller<HyperParameterTuningJobSearchEntity, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public HyperParameterTuningJobSearchEntity Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            HyperParameterTuningJobSearchEntity unmarshalledObject = new HyperParameterTuningJobSearchEntity();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("BestTrainingJob", targetDepth))
                {
                    var unmarshaller = HyperParameterTrainingJobSummaryUnmarshaller.Instance;
                    unmarshalledObject.BestTrainingJob = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConsumedResources", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobConsumedResourcesUnmarshaller.Instance;
                    unmarshalledObject.ConsumedResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningEndTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningEndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningJobArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningJobConfig", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobConfigUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningJobConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningJobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningJobName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningJobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningJobStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ObjectiveStatusCounters", targetDepth))
                {
                    var unmarshaller = ObjectiveStatusCountersUnmarshaller.Instance;
                    unmarshalledObject.ObjectiveStatusCounters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OverallBestTrainingJob", targetDepth))
                {
                    var unmarshaller = HyperParameterTrainingJobSummaryUnmarshaller.Instance;
                    unmarshalledObject.OverallBestTrainingJob = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrainingJobDefinition", targetDepth))
                {
                    var unmarshaller = HyperParameterTrainingJobDefinitionUnmarshaller.Instance;
                    unmarshalledObject.TrainingJobDefinition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrainingJobDefinitions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<HyperParameterTrainingJobDefinition, HyperParameterTrainingJobDefinitionUnmarshaller>(HyperParameterTrainingJobDefinitionUnmarshaller.Instance);
                    unmarshalledObject.TrainingJobDefinitions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrainingJobStatusCounters", targetDepth))
                {
                    var unmarshaller = TrainingJobStatusCountersUnmarshaller.Instance;
                    unmarshalledObject.TrainingJobStatusCounters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TuningJobCompletionDetails", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobCompletionDetailsUnmarshaller.Instance;
                    unmarshalledObject.TuningJobCompletionDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WarmStartConfig", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobWarmStartConfigUnmarshaller.Instance;
                    unmarshalledObject.WarmStartConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static HyperParameterTuningJobSearchEntityUnmarshaller _instance = new HyperParameterTuningJobSearchEntityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HyperParameterTuningJobSearchEntityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}