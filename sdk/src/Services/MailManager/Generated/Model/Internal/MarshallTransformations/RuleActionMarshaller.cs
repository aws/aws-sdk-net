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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MailManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RuleAction Marshaller
    /// </summary>
    public class RuleActionMarshaller : IRequestMarshaller<RuleAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuleAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddHeader())
            {
                context.Writer.WritePropertyName("AddHeader");
                context.Writer.WriteObjectStart();

                var marshaller = AddHeaderActionMarshaller.Instance;
                marshaller.Marshall(requestObject.AddHeader, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetArchive())
            {
                context.Writer.WritePropertyName("Archive");
                context.Writer.WriteObjectStart();

                var marshaller = ArchiveActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Archive, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDeliverToMailbox())
            {
                context.Writer.WritePropertyName("DeliverToMailbox");
                context.Writer.WriteObjectStart();

                var marshaller = DeliverToMailboxActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DeliverToMailbox, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDeliverToQBusiness())
            {
                context.Writer.WritePropertyName("DeliverToQBusiness");
                context.Writer.WriteObjectStart();

                var marshaller = DeliverToQBusinessActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DeliverToQBusiness, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDrop())
            {
                context.Writer.WritePropertyName("Drop");
                context.Writer.WriteObjectStart();

                var marshaller = DropActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Drop, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRelay())
            {
                context.Writer.WritePropertyName("Relay");
                context.Writer.WriteObjectStart();

                var marshaller = RelayActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Relay, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetReplaceRecipient())
            {
                context.Writer.WritePropertyName("ReplaceRecipient");
                context.Writer.WriteObjectStart();

                var marshaller = ReplaceRecipientActionMarshaller.Instance;
                marshaller.Marshall(requestObject.ReplaceRecipient, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSend())
            {
                context.Writer.WritePropertyName("Send");
                context.Writer.WriteObjectStart();

                var marshaller = SendActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Send, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWriteToS3())
            {
                context.Writer.WritePropertyName("WriteToS3");
                context.Writer.WriteObjectStart();

                var marshaller = S3ActionMarshaller.Instance;
                marshaller.Marshall(requestObject.WriteToS3, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleActionMarshaller Instance = new RuleActionMarshaller();

    }
}