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
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AlgorithmSpecification Object
    /// </summary>  
    public class AlgorithmSpecificationUnmarshaller : IUnmarshaller<AlgorithmSpecification, XmlUnmarshallerContext>, IUnmarshaller<AlgorithmSpecification, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AlgorithmSpecification IUnmarshaller<AlgorithmSpecification, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AlgorithmSpecification Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AlgorithmSpecification unmarshalledObject = new AlgorithmSpecification();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AlgorithmName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AlgorithmName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContainerArguments", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ContainerArguments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContainerEntrypoint", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ContainerEntrypoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableSageMakerMetricsTimeSeries", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableSageMakerMetricsTimeSeries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricDefinitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MetricDefinition, MetricDefinitionUnmarshaller>(MetricDefinitionUnmarshaller.Instance);
                    unmarshalledObject.MetricDefinitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingImage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingImage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingImageConfig", targetDepth))
                {
                    var unmarshaller = TrainingImageConfigUnmarshaller.Instance;
                    unmarshalledObject.TrainingImageConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingInputMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingInputMode = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AlgorithmSpecificationUnmarshaller _instance = new AlgorithmSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AlgorithmSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}