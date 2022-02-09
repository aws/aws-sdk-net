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
    /// CallAnalyticsJobSettings Marshaller
    /// </summary>
    public class CallAnalyticsJobSettingsMarshaller : IRequestMarshaller<CallAnalyticsJobSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CallAnalyticsJobSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetContentRedaction())
            {
                context.Writer.WritePropertyName("ContentRedaction");
                context.Writer.WriteObjectStart();

                var marshaller = ContentRedactionMarshaller.Instance;
                marshaller.Marshall(requestObject.ContentRedaction, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLanguageIdSettings())
            {
                context.Writer.WritePropertyName("LanguageIdSettings");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectLanguageIdSettingsKvp in requestObject.LanguageIdSettings)
                {
                    context.Writer.WritePropertyName(requestObjectLanguageIdSettingsKvp.Key);
                    var requestObjectLanguageIdSettingsValue = requestObjectLanguageIdSettingsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = LanguageIdSettingsMarshaller.Instance;
                    marshaller.Marshall(requestObjectLanguageIdSettingsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLanguageModelName())
            {
                context.Writer.WritePropertyName("LanguageModelName");
                context.Writer.Write(requestObject.LanguageModelName);
            }

            if(requestObject.IsSetLanguageOptions())
            {
                context.Writer.WritePropertyName("LanguageOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLanguageOptionsListValue in requestObject.LanguageOptions)
                {
                        context.Writer.Write(requestObjectLanguageOptionsListValue);
                }
                context.Writer.WriteArrayEnd();
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
        public readonly static CallAnalyticsJobSettingsMarshaller Instance = new CallAnalyticsJobSettingsMarshaller();

    }
}