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
    /// Response Unmarshaller for Row Object
    /// </summary>  
    public class RowUnmarshaller : ICborUnmarshaller<Row, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Row Unmarshall(CborUnmarshallerContext context)
        {
            Row unmarshalledObject = new Row();
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
                    case "ArchivedMessageId":
                        {
                            context.AddPathSegment("ArchivedMessageId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ArchivedMessageId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Cc":
                        {
                            context.AddPathSegment("Cc");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Cc = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Date":
                        {
                            context.AddPathSegment("Date");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Date = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Envelope":
                        {
                            context.AddPathSegment("Envelope");
                            var unmarshaller = EnvelopeUnmarshaller.Instance;
                            unmarshalledObject.Envelope = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "From":
                        {
                            context.AddPathSegment("From");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.From = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "HasAttachments":
                        {
                            context.AddPathSegment("HasAttachments");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.HasAttachments = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IngressPointId":
                        {
                            context.AddPathSegment("IngressPointId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.IngressPointId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InReplyTo":
                        {
                            context.AddPathSegment("InReplyTo");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InReplyTo = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MessageId":
                        {
                            context.AddPathSegment("MessageId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.MessageId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ReceivedHeaders":
                        {
                            context.AddPathSegment("ReceivedHeaders");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.ReceivedHeaders = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ReceivedTimestamp":
                        {
                            context.AddPathSegment("ReceivedTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.ReceivedTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SenderHostname":
                        {
                            context.AddPathSegment("SenderHostname");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SenderHostname = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SenderIpAddress":
                        {
                            context.AddPathSegment("SenderIpAddress");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SenderIpAddress = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SourceArn":
                        {
                            context.AddPathSegment("SourceArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SourceArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Subject":
                        {
                            context.AddPathSegment("Subject");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Subject = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "To":
                        {
                            context.AddPathSegment("To");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.To = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "XMailer":
                        {
                            context.AddPathSegment("XMailer");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.XMailer = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "XOriginalMailer":
                        {
                            context.AddPathSegment("XOriginalMailer");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.XOriginalMailer = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "XPriority":
                        {
                            context.AddPathSegment("XPriority");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.XPriority = unmarshaller.Unmarshall(context);
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


        private static RowUnmarshaller _instance = new RowUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RowUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}