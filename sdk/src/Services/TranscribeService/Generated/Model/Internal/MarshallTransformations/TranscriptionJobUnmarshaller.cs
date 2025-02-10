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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TranscriptionJob Object
    /// </summary>  
    public class TranscriptionJobUnmarshaller : IJsonUnmarshaller<TranscriptionJob, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TranscriptionJob Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TranscriptionJob unmarshalledObject = new TranscriptionJob();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CompletionTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CompletionTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ContentRedaction", targetDepth))
                {
                    var unmarshaller = ContentRedactionUnmarshaller.Instance;
                    unmarshalledObject.ContentRedaction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IdentifiedLanguageScore", targetDepth))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.IdentifiedLanguageScore = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IdentifyLanguage", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IdentifyLanguage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IdentifyMultipleLanguages", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IdentifyMultipleLanguages = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JobExecutionSettings", targetDepth))
                {
                    var unmarshaller = JobExecutionSettingsUnmarshaller.Instance;
                    unmarshalledObject.JobExecutionSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LanguageCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LanguageCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LanguageCodes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<LanguageCodeItem, LanguageCodeItemUnmarshaller>(LanguageCodeItemUnmarshaller.Instance);
                    unmarshalledObject.LanguageCodes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LanguageIdSettings", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, LanguageIdSettings, StringUnmarshaller, LanguageIdSettingsUnmarshaller>(StringUnmarshaller.Instance, LanguageIdSettingsUnmarshaller.Instance);
                    unmarshalledObject.LanguageIdSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LanguageOptions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.LanguageOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Media", targetDepth))
                {
                    var unmarshaller = MediaUnmarshaller.Instance;
                    unmarshalledObject.Media = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MediaFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaFormat = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MediaSampleRateHertz", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MediaSampleRateHertz = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ModelSettings", targetDepth))
                {
                    var unmarshaller = ModelSettingsUnmarshaller.Instance;
                    unmarshalledObject.ModelSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Settings", targetDepth))
                {
                    var unmarshaller = SettingsUnmarshaller.Instance;
                    unmarshalledObject.Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Subtitles", targetDepth))
                {
                    var unmarshaller = SubtitlesOutputUnmarshaller.Instance;
                    unmarshalledObject.Subtitles = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ToxicityDetection", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ToxicityDetectionSettings, ToxicityDetectionSettingsUnmarshaller>(ToxicityDetectionSettingsUnmarshaller.Instance);
                    unmarshalledObject.ToxicityDetection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Transcript", targetDepth))
                {
                    var unmarshaller = TranscriptUnmarshaller.Instance;
                    unmarshalledObject.Transcript = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TranscriptionJobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TranscriptionJobName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TranscriptionJobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TranscriptionJobStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TranscriptionJobUnmarshaller _instance = new TranscriptionJobUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TranscriptionJobUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}