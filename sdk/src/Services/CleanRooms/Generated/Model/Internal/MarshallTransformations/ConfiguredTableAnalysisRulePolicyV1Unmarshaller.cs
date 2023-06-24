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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfiguredTableAnalysisRulePolicyV1 Object
    /// </summary>  
    public class ConfiguredTableAnalysisRulePolicyV1Unmarshaller : IUnmarshaller<ConfiguredTableAnalysisRulePolicyV1, XmlUnmarshallerContext>, IUnmarshaller<ConfiguredTableAnalysisRulePolicyV1, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConfiguredTableAnalysisRulePolicyV1 IUnmarshaller<ConfiguredTableAnalysisRulePolicyV1, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConfiguredTableAnalysisRulePolicyV1 Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConfiguredTableAnalysisRulePolicyV1 unmarshalledObject = new ConfiguredTableAnalysisRulePolicyV1();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("aggregation", targetDepth))
                {
                    var unmarshaller = AnalysisRuleAggregationUnmarshaller.Instance;
                    unmarshalledObject.Aggregation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("list", targetDepth))
                {
                    var unmarshaller = AnalysisRuleListUnmarshaller.Instance;
                    unmarshalledObject.List = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConfiguredTableAnalysisRulePolicyV1Unmarshaller _instance = new ConfiguredTableAnalysisRulePolicyV1Unmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfiguredTableAnalysisRulePolicyV1Unmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}