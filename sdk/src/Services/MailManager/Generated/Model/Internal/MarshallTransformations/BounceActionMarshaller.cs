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
    /// BounceAction Marshaller
    /// </summary>
    public class BounceActionMarshaller : IRequestMarshaller<BounceAction, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BounceAction requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetActionFailurePolicy())
            {
                context.Writer.WriteTextString("ActionFailurePolicy");
                context.Writer.WriteTextString(requestObject.ActionFailurePolicy);
            }
            if (requestObject.IsSetDiagnosticMessage())
            {
                context.Writer.WriteTextString("DiagnosticMessage");
                context.Writer.WriteTextString(requestObject.DiagnosticMessage);
            }
            if (requestObject.IsSetMessage())
            {
                context.Writer.WriteTextString("Message");
                context.Writer.WriteTextString(requestObject.Message);
            }
            if (requestObject.IsSetRoleArn())
            {
                context.Writer.WriteTextString("RoleArn");
                context.Writer.WriteTextString(requestObject.RoleArn);
            }
            if (requestObject.IsSetSender())
            {
                context.Writer.WriteTextString("Sender");
                context.Writer.WriteTextString(requestObject.Sender);
            }
            if (requestObject.IsSetSmtpReplyCode())
            {
                context.Writer.WriteTextString("SmtpReplyCode");
                context.Writer.WriteTextString(requestObject.SmtpReplyCode);
            }
            if (requestObject.IsSetStatusCode())
            {
                context.Writer.WriteTextString("StatusCode");
                context.Writer.WriteTextString(requestObject.StatusCode);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BounceActionMarshaller Instance = new BounceActionMarshaller();

    }
}