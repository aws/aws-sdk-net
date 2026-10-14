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
    /// Response Unmarshaller for Row Object
    /// </summary>
    public partial class RowUnmarshaller : ICborUnmarshaller<Row, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Row Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Row();
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
                    case "ArchivedMessageId":
                        context.AddPathSegment("ArchivedMessageId");
                        unmarshalledObject.ArchivedMessageId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Cc":
                        context.AddPathSegment("Cc");
                        unmarshalledObject.Cc = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Date":
                        context.AddPathSegment("Date");
                        unmarshalledObject.Date = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Envelope":
                        context.AddPathSegment("Envelope");
                        unmarshalledObject.Envelope = EnvelopeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "From":
                        context.AddPathSegment("From");
                        unmarshalledObject.From = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "HasAttachments":
                        context.AddPathSegment("HasAttachments");
                        unmarshalledObject.HasAttachments = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InReplyTo":
                        context.AddPathSegment("InReplyTo");
                        unmarshalledObject.InReplyTo = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IngressPointId":
                        context.AddPathSegment("IngressPointId");
                        unmarshalledObject.IngressPointId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MessageId":
                        context.AddPathSegment("MessageId");
                        unmarshalledObject.MessageId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ReceivedHeaders":
                        context.AddPathSegment("ReceivedHeaders");
                        unmarshalledObject.ReceivedHeaders = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ReceivedTimestamp":
                        context.AddPathSegment("ReceivedTimestamp");
                        unmarshalledObject.ReceivedTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SenderHostname":
                        context.AddPathSegment("SenderHostname");
                        unmarshalledObject.SenderHostname = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SenderIpAddress":
                        context.AddPathSegment("SenderIpAddress");
                        unmarshalledObject.SenderIpAddress = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceArn":
                        context.AddPathSegment("SourceArn");
                        unmarshalledObject.SourceArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Subject":
                        context.AddPathSegment("Subject");
                        unmarshalledObject.Subject = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "To":
                        context.AddPathSegment("To");
                        unmarshalledObject.To = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "XMailer":
                        context.AddPathSegment("XMailer");
                        unmarshalledObject.XMailer = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "XOriginalMailer":
                        context.AddPathSegment("XOriginalMailer");
                        unmarshalledObject.XOriginalMailer = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "XPriority":
                        context.AddPathSegment("XPriority");
                        unmarshalledObject.XPriority = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static RowUnmarshaller _instance = new RowUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RowUnmarshaller Instance => _instance;
    }
}
