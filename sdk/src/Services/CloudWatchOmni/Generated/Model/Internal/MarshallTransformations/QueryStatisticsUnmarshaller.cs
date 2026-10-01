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
    /// Response Unmarshaller for QueryStatistics Object
    /// </summary>  
    public class QueryStatisticsUnmarshaller : ICborUnmarshaller<QueryStatistics, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public QueryStatistics Unmarshall(CborUnmarshallerContext context)
        {
            QueryStatistics unmarshalledObject = new QueryStatistics();
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
                    case "bytesScanned":
                        {
                            context.AddPathSegment("BytesScanned");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            unmarshalledObject.BytesScanned = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "partialResults":
                        {
                            context.AddPathSegment("PartialResults");
                            var unmarshaller = PartialResultsUnmarshaller.Instance;
                            unmarshalledObject.PartialResults = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "percentComplete":
                        {
                            context.AddPathSegment("PercentComplete");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.PercentComplete = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "recordsMatched":
                        {
                            context.AddPathSegment("RecordsMatched");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.RecordsMatched = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "recordsScanned":
                        {
                            context.AddPathSegment("RecordsScanned");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.RecordsScanned = unmarshaller.Unmarshall(context);
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


        private static QueryStatisticsUnmarshaller _instance = new QueryStatisticsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QueryStatisticsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}