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
    /// Response Unmarshaller for Metadata Object
    /// </summary>  
    public class MetadataUnmarshaller : ICborUnmarshaller<Metadata, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Metadata Unmarshall(CborUnmarshallerContext context)
        {
            Metadata unmarshalledObject = new Metadata();
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
                    case "logs":
                        {
                            context.AddPathSegment("Logs");
                            var unmarshaller = new CborListUnmarshaller<LogMetadata, LogMetadataUnmarshaller>(LogMetadataUnmarshaller.Instance);
                            unmarshalledObject.Logs = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "metrics":
                        {
                            context.AddPathSegment("Metrics");
                            var unmarshaller = new CborListUnmarshaller<MetricMetadata, MetricMetadataUnmarshaller>(MetricMetadataUnmarshaller.Instance);
                            unmarshalledObject.Metrics = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "semantics":
                        {
                            context.AddPathSegment("Semantics");
                            var unmarshaller = NodeSemanticsUnmarshaller.Instance;
                            unmarshalledObject.Semantics = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "traces":
                        {
                            context.AddPathSegment("Traces");
                            var unmarshaller = new CborListUnmarshaller<TraceMetadata, TraceMetadataUnmarshaller>(TraceMetadataUnmarshaller.Instance);
                            unmarshalledObject.Traces = unmarshaller.Unmarshall(context);
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


        private static MetadataUnmarshaller _instance = new MetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}