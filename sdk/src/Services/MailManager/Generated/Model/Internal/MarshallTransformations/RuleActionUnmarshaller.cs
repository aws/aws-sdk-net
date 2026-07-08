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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MailManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
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
    public class RuleActionUnmarshaller : ICborUnmarshaller<RuleAction, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RuleAction Unmarshall(CborUnmarshallerContext context)
        {
            RuleAction unmarshalledObject = new RuleAction();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "AddHeader":
                        {
                            context.AddPathSegment("AddHeader");
                            var unmarshaller = AddHeaderActionUnmarshaller.Instance;
                            unmarshalledObject.AddHeader = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Archive":
                        {
                            context.AddPathSegment("Archive");
                            var unmarshaller = ArchiveActionUnmarshaller.Instance;
                            unmarshalledObject.Archive = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Bounce":
                        {
                            context.AddPathSegment("Bounce");
                            var unmarshaller = BounceActionUnmarshaller.Instance;
                            unmarshalledObject.Bounce = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DeliverToMailbox":
                        {
                            context.AddPathSegment("DeliverToMailbox");
                            var unmarshaller = DeliverToMailboxActionUnmarshaller.Instance;
                            unmarshalledObject.DeliverToMailbox = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DeliverToQBusiness":
                        {
                            context.AddPathSegment("DeliverToQBusiness");
                            var unmarshaller = DeliverToQBusinessActionUnmarshaller.Instance;
                            unmarshalledObject.DeliverToQBusiness = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Drop":
                        {
                            context.AddPathSegment("Drop");
                            var unmarshaller = DropActionUnmarshaller.Instance;
                            unmarshalledObject.Drop = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InvokeLambda":
                        {
                            context.AddPathSegment("InvokeLambda");
                            var unmarshaller = InvokeLambdaActionUnmarshaller.Instance;
                            unmarshalledObject.InvokeLambda = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PublishToSns":
                        {
                            context.AddPathSegment("PublishToSns");
                            var unmarshaller = SnsActionUnmarshaller.Instance;
                            unmarshalledObject.PublishToSns = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Relay":
                        {
                            context.AddPathSegment("Relay");
                            var unmarshaller = RelayActionUnmarshaller.Instance;
                            unmarshalledObject.Relay = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ReplaceRecipient":
                        {
                            context.AddPathSegment("ReplaceRecipient");
                            var unmarshaller = ReplaceRecipientActionUnmarshaller.Instance;
                            unmarshalledObject.ReplaceRecipient = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Send":
                        {
                            context.AddPathSegment("Send");
                            var unmarshaller = SendActionUnmarshaller.Instance;
                            unmarshalledObject.Send = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "WriteToS3":
                        {
                            context.AddPathSegment("WriteToS3");
                            var unmarshaller = S3ActionUnmarshaller.Instance;
                            unmarshalledObject.WriteToS3 = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
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
        public static RuleActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}