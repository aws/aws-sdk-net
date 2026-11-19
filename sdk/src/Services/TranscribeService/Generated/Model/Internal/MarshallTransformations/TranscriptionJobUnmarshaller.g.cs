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
    /// Response Unmarshaller for TranscriptionJob Object
    /// </summary>
    public partial class TranscriptionJobUnmarshaller : ICborUnmarshaller<TranscriptionJob, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public TranscriptionJob Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new TranscriptionJob();
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

                    case "JobExecutionSettings":
                        context.AddPathSegment("JobExecutionSettings");
                        unmarshalledObject.JobExecutionSettings = JobExecutionSettingsUnmarshaller.Instance.Unmarshall(context);
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

                    case "LanguageIdSettings":
                        context.AddPathSegment("LanguageIdSettings");
                        unmarshalledObject.LanguageIdSettings = new CborDictionaryUnmarshaller<string, LanguageIdSettings, CborStringUnmarshaller, LanguageIdSettingsUnmarshaller>(CborStringUnmarshaller.Instance, LanguageIdSettingsUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LanguageOptions":
                        context.AddPathSegment("LanguageOptions");
                        unmarshalledObject.LanguageOptions = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Media":
                        context.AddPathSegment("Media");
                        unmarshalledObject.Media = MediaUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MediaFormat":
                        context.AddPathSegment("MediaFormat");
                        unmarshalledObject.MediaFormat = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MediaSampleRateHertz":
                        context.AddPathSegment("MediaSampleRateHertz");
                        unmarshalledObject.MediaSampleRateHertz = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ModelSettings":
                        context.AddPathSegment("ModelSettings");
                        unmarshalledObject.ModelSettings = ModelSettingsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Settings":
                        context.AddPathSegment("Settings");
                        unmarshalledObject.Settings = SettingsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StartTime":
                        context.AddPathSegment("StartTime");
                        unmarshalledObject.StartTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Subtitles":
                        context.AddPathSegment("Subtitles");
                        unmarshalledObject.Subtitles = SubtitlesOutputUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ToxicityDetection":
                        context.AddPathSegment("ToxicityDetection");
                        unmarshalledObject.ToxicityDetection = new CborListUnmarshaller<ToxicityDetectionSettings, ToxicityDetectionSettingsUnmarshaller>(ToxicityDetectionSettingsUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Transcript":
                        context.AddPathSegment("Transcript");
                        unmarshalledObject.Transcript = TranscriptUnmarshaller.Instance.Unmarshall(context);
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

        private static TranscriptionJobUnmarshaller _instance = new TranscriptionJobUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TranscriptionJobUnmarshaller Instance => _instance;
    }
}
