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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EmailConfigurationType Marshaller
    /// </summary>
    public class EmailConfigurationTypeMarshaller : IRequestMarshaller<EmailConfigurationType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EmailConfigurationType requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConfigurationSet())
            {
                context.Writer.WritePropertyName("ConfigurationSet");
                context.Writer.WriteStringValue(requestObject.ConfigurationSet);
            }

            if(requestObject.IsSetEmailSendingAccount())
            {
                context.Writer.WritePropertyName("EmailSendingAccount");
                context.Writer.WriteStringValue(requestObject.EmailSendingAccount);
            }

            if(requestObject.IsSetFrom())
            {
                context.Writer.WritePropertyName("From");
                context.Writer.WriteStringValue(requestObject.From);
            }

            if(requestObject.IsSetReplyToEmailAddress())
            {
                context.Writer.WritePropertyName("ReplyToEmailAddress");
                context.Writer.WriteStringValue(requestObject.ReplyToEmailAddress);
            }

            if(requestObject.IsSetSourceArn())
            {
                context.Writer.WritePropertyName("SourceArn");
                context.Writer.WriteStringValue(requestObject.SourceArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EmailConfigurationTypeMarshaller Instance = new EmailConfigurationTypeMarshaller();

    }
}