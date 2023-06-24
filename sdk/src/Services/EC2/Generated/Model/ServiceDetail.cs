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
    /// Describes a VPC endpoint service.
    /// </summary>
    public partial class ServiceDetail
    {
        private bool? _acceptanceRequired;
        private List<string> _availabilityZones = new List<string>();
        private List<string> _baseEndpointDnsNames = new List<string>();
        private bool? _managesVpcEndpoints;
        private string _owner;
        private PayerResponsibility _payerResponsibility;
        private string _privateDnsName;
        private List<PrivateDnsDetails> _privateDnsNames = new List<PrivateDnsDetails>();
        private DnsNameState _privateDnsNameVerificationState;
        private string _serviceId;
        private string _serviceName;
        private List<ServiceTypeDetail> _serviceType = new List<ServiceTypeDetail>();
        private List<string> _supportedIpAddressTypes = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private bool? _vpcEndpointPolicySupported;

        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// Indicates whether VPC endpoint connection requests to the service must be accepted
        /// by the service owner.
        /// </para>
        /// </summary>
        public bool AcceptanceRequired
        {
            get { return this._acceptanceRequired.GetValueOrDefault(); }
            set { this._acceptanceRequired = value; }
        }

        // Check to see if AcceptanceRequired property is set
        internal bool IsSetAcceptanceRequired()
        {
            return this._acceptanceRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones in which the service is available.
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BaseEndpointDnsNames. 
        /// <para>
        /// The DNS names for the service.
        /// </para>
        /// </summary>
        public List<string> BaseEndpointDnsNames
        {
            get { return this._baseEndpointDnsNames; }
            set { this._baseEndpointDnsNames = value; }
        }

        // Check to see if BaseEndpointDnsNames property is set
        internal bool IsSetBaseEndpointDnsNames()
        {
            return this._baseEndpointDnsNames != null && this._baseEndpointDnsNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ManagesVpcEndpoints. 
        /// <para>
        /// Indicates whether the service manages its VPC endpoints. Management of the service
        /// VPC endpoints using the VPC endpoint API is restricted.
        /// </para>
        /// </summary>
        public bool ManagesVpcEndpoints
        {
            get { return this._managesVpcEndpoints.GetValueOrDefault(); }
            set { this._managesVpcEndpoints = value; }
        }

        // Check to see if ManagesVpcEndpoints property is set
        internal bool IsSetManagesVpcEndpoints()
        {
            return this._managesVpcEndpoints.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services account ID of the service owner.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property PayerResponsibility. 
        /// <para>
        /// The payer responsibility.
        /// </para>
        /// </summary>
        public PayerResponsibility PayerResponsibility
        {
            get { return this._payerResponsibility; }
            set { this._payerResponsibility = value; }
        }

        // Check to see if PayerResponsibility property is set
        internal bool IsSetPayerResponsibility()
        {
            return this._payerResponsibility != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsName. 
        /// <para>
        /// The private DNS name for the service.
        /// </para>
        /// </summary>
        public string PrivateDnsName
        {
            get { return this._privateDnsName; }
            set { this._privateDnsName = value; }
        }

        // Check to see if PrivateDnsName property is set
        internal bool IsSetPrivateDnsName()
        {
            return this._privateDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsNames. 
        /// <para>
        /// The private DNS names assigned to the VPC endpoint service.
        /// </para>
        /// </summary>
        public List<PrivateDnsDetails> PrivateDnsNames
        {
            get { return this._privateDnsNames; }
            set { this._privateDnsNames = value; }
        }

        // Check to see if PrivateDnsNames property is set
        internal bool IsSetPrivateDnsNames()
        {
            return this._privateDnsNames != null && this._privateDnsNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsNameVerificationState. 
        /// <para>
        /// The verification state of the VPC endpoint service.
        /// </para>
        ///  
        /// <para>
        /// Consumers of the endpoint service cannot use the private name when the state is not
        /// <code>verified</code>.
        /// </para>
        /// </summary>
        public DnsNameState PrivateDnsNameVerificationState
        {
            get { return this._privateDnsNameVerificationState; }
            set { this._privateDnsNameVerificationState = value; }
        }

        // Check to see if PrivateDnsNameVerificationState property is set
        internal bool IsSetPrivateDnsNameVerificationState()
        {
            return this._privateDnsNameVerificationState != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the endpoint service.
        /// </para>
        /// </summary>
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The type of service.
        /// </para>
        /// </summary>
        public List<ServiceTypeDetail> ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        // Check to see if ServiceType property is set
        internal bool IsSetServiceType()
        {
            return this._serviceType != null && this._serviceType.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedIpAddressTypes. 
        /// <para>
        /// The supported IP address types.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> SupportedIpAddressTypes
        {
            get { return this._supportedIpAddressTypes; }
            set { this._supportedIpAddressTypes = value; }
        }

        // Check to see if SupportedIpAddressTypes property is set
        internal bool IsSetSupportedIpAddressTypes()
        {
            return this._supportedIpAddressTypes != null && this._supportedIpAddressTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the service.
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
        /// Gets and sets the property VpcEndpointPolicySupported. 
        /// <para>
        /// Indicates whether the service supports endpoint policies.
        /// </para>
        /// </summary>
        public bool VpcEndpointPolicySupported
        {
            get { return this._vpcEndpointPolicySupported.GetValueOrDefault(); }
            set { this._vpcEndpointPolicySupported = value; }
        }

        // Check to see if VpcEndpointPolicySupported property is set
        internal bool IsSetVpcEndpointPolicySupported()
        {
            return this._vpcEndpointPolicySupported.HasValue; 
        }

    }
}