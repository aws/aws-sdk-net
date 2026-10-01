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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchOmni.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TelemetryRule Object
    /// </summary>  
    public class TelemetryRuleUnmarshaller : ICborUnmarshaller<TelemetryRule, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TelemetryRule Unmarshall(CborUnmarshallerContext context)
        {
            TelemetryRule unmarshalledObject = new TelemetryRule();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "condition":
                        {
                            context.AddPathSegment("Condition");
                            var unmarshaller = AlertConditionUnmarshaller.Instance;
                            unmarshalledObject.Condition = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "evaluation":
                        {
                            context.AddPathSegment("Evaluation");
                            var unmarshaller = AlertEvaluationUnmarshaller.Instance;
                            unmarshalledObject.Evaluation = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "noData":
                        {
                            context.AddPathSegment("NoData");
                            var unmarshaller = NoDataUnmarshaller.Instance;
                            unmarshalledObject.NoData = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "query":
                        {
                            context.AddPathSegment("Query");
                            var unmarshaller = AlertRuleQueryUnmarshaller.Instance;
                            unmarshalledObject.Query = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }


        private static TelemetryRuleUnmarshaller _instance = new TelemetryRuleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TelemetryRuleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}