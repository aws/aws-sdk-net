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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PI.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.PI.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Insight Object
    /// </summary>  
    public class InsightUnmarshaller : ICborUnmarshaller<Insight, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Insight Unmarshall(CborUnmarshallerContext context)
        {
            Insight unmarshalledObject = new Insight();
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
                    case "BaselineData":
                        {
                            context.AddPathSegment("BaselineData");
                            var unmarshaller = new CborListUnmarshaller<Data, DataUnmarshaller>(DataUnmarshaller.Instance);
                            unmarshalledObject.BaselineData = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Context":
                        {
                            context.AddPathSegment("Context");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Context = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Description":
                        {
                            context.AddPathSegment("Description");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EndTime":
                        {
                            context.AddPathSegment("EndTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InsightData":
                        {
                            context.AddPathSegment("InsightData");
                            var unmarshaller = new CborListUnmarshaller<Data, DataUnmarshaller>(DataUnmarshaller.Instance);
                            unmarshalledObject.InsightData = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InsightId":
                        {
                            context.AddPathSegment("InsightId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InsightId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InsightType":
                        {
                            context.AddPathSegment("InsightType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InsightType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Recommendations":
                        {
                            context.AddPathSegment("Recommendations");
                            var unmarshaller = new CborListUnmarshaller<Recommendation, RecommendationUnmarshaller>(RecommendationUnmarshaller.Instance);
                            unmarshalledObject.Recommendations = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Severity":
                        {
                            context.AddPathSegment("Severity");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Severity = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StartTime":
                        {
                            context.AddPathSegment("StartTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SupportingInsights":
                        {
                            context.AddPathSegment("SupportingInsights");
                            var unmarshaller = new CborListUnmarshaller<Insight, InsightUnmarshaller>(InsightUnmarshaller.Instance);
                            unmarshalledObject.SupportingInsights = unmarshaller.Unmarshall(context);
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


        private static InsightUnmarshaller _instance = new InsightUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InsightUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}