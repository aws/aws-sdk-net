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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Translate.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.Translate.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ParallelDataProperties Object
    /// </summary>  
    public class ParallelDataPropertiesUnmarshaller : ICborUnmarshaller<ParallelDataProperties, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ParallelDataProperties Unmarshall(CborUnmarshallerContext context)
        {
            ParallelDataProperties unmarshalledObject = new ParallelDataProperties();
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
                    case "Arn":
                        {
                            context.AddPathSegment("Arn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreatedAt":
                        {
                            context.AddPathSegment("CreatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Description":
                        {
                            context.AddPathSegment("Description");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EncryptionKey":
                        {
                            context.AddPathSegment("EncryptionKey");
                            var unmarshaller = EncryptionKeyUnmarshaller.Instance;
                            unmarshalledObject.EncryptionKey = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FailedRecordCount":
                        {
                            context.AddPathSegment("FailedRecordCount");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.FailedRecordCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImportedDataSize":
                        {
                            context.AddPathSegment("ImportedDataSize");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.ImportedDataSize = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImportedRecordCount":
                        {
                            context.AddPathSegment("ImportedRecordCount");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.ImportedRecordCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LastUpdatedAt":
                        {
                            context.AddPathSegment("LastUpdatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastUpdatedAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LatestUpdateAttemptAt":
                        {
                            context.AddPathSegment("LatestUpdateAttemptAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LatestUpdateAttemptAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LatestUpdateAttemptStatus":
                        {
                            context.AddPathSegment("LatestUpdateAttemptStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LatestUpdateAttemptStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Message":
                        {
                            context.AddPathSegment("Message");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Message = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ParallelDataConfig":
                        {
                            context.AddPathSegment("ParallelDataConfig");
                            var unmarshaller = ParallelDataConfigUnmarshaller.Instance;
                            unmarshalledObject.ParallelDataConfig = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SkippedRecordCount":
                        {
                            context.AddPathSegment("SkippedRecordCount");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.SkippedRecordCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SourceLanguageCode":
                        {
                            context.AddPathSegment("SourceLanguageCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SourceLanguageCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TargetLanguageCodes":
                        {
                            context.AddPathSegment("TargetLanguageCodes");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.TargetLanguageCodes = unmarshaller.Unmarshall(context);
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


        private static ParallelDataPropertiesUnmarshaller _instance = new ParallelDataPropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ParallelDataPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}