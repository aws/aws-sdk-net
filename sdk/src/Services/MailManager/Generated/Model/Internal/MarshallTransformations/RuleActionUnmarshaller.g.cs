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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.MailManager.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RuleAction Object
    /// </summary>
    public partial class RuleActionUnmarshaller : ICborUnmarshaller<RuleAction, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RuleAction Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new RuleAction();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "AddHeader":
                        context.AddPathSegment("AddHeader");
                        unmarshalledObject.AddHeader = AddHeaderActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Archive":
                        context.AddPathSegment("Archive");
                        unmarshalledObject.Archive = ArchiveActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Bounce":
                        context.AddPathSegment("Bounce");
                        unmarshalledObject.Bounce = BounceActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeliverToMailbox":
                        context.AddPathSegment("DeliverToMailbox");
                        unmarshalledObject.DeliverToMailbox = DeliverToMailboxActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeliverToQBusiness":
                        context.AddPathSegment("DeliverToQBusiness");
                        unmarshalledObject.DeliverToQBusiness = DeliverToQBusinessActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Drop":
                        context.AddPathSegment("Drop");
                        unmarshalledObject.Drop = DropActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InvokeLambda":
                        context.AddPathSegment("InvokeLambda");
                        unmarshalledObject.InvokeLambda = InvokeLambdaActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PublishToSns":
                        context.AddPathSegment("PublishToSns");
                        unmarshalledObject.PublishToSns = SnsActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Relay":
                        context.AddPathSegment("Relay");
                        unmarshalledObject.Relay = RelayActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ReplaceRecipient":
                        context.AddPathSegment("ReplaceRecipient");
                        unmarshalledObject.ReplaceRecipient = ReplaceRecipientActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Send":
                        context.AddPathSegment("Send");
                        unmarshalledObject.Send = SendActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WriteToS3":
                        context.AddPathSegment("WriteToS3");
                        unmarshalledObject.WriteToS3 = S3ActionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static RuleActionUnmarshaller _instance = new RuleActionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RuleActionUnmarshaller Instance => _instance;
    }
}
