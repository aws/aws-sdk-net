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
    /// Response Unmarshaller for SearchRecord Object
    /// </summary>  
    public class SearchRecordUnmarshaller : IUnmarshaller<SearchRecord, XmlUnmarshallerContext>, IUnmarshaller<SearchRecord, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SearchRecord IUnmarshaller<SearchRecord, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SearchRecord Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SearchRecord unmarshalledObject = new SearchRecord();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Endpoint", targetDepth))
                {
                    var unmarshaller = EndpointUnmarshaller.Instance;
                    unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Experiment", targetDepth))
                {
                    var unmarshaller = ExperimentUnmarshaller.Instance;
                    unmarshalledObject.Experiment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeatureGroup", targetDepth))
                {
                    var unmarshaller = FeatureGroupUnmarshaller.Instance;
                    unmarshalledObject.FeatureGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeatureMetadata", targetDepth))
                {
                    var unmarshaller = FeatureMetadataUnmarshaller.Instance;
                    unmarshalledObject.FeatureMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HyperParameterTuningJob", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobSearchEntityUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningJob = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Model", targetDepth))
                {
                    var unmarshaller = ModelDashboardModelUnmarshaller.Instance;
                    unmarshalledObject.Model = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelCard", targetDepth))
                {
                    var unmarshaller = ModelCardUnmarshaller.Instance;
                    unmarshalledObject.ModelCard = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackage", targetDepth))
                {
                    var unmarshaller = ModelPackageUnmarshaller.Instance;
                    unmarshalledObject.ModelPackage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageGroup", targetDepth))
                {
                    var unmarshaller = ModelPackageGroupUnmarshaller.Instance;
                    unmarshalledObject.ModelPackageGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Pipeline", targetDepth))
                {
                    var unmarshaller = PipelineUnmarshaller.Instance;
                    unmarshalledObject.Pipeline = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PipelineExecution", targetDepth))
                {
                    var unmarshaller = PipelineExecutionUnmarshaller.Instance;
                    unmarshalledObject.PipelineExecution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Project", targetDepth))
                {
                    var unmarshaller = ProjectUnmarshaller.Instance;
                    unmarshalledObject.Project = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingJob", targetDepth))
                {
                    var unmarshaller = TrainingJobUnmarshaller.Instance;
                    unmarshalledObject.TrainingJob = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Trial", targetDepth))
                {
                    var unmarshaller = TrialUnmarshaller.Instance;
                    unmarshalledObject.Trial = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrialComponent", targetDepth))
                {
                    var unmarshaller = TrialComponentUnmarshaller.Instance;
                    unmarshalledObject.TrialComponent = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SearchRecordUnmarshaller _instance = new SearchRecordUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchRecordUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}