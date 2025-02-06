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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AmazonTranscribeProcessorConfiguration Marshaller
    /// </summary>
    public class AmazonTranscribeProcessorConfigurationMarshaller : IRequestMarshaller<AmazonTranscribeProcessorConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AmazonTranscribeProcessorConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContentIdentificationType())
            {
                context.Writer.WritePropertyName("ContentIdentificationType");
                context.Writer.WriteStringValue(requestObject.ContentIdentificationType);
            }

            if(requestObject.IsSetContentRedactionType())
            {
                context.Writer.WritePropertyName("ContentRedactionType");
                context.Writer.WriteStringValue(requestObject.ContentRedactionType);
            }

            if(requestObject.IsSetEnablePartialResultsStabilization())
            {
                context.Writer.WritePropertyName("EnablePartialResultsStabilization");
                context.Writer.WriteBooleanValue(requestObject.EnablePartialResultsStabilization.Value);
            }

            if(requestObject.IsSetFilterPartialResults())
            {
                context.Writer.WritePropertyName("FilterPartialResults");
                context.Writer.WriteBooleanValue(requestObject.FilterPartialResults.Value);
            }

            if(requestObject.IsSetIdentifyLanguage())
            {
                context.Writer.WritePropertyName("IdentifyLanguage");
                context.Writer.WriteBooleanValue(requestObject.IdentifyLanguage.Value);
            }

            if(requestObject.IsSetIdentifyMultipleLanguages())
            {
                context.Writer.WritePropertyName("IdentifyMultipleLanguages");
                context.Writer.WriteBooleanValue(requestObject.IdentifyMultipleLanguages.Value);
            }

            if(requestObject.IsSetLanguageCode())
            {
                context.Writer.WritePropertyName("LanguageCode");
                context.Writer.WriteStringValue(requestObject.LanguageCode);
            }

            if(requestObject.IsSetLanguageModelName())
            {
                context.Writer.WritePropertyName("LanguageModelName");
                context.Writer.WriteStringValue(requestObject.LanguageModelName);
            }

            if(requestObject.IsSetLanguageOptions())
            {
                context.Writer.WritePropertyName("LanguageOptions");
                context.Writer.WriteStringValue(requestObject.LanguageOptions);
            }

            if(requestObject.IsSetPartialResultsStability())
            {
                context.Writer.WritePropertyName("PartialResultsStability");
                context.Writer.WriteStringValue(requestObject.PartialResultsStability);
            }

            if(requestObject.IsSetPiiEntityTypes())
            {
                context.Writer.WritePropertyName("PiiEntityTypes");
                context.Writer.WriteStringValue(requestObject.PiiEntityTypes);
            }

            if(requestObject.IsSetPreferredLanguage())
            {
                context.Writer.WritePropertyName("PreferredLanguage");
                context.Writer.WriteStringValue(requestObject.PreferredLanguage);
            }

            if(requestObject.IsSetShowSpeakerLabel())
            {
                context.Writer.WritePropertyName("ShowSpeakerLabel");
                context.Writer.WriteBooleanValue(requestObject.ShowSpeakerLabel.Value);
            }

            if(requestObject.IsSetVocabularyFilterMethod())
            {
                context.Writer.WritePropertyName("VocabularyFilterMethod");
                context.Writer.WriteStringValue(requestObject.VocabularyFilterMethod);
            }

            if(requestObject.IsSetVocabularyFilterName())
            {
                context.Writer.WritePropertyName("VocabularyFilterName");
                context.Writer.WriteStringValue(requestObject.VocabularyFilterName);
            }

            if(requestObject.IsSetVocabularyFilterNames())
            {
                context.Writer.WritePropertyName("VocabularyFilterNames");
                context.Writer.WriteStringValue(requestObject.VocabularyFilterNames);
            }

            if(requestObject.IsSetVocabularyName())
            {
                context.Writer.WritePropertyName("VocabularyName");
                context.Writer.WriteStringValue(requestObject.VocabularyName);
            }

            if(requestObject.IsSetVocabularyNames())
            {
                context.Writer.WritePropertyName("VocabularyNames");
                context.Writer.WriteStringValue(requestObject.VocabularyNames);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AmazonTranscribeProcessorConfigurationMarshaller Instance = new AmazonTranscribeProcessorConfigurationMarshaller();

    }
}