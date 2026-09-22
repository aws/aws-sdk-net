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
    /// Response Unmarshaller for Node Object
    /// </summary>  
    public class NodeUnmarshaller : ICborUnmarshaller<Node, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Node Unmarshall(CborUnmarshallerContext context)
        {
            Node unmarshalledObject = new Node();
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
                    case "alternateNames":
                        {
                            context.AddPathSegment("AlternateNames");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.AlternateNames = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "edges":
                        {
                            context.AddPathSegment("Edges");
                            var unmarshaller = new CborListUnmarshaller<Edge, EdgeUnmarshaller>(EdgeUnmarshaller.Instance);
                            unmarshalledObject.Edges = unmarshaller.Unmarshall(context);
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
                    case "name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "nodeId":
                        {
                            context.AddPathSegment("NodeId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.NodeId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "nodeProperties":
                        {
                            context.AddPathSegment("NodeProperties");
                            var unmarshaller = NodePropertiesUnmarshaller.Instance;
                            unmarshalledObject.NodeProperties = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "nodeType":
                        {
                            context.AddPathSegment("NodeType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.NodeType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "operationDetails":
                        {
                            context.AddPathSegment("OperationDetails");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, List<Dictionary<string, string>>, CborStringUnmarshaller, CborListUnmarshaller<Dictionary<string, string>, CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>>>(CborStringUnmarshaller.Instance, new CborListUnmarshaller<Dictionary<string, string>, CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>>(new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance)));
                            unmarshalledObject.OperationDetails = unmarshaller.Unmarshall(context);
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
                    case "tags":
                        {
                            context.AddPathSegment("Tags");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance);
                            unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
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
        public static NodeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}