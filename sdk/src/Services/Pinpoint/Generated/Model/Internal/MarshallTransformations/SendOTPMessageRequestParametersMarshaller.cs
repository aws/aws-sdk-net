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
#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendOTPMessageRequestParameters Marshaller
    /// </summary>
    public class SendOTPMessageRequestParametersMarshaller : IRequestMarshaller<SendOTPMessageRequestParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SendOTPMessageRequestParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowedAttempts())
            {
                context.Writer.WritePropertyName("AllowedAttempts");
                context.Writer.WriteNumberValue(requestObject.AllowedAttempts.Value);
            }

            if(requestObject.IsSetBrandName())
            {
                context.Writer.WritePropertyName("BrandName");
                context.Writer.WriteStringValue(requestObject.BrandName);
            }

            if(requestObject.IsSetChannel())
            {
                context.Writer.WritePropertyName("Channel");
                context.Writer.WriteStringValue(requestObject.Channel);
            }

            if(requestObject.IsSetCodeLength())
            {
                context.Writer.WritePropertyName("CodeLength");
                context.Writer.WriteNumberValue(requestObject.CodeLength.Value);
            }

            if(requestObject.IsSetDestinationIdentity())
            {
                context.Writer.WritePropertyName("DestinationIdentity");
                context.Writer.WriteStringValue(requestObject.DestinationIdentity);
            }

            if(requestObject.IsSetEntityId())
            {
                context.Writer.WritePropertyName("EntityId");
                context.Writer.WriteStringValue(requestObject.EntityId);
            }

            if(requestObject.IsSetLanguage())
            {
                context.Writer.WritePropertyName("Language");
                context.Writer.WriteStringValue(requestObject.Language);
            }

            if(requestObject.IsSetOriginationIdentity())
            {
                context.Writer.WritePropertyName("OriginationIdentity");
                context.Writer.WriteStringValue(requestObject.OriginationIdentity);
            }

            if(requestObject.IsSetReferenceId())
            {
                context.Writer.WritePropertyName("ReferenceId");
                context.Writer.WriteStringValue(requestObject.ReferenceId);
            }

            if(requestObject.IsSetTemplateId())
            {
                context.Writer.WritePropertyName("TemplateId");
                context.Writer.WriteStringValue(requestObject.TemplateId);
            }

            if(requestObject.IsSetValidityPeriod())
            {
                context.Writer.WritePropertyName("ValidityPeriod");
                context.Writer.WriteNumberValue(requestObject.ValidityPeriod.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SendOTPMessageRequestParametersMarshaller Instance = new SendOTPMessageRequestParametersMarshaller();

    }
}