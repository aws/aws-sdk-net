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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LogGroup Object
    /// </summary>  
    public class LogGroupUnmarshaller : ICborUnmarshaller<LogGroup, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LogGroup Unmarshall(CborUnmarshallerContext context)
        {
            LogGroup unmarshalledObject = new LogGroup();
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
                    case "arn":
                        {
                            context.AddPathSegment("Arn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "creationTime":
                        {
                            context.AddPathSegment("CreationTime");
                            var unmarshaller = CborNullableDateTimeEpochLongMillisecondsUnmarshaller.Instance;
                            unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "dataProtectionStatus":
                        {
                            context.AddPathSegment("DataProtectionStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DataProtectionStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "inheritedProperties":
                        {
                            context.AddPathSegment("InheritedProperties");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.InheritedProperties = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "kmsKeyId":
                        {
                            context.AddPathSegment("KmsKeyId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "logGroupArn":
                        {
                            context.AddPathSegment("LogGroupArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LogGroupArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "logGroupClass":
                        {
                            context.AddPathSegment("LogGroupClass");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LogGroupClass = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "logGroupName":
                        {
                            context.AddPathSegment("LogGroupName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LogGroupName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "metricFilterCount":
                        {
                            context.AddPathSegment("MetricFilterCount");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.MetricFilterCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "retentionInDays":
                        {
                            context.AddPathSegment("RetentionInDays");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.RetentionInDays = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "storedBytes":
                        {
                            context.AddPathSegment("StoredBytes");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.StoredBytes = unmarshaller.Unmarshall(context);
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


        private static LogGroupUnmarshaller _instance = new LogGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LogGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}