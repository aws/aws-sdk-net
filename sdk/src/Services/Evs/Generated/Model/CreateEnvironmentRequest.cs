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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEnvironment operation.
    /// Creates an Amazon EVS environment that runs VCF software, such as SDDC Manager, NSX
    /// Manager, and vCenter Server.
    /// 
    ///  
    /// <para>
    /// During environment creation, Amazon EVS performs validations on DNS settings, provisions
    /// VLAN subnets and hosts, and deploys the supplied version of VCF.
    /// </para>
    ///  
    /// <para>
    /// It can take several hours to create an environment. After the deployment completes,
    /// you can configure VCF in the vSphere user interface according to your needs.
    /// </para>
    ///  <note> 
    /// <para>
    /// You cannot use the <c>dedicatedHostId</c> and <c>placementGroupId</c> parameters together
    /// in the same <c>CreateEnvironment</c> action. This results in a <c>ValidationException</c>
    /// response.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonEvsRequest
    {
        private string _clientToken;
        private ConnectivityInfo _connectivityInfo;
        private string _environmentName;
        private List<HostInfoForCreate> _hosts = AWSConfigs.InitializeCollections ? new List<HostInfoForCreate>() : null;
        private InitialVlans _initialVlans;
        private string _kmsKeyId;
        private List<LicenseInfo> _licenseInfo = AWSConfigs.InitializeCollections ? new List<LicenseInfo>() : null;
        private ServiceAccessSecurityGroups _serviceAccessSecurityGroups;
        private string _serviceAccessSubnetId;
        private string _siteId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _termsAccepted;
        private VcfHostnames _vcfHostnames;
        private VcfVersion _vcfVersion;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// <note> 
        /// <para>
        /// This parameter is not used in Amazon EVS currently. If you supply input for this parameter,
        /// it will have no effect.
        /// </para>
        ///  </note> 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the environment creation request. If you do not specify a client token, a randomly
        /// generated token is used for the request to ensure idempotency.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property ConnectivityInfo. 
        /// <para>
        ///  The connectivity configuration for the environment. Amazon EVS requires that you
        /// specify two route server peer IDs. During environment creation, the route server endpoints
        /// peer with the NSX edges over the NSX uplink subnet, providing BGP-based dynamic routing
        /// for overlay networks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectivityInfo ConnectivityInfo
        {
            get { return this._connectivityInfo; }
            set { this._connectivityInfo = value; }
        }

        // Check to see if ConnectivityInfo property is set
        internal bool IsSetConnectivityInfo()
        {
            return this._connectivityInfo != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name to give to your environment. The name can contain only alphanumeric characters
        /// (case-sensitive), hyphens, and underscores. It must start with an alphanumeric character,
        /// and can't be longer than 100 characters. The name must be unique within the Amazon
        /// Web Services Region and Amazon Web Services account that you're creating the environment
        /// in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property Hosts. 
        /// <para>
        /// The ESXi hosts to add to the environment. Amazon EVS requires that you provide details
        /// for a minimum of 4 hosts during environment creation.
        /// </para>
        ///  
        /// <para>
        /// For each host, you must provide the desired hostname, EC2 SSH keypair name, and EC2
        /// instance type. Optionally, you can also provide a partition or cluster placement group
        /// to use, or use Amazon EC2 Dedicated Hosts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=4)]
        public List<HostInfoForCreate> Hosts
        {
            get { return this._hosts; }
            set { this._hosts = value; }
        }

        // Check to see if Hosts property is set
        internal bool IsSetHosts()
        {
            return this._hosts != null && (this._hosts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InitialVlans. 
        /// <para>
        /// The initial VLAN subnets for the Amazon EVS environment.
        /// </para>
        ///  <note> 
        /// <para>
        /// For each Amazon EVS VLAN subnet, you must specify a non-overlapping CIDR block. Amazon
        /// EVS VLAN subnets have a minimum CIDR block size of /28 and a maximum size of /24.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public InitialVlans InitialVlans
        {
            get { return this._initialVlans; }
            set { this._initialVlans = value; }
        }

        // Check to see if InitialVlans property is set
        internal bool IsSetInitialVlans()
        {
            return this._initialVlans != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// A unique ID for the customer-managed KMS key that is used to encrypt the VCF credential
        /// pairs for SDDC Manager, NSX Manager, and vCenter appliances. These credentials are
        /// stored in Amazon Web Services Secrets Manager.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseInfo. 
        /// <para>
        /// The license information that Amazon EVS requires to create an environment. Amazon
        /// EVS requires two license keys: a VCF solution key and a vSAN license key. The VCF
        /// solution key must cover a minimum of 256 cores. The vSAN license key must provide
        /// at least 110 TiB of vSAN capacity.
        /// </para>
        ///  
        /// <para>
        /// VCF licenses can be used for only one Amazon EVS environment. Amazon EVS does not
        /// support reuse of VCF licenses for multiple environments.
        /// </para>
        ///  
        /// <para>
        /// VCF license information can be retrieved from the Broadcom portal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<LicenseInfo> LicenseInfo
        {
            get { return this._licenseInfo; }
            set { this._licenseInfo = value; }
        }

        // Check to see if LicenseInfo property is set
        internal bool IsSetLicenseInfo()
        {
            return this._licenseInfo != null && (this._licenseInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessSecurityGroups. 
        /// <para>
        /// The security group that controls communication between the Amazon EVS control plane
        /// and VPC. The default security group is used if a custom security group isn't specified.
        /// </para>
        ///  
        /// <para>
        /// The security group should allow access to the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// TCP/UDP access to the DNS servers
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HTTPS/SSH access to the host management VLAN subnet
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HTTPS/SSH access to the Management VM VLAN subnet
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You should avoid modifying the security group rules after deployment, as this can
        /// break the persistent connection between the Amazon EVS control plane and VPC. This
        /// can cause future environment actions like adding or removing hosts to fail.
        /// </para>
        /// </summary>
        public ServiceAccessSecurityGroups ServiceAccessSecurityGroups
        {
            get { return this._serviceAccessSecurityGroups; }
            set { this._serviceAccessSecurityGroups = value; }
        }

        // Check to see if ServiceAccessSecurityGroups property is set
        internal bool IsSetServiceAccessSecurityGroups()
        {
            return this._serviceAccessSecurityGroups != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessSubnetId. 
        /// <para>
        /// The subnet that is used to establish connectivity between the Amazon EVS control plane
        /// and VPC. Amazon EVS uses this subnet to validate mandatory DNS records for your VCF
        /// appliances and hosts and create the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=15, Max=24)]
        public string ServiceAccessSubnetId
        {
            get { return this._serviceAccessSubnetId; }
            set { this._serviceAccessSubnetId = value; }
        }

        // Check to see if ServiceAccessSubnetId property is set
        internal bool IsSetServiceAccessSubnetId()
        {
            return this._serviceAccessSubnetId != null;
        }

        /// <summary>
        /// Gets and sets the property SiteId. 
        /// <para>
        /// The Broadcom Site ID that is allocated to you as part of your electronic software
        /// delivery. This ID allows customer access to the Broadcom portal, and is provided to
        /// you by Broadcom at the close of your software contract or contract renewal. Amazon
        /// EVS uses the Broadcom Site ID that you provide to meet Broadcom VCF license usage
        /// reporting requirements for Amazon EVS.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SiteId
        {
            get { return this._siteId; }
            set { this._siteId = value; }
        }

        // Check to see if SiteId property is set
        internal bool IsSetSiteId()
        {
            return this._siteId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that assists with categorization and organization. Each tag consists of a
        /// key and an optional value. You define both. Tags don't propagate to any other cluster
        /// or Amazon Web Services resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TermsAccepted. 
        /// <para>
        /// Customer confirmation that the customer has purchased and will continue to maintain
        /// the required number of VCF software licenses to cover all physical processor cores
        /// in the Amazon EVS environment. Information about your VCF software in Amazon EVS will
        /// be shared with Broadcom to verify license compliance. Amazon EVS does not validate
        /// license keys. To validate license keys, visit the Broadcom support portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? TermsAccepted
        {
            get { return this._termsAccepted; }
            set { this._termsAccepted = value; }
        }

        // Check to see if TermsAccepted property is set
        internal bool IsSetTermsAccepted()
        {
            return this._termsAccepted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VcfHostnames. 
        /// <para>
        /// The DNS hostnames for the virtual machines that host the VCF management appliances.
        /// Amazon EVS requires that you provide DNS hostnames for the following appliances: vCenter,
        /// NSX Manager, SDDC Manager, and Cloud Builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VcfHostnames VcfHostnames
        {
            get { return this._vcfHostnames; }
            set { this._vcfHostnames = value; }
        }

        // Check to see if VcfHostnames property is set
        internal bool IsSetVcfHostnames()
        {
            return this._vcfHostnames != null;
        }

        /// <summary>
        /// Gets and sets the property VcfVersion. 
        /// <para>
        ///  The VCF version to use for the environment. Amazon EVS only supports VCF version
        /// 5.2.1 at this time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VcfVersion VcfVersion
        {
            get { return this._vcfVersion; }
            set { this._vcfVersion = value; }
        }

        // Check to see if VcfVersion property is set
        internal bool IsSetVcfVersion()
        {
            return this._vcfVersion != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// A unique ID for the VPC that the environment is deployed inside.
        /// </para>
        ///  
        /// <para>
        /// Amazon EVS requires that all VPC subnets exist in a single Availability Zone in a
        /// Region where the service is available.
        /// </para>
        ///  
        /// <para>
        /// The VPC that you specify must have a valid DHCP option set with domain name, at least
        /// two DNS servers, and an NTP server. These settings are used to configure your VCF
        /// appliances and hosts. The VPC cannot be used with any other deployed Amazon EVS environment.
        /// Amazon EVS does not provide multi-VPC support for environments at this time.
        /// </para>
        ///  
        /// <para>
        /// Amazon EVS does not support the following Amazon Web Services networking options for
        /// NSX overlay connectivity: cross-Region VPC peering, Amazon S3 gateway endpoints, or
        /// Amazon Web Services Direct Connect virtual private gateway associations.
        /// </para>
        ///  <note> 
        /// <para>
        /// Ensure that you specify a VPC that is adequately sized to accommodate the {evws} subnets.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=21)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}