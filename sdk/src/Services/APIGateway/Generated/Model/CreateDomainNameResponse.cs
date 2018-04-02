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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents a custom domain name as a user-friendly host name of an API (<a>RestApi</a>).
    /// 
    ///  <div class="Remarks"> 
    /// <para>
    /// When you deploy an API, API Gateway creates a default host name for the API. This
    /// default API host name is of the <code>{restapi-id}.execute-api.{region}.amazonaws.com</code>
    /// format. With the default host name, you can access the API's root resource with the
    /// URL of <code>https://{restapi-id}.execute-api.{region}.amazonaws.com/{stage}/</code>.
    /// When you set up a custom domain name of <code>apis.example.com</code> for this API,
    /// you can then access the same resource using the URL of the <code>https://apis.examples.com/myApi</code>,
    /// where <code>myApi</code> is the base path mapping (<a>BasePathMapping</a>) of your
    /// API under the custom domain name. 
    /// </para>
    ///  </div> <div class="seeAlso"> <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/how-to-custom-domains.html">Set
    /// a Custom Host Name for an API</a> </div>
    /// </summary>
    public partial class CreateDomainNameResponse : AmazonWebServiceResponse
    {
        private string _certificateArn;
        private string _certificateName;
        private DateTime? _certificateUploadDate;
        private string _distributionDomainName;
        private string _distributionHostedZoneId;
        private EndpointConfiguration _endpointConfiguration;
        private string _name;
        private string _regionalCertificateArn;
        private string _regionalCertificateName;
        private string _regionalDomainName;
        private string _regionalHostedZoneId;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The reference to an AWS-managed certificate that will be used by edge-optimized endpoint
        /// for this domain name. AWS Certificate Manager is the only supported source.
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
        /// The name of the certificate that will be used by edge-optimized endpoint for this
        /// domain name.
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
        /// Gets and sets the property DistributionDomainName. 
        /// <para>
        /// The domain name of the Amazon CloudFront distribution associated with this custom
        /// domain name for an edge-optimized endpoint. You set up this association when adding
        /// a DNS record pointing the custom domain name to this distribution name. For more information
        /// about CloudFront distributions, see the <a href="http://aws.amazon.com/documentation/cloudfront/"
        /// target="_blank">Amazon CloudFront documentation</a>.
        /// </para>
        /// </summary>
        public string DistributionDomainName
        {
            get { return this._distributionDomainName; }
            set { this._distributionDomainName = value; }
        }

        // Check to see if DistributionDomainName property is set
        internal bool IsSetDistributionDomainName()
        {
            return this._distributionDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionHostedZoneId. 
        /// <para>
        /// The region-agnostic Amazon Route 53 Hosted Zone ID of the edge-optimized endpoint.
        /// The valid value is <code>Z2FDTNDATAQYW2</code> for all the regions. For more information,
        /// see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-regional-api-custom-domain-create.html">Set
        /// up a Regional Custom Domain Name</a> and <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#apigateway_region">AWS
        /// Regions and Endpoints for API Gateway</a>. 
        /// </para>
        /// </summary>
        public string DistributionHostedZoneId
        {
            get { return this._distributionHostedZoneId; }
            set { this._distributionHostedZoneId = value; }
        }

        // Check to see if DistributionHostedZoneId property is set
        internal bool IsSetDistributionHostedZoneId()
        {
            return this._distributionHostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// The endpoint configuration of this <a>DomainName</a> showing the endpoint types of
        /// the domain name. 
        /// </para>
        /// </summary>
        public EndpointConfiguration EndpointConfiguration
        {
            get { return this._endpointConfiguration; }
            set { this._endpointConfiguration = value; }
        }

        // Check to see if EndpointConfiguration property is set
        internal bool IsSetEndpointConfiguration()
        {
            return this._endpointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The custom domain name as an API host name, for example, <code>my-api.example.com</code>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RegionalCertificateArn. 
        /// <para>
        /// The reference to an AWS-managed certificate that will be used for validating the regional
        /// domain name. AWS Certificate Manager is the only supported source.
        /// </para>
        /// </summary>
        public string RegionalCertificateArn
        {
            get { return this._regionalCertificateArn; }
            set { this._regionalCertificateArn = value; }
        }

        // Check to see if RegionalCertificateArn property is set
        internal bool IsSetRegionalCertificateArn()
        {
            return this._regionalCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegionalCertificateName. 
        /// <para>
        /// The name of the certificate that will be used for validating the regional domain name.
        /// </para>
        /// </summary>
        public string RegionalCertificateName
        {
            get { return this._regionalCertificateName; }
            set { this._regionalCertificateName = value; }
        }

        // Check to see if RegionalCertificateName property is set
        internal bool IsSetRegionalCertificateName()
        {
            return this._regionalCertificateName != null;
        }

        /// <summary>
        /// Gets and sets the property RegionalDomainName. 
        /// <para>
        /// The domain name associated with the regional endpoint for this custom domain name.
        /// You set up this association by adding a DNS record that points the custom domain name
        /// to this regional domain name. The regional domain name is returned by API Gateway
        /// when you create a regional endpoint.
        /// </para>
        /// </summary>
        public string RegionalDomainName
        {
            get { return this._regionalDomainName; }
            set { this._regionalDomainName = value; }
        }

        // Check to see if RegionalDomainName property is set
        internal bool IsSetRegionalDomainName()
        {
            return this._regionalDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property RegionalHostedZoneId. 
        /// <para>
        /// The region-specific Amazon Route 53 Hosted Zone ID of the regional endpoint. For more
        /// information, see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-regional-api-custom-domain-create.html">Set
        /// up a Regional Custom Domain Name</a> and <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#apigateway_region">AWS
        /// Regions and Endpoints for API Gateway</a>. 
        /// </para>
        /// </summary>
        public string RegionalHostedZoneId
        {
            get { return this._regionalHostedZoneId; }
            set { this._regionalHostedZoneId = value; }
        }

        // Check to see if RegionalHostedZoneId property is set
        internal bool IsSetRegionalHostedZoneId()
        {
            return this._regionalHostedZoneId != null;
        }

    }
}