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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.CloudFront.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResponseHeadersPolicySecurityHeadersConfig Marshaller
    /// </summary>
    public partial class ResponseHeadersPolicySecurityHeadersConfigMarshaller : IRequestMarshaller<ResponseHeadersPolicySecurityHeadersConfig, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ResponseHeadersPolicySecurityHeadersConfig requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetContentSecurityPolicy())
            {
                context.Writer.WriteStartElement("ContentSecurityPolicy");
                ResponseHeadersPolicyContentSecurityPolicyMarshaller.Instance.Marshall(requestObject.ContentSecurityPolicy, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetContentTypeOptions())
            {
                context.Writer.WriteStartElement("ContentTypeOptions");
                ResponseHeadersPolicyContentTypeOptionsMarshaller.Instance.Marshall(requestObject.ContentTypeOptions, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetFrameOptions())
            {
                context.Writer.WriteStartElement("FrameOptions");
                ResponseHeadersPolicyFrameOptionsMarshaller.Instance.Marshall(requestObject.FrameOptions, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetReferrerPolicy())
            {
                context.Writer.WriteStartElement("ReferrerPolicy");
                ResponseHeadersPolicyReferrerPolicyMarshaller.Instance.Marshall(requestObject.ReferrerPolicy, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetStrictTransportSecurity())
            {
                context.Writer.WriteStartElement("StrictTransportSecurity");
                ResponseHeadersPolicyStrictTransportSecurityMarshaller.Instance.Marshall(requestObject.StrictTransportSecurity, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetXSSProtection())
            {
                context.Writer.WriteStartElement("XSSProtection");
                ResponseHeadersPolicyXSSProtectionMarshaller.Instance.Marshall(requestObject.XSSProtection, context);
                context.Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ResponseHeadersPolicySecurityHeadersConfigMarshaller Instance = new ResponseHeadersPolicySecurityHeadersConfigMarshaller();
    }
}
