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
    /// An Amazon Web Services Verified Access endpoint specifies the application that Amazon
    /// Web Services Verified Access provides access to. It must be attached to an Amazon
    /// Web Services Verified Access group. An Amazon Web Services Verified Access endpoint
    /// must also have an attached access policy before you attached it to a group.
    /// </summary>
    public partial class VerifiedAccessEndpoint
    {
        private string _applicationDomain;
        private VerifiedAccessEndpointAttachmentType _attachmentType;
        private string _creationTime;
        private string _deletionTime;
        private string _description;
        private string _deviceValidationDomain;
        private string _domainCertificateArn;
        private string _endpointDomain;
        private VerifiedAccessEndpointType _endpointType;
        private string _lastUpdatedTime;
        private VerifiedAccessEndpointLoadBalancerOptions _loadBalancerOptions;
        private VerifiedAccessEndpointEniOptions _networkInterfaceOptions;
        private List<string> _securityGroupIds = new List<string>();
        private VerifiedAccessEndpointStatus _status;
        private List<Tag> _tags = new List<Tag>();
        private string _verifiedAccessEndpointId;
        private string _verifiedAccessGroupId;
        private string _verifiedAccessInstanceId;

        /// <summary>
        /// Gets and sets the property ApplicationDomain. 
        /// <para>
        /// The DNS name for users to reach your application.
        /// </para>
        /// </summary>
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
        /// The type of attachment used to provide connectivity between the Amazon Web Services
        /// Verified Access endpoint and the application.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionTime. 
        /// <para>
        /// The deletion time.
        /// </para>
        /// </summary>
        public string DeletionTime
        {
            get { return this._deletionTime; }
            set { this._deletionTime = value; }
        }

        // Check to see if DeletionTime property is set
        internal bool IsSetDeletionTime()
        {
            return this._deletionTime != null;
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
        /// Gets and sets the property DeviceValidationDomain. 
        /// <para>
        /// Returned if endpoint has a device trust provider attached.
        /// </para>
        /// </summary>
        public string DeviceValidationDomain
        {
            get { return this._deviceValidationDomain; }
            set { this._deviceValidationDomain = value; }
        }

        // Check to see if DeviceValidationDomain property is set
        internal bool IsSetDeviceValidationDomain()
        {
            return this._deviceValidationDomain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainCertificateArn. 
        /// <para>
        /// The ARN of a public TLS/SSL certificate imported into or created with ACM.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EndpointDomain. 
        /// <para>
        /// A DNS name that is generated for the endpoint.
        /// </para>
        /// </summary>
        public string EndpointDomain
        {
            get { return this._endpointDomain; }
            set { this._endpointDomain = value; }
        }

        // Check to see if EndpointDomain property is set
        internal bool IsSetEndpointDomain()
        {
            return this._endpointDomain != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of Amazon Web Services Verified Access endpoint. Incoming application requests
        /// will be sent to an IP address, load balancer or a network interface depending on the
        /// endpoint type specified.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last updated time.
        /// </para>
        /// </summary>
        public string LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerOptions. 
        /// <para>
        /// The load balancer details if creating the Amazon Web Services Verified Access endpoint
        /// as <code>load-balancer</code>type.
        /// </para>
        /// </summary>
        public VerifiedAccessEndpointLoadBalancerOptions LoadBalancerOptions
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
        /// The options for network-interface type endpoint.
        /// </para>
        /// </summary>
        public VerifiedAccessEndpointEniOptions NetworkInterfaceOptions
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups for the endpoint.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The endpoint status.
        /// </para>
        /// </summary>
        public VerifiedAccessEndpointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessEndpointId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access endpoint.
        /// </para>
        /// </summary>
        public string VerifiedAccessEndpointId
        {
            get { return this._verifiedAccessEndpointId; }
            set { this._verifiedAccessEndpointId = value; }
        }

        // Check to see if VerifiedAccessEndpointId property is set
        internal bool IsSetVerifiedAccessEndpointId()
        {
            return this._verifiedAccessEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessGroupId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access group.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property VerifiedAccessInstanceId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access instance.
        /// </para>
        /// </summary>
        public string VerifiedAccessInstanceId
        {
            get { return this._verifiedAccessInstanceId; }
            set { this._verifiedAccessInstanceId = value; }
        }

        // Check to see if VerifiedAccessInstanceId property is set
        internal bool IsSetVerifiedAccessInstanceId()
        {
            return this._verifiedAccessInstanceId != null;
        }

    }
}