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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EndUserMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EndUserMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BrandProfileAttributeInput Marshaller
    /// </summary>
    public class BrandProfileAttributeInputMarshaller : IRequestMarshaller<BrandProfileAttributeInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BrandProfileAttributeInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttachmentBody())
            {
                context.Writer.WritePropertyName("attachmentBody");
                StringUtils.WriteBase64StringValue(context.Writer, requestObject.AttachmentBody);
            }

            if(requestObject.IsSetAttributeName())
            {
                context.Writer.WritePropertyName("attributeName");
                context.Writer.WriteStringValue(requestObject.AttributeName);
            }

            if(requestObject.IsSetAttributeType())
            {
                context.Writer.WritePropertyName("attributeType");
                context.Writer.WriteStringValue(requestObject.AttributeType);
            }

            if(requestObject.IsSetAttributeValue())
            {
                context.Writer.WritePropertyName("attributeValue");
                context.Writer.WriteStringValue(requestObject.AttributeValue);
            }

            if(requestObject.IsSetCategory())
            {
                context.Writer.WritePropertyName("category");
                context.Writer.WriteStringValue(requestObject.Category);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BrandProfileAttributeInputMarshaller Instance = new BrandProfileAttributeInputMarshaller();

    }
}