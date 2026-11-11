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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DefaultImportClientBrandingAttributes Marshaller
    /// </summary>
    public partial class DefaultImportClientBrandingAttributesMarshaller : IRequestMarshaller<DefaultImportClientBrandingAttributes, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DefaultImportClientBrandingAttributes requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetForgotPasswordLink())
            {
                context.Writer.WriteTextString("ForgotPasswordLink");
                context.Writer.WriteTextString(requestObject.ForgotPasswordLink);
            }

            if (requestObject.IsSetLoginMessage())
            {
                context.Writer.WriteTextString("LoginMessage");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectLoginMessageKvp in requestObject.LoginMessage)
                {
                    context.Writer.WriteTextString(requestObjectLoginMessageKvp.Key);
                    var requestObjectLoginMessageValue = requestObjectLoginMessageKvp.Value;
                    context.Writer.WriteTextString(requestObjectLoginMessageValue);
                }
                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetLogo())
            {
                context.Writer.WriteTextString("Logo");
                context.Writer.WriteByteString(requestObject.Logo);
            }

            if (requestObject.IsSetSupportEmail())
            {
                context.Writer.WriteTextString("SupportEmail");
                context.Writer.WriteTextString(requestObject.SupportEmail);
            }

            if (requestObject.IsSetSupportLink())
            {
                context.Writer.WriteTextString("SupportLink");
                context.Writer.WriteTextString(requestObject.SupportLink);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DefaultImportClientBrandingAttributesMarshaller Instance = new DefaultImportClientBrandingAttributesMarshaller();
    }
}
