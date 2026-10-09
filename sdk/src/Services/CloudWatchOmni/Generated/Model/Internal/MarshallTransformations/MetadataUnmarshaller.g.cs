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
    /// Response Unmarshaller for Metadata Object
    /// </summary>
    public partial class MetadataUnmarshaller : ICborUnmarshaller<Metadata, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Metadata Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Metadata();
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
                    case "logs":
                        context.AddPathSegment("Logs");
                        unmarshalledObject.Logs = new CborListUnmarshaller<LogMetadata, LogMetadataUnmarshaller>(LogMetadataUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "metrics":
                        context.AddPathSegment("Metrics");
                        unmarshalledObject.Metrics = new CborListUnmarshaller<MetricMetadata, MetricMetadataUnmarshaller>(MetricMetadataUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "semantics":
                        context.AddPathSegment("Semantics");
                        unmarshalledObject.Semantics = NodeSemanticsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "traces":
                        context.AddPathSegment("Traces");
                        unmarshalledObject.Traces = new CborListUnmarshaller<TraceMetadata, TraceMetadataUnmarshaller>(TraceMetadataUnmarshaller.Instance).Unmarshall(context);
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

        private static MetadataUnmarshaller _instance = new MetadataUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static MetadataUnmarshaller Instance => _instance;
    }
}
