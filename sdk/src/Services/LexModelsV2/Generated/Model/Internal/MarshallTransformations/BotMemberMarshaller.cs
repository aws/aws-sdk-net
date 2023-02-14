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
    /// BotMember Marshaller
    /// </summary>
    public class BotMemberMarshaller : IRequestMarshaller<BotMember, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BotMember requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBotMemberAliasId())
            {
                context.Writer.WritePropertyName("botMemberAliasId");
                context.Writer.Write(requestObject.BotMemberAliasId);
            }

            if(requestObject.IsSetBotMemberAliasName())
            {
                context.Writer.WritePropertyName("botMemberAliasName");
                context.Writer.Write(requestObject.BotMemberAliasName);
            }

            if(requestObject.IsSetBotMemberId())
            {
                context.Writer.WritePropertyName("botMemberId");
                context.Writer.Write(requestObject.BotMemberId);
            }

            if(requestObject.IsSetBotMemberName())
            {
                context.Writer.WritePropertyName("botMemberName");
                context.Writer.Write(requestObject.BotMemberName);
            }

            if(requestObject.IsSetBotMemberVersion())
            {
                context.Writer.WritePropertyName("botMemberVersion");
                context.Writer.Write(requestObject.BotMemberVersion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BotMemberMarshaller Instance = new BotMemberMarshaller();

    }
}