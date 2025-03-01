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
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MedicalScribeSettings Marshaller
    /// </summary>
    public class MedicalScribeSettingsMarshaller : IRequestMarshaller<MedicalScribeSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MedicalScribeSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetChannelIdentification())
            {
                context.Writer.WritePropertyName("ChannelIdentification");
                context.Writer.WriteBooleanValue(requestObject.ChannelIdentification.Value);
            }

            if(requestObject.IsSetClinicalNoteGenerationSettings())
            {
                context.Writer.WritePropertyName("ClinicalNoteGenerationSettings");
                context.Writer.WriteStartObject();

                var marshaller = ClinicalNoteGenerationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ClinicalNoteGenerationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaxSpeakerLabels())
            {
                context.Writer.WritePropertyName("MaxSpeakerLabels");
                context.Writer.WriteNumberValue(requestObject.MaxSpeakerLabels.Value);
            }

            if(requestObject.IsSetShowSpeakerLabels())
            {
                context.Writer.WritePropertyName("ShowSpeakerLabels");
                context.Writer.WriteBooleanValue(requestObject.ShowSpeakerLabels.Value);
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

            if(requestObject.IsSetVocabularyName())
            {
                context.Writer.WritePropertyName("VocabularyName");
                context.Writer.WriteStringValue(requestObject.VocabularyName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MedicalScribeSettingsMarshaller Instance = new MedicalScribeSettingsMarshaller();

    }
}