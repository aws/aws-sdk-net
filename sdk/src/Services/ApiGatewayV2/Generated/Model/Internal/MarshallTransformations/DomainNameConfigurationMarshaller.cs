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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DomainNameConfiguration Marshaller
    /// </summary>
    public class DomainNameConfigurationMarshaller : IRequestMarshaller<DomainNameConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DomainNameConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApiGatewayDomainName())
            {
                context.Writer.WritePropertyName("apiGatewayDomainName");
                context.Writer.WriteStringValue(requestObject.ApiGatewayDomainName);
            }

            if(requestObject.IsSetCertificateArn())
            {
                context.Writer.WritePropertyName("certificateArn");
                context.Writer.WriteStringValue(requestObject.CertificateArn);
            }

            if(requestObject.IsSetCertificateName())
            {
                context.Writer.WritePropertyName("certificateName");
                context.Writer.WriteStringValue(requestObject.CertificateName);
            }

            if(requestObject.IsSetCertificateUploadDate())
            {
                context.Writer.WritePropertyName("certificateUploadDate");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.CertificateUploadDate));
            }

            if(requestObject.IsSetDomainNameStatus())
            {
                context.Writer.WritePropertyName("domainNameStatus");
                context.Writer.WriteStringValue(requestObject.DomainNameStatus);
            }

            if(requestObject.IsSetDomainNameStatusMessage())
            {
                context.Writer.WritePropertyName("domainNameStatusMessage");
                context.Writer.WriteStringValue(requestObject.DomainNameStatusMessage);
            }

            if(requestObject.IsSetEndpointType())
            {
                context.Writer.WritePropertyName("endpointType");
                context.Writer.WriteStringValue(requestObject.EndpointType);
            }

            if(requestObject.IsSetHostedZoneId())
            {
                context.Writer.WritePropertyName("hostedZoneId");
                context.Writer.WriteStringValue(requestObject.HostedZoneId);
            }

            if(requestObject.IsSetIpAddressType())
            {
                context.Writer.WritePropertyName("ipAddressType");
                context.Writer.WriteStringValue(requestObject.IpAddressType);
            }

            if(requestObject.IsSetOwnershipVerificationCertificateArn())
            {
                context.Writer.WritePropertyName("ownershipVerificationCertificateArn");
                context.Writer.WriteStringValue(requestObject.OwnershipVerificationCertificateArn);
            }

            if(requestObject.IsSetSecurityPolicy())
            {
                context.Writer.WritePropertyName("securityPolicy");
                context.Writer.WriteStringValue(requestObject.SecurityPolicy);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DomainNameConfigurationMarshaller Instance = new DomainNameConfigurationMarshaller();

    }
}