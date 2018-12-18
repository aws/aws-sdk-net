/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// The domain name configuration.
    /// </summary>
    public partial class DomainNameConfiguration
    {
        private string _apiGatewayDomainName;
        private string _certificateArn;
        private string _certificateName;
        private DateTime? _certificateUploadDate;
        private EndpointType _endpointType;
        private string _hostedZoneId;

        /// <summary>
        /// Gets and sets the property ApiGatewayDomainName. 
        /// <para>
        /// A domain name for the WebSocket API.
        /// </para>
        /// </summary>
        public string ApiGatewayDomainName
        {
            get { return this._apiGatewayDomainName; }
            set { this._apiGatewayDomainName = value; }
        }

        // Check to see if ApiGatewayDomainName property is set
        internal bool IsSetApiGatewayDomainName()
        {
            return this._apiGatewayDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// An AWS-managed certificate that will be used by the edge-optimized endpoint for this
        /// domain name. AWS Certificate Manager is the only supported source.
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The user-friendly name of the certificate that will be used by the edge-optimized
        /// endpoint for this domain name.
        /// </para>
        /// </summary>
        public string CertificateName
        {
            get { return this._certificateName; }
            set { this._certificateName = value; }
        }

        // Check to see if CertificateName property is set
        internal bool IsSetCertificateName()
        {
            return this._certificateName != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateUploadDate. 
        /// <para>
        /// The timestamp when the certificate that was used by edge-optimized endpoint for this
        /// domain name was uploaded.
        /// </para>
        /// </summary>
        public DateTime CertificateUploadDate
        {
            get { return this._certificateUploadDate.GetValueOrDefault(); }
            set { this._certificateUploadDate = value; }
        }

        // Check to see if CertificateUploadDate property is set
        internal bool IsSetCertificateUploadDate()
        {
            return this._certificateUploadDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The endpoint type.
        /// </para>
        /// </summary>
        public EndpointType EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The Amazon Route 53 Hosted Zone ID of the endpoint. See <a href="docs.aws.amazon.com/general/latest/gr/rande.html#apigateway_region">AWS
        /// Regions and Endpoints for API Gateway</a>.
        /// </para>
        /// </summary>
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

    }
}