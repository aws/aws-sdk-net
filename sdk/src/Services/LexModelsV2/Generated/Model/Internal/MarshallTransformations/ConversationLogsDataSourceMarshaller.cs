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
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConversationLogsDataSource Marshaller
    /// </summary>
    public class ConversationLogsDataSourceMarshaller : IRequestMarshaller<ConversationLogsDataSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConversationLogsDataSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBotAliasId())
            {
                context.Writer.WritePropertyName("botAliasId");
                context.Writer.WriteStringValue(requestObject.BotAliasId);
            }

            if(requestObject.IsSetBotId())
            {
                context.Writer.WritePropertyName("botId");
                context.Writer.WriteStringValue(requestObject.BotId);
            }

            if(requestObject.IsSetFilter())
            {
                context.Writer.WritePropertyName("filter");
                context.Writer.WriteStartObject();

                var marshaller = ConversationLogsDataSourceFilterByMarshaller.Instance;
                marshaller.Marshall(requestObject.Filter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLocaleId())
            {
                context.Writer.WritePropertyName("localeId");
                context.Writer.WriteStringValue(requestObject.LocaleId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConversationLogsDataSourceMarshaller Instance = new ConversationLogsDataSourceMarshaller();

    }
}