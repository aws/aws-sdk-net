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
    /// Response Unmarshaller for TrainingSpecification Object
    /// </summary>  
    public class TrainingSpecificationUnmarshaller : IJsonUnmarshaller<TrainingSpecification, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TrainingSpecification Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TrainingSpecification unmarshalledObject = new TrainingSpecification();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AdditionalS3DataSource", targetDepth))
                {
                    var unmarshaller = AdditionalS3DataSourceUnmarshaller.Instance;
                    unmarshalledObject.AdditionalS3DataSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MetricDefinitions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<MetricDefinition, MetricDefinitionUnmarshaller>(MetricDefinitionUnmarshaller.Instance);
                    unmarshalledObject.MetricDefinitions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SupportedHyperParameters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<HyperParameterSpecification, HyperParameterSpecificationUnmarshaller>(HyperParameterSpecificationUnmarshaller.Instance);
                    unmarshalledObject.SupportedHyperParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SupportedTrainingInstanceTypes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedTrainingInstanceTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SupportedTuningJobObjectiveMetrics", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<HyperParameterTuningJobObjective, HyperParameterTuningJobObjectiveUnmarshaller>(HyperParameterTuningJobObjectiveUnmarshaller.Instance);
                    unmarshalledObject.SupportedTuningJobObjectiveMetrics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SupportsDistributedTraining", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.SupportsDistributedTraining = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrainingChannels", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ChannelSpecification, ChannelSpecificationUnmarshaller>(ChannelSpecificationUnmarshaller.Instance);
                    unmarshalledObject.TrainingChannels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrainingImage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingImage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrainingImageDigest", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingImageDigest = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TrainingSpecificationUnmarshaller _instance = new TrainingSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TrainingSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}