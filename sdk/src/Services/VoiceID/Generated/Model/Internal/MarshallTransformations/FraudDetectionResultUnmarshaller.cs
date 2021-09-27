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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.VoiceID.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.VoiceID.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FraudDetectionResult Object
    /// </summary>  
    public class FraudDetectionResultUnmarshaller : IUnmarshaller<FraudDetectionResult, XmlUnmarshallerContext>, IUnmarshaller<FraudDetectionResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FraudDetectionResult IUnmarshaller<FraudDetectionResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FraudDetectionResult Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FraudDetectionResult unmarshalledObject = new FraudDetectionResult();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AudioAggregationEndedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.AudioAggregationEndedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AudioAggregationStartedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.AudioAggregationStartedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Configuration", targetDepth))
                {
                    var unmarshaller = FraudDetectionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Configuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Decision", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Decision = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FraudDetectionResultId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FraudDetectionResultId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Reasons", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Reasons = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RiskDetails", targetDepth))
                {
                    var unmarshaller = FraudRiskDetailsUnmarshaller.Instance;
                    unmarshalledObject.RiskDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FraudDetectionResultUnmarshaller _instance = new FraudDetectionResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FraudDetectionResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}