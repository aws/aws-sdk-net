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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfigRecommendation Object
    /// </summary>  
    public class ConfigRecommendationUnmarshaller : IUnmarshaller<ConfigRecommendation, XmlUnmarshallerContext>, IUnmarshaller<ConfigRecommendation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConfigRecommendation IUnmarshaller<ConfigRecommendation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConfigRecommendation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConfigRecommendation unmarshalledObject = new ConfigRecommendation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("appComponentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AppComponentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("compliance", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, DisruptionCompliance, StringUnmarshaller, DisruptionComplianceUnmarshaller>(StringUnmarshaller.Instance, DisruptionComplianceUnmarshaller.Instance);
                    unmarshalledObject.Compliance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cost", targetDepth))
                {
                    var unmarshaller = CostUnmarshaller.Instance;
                    unmarshalledObject.Cost = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("haArchitecture", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HaArchitecture = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("optimizationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OptimizationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recommendationCompliance", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, RecommendationDisruptionCompliance, StringUnmarshaller, RecommendationDisruptionComplianceUnmarshaller>(StringUnmarshaller.Instance, RecommendationDisruptionComplianceUnmarshaller.Instance);
                    unmarshalledObject.RecommendationCompliance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("referenceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReferenceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("suggestedChanges", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SuggestedChanges = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConfigRecommendationUnmarshaller _instance = new ConfigRecommendationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfigRecommendationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}