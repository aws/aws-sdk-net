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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.B2bi.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.B2bi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// X12InterchangeControlHeaders Marshaller
    /// </summary>
    public class X12InterchangeControlHeadersMarshaller : IRequestMarshaller<X12InterchangeControlHeaders, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(X12InterchangeControlHeaders requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAcknowledgmentRequestedCode())
            {
                context.Writer.WritePropertyName("acknowledgmentRequestedCode");
                context.Writer.Write(requestObject.AcknowledgmentRequestedCode);
            }

            if(requestObject.IsSetReceiverId())
            {
                context.Writer.WritePropertyName("receiverId");
                context.Writer.Write(requestObject.ReceiverId);
            }

            if(requestObject.IsSetReceiverIdQualifier())
            {
                context.Writer.WritePropertyName("receiverIdQualifier");
                context.Writer.Write(requestObject.ReceiverIdQualifier);
            }

            if(requestObject.IsSetRepetitionSeparator())
            {
                context.Writer.WritePropertyName("repetitionSeparator");
                context.Writer.Write(requestObject.RepetitionSeparator);
            }

            if(requestObject.IsSetSenderId())
            {
                context.Writer.WritePropertyName("senderId");
                context.Writer.Write(requestObject.SenderId);
            }

            if(requestObject.IsSetSenderIdQualifier())
            {
                context.Writer.WritePropertyName("senderIdQualifier");
                context.Writer.Write(requestObject.SenderIdQualifier);
            }

            if(requestObject.IsSetUsageIndicatorCode())
            {
                context.Writer.WritePropertyName("usageIndicatorCode");
                context.Writer.Write(requestObject.UsageIndicatorCode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static X12InterchangeControlHeadersMarshaller Instance = new X12InterchangeControlHeadersMarshaller();

    }
}