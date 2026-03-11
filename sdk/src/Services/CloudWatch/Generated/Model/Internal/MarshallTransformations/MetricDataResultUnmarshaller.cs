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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MetricDataResult Object
    /// </summary>  
    public class MetricDataResultUnmarshaller : ICborUnmarshaller<MetricDataResult, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MetricDataResult Unmarshall(CborUnmarshallerContext context)
        {
            MetricDataResult unmarshalledObject = new MetricDataResult();
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
                    case "Id":
                        {
                            context.AddPathSegment("Id");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Label":
                        {
                            context.AddPathSegment("Label");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Label = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Messages":
                        {
                            context.AddPathSegment("Messages");
                            var unmarshaller = new CborListUnmarshaller<MessageData, MessageDataUnmarshaller>(MessageDataUnmarshaller.Instance);
                            unmarshalledObject.Messages = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatusCode":
                        {
                            context.AddPathSegment("StatusCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StatusCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Timestamps":
                        {
                            context.AddPathSegment("Timestamps");
                            var unmarshaller = new CborListUnmarshaller<DateTime, CborDateTimeUnmarshaller>(CborDateTimeUnmarshaller.Instance);
                            unmarshalledObject.Timestamps = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Values":
                        {
                            context.AddPathSegment("Values");
                            var unmarshaller = new CborListUnmarshaller<double, CborDoubleUnmarshaller>(CborDoubleUnmarshaller.Instance);
                            unmarshalledObject.Values = unmarshaller.Unmarshall(context);
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


        private static MetricDataResultUnmarshaller _instance = new MetricDataResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MetricDataResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}