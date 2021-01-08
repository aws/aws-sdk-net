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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EmailMessage Marshaller
    /// </summary>       
    public class EmailMessageMarshaller : IRequestMarshaller<EmailMessage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EmailMessage requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBody())
            {
                context.Writer.WritePropertyName("Body");
                context.Writer.Write(requestObject.Body);
            }

            if(requestObject.IsSetFeedbackForwardingAddress())
            {
                context.Writer.WritePropertyName("FeedbackForwardingAddress");
                context.Writer.Write(requestObject.FeedbackForwardingAddress);
            }

            if(requestObject.IsSetFromAddress())
            {
                context.Writer.WritePropertyName("FromAddress");
                context.Writer.Write(requestObject.FromAddress);
            }

            if(requestObject.IsSetRawEmail())
            {
                context.Writer.WritePropertyName("RawEmail");
                context.Writer.WriteObjectStart();

                var marshaller = RawEmailMarshaller.Instance;
                marshaller.Marshall(requestObject.RawEmail, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetReplyToAddresses())
            {
                context.Writer.WritePropertyName("ReplyToAddresses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectReplyToAddressesListValue in requestObject.ReplyToAddresses)
                {
                        context.Writer.Write(requestObjectReplyToAddressesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSimpleEmail())
            {
                context.Writer.WritePropertyName("SimpleEmail");
                context.Writer.WriteObjectStart();

                var marshaller = SimpleEmailMarshaller.Instance;
                marshaller.Marshall(requestObject.SimpleEmail, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSubstitutions())
            {
                context.Writer.WritePropertyName("Substitutions");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSubstitutionsKvp in requestObject.Substitutions)
                {
                    context.Writer.WritePropertyName(requestObjectSubstitutionsKvp.Key);
                    var requestObjectSubstitutionsValue = requestObjectSubstitutionsKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectSubstitutionsValueListValue in requestObjectSubstitutionsValue)
                    {
                            context.Writer.Write(requestObjectSubstitutionsValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static EmailMessageMarshaller Instance = new EmailMessageMarshaller();

    }
}