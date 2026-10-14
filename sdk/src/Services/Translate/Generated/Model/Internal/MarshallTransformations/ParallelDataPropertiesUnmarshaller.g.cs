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

using Amazon.Translate.Model;
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
    public partial class ParallelDataPropertiesUnmarshaller : ICborUnmarshaller<ParallelDataProperties, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ParallelDataProperties Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ParallelDataProperties();
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
                    case "Arn":
                        context.AddPathSegment("Arn");
                        unmarshalledObject.Arn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreatedAt":
                        context.AddPathSegment("CreatedAt");
                        unmarshalledObject.CreatedAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EncryptionKey":
                        context.AddPathSegment("EncryptionKey");
                        unmarshalledObject.EncryptionKey = EncryptionKeyUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FailedRecordCount":
                        context.AddPathSegment("FailedRecordCount");
                        unmarshalledObject.FailedRecordCount = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ImportedDataSize":
                        context.AddPathSegment("ImportedDataSize");
                        unmarshalledObject.ImportedDataSize = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ImportedRecordCount":
                        context.AddPathSegment("ImportedRecordCount");
                        unmarshalledObject.ImportedRecordCount = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastUpdatedAt":
                        context.AddPathSegment("LastUpdatedAt");
                        unmarshalledObject.LastUpdatedAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LatestUpdateAttemptAt":
                        context.AddPathSegment("LatestUpdateAttemptAt");
                        unmarshalledObject.LatestUpdateAttemptAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LatestUpdateAttemptStatus":
                        context.AddPathSegment("LatestUpdateAttemptStatus");
                        unmarshalledObject.LatestUpdateAttemptStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Message":
                        context.AddPathSegment("Message");
                        unmarshalledObject.Message = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ParallelDataConfig":
                        context.AddPathSegment("ParallelDataConfig");
                        unmarshalledObject.ParallelDataConfig = ParallelDataConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SkippedRecordCount":
                        context.AddPathSegment("SkippedRecordCount");
                        unmarshalledObject.SkippedRecordCount = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceLanguageCode":
                        context.AddPathSegment("SourceLanguageCode");
                        unmarshalledObject.SourceLanguageCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TargetLanguageCodes":
                        context.AddPathSegment("TargetLanguageCodes");
                        unmarshalledObject.TargetLanguageCodes = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
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

        private static ParallelDataPropertiesUnmarshaller _instance = new ParallelDataPropertiesUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ParallelDataPropertiesUnmarshaller Instance => _instance;
    }
}
