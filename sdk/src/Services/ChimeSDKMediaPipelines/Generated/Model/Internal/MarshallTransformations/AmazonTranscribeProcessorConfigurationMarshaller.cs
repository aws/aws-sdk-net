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
using ThirdParty.Json.LitJson;

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

            if(requestObject.IsSetFilterPartialResults())
            {
                context.Writer.WritePropertyName("FilterPartialResults");
                context.Writer.Write(requestObject.FilterPartialResults);
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

            if(requestObject.IsSetShowSpeakerLabel())
            {
                context.Writer.WritePropertyName("ShowSpeakerLabel");
                context.Writer.Write(requestObject.ShowSpeakerLabel);
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

            if(requestObject.IsSetVocabularyName())
            {
                context.Writer.WritePropertyName("VocabularyName");
                context.Writer.Write(requestObject.VocabularyName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AmazonTranscribeProcessorConfigurationMarshaller Instance = new AmazonTranscribeProcessorConfigurationMarshaller();

    }
}