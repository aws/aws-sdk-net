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
    /// Response Unmarshaller for Edge Object
    /// </summary>  
    public class EdgeUnmarshaller : ICborUnmarshaller<Edge, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Edge Unmarshall(CborUnmarshallerContext context)
        {
            Edge unmarshalledObject = new Edge();
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
                    case "edgeId":
                        {
                            context.AddPathSegment("EdgeId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EdgeId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "edgeProperties":
                        {
                            context.AddPathSegment("EdgeProperties");
                            var unmarshaller = EdgePropertiesUnmarshaller.Instance;
                            unmarshalledObject.EdgeProperties = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "edgeType":
                        {
                            context.AddPathSegment("EdgeType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EdgeType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "firstObservedAt":
                        {
                            context.AddPathSegment("FirstObservedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.FirstObservedAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "from":
                        {
                            context.AddPathSegment("From");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.From = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastObservedAt":
                        {
                            context.AddPathSegment("LastObservedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastObservedAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "metadata":
                        {
                            context.AddPathSegment("Metadata");
                            var unmarshaller = MetadataUnmarshaller.Instance;
                            unmarshalledObject.Metadata = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "operations":
                        {
                            context.AddPathSegment("Operations");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.Operations = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "signalTypes":
                        {
                            context.AddPathSegment("SignalTypes");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.SignalTypes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "sources":
                        {
                            context.AddPathSegment("Sources");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.Sources = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "telemetryAttributes":
                        {
                            context.AddPathSegment("TelemetryAttributes");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance);
                            unmarshalledObject.TelemetryAttributes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "to":
                        {
                            context.AddPathSegment("To");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.To = unmarshaller.Unmarshall(context);
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


        private static EdgeUnmarshaller _instance = new EdgeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EdgeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}