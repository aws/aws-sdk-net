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

using Amazon.BedrockAgentCore.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EmbeddedCryptoWallet Marshaller
    /// </summary>
    public partial class EmbeddedCryptoWalletMarshaller : IRequestMarshaller<EmbeddedCryptoWallet, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(EmbeddedCryptoWallet requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetLinkedAccounts())
            {
                context.Writer.WritePropertyName("linkedAccounts");
                context.Writer.WriteStartArray();
                foreach (var requestObjectLinkedAccountsListValue in requestObject.LinkedAccounts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LinkedAccountMarshaller.Instance;
                    marshaller.Marshall(requestObjectLinkedAccountsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetNetwork())
            {
                context.Writer.WritePropertyName("network");
                context.Writer.WriteStringValue(requestObject.Network);
            }

            if (requestObject.IsSetRedirectUrl())
            {
                context.Writer.WritePropertyName("redirectUrl");
                context.Writer.WriteStringValue(requestObject.RedirectUrl);
            }

            if (requestObject.IsSetWalletAddress())
            {
                context.Writer.WritePropertyName("walletAddress");
                context.Writer.WriteStringValue(requestObject.WalletAddress);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static EmbeddedCryptoWalletMarshaller Instance = new EmbeddedCryptoWalletMarshaller();
    }
}
