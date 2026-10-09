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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.CloudWatchOmni.Model;
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
    public partial class EdgeUnmarshaller : ICborUnmarshaller<Edge, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Edge Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Edge();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "edgeId":
                        context.AddPathSegment("EdgeId");
                        unmarshalledObject.EdgeId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "edgeProperties":
                        context.AddPathSegment("EdgeProperties");
                        unmarshalledObject.EdgeProperties = EdgePropertiesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "edgeType":
                        context.AddPathSegment("EdgeType");
                        unmarshalledObject.EdgeType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "firstObservedAt":
                        context.AddPathSegment("FirstObservedAt");
                        unmarshalledObject.FirstObservedAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "from":
                        context.AddPathSegment("From");
                        unmarshalledObject.From = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lastObservedAt":
                        context.AddPathSegment("LastObservedAt");
                        unmarshalledObject.LastObservedAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "metadata":
                        context.AddPathSegment("Metadata");
                        unmarshalledObject.Metadata = MetadataUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "operations":
                        context.AddPathSegment("Operations");
                        unmarshalledObject.Operations = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "signalTypes":
                        context.AddPathSegment("SignalTypes");
                        unmarshalledObject.SignalTypes = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "sources":
                        context.AddPathSegment("Sources");
                        unmarshalledObject.Sources = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "telemetryAttributes":
                        context.AddPathSegment("TelemetryAttributes");
                        unmarshalledObject.TelemetryAttributes = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "to":
                        context.AddPathSegment("To");
                        unmarshalledObject.To = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

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
        public static EdgeUnmarshaller Instance => _instance;
    }
}
