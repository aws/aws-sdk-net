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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.EventBridgeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WebhookHmacAuthConfiguration Marshaller
    /// </summary>
    public partial class WebhookHmacAuthConfigurationMarshaller : IRequestMarshaller<WebhookHmacAuthConfiguration, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(WebhookHmacAuthConfiguration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAlgorithm())
            {
                context.Writer.WriteTextString("Algorithm");
                context.Writer.WriteTextString(requestObject.Algorithm);
            }

            if (requestObject.IsSetDelimiter())
            {
                context.Writer.WriteTextString("Delimiter");
                context.Writer.WriteTextString(requestObject.Delimiter);
            }

            if (requestObject.IsSetEncoding())
            {
                context.Writer.WriteTextString("Encoding");
                context.Writer.WriteTextString(requestObject.Encoding);
            }

            if (requestObject.IsSetMessageIdHttpHeader())
            {
                context.Writer.WriteTextString("MessageIdHttpHeader");
                context.Writer.WriteTextString(requestObject.MessageIdHttpHeader);
            }

            if (requestObject.IsSetSecretEncoding())
            {
                context.Writer.WriteTextString("SecretEncoding");
                context.Writer.WriteTextString(requestObject.SecretEncoding);
            }

            if (requestObject.IsSetSecretValue())
            {
                context.Writer.WriteTextString("SecretValue");
                context.Writer.WriteTextString(requestObject.SecretValue);
            }

            if (requestObject.IsSetSignatureHttpHeader())
            {
                context.Writer.WriteTextString("SignatureHttpHeader");
                context.Writer.WriteTextString(requestObject.SignatureHttpHeader);
            }

            if (requestObject.IsSetSignaturePrefix())
            {
                context.Writer.WriteTextString("SignaturePrefix");
                context.Writer.WriteTextString(requestObject.SignaturePrefix);
            }

            if (requestObject.IsSetSignedMessageComposition())
            {
                context.Writer.WriteTextString("SignedMessageComposition");
                context.Writer.WriteTextString(requestObject.SignedMessageComposition);
            }

            if (requestObject.IsSetTimestampHttpHeader())
            {
                context.Writer.WriteTextString("TimestampHttpHeader");
                context.Writer.WriteTextString(requestObject.TimestampHttpHeader);
            }

            if (requestObject.IsSetTimestampPrefix())
            {
                context.Writer.WriteTextString("TimestampPrefix");
                context.Writer.WriteTextString(requestObject.TimestampPrefix);
            }

            if (requestObject.IsSetTimestampToleranceInSeconds())
            {
                context.Writer.WriteTextString("TimestampToleranceInSeconds");
                context.Writer.WriteInt32(requestObject.TimestampToleranceInSeconds.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static WebhookHmacAuthConfigurationMarshaller Instance = new WebhookHmacAuthConfigurationMarshaller();
    }
}
