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
    /// Response Unmarshaller for NodeProperties Object
    /// </summary>  
    public class NodePropertiesUnmarshaller : ICborUnmarshaller<NodeProperties, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public NodeProperties Unmarshall(CborUnmarshallerContext context)
        {
            NodeProperties unmarshalledObject = new NodeProperties();
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
                    case "category":
                        {
                            context.AddPathSegment("Category");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Category = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "cloudProvider":
                        {
                            context.AddPathSegment("CloudProvider");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CloudProvider = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "namespace":
                        {
                            context.AddPathSegment("Namespace");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Namespace = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "region":
                        {
                            context.AddPathSegment("Region");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "sourceAccountId":
                        {
                            context.AddPathSegment("SourceAccountId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SourceAccountId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "stage":
                        {
                            context.AddPathSegment("Stage");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Stage = unmarshaller.Unmarshall(context);
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


        private static NodePropertiesUnmarshaller _instance = new NodePropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NodePropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}