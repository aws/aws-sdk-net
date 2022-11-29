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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVerifiedAccessEndpoint operation.
    /// An Amazon Web Services Verified Access endpoint is where you define your application
    /// along with an optional endpoint-level access policy.
    /// </summary>
    public partial class CreateVerifiedAccessEndpointRequest : AmazonEC2Request
    {
        private string _applicationDomain;
        private VerifiedAccessEndpointAttachmentType _attachmentType;
        private string _clientToken;
        private string _description;
        private string _domainCertificateArn;
        private string _endpointDomainPrefix;
        private VerifiedAccessEndpointType _endpointType;
        private CreateVerifiedAccessEndpointLoadBalancerOptions _loadBalancerOptions;
        private CreateVerifiedAccessEndpointEniOptions _networkInterfaceOptions;
        private string _policyDocument;
        private List<string> _securityGroupIds = new List<string>();
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private string _verifiedAccessGroupId;

        /// <summary>
        /// Gets and sets the property ApplicationDomain. 
        /// <para>
        /// The DNS name for users to reach your application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationDomain
        {
            get { return this._applicationDomain; }
            set { this._applicationDomain = value; }
        }

        // Check to see if ApplicationDomain property is set
        internal bool IsSetApplicationDomain()
        {
            return this._applicationDomain != null;
        }

        /// <summary>
        /// Gets and sets the property AttachmentType. 
        /// <para>
        /// The Amazon Web Services network component Verified Access attaches to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VerifiedAccessEndpointAttachmentType AttachmentType
        {
            get { return this._attachmentType; }
            set { this._attachmentType = value; }
        }

        // Check to see if AttachmentType property is set
        internal bool IsSetAttachmentType()
        {
            return this._attachmentType != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure idempotency of your modification
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Amazon Web Services Verified Access endpoint.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DomainCertificateArn. 
        /// <para>
        /// The ARN of the public TLS/SSL certificate in Amazon Web Services Certificate Manager
        /// to associate with the endpoint. The CN in the certificate must match the DNS name
        /// your end users will use to reach your application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainCertificateArn
        {
            get { return this._domainCertificateArn; }
            set { this._domainCertificateArn = value; }
        }

        // Check to see if DomainCertificateArn property is set
        internal bool IsSetDomainCertificateArn()
        {
            return this._domainCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointDomainPrefix. 
        /// <para>
        /// A custom identifier that gets prepended to a DNS name that is generated for the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EndpointDomainPrefix
        {
            get { return this._endpointDomainPrefix; }
            set { this._endpointDomainPrefix = value; }
        }

        // Check to see if EndpointDomainPrefix property is set
        internal bool IsSetEndpointDomainPrefix()
        {
            return this._endpointDomainPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of Amazon Web Services Verified Access endpoint to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VerifiedAccessEndpointType EndpointType
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
        /// Gets and sets the property LoadBalancerOptions. 
        /// <para>
        /// The load balancer details if creating the Amazon Web Services Verified Access endpoint
        /// as <code>load-balancer</code>type.
        /// </para>
        /// </summary>
        public CreateVerifiedAccessEndpointLoadBalancerOptions LoadBalancerOptions
        {
            get { return this._loadBalancerOptions; }
            set { this._loadBalancerOptions = value; }
        }

        // Check to see if LoadBalancerOptions property is set
        internal bool IsSetLoadBalancerOptions()
        {
            return this._loadBalancerOptions != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceOptions. 
        /// <para>
        /// The network interface details if creating the Amazon Web Services Verified Access
        /// endpoint as <code>network-interface</code>type.
        /// </para>
        /// </summary>
        public CreateVerifiedAccessEndpointEniOptions NetworkInterfaceOptions
        {
            get { return this._networkInterfaceOptions; }
            set { this._networkInterfaceOptions = value; }
        }

        // Check to see if NetworkInterfaceOptions property is set
        internal bool IsSetNetworkInterfaceOptions()
        {
            return this._networkInterfaceOptions != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The Amazon Web Services Verified Access policy document.
        /// </para>
        /// </summary>
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The Amazon EC2 security groups to associate with the Amazon Web Services Verified
        /// Access endpoint.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the Amazon Web Services Verified Access endpoint.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessGroupId. 
        /// <para>
        /// The ID of the Verified Access group to associate the endpoint with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VerifiedAccessGroupId
        {
            get { return this._verifiedAccessGroupId; }
            set { this._verifiedAccessGroupId = value; }
        }

        // Check to see if VerifiedAccessGroupId property is set
        internal bool IsSetVerifiedAccessGroupId()
        {
            return this._verifiedAccessGroupId != null;
        }

    }
}