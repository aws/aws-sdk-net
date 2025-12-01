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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Personalize.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Personalize.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SolutionVersion Object
    /// </summary>  
    public class SolutionVersionUnmarshaller : IUnmarshaller<SolutionVersion, XmlUnmarshallerContext>, IUnmarshaller<SolutionVersion, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SolutionVersion IUnmarshaller<SolutionVersion, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SolutionVersion Unmarshall(JsonUnmarshallerContext context)
        {
            SolutionVersion unmarshalledObject = new SolutionVersion();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("creationDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("datasetGroupArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatasetGroupArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("performAutoML", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PerformAutoML = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("performHPO", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PerformHPO = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("performIncrementalUpdate", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PerformIncrementalUpdate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recipeArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecipeArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("solutionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SolutionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("solutionConfig", targetDepth))
                {
                    var unmarshaller = SolutionConfigUnmarshaller.Instance;
                    unmarshalledObject.SolutionConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("solutionVersionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SolutionVersionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("trainingHours", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.TrainingHours = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("trainingMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("trainingType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tunedHPOParams", targetDepth))
                {
                    var unmarshaller = TunedHPOParamsUnmarshaller.Instance;
                    unmarshalledObject.TunedHPOParams = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SolutionVersionUnmarshaller _instance = new SolutionVersionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SolutionVersionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}