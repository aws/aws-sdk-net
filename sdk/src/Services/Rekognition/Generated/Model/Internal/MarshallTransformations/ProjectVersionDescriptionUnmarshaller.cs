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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProjectVersionDescription Object
    /// </summary>  
    public class ProjectVersionDescriptionUnmarshaller : IUnmarshaller<ProjectVersionDescription, XmlUnmarshallerContext>, IUnmarshaller<ProjectVersionDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProjectVersionDescription IUnmarshaller<ProjectVersionDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ProjectVersionDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ProjectVersionDescription unmarshalledObject = new ProjectVersionDescription();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BillableTrainingTimeInSeconds", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.BillableTrainingTimeInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationResult", targetDepth))
                {
                    var unmarshaller = EvaluationResultUnmarshaller.Instance;
                    unmarshalledObject.EvaluationResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManifestSummary", targetDepth))
                {
                    var unmarshaller = GroundTruthManifestUnmarshaller.Instance;
                    unmarshalledObject.ManifestSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinInferenceUnits", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinInferenceUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputConfig", targetDepth))
                {
                    var unmarshaller = OutputConfigUnmarshaller.Instance;
                    unmarshalledObject.OutputConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProjectVersionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectVersionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TestingDataResult", targetDepth))
                {
                    var unmarshaller = TestingDataResultUnmarshaller.Instance;
                    unmarshalledObject.TestingDataResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingDataResult", targetDepth))
                {
                    var unmarshaller = TrainingDataResultUnmarshaller.Instance;
                    unmarshalledObject.TrainingDataResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingEndTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.TrainingEndTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProjectVersionDescriptionUnmarshaller _instance = new ProjectVersionDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProjectVersionDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}