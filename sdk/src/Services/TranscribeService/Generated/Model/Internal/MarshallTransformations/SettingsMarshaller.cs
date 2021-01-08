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
using ThirdParty.Json.LitJson;

namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Settings Marshaller
    /// </summary>       
    public class SettingsMarshaller : IRequestMarshaller<Settings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Settings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetChannelIdentification())
            {
                context.Writer.WritePropertyName("ChannelIdentification");
                context.Writer.Write(requestObject.ChannelIdentification);
            }

            if(requestObject.IsSetMaxAlternatives())
            {
                context.Writer.WritePropertyName("MaxAlternatives");
                context.Writer.Write(requestObject.MaxAlternatives);
            }

            if(requestObject.IsSetMaxSpeakerLabels())
            {
                context.Writer.WritePropertyName("MaxSpeakerLabels");
                context.Writer.Write(requestObject.MaxSpeakerLabels);
            }

            if(requestObject.IsSetShowAlternatives())
            {
                context.Writer.WritePropertyName("ShowAlternatives");
                context.Writer.Write(requestObject.ShowAlternatives);
            }

            if(requestObject.IsSetShowSpeakerLabels())
            {
                context.Writer.WritePropertyName("ShowSpeakerLabels");
                context.Writer.Write(requestObject.ShowSpeakerLabels);
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
        public readonly static SettingsMarshaller Instance = new SettingsMarshaller();

    }
}