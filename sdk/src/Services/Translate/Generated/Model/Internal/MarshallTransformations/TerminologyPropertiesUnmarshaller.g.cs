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
    /// Response Unmarshaller for TerminologyProperties Object
    /// </summary>
    public partial class TerminologyPropertiesUnmarshaller : ICborUnmarshaller<TerminologyProperties, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public TerminologyProperties Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new TerminologyProperties();
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

                    case "Directionality":
                        context.AddPathSegment("Directionality");
                        unmarshalledObject.Directionality = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EncryptionKey":
                        context.AddPathSegment("EncryptionKey");
                        unmarshalledObject.EncryptionKey = EncryptionKeyUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Format":
                        context.AddPathSegment("Format");
                        unmarshalledObject.Format = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastUpdatedAt":
                        context.AddPathSegment("LastUpdatedAt");
                        unmarshalledObject.LastUpdatedAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
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

                    case "SizeBytes":
                        context.AddPathSegment("SizeBytes");
                        unmarshalledObject.SizeBytes = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SkippedTermCount":
                        context.AddPathSegment("SkippedTermCount");
                        unmarshalledObject.SkippedTermCount = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceLanguageCode":
                        context.AddPathSegment("SourceLanguageCode");
                        unmarshalledObject.SourceLanguageCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TargetLanguageCodes":
                        context.AddPathSegment("TargetLanguageCodes");
                        unmarshalledObject.TargetLanguageCodes = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TermCount":
                        context.AddPathSegment("TermCount");
                        unmarshalledObject.TermCount = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
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

        private static TerminologyPropertiesUnmarshaller _instance = new TerminologyPropertiesUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TerminologyPropertiesUnmarshaller Instance => _instance;
    }
}
