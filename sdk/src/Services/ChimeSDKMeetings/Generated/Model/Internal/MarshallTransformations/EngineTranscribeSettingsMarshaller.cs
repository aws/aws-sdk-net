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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMeetings.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMeetings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EngineTranscribeSettings Marshaller
    /// </summary>
    public class EngineTranscribeSettingsMarshaller : IRequestMarshaller<EngineTranscribeSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EngineTranscribeSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetContentIdentificationType())
            {
                context.Writer.WritePropertyName("ContentIdentificationType");
                context.Writer.Write(requestObject.ContentIdentificationType);
            }

            if(requestObject.IsSetContentRedactionType())
            {
                context.Writer.WritePropertyName("ContentRedactionType");
                context.Writer.Write(requestObject.ContentRedactionType);
            }

            if(requestObject.IsSetEnablePartialResultsStabilization())
            {
                context.Writer.WritePropertyName("EnablePartialResultsStabilization");
                context.Writer.Write(requestObject.EnablePartialResultsStabilization);
            }

            if(requestObject.IsSetIdentifyLanguage())
            {
                context.Writer.WritePropertyName("IdentifyLanguage");
                context.Writer.Write(requestObject.IdentifyLanguage);
            }

            if(requestObject.IsSetLanguageCode())
            {
                context.Writer.WritePropertyName("LanguageCode");
                context.Writer.Write(requestObject.LanguageCode);
            }

            if(requestObject.IsSetLanguageModelName())
            {
                context.Writer.WritePropertyName("LanguageModelName");
                context.Writer.Write(requestObject.LanguageModelName);
            }

            if(requestObject.IsSetLanguageOptions())
            {
                context.Writer.WritePropertyName("LanguageOptions");
                context.Writer.Write(requestObject.LanguageOptions);
            }

            if(requestObject.IsSetPartialResultsStability())
            {
                context.Writer.WritePropertyName("PartialResultsStability");
                context.Writer.Write(requestObject.PartialResultsStability);
            }

            if(requestObject.IsSetPiiEntityTypes())
            {
                context.Writer.WritePropertyName("PiiEntityTypes");
                context.Writer.Write(requestObject.PiiEntityTypes);
            }

            if(requestObject.IsSetPreferredLanguage())
            {
                context.Writer.WritePropertyName("PreferredLanguage");
                context.Writer.Write(requestObject.PreferredLanguage);
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("Region");
                context.Writer.Write(requestObject.Region);
            }

            if(requestObject.IsSetVocabularyFilterMethod())
            {
                context.Writer.WritePropertyName("VocabularyFilterMethod");
                context.Writer.Write(requestObject.VocabularyFilterMethod);
            }

            if(requestObject.IsSetVocabularyFilterName())
            {
                context.Writer.WritePropertyName("VocabularyFilterName");
                context.Writer.Write(requestObject.VocabularyFilterName);
            }

            if(requestObject.IsSetVocabularyFilterNames())
            {
                context.Writer.WritePropertyName("VocabularyFilterNames");
                context.Writer.Write(requestObject.VocabularyFilterNames);
            }

            if(requestObject.IsSetVocabularyName())
            {
                context.Writer.WritePropertyName("VocabularyName");
                context.Writer.Write(requestObject.VocabularyName);
            }

            if(requestObject.IsSetVocabularyNames())
            {
                context.Writer.WritePropertyName("VocabularyNames");
                context.Writer.Write(requestObject.VocabularyNames);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EngineTranscribeSettingsMarshaller Instance = new EngineTranscribeSettingsMarshaller();

    }
}