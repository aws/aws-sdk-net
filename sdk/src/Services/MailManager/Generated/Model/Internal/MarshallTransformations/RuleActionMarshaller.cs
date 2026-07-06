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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RuleAction Marshaller
    /// </summary>
    public class RuleActionMarshaller : IRequestMarshaller<RuleAction, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuleAction requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAddHeader())
            {
                context.Writer.WriteTextString("AddHeader");
                context.Writer.WriteStartMap(null);

                var marshaller = AddHeaderActionMarshaller.Instance;
                marshaller.Marshall(requestObject.AddHeader, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetArchive())
            {
                context.Writer.WriteTextString("Archive");
                context.Writer.WriteStartMap(null);

                var marshaller = ArchiveActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Archive, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetBounce())
            {
                context.Writer.WriteTextString("Bounce");
                context.Writer.WriteStartMap(null);

                var marshaller = BounceActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Bounce, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetDeliverToMailbox())
            {
                context.Writer.WriteTextString("DeliverToMailbox");
                context.Writer.WriteStartMap(null);

                var marshaller = DeliverToMailboxActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DeliverToMailbox, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetDeliverToQBusiness())
            {
                context.Writer.WriteTextString("DeliverToQBusiness");
                context.Writer.WriteStartMap(null);

                var marshaller = DeliverToQBusinessActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DeliverToQBusiness, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetDrop())
            {
                context.Writer.WriteTextString("Drop");
                context.Writer.WriteStartMap(null);

                var marshaller = DropActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Drop, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetInvokeLambda())
            {
                context.Writer.WriteTextString("InvokeLambda");
                context.Writer.WriteStartMap(null);

                var marshaller = InvokeLambdaActionMarshaller.Instance;
                marshaller.Marshall(requestObject.InvokeLambda, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetPublishToSns())
            {
                context.Writer.WriteTextString("PublishToSns");
                context.Writer.WriteStartMap(null);

                var marshaller = SnsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.PublishToSns, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetRelay())
            {
                context.Writer.WriteTextString("Relay");
                context.Writer.WriteStartMap(null);

                var marshaller = RelayActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Relay, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetReplaceRecipient())
            {
                context.Writer.WriteTextString("ReplaceRecipient");
                context.Writer.WriteStartMap(null);

                var marshaller = ReplaceRecipientActionMarshaller.Instance;
                marshaller.Marshall(requestObject.ReplaceRecipient, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetSend())
            {
                context.Writer.WriteTextString("Send");
                context.Writer.WriteStartMap(null);

                var marshaller = SendActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Send, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetWriteToS3())
            {
                context.Writer.WriteTextString("WriteToS3");
                context.Writer.WriteStartMap(null);

                var marshaller = S3ActionMarshaller.Instance;
                marshaller.Marshall(requestObject.WriteToS3, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleActionMarshaller Instance = new RuleActionMarshaller();

    }
}