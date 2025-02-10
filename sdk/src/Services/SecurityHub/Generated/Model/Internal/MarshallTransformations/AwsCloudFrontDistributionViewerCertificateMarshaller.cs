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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsCloudFrontDistributionViewerCertificate Marshaller
    /// </summary>
    public class AwsCloudFrontDistributionViewerCertificateMarshaller : IRequestMarshaller<AwsCloudFrontDistributionViewerCertificate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsCloudFrontDistributionViewerCertificate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAcmCertificateArn())
            {
                context.Writer.WritePropertyName("AcmCertificateArn");
                context.Writer.WriteStringValue(requestObject.AcmCertificateArn);
            }

            if(requestObject.IsSetCertificate())
            {
                context.Writer.WritePropertyName("Certificate");
                context.Writer.WriteStringValue(requestObject.Certificate);
            }

            if(requestObject.IsSetCertificateSource())
            {
                context.Writer.WritePropertyName("CertificateSource");
                context.Writer.WriteStringValue(requestObject.CertificateSource);
            }

            if(requestObject.IsSetCloudFrontDefaultCertificate())
            {
                context.Writer.WritePropertyName("CloudFrontDefaultCertificate");
                context.Writer.WriteBooleanValue(requestObject.CloudFrontDefaultCertificate.Value);
            }

            if(requestObject.IsSetIamCertificateId())
            {
                context.Writer.WritePropertyName("IamCertificateId");
                context.Writer.WriteStringValue(requestObject.IamCertificateId);
            }

            if(requestObject.IsSetMinimumProtocolVersion())
            {
                context.Writer.WritePropertyName("MinimumProtocolVersion");
                context.Writer.WriteStringValue(requestObject.MinimumProtocolVersion);
            }

            if(requestObject.IsSetSslSupportMethod())
            {
                context.Writer.WritePropertyName("SslSupportMethod");
                context.Writer.WriteStringValue(requestObject.SslSupportMethod);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsCloudFrontDistributionViewerCertificateMarshaller Instance = new AwsCloudFrontDistributionViewerCertificateMarshaller();

    }
}