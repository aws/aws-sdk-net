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
    /// BotImportSpecification Marshaller
    /// </summary>
    public class BotImportSpecificationMarshaller : IRequestMarshaller<BotImportSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BotImportSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBotName())
            {
                context.Writer.WritePropertyName("botName");
                context.Writer.WriteStringValue(requestObject.BotName);
            }

            if(requestObject.IsSetBotTags())
            {
                context.Writer.WritePropertyName("botTags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectBotTagsKvp in requestObject.BotTags)
                {
                    context.Writer.WritePropertyName(requestObjectBotTagsKvp.Key);
                    var requestObjectBotTagsValue = requestObjectBotTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectBotTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataPrivacy())
            {
                context.Writer.WritePropertyName("dataPrivacy");
                context.Writer.WriteStartObject();

                var marshaller = DataPrivacyMarshaller.Instance;
                marshaller.Marshall(requestObject.DataPrivacy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetErrorLogSettings())
            {
                context.Writer.WritePropertyName("errorLogSettings");
                context.Writer.WriteStartObject();

                var marshaller = ErrorLogSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ErrorLogSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIdleSessionTTLInSeconds())
            {
                context.Writer.WritePropertyName("idleSessionTTLInSeconds");
                context.Writer.WriteNumberValue(requestObject.IdleSessionTTLInSeconds.Value);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetTestBotAliasTags())
            {
                context.Writer.WritePropertyName("testBotAliasTags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTestBotAliasTagsKvp in requestObject.TestBotAliasTags)
                {
                    context.Writer.WritePropertyName(requestObjectTestBotAliasTagsKvp.Key);
                    var requestObjectTestBotAliasTagsValue = requestObjectTestBotAliasTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectTestBotAliasTagsValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BotImportSpecificationMarshaller Instance = new BotImportSpecificationMarshaller();

    }
}