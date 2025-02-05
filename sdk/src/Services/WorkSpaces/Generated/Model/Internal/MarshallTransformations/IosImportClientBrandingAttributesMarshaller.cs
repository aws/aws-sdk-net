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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IosImportClientBrandingAttributes Marshaller
    /// </summary>
    public class IosImportClientBrandingAttributesMarshaller : IRequestMarshaller<IosImportClientBrandingAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(IosImportClientBrandingAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetForgotPasswordLink())
            {
                context.Writer.WritePropertyName("ForgotPasswordLink");
                context.Writer.WriteStringValue(requestObject.ForgotPasswordLink);
            }

            if(requestObject.IsSetLoginMessage())
            {
                context.Writer.WritePropertyName("LoginMessage");
                context.Writer.WriteStartObject();
                foreach (var requestObjectLoginMessageKvp in requestObject.LoginMessage)
                {
                    context.Writer.WritePropertyName(requestObjectLoginMessageKvp.Key);
                    var requestObjectLoginMessageValue = requestObjectLoginMessageKvp.Value;

                        context.Writer.WriteStringValue(requestObjectLoginMessageValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLogo())
            {
                context.Writer.WritePropertyName("Logo");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(requestObject.Logo));
            }

            if(requestObject.IsSetLogo2x())
            {
                context.Writer.WritePropertyName("Logo2x");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(requestObject.Logo2x));
            }

            if(requestObject.IsSetLogo3x())
            {
                context.Writer.WritePropertyName("Logo3x");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(requestObject.Logo3x));
            }

            if(requestObject.IsSetSupportEmail())
            {
                context.Writer.WritePropertyName("SupportEmail");
                context.Writer.WriteStringValue(requestObject.SupportEmail);
            }

            if(requestObject.IsSetSupportLink())
            {
                context.Writer.WritePropertyName("SupportLink");
                context.Writer.WriteStringValue(requestObject.SupportLink);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static IosImportClientBrandingAttributesMarshaller Instance = new IosImportClientBrandingAttributesMarshaller();

    }
}