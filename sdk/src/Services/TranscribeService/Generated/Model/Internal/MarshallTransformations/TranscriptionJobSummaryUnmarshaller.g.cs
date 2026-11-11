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

using Amazon.TranscribeService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TranscriptionJobSummary Object
    /// </summary>
    public partial class TranscriptionJobSummaryUnmarshaller : ICborUnmarshaller<TranscriptionJobSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public TranscriptionJobSummary Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new TranscriptionJobSummary();
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
                    case "CompletionTime":
                        context.AddPathSegment("CompletionTime");
                        unmarshalledObject.CompletionTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ContentRedaction":
                        context.AddPathSegment("ContentRedaction");
                        unmarshalledObject.ContentRedaction = ContentRedactionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreationTime":
                        context.AddPathSegment("CreationTime");
                        unmarshalledObject.CreationTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FailureReason":
                        context.AddPathSegment("FailureReason");
                        unmarshalledObject.FailureReason = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IdentifiedLanguageScore":
                        context.AddPathSegment("IdentifiedLanguageScore");
                        unmarshalledObject.IdentifiedLanguageScore = CborNullableFloatUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IdentifyLanguage":
                        context.AddPathSegment("IdentifyLanguage");
                        unmarshalledObject.IdentifyLanguage = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IdentifyMultipleLanguages":
                        context.AddPathSegment("IdentifyMultipleLanguages");
                        unmarshalledObject.IdentifyMultipleLanguages = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LanguageCode":
                        context.AddPathSegment("LanguageCode");
                        unmarshalledObject.LanguageCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LanguageCodes":
                        context.AddPathSegment("LanguageCodes");
                        unmarshalledObject.LanguageCodes = new CborListUnmarshaller<LanguageCodeItem, LanguageCodeItemUnmarshaller>(LanguageCodeItemUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ModelSettings":
                        context.AddPathSegment("ModelSettings");
                        unmarshalledObject.ModelSettings = ModelSettingsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OutputLocationType":
                        context.AddPathSegment("OutputLocationType");
                        unmarshalledObject.OutputLocationType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StartTime":
                        context.AddPathSegment("StartTime");
                        unmarshalledObject.StartTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ToxicityDetection":
                        context.AddPathSegment("ToxicityDetection");
                        unmarshalledObject.ToxicityDetection = new CborListUnmarshaller<ToxicityDetectionSettings, ToxicityDetectionSettingsUnmarshaller>(ToxicityDetectionSettingsUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TranscriptionJobName":
                        context.AddPathSegment("TranscriptionJobName");
                        unmarshalledObject.TranscriptionJobName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TranscriptionJobStatus":
                        context.AddPathSegment("TranscriptionJobStatus");
                        unmarshalledObject.TranscriptionJobStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static TranscriptionJobSummaryUnmarshaller _instance = new TranscriptionJobSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TranscriptionJobSummaryUnmarshaller Instance => _instance;
    }
}
