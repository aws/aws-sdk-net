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

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConversationLogSettings Marshaller
    /// </summary>       
    public class ConversationLogSettingsMarshaller : IRequestMarshaller<ConversationLogSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConversationLogSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAudioLogSettings())
            {
                context.Writer.WritePropertyName("audioLogSettings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAudioLogSettingsListValue in requestObject.AudioLogSettings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AudioLogSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectAudioLogSettingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTextLogSettings())
            {
                context.Writer.WritePropertyName("textLogSettings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTextLogSettingsListValue in requestObject.TextLogSettings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TextLogSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectTextLogSettingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ConversationLogSettingsMarshaller Instance = new ConversationLogSettingsMarshaller();

    }
}