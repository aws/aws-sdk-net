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
    /// ResponseHeadersPolicyCorsConfig Marshaller
    /// </summary>
    public partial class ResponseHeadersPolicyCorsConfigMarshaller : IRequestMarshaller<ResponseHeadersPolicyCorsConfig, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ResponseHeadersPolicyCorsConfig requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAccessControlAllowCredentials())
            {
                context.Writer.WriteElementString("AccessControlAllowCredentials", StringUtils.FromBool(requestObject.AccessControlAllowCredentials.Value));
            }
            if (requestObject.IsSetAccessControlAllowHeaders())
            {
                context.Writer.WriteStartElement("AccessControlAllowHeaders");
                ResponseHeadersPolicyAccessControlAllowHeadersMarshaller.Instance.Marshall(requestObject.AccessControlAllowHeaders, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetAccessControlAllowMethods())
            {
                context.Writer.WriteStartElement("AccessControlAllowMethods");
                ResponseHeadersPolicyAccessControlAllowMethodsMarshaller.Instance.Marshall(requestObject.AccessControlAllowMethods, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetAccessControlAllowOrigins())
            {
                context.Writer.WriteStartElement("AccessControlAllowOrigins");
                ResponseHeadersPolicyAccessControlAllowOriginsMarshaller.Instance.Marshall(requestObject.AccessControlAllowOrigins, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetAccessControlExposeHeaders())
            {
                context.Writer.WriteStartElement("AccessControlExposeHeaders");
                ResponseHeadersPolicyAccessControlExposeHeadersMarshaller.Instance.Marshall(requestObject.AccessControlExposeHeaders, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetAccessControlMaxAgeSec())
            {
                context.Writer.WriteElementString("AccessControlMaxAgeSec", StringUtils.FromInt(requestObject.AccessControlMaxAgeSec.Value));
            }
            if (requestObject.IsSetOriginOverride())
            {
                context.Writer.WriteElementString("OriginOverride", StringUtils.FromBool(requestObject.OriginOverride.Value));
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ResponseHeadersPolicyCorsConfigMarshaller Instance = new ResponseHeadersPolicyCorsConfigMarshaller();
    }
}
