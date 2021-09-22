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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AggregatedUtterancesSummary Object
    /// </summary>  
    public class AggregatedUtterancesSummaryUnmarshaller : IUnmarshaller<AggregatedUtterancesSummary, XmlUnmarshallerContext>, IUnmarshaller<AggregatedUtterancesSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AggregatedUtterancesSummary IUnmarshaller<AggregatedUtterancesSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AggregatedUtterancesSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AggregatedUtterancesSummary unmarshalledObject = new AggregatedUtterancesSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("containsDataFromDeletedResources", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ContainsDataFromDeletedResources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hitCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.HitCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("missedCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MissedCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("utterance", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Utterance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("utteranceFirstRecordedInAggregationDuration", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UtteranceFirstRecordedInAggregationDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("utteranceLastRecordedInAggregationDuration", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UtteranceLastRecordedInAggregationDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AggregatedUtterancesSummaryUnmarshaller _instance = new AggregatedUtterancesSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AggregatedUtterancesSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}