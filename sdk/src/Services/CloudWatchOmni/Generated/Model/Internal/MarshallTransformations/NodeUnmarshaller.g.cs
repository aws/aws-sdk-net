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
    /// Response Unmarshaller for Node Object
    /// </summary>
    public partial class NodeUnmarshaller : ICborUnmarshaller<Node, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Node Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Node();
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
                    case "alternateNames":
                        context.AddPathSegment("AlternateNames");
                        unmarshalledObject.AlternateNames = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "edges":
                        context.AddPathSegment("Edges");
                        unmarshalledObject.Edges = new CborListUnmarshaller<Edge, EdgeUnmarshaller>(EdgeUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "firstObservedAt":
                        context.AddPathSegment("FirstObservedAt");
                        unmarshalledObject.FirstObservedAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
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

                    case "name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "nodeId":
                        context.AddPathSegment("NodeId");
                        unmarshalledObject.NodeId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "nodeProperties":
                        context.AddPathSegment("NodeProperties");
                        unmarshalledObject.NodeProperties = NodePropertiesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "nodeType":
                        context.AddPathSegment("NodeType");
                        unmarshalledObject.NodeType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "operationDetails":
                        context.AddPathSegment("OperationDetails");
                        unmarshalledObject.OperationDetails = new CborDictionaryUnmarshaller<string, List<Dictionary<string, string>>, CborStringUnmarshaller, CborListUnmarshaller<Dictionary<string, string>, CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>>>(CborStringUnmarshaller.Instance, new CborListUnmarshaller<Dictionary<string, string>, CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>>(new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance))).Unmarshall(context);
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

                    case "tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "telemetryAttributes":
                        context.AddPathSegment("TelemetryAttributes");
                        unmarshalledObject.TelemetryAttributes = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance).Unmarshall(context);
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

        private static NodeUnmarshaller _instance = new NodeUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static NodeUnmarshaller Instance => _instance;
    }
}
