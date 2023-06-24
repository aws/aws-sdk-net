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

namespace Amazon.Personalize.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SolutionConfig Object
    /// </summary>  
    public class SolutionConfigUnmarshaller : IUnmarshaller<SolutionConfig, XmlUnmarshallerContext>, IUnmarshaller<SolutionConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SolutionConfig IUnmarshaller<SolutionConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SolutionConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SolutionConfig unmarshalledObject = new SolutionConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("algorithmHyperParameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.AlgorithmHyperParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("autoMLConfig", targetDepth))
                {
                    var unmarshaller = AutoMLConfigUnmarshaller.Instance;
                    unmarshalledObject.AutoMLConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventValueThreshold", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventValueThreshold = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("featureTransformationParameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.FeatureTransformationParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hpoConfig", targetDepth))
                {
                    var unmarshaller = HPOConfigUnmarshaller.Instance;
                    unmarshalledObject.HpoConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("optimizationObjective", targetDepth))
                {
                    var unmarshaller = OptimizationObjectiveUnmarshaller.Instance;
                    unmarshalledObject.OptimizationObjective = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("trainingDataConfig", targetDepth))
                {
                    var unmarshaller = TrainingDataConfigUnmarshaller.Instance;
                    unmarshalledObject.TrainingDataConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SolutionConfigUnmarshaller _instance = new SolutionConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SolutionConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}