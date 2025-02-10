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
    /// NotifyConfigurationType Marshaller
    /// </summary>
    public class NotifyConfigurationTypeMarshaller : IRequestMarshaller<NotifyConfigurationType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NotifyConfigurationType requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlockEmail())
            {
                context.Writer.WritePropertyName("BlockEmail");
                context.Writer.WriteStartObject();

                var marshaller = NotifyEmailTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.BlockEmail, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFrom())
            {
                context.Writer.WritePropertyName("From");
                context.Writer.WriteStringValue(requestObject.From);
            }

            if(requestObject.IsSetMfaEmail())
            {
                context.Writer.WritePropertyName("MfaEmail");
                context.Writer.WriteStartObject();

                var marshaller = NotifyEmailTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.MfaEmail, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNoActionEmail())
            {
                context.Writer.WritePropertyName("NoActionEmail");
                context.Writer.WriteStartObject();

                var marshaller = NotifyEmailTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.NoActionEmail, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReplyTo())
            {
                context.Writer.WritePropertyName("ReplyTo");
                context.Writer.WriteStringValue(requestObject.ReplyTo);
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
        public readonly static NotifyConfigurationTypeMarshaller Instance = new NotifyConfigurationTypeMarshaller();

    }
}