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
    /// ViewerCertificate Marshaller
    /// </summary>
    public partial class ViewerCertificateMarshaller : IRequestMarshaller<ViewerCertificate, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ViewerCertificate requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetACMCertificateArn())
            {
                context.Writer.WriteElementString("ACMCertificateArn", StringUtils.FromString(requestObject.ACMCertificateArn));
            }
            if (requestObject.IsSetCertificate())
            {
                context.Writer.WriteElementString("Certificate", StringUtils.FromString(requestObject.Certificate));
            }
            if (requestObject.IsSetCertificateSource())
            {
                context.Writer.WriteElementString("CertificateSource", StringUtils.FromString(requestObject.CertificateSource));
            }
            if (requestObject.IsSetCloudFrontDefaultCertificate())
            {
                context.Writer.WriteElementString("CloudFrontDefaultCertificate", StringUtils.FromBool(requestObject.CloudFrontDefaultCertificate.Value));
            }
            if (requestObject.IsSetIAMCertificateId())
            {
                context.Writer.WriteElementString("IAMCertificateId", StringUtils.FromString(requestObject.IAMCertificateId));
            }
            if (requestObject.IsSetMinimumProtocolVersion())
            {
                context.Writer.WriteElementString("MinimumProtocolVersion", StringUtils.FromString(requestObject.MinimumProtocolVersion));
            }
            if (requestObject.IsSetSSLSupportMethod())
            {
                context.Writer.WriteElementString("SSLSupportMethod", StringUtils.FromString(requestObject.SSLSupportMethod));
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ViewerCertificateMarshaller Instance = new ViewerCertificateMarshaller();
    }
}
