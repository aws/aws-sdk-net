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

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVerifiedAccessEndpoint operation. An Amazon
    /// Web Services Verified Access endpoint is where you define your application along with
    /// an optional endpoint-level access policy.
    /// </summary>
    public partial class CreateVerifiedAccessEndpointRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ApplicationDomain. 
        /// <para>
        /// The DNS name for users to reach your application.
        /// </para>
        /// </summary>
        public string ApplicationDomain { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationDomain property is set.
        /// </summary>
        internal bool IsSetApplicationDomain() => this.ApplicationDomain != null;

        /// <summary>
        /// Gets and sets the property AttachmentType. 
        /// <para>
        /// The type of attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VerifiedAccessEndpointAttachmentType AttachmentType { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentType property is set.
        /// </summary>
        internal bool IsSetAttachmentType() => this.AttachmentType != null;

        /// <summary>
        /// Gets and sets the property CidrOptions. 
        /// <para>
        /// The CIDR options. This parameter is required if the endpoint type is <c>cidr</c>.
        /// </para>
        /// </summary>
        public CreateVerifiedAccessEndpointCidrOptions CidrOptions { get; set; }

        /// <summary>
        /// Checks to see if the CidrOptions property is set.
        /// </summary>
        internal bool IsSetCidrOptions() => this.CidrOptions != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure idempotency of your modification
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Verified Access endpoint.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainCertificateArn. 
        /// <para>
        /// The ARN of the public TLS/SSL certificate in Amazon Web Services Certificate Manager
        /// to associate with the endpoint. The CN in the certificate must match the DNS name
        /// your end users will use to reach your application.
        /// </para>
        /// </summary>
        public string DomainCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the DomainCertificateArn property is set.
        /// </summary>
        internal bool IsSetDomainCertificateArn() => this.DomainCertificateArn != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointDomainPrefix. 
        /// <para>
        /// A custom identifier that is prepended to the DNS name that is generated for the endpoint.
        /// </para>
        /// </summary>
        public string EndpointDomainPrefix { get; set; }

        /// <summary>
        /// Checks to see if the EndpointDomainPrefix property is set.
        /// </summary>
        internal bool IsSetEndpointDomainPrefix() => this.EndpointDomainPrefix != null;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of Verified Access endpoint to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VerifiedAccessEndpointType EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerOptions. 
        /// <para>
        /// The load balancer details. This parameter is required if the endpoint type is <c>load-balancer</c>.
        /// </para>
        /// </summary>
        public CreateVerifiedAccessEndpointLoadBalancerOptions LoadBalancerOptions { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerOptions property is set.
        /// </summary>
        internal bool IsSetLoadBalancerOptions() => this.LoadBalancerOptions != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceOptions. 
        /// <para>
        /// The network interface details. This parameter is required if the endpoint type is
        /// <c>network-interface</c>.
        /// </para>
        /// </summary>
        public CreateVerifiedAccessEndpointEniOptions NetworkInterfaceOptions { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceOptions property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceOptions() => this.NetworkInterfaceOptions != null;

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The Verified Access policy document.
        /// </para>
        /// </summary>
        public string PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDocument property is set.
        /// </summary>
        internal bool IsSetPolicyDocument() => this.PolicyDocument != null;

        /// <summary>
        /// Gets and sets the property RdsOptions. 
        /// <para>
        /// The RDS details. This parameter is required if the endpoint type is <c>rds</c>.
        /// </para>
        /// </summary>
        public CreateVerifiedAccessEndpointRdsOptions RdsOptions { get; set; }

        /// <summary>
        /// Checks to see if the RdsOptions property is set.
        /// </summary>
        internal bool IsSetRdsOptions() => this.RdsOptions != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups to associate with the Verified Access endpoint. Required
        /// if <c>AttachmentType</c> is set to <c>vpc</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SseSpecification. 
        /// <para>
        /// The options for server side encryption.
        /// </para>
        /// </summary>
        public VerifiedAccessSseSpecificationRequest SseSpecification { get; set; }

        /// <summary>
        /// Checks to see if the SseSpecification property is set.
        /// </summary>
        internal bool IsSetSseSpecification() => this.SseSpecification != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the Verified Access endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VerifiedAccessGroupId. 
        /// <para>
        /// The ID of the Verified Access group to associate the endpoint with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VerifiedAccessGroupId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessGroupId property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessGroupId() => this.VerifiedAccessGroupId != null;
    }
}
