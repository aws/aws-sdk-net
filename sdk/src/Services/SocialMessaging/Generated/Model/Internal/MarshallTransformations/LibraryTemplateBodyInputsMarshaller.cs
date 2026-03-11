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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SocialMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SocialMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LibraryTemplateBodyInputs Marshaller
    /// </summary>
    public class LibraryTemplateBodyInputsMarshaller : IRequestMarshaller<LibraryTemplateBodyInputs, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LibraryTemplateBodyInputs requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddContactNumber())
            {
                context.Writer.WritePropertyName("addContactNumber");
                context.Writer.WriteBooleanValue(requestObject.AddContactNumber.Value);
            }

            if(requestObject.IsSetAddLearnMoreLink())
            {
                context.Writer.WritePropertyName("addLearnMoreLink");
                context.Writer.WriteBooleanValue(requestObject.AddLearnMoreLink.Value);
            }

            if(requestObject.IsSetAddSecurityRecommendation())
            {
                context.Writer.WritePropertyName("addSecurityRecommendation");
                context.Writer.WriteBooleanValue(requestObject.AddSecurityRecommendation.Value);
            }

            if(requestObject.IsSetAddTrackPackageLink())
            {
                context.Writer.WritePropertyName("addTrackPackageLink");
                context.Writer.WriteBooleanValue(requestObject.AddTrackPackageLink.Value);
            }

            if(requestObject.IsSetCodeExpirationMinutes())
            {
                context.Writer.WritePropertyName("codeExpirationMinutes");
                context.Writer.WriteNumberValue(requestObject.CodeExpirationMinutes.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LibraryTemplateBodyInputsMarshaller Instance = new LibraryTemplateBodyInputsMarshaller();

    }
}