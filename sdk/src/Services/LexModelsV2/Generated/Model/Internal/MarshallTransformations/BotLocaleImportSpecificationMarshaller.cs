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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BotLocaleImportSpecification Marshaller
    /// </summary>
    public class BotLocaleImportSpecificationMarshaller : IRequestMarshaller<BotLocaleImportSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BotLocaleImportSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBotId())
            {
                context.Writer.WritePropertyName("botId");
                context.Writer.Write(requestObject.BotId);
            }

            if(requestObject.IsSetBotVersion())
            {
                context.Writer.WritePropertyName("botVersion");
                context.Writer.Write(requestObject.BotVersion);
            }

            if(requestObject.IsSetLocaleId())
            {
                context.Writer.WritePropertyName("localeId");
                context.Writer.Write(requestObject.LocaleId);
            }

            if(requestObject.IsSetNluIntentConfidenceThreshold())
            {
                context.Writer.WritePropertyName("nluIntentConfidenceThreshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.NluIntentConfidenceThreshold))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.NluIntentConfidenceThreshold));
                }
                else
                {
                    context.Writer.Write(requestObject.NluIntentConfidenceThreshold);
                }
            }

            if(requestObject.IsSetSpeechDetectionSensitivity())
            {
                context.Writer.WritePropertyName("speechDetectionSensitivity");
                context.Writer.Write(requestObject.SpeechDetectionSensitivity);
            }

            if(requestObject.IsSetVoiceSettings())
            {
                context.Writer.WritePropertyName("voiceSettings");
                context.Writer.WriteObjectStart();

                var marshaller = VoiceSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.VoiceSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BotLocaleImportSpecificationMarshaller Instance = new BotLocaleImportSpecificationMarshaller();

    }
}