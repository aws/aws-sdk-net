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

using Amazon.EventBridgeV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.EventBridgeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WebhookHmacAuthConfiguration Object
    /// </summary>
    public partial class WebhookHmacAuthConfigurationUnmarshaller : ICborUnmarshaller<WebhookHmacAuthConfiguration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public WebhookHmacAuthConfiguration Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new WebhookHmacAuthConfiguration();
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
                    case "Algorithm":
                        context.AddPathSegment("Algorithm");
                        unmarshalledObject.Algorithm = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Delimiter":
                        context.AddPathSegment("Delimiter");
                        unmarshalledObject.Delimiter = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Encoding":
                        context.AddPathSegment("Encoding");
                        unmarshalledObject.Encoding = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MessageIdHttpHeader":
                        context.AddPathSegment("MessageIdHttpHeader");
                        unmarshalledObject.MessageIdHttpHeader = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SecretEncoding":
                        context.AddPathSegment("SecretEncoding");
                        unmarshalledObject.SecretEncoding = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SecretValue":
                        context.AddPathSegment("SecretValue");
                        unmarshalledObject.SecretValue = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SignatureHttpHeader":
                        context.AddPathSegment("SignatureHttpHeader");
                        unmarshalledObject.SignatureHttpHeader = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SignaturePrefix":
                        context.AddPathSegment("SignaturePrefix");
                        unmarshalledObject.SignaturePrefix = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SignedMessageComposition":
                        context.AddPathSegment("SignedMessageComposition");
                        unmarshalledObject.SignedMessageComposition = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TimestampHttpHeader":
                        context.AddPathSegment("TimestampHttpHeader");
                        unmarshalledObject.TimestampHttpHeader = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TimestampPrefix":
                        context.AddPathSegment("TimestampPrefix");
                        unmarshalledObject.TimestampPrefix = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TimestampToleranceInSeconds":
                        context.AddPathSegment("TimestampToleranceInSeconds");
                        unmarshalledObject.TimestampToleranceInSeconds = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
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

        private static WebhookHmacAuthConfigurationUnmarshaller _instance = new WebhookHmacAuthConfigurationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static WebhookHmacAuthConfigurationUnmarshaller Instance => _instance;
    }
}
