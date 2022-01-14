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
            if(requestObject.IsSetAllowedAttempts())
            {
                context.Writer.WritePropertyName("AllowedAttempts");
                context.Writer.Write(requestObject.AllowedAttempts);
            }

            if(requestObject.IsSetBrandName())
            {
                context.Writer.WritePropertyName("BrandName");
                context.Writer.Write(requestObject.BrandName);
            }

            if(requestObject.IsSetChannel())
            {
                context.Writer.WritePropertyName("Channel");
                context.Writer.Write(requestObject.Channel);
            }

            if(requestObject.IsSetCodeLength())
            {
                context.Writer.WritePropertyName("CodeLength");
                context.Writer.Write(requestObject.CodeLength);
            }

            if(requestObject.IsSetDestinationIdentity())
            {
                context.Writer.WritePropertyName("DestinationIdentity");
                context.Writer.Write(requestObject.DestinationIdentity);
            }

            if(requestObject.IsSetEntityId())
            {
                context.Writer.WritePropertyName("EntityId");
                context.Writer.Write(requestObject.EntityId);
            }

            if(requestObject.IsSetLanguage())
            {
                context.Writer.WritePropertyName("Language");
                context.Writer.Write(requestObject.Language);
            }

            if(requestObject.IsSetOriginationIdentity())
            {
                context.Writer.WritePropertyName("OriginationIdentity");
                context.Writer.Write(requestObject.OriginationIdentity);
            }

            if(requestObject.IsSetReferenceId())
            {
                context.Writer.WritePropertyName("ReferenceId");
                context.Writer.Write(requestObject.ReferenceId);
            }

            if(requestObject.IsSetTemplateId())
            {
                context.Writer.WritePropertyName("TemplateId");
                context.Writer.Write(requestObject.TemplateId);
            }

            if(requestObject.IsSetValidityPeriod())
            {
                context.Writer.WritePropertyName("ValidityPeriod");
                context.Writer.Write(requestObject.ValidityPeriod);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SendOTPMessageRequestParametersMarshaller Instance = new SendOTPMessageRequestParametersMarshaller();

    }
}