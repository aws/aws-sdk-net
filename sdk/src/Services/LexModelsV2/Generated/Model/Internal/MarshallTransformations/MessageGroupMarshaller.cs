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
    /// MessageGroup Marshaller
    /// </summary>
    public class MessageGroupMarshaller : IRequestMarshaller<MessageGroup, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MessageGroup requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMessage())
            {
                context.Writer.WritePropertyName("message");
                context.Writer.WriteStartObject();

                var marshaller = MessageMarshaller.Instance;
                marshaller.Marshall(requestObject.Message, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVariations())
            {
                context.Writer.WritePropertyName("variations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVariationsListValue in requestObject.Variations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MessageMarshaller.Instance;
                    marshaller.Marshall(requestObjectVariationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MessageGroupMarshaller Instance = new MessageGroupMarshaller();

    }
}