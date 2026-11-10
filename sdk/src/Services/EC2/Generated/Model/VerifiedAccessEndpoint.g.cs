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
    /// An Amazon Web Services Verified Access endpoint specifies the application that Amazon
    /// Web Services Verified Access provides access to. It must be attached to an Amazon
    /// Web Services Verified Access group. An Amazon Web Services Verified Access endpoint
    /// must also have an attached access policy before you attached it to a group.
    /// </summary>
    public partial class VerifiedAccessEndpoint
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
        /// The type of attachment used to provide connectivity between the Amazon Web Services
        /// Verified Access endpoint and the application.
        /// </para>
        /// </summary>
        public VerifiedAccessEndpointAttachmentType AttachmentType { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentType property is set.
        /// </summary>
        internal bool IsSetAttachmentType() => this.AttachmentType != null;

        /// <summary>
        /// Gets and sets the property CidrOptions. 
        /// <para>
        /// The options for a CIDR endpoint.
        /// </para>
        /// </summary>
        public VerifiedAccessEndpointCidrOptions CidrOptions { get; set; }

        /// <summary>
        /// Checks to see if the CidrOptions property is set.
        /// </summary>
        internal bool IsSetCidrOptions() => this.CidrOptions != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property DeletionTime. 
        /// <para>
        /// The deletion time.
        /// </para>
        /// </summary>
        public string DeletionTime { get; set; }

        /// <summary>
        /// Checks to see if the DeletionTime property is set.
        /// </summary>
        internal bool IsSetDeletionTime() => this.DeletionTime != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Amazon Web Services Verified Access endpoint.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceValidationDomain. 
        /// <para>
        /// Returned if endpoint has a device trust provider attached.
        /// </para>
        /// </summary>
        public string DeviceValidationDomain { get; set; }

        /// <summary>
        /// Checks to see if the DeviceValidationDomain property is set.
        /// </summary>
        internal bool IsSetDeviceValidationDomain() => this.DeviceValidationDomain != null;

        /// <summary>
        /// Gets and sets the property DomainCertificateArn. 
        /// <para>
        /// The ARN of a public TLS/SSL certificate imported into or created with ACM.
        /// </para>
        /// </summary>
        public string DomainCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the DomainCertificateArn property is set.
        /// </summary>
        internal bool IsSetDomainCertificateArn() => this.DomainCertificateArn != null;

        /// <summary>
        /// Gets and sets the property EndpointDomain. 
        /// <para>
        /// A DNS name that is generated for the endpoint.
        /// </para>
        /// </summary>
        public string EndpointDomain { get; set; }

        /// <summary>
        /// Checks to see if the EndpointDomain property is set.
        /// </summary>
        internal bool IsSetEndpointDomain() => this.EndpointDomain != null;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of Amazon Web Services Verified Access endpoint. Incoming application requests
        /// will be sent to an IP address, load balancer or a network interface depending on the
        /// endpoint type specified.
        /// </para>
        /// </summary>
        public VerifiedAccessEndpointType EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last updated time.
        /// </para>
        /// </summary>
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerOptions. 
        /// <para>
        /// The load balancer details if creating the Amazon Web Services Verified Access endpoint
        /// as <c>load-balancer</c>type.
        /// </para>
        /// </summary>
        public VerifiedAccessEndpointLoadBalancerOptions LoadBalancerOptions { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerOptions property is set.
        /// </summary>
        internal bool IsSetLoadBalancerOptions() => this.LoadBalancerOptions != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceOptions. 
        /// <para>
        /// The options for network-interface type endpoint.
        /// </para>
        /// </summary>
        public VerifiedAccessEndpointEniOptions NetworkInterfaceOptions { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceOptions property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceOptions() => this.NetworkInterfaceOptions != null;

        /// <summary>
        /// Gets and sets the property RdsOptions. 
        /// <para>
        /// The options for an RDS endpoint.
        /// </para>
        /// </summary>
        public VerifiedAccessEndpointRdsOptions RdsOptions { get; set; }

        /// <summary>
        /// Checks to see if the RdsOptions property is set.
        /// </summary>
        internal bool IsSetRdsOptions() => this.RdsOptions != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups for the endpoint.
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
        /// The options in use for server side encryption.
        /// </para>
        /// </summary>
        public VerifiedAccessSseSpecificationResponse SseSpecification { get; set; }

        /// <summary>
        /// Checks to see if the SseSpecification property is set.
        /// </summary>
        internal bool IsSetSseSpecification() => this.SseSpecification != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The endpoint status.
        /// </para>
        /// </summary>
        public VerifiedAccessEndpointStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VerifiedAccessEndpointId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access endpoint.
        /// </para>
        /// </summary>
        public string VerifiedAccessEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessEndpointId property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessEndpointId() => this.VerifiedAccessEndpointId != null;

        /// <summary>
        /// Gets and sets the property VerifiedAccessGroupId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access group.
        /// </para>
        /// </summary>
        public string VerifiedAccessGroupId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessGroupId property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessGroupId() => this.VerifiedAccessGroupId != null;

        /// <summary>
        /// Gets and sets the property VerifiedAccessInstanceId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access instance.
        /// </para>
        /// </summary>
        public string VerifiedAccessInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessInstanceId property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessInstanceId() => this.VerifiedAccessInstanceId != null;
    }
}
