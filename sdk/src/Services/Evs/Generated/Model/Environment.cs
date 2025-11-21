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
    /// An object that represents an Amazon EVS environment.
    /// </summary>
    public partial class Environment
    {
        private List<Check> _checks = AWSConfigs.InitializeCollections ? new List<Check>() : null;
        private ConnectivityInfo _connectivityInfo;
        private DateTime? _createdAt;
        private List<Secret> _credentials = AWSConfigs.InitializeCollections ? new List<Secret>() : null;
        private string _environmentArn;
        private string _environmentId;
        private string _environmentName;
        private EnvironmentState _environmentState;
        private CheckResult _environmentStatus;
        private string _kmsKeyId;
        private List<LicenseInfo> _licenseInfo = AWSConfigs.InitializeCollections ? new List<LicenseInfo>() : null;
        private DateTime? _modifiedAt;
        private ServiceAccessSecurityGroups _serviceAccessSecurityGroups;
        private string _serviceAccessSubnetId;
        private string _siteId;
        private string _stateDetails;
        private bool? _termsAccepted;
        private VcfHostnames _vcfHostnames;
        private VcfVersion _vcfVersion;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Checks. 
        /// <para>
        /// A check on the environment to identify instance health and VMware VCF licensing issues.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Check> Checks
        {
            get { return this._checks; }
            set { this._checks = value; }
        }

        // Check to see if Checks property is set
        internal bool IsSetChecks()
        {
            return this._checks != null && (this._checks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectivityInfo. 
        /// <para>
        /// The connectivity configuration for the environment. Amazon EVS requires that you specify
        /// two route server peer IDs. During environment creation, the route server endpoints
        /// peer with the NSX uplink VLAN for connectivity to the NSX overlay network.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the environment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The VCF credentials that are stored as Amazon EVS managed secrets in Amazon Web Services
        /// Secrets Manager.
        /// </para>
        ///  
        /// <para>
        /// Amazon EVS stores credentials that are needed to install vCenter Server, NSX, and
        /// SDDC Manager.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Secret> Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null && (this._credentials.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string EnvironmentArn
        {
            get { return this._environmentArn; }
            set { this._environmentArn = value; }
        }

        // Check to see if EnvironmentArn property is set
        internal bool IsSetEnvironmentArn()
        {
            return this._environmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The unique ID for the environment.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment.
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
        /// Gets and sets the property EnvironmentState. 
        /// <para>
        /// The state of an environment.
        /// </para>
        /// </summary>
        public EnvironmentState EnvironmentState
        {
            get { return this._environmentState; }
            set { this._environmentState = value; }
        }

        // Check to see if EnvironmentState property is set
        internal bool IsSetEnvironmentState()
        {
            return this._environmentState != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentStatus. 
        /// <para>
        /// Reports impaired functionality that stems from issues internal to the environment,
        /// such as impaired reachability.
        /// </para>
        /// </summary>
        public CheckResult EnvironmentStatus
        {
            get { return this._environmentStatus; }
            set { this._environmentStatus = value; }
        }

        // Check to see if EnvironmentStatus property is set
        internal bool IsSetEnvironmentStatus()
        {
            return this._environmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key ID that Amazon Web Services Secrets Manager uses to
        /// encrypt secrets that are associated with the environment. These secrets contain the
        /// VCF credentials that are needed to install vCenter Server, NSX, and SDDC Manager.
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon EVS use the Amazon Web Services Secrets Manager managed key <c>aws/secretsmanager</c>.
        /// You can also specify a customer managed key.
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
        ///  The license information that Amazon EVS requires to create an environment. Amazon
        /// EVS requires two license keys: a VCF solution key and a vSAN license key. The VCF
        /// solution key must cover a minimum of 256 cores. The vSAN license key must provide
        /// at least 110 TiB of vSAN capacity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        ///  The date and time that the environment was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessSecurityGroups. 
        /// <para>
        /// The security groups that allow traffic between the Amazon EVS control plane and your
        /// VPC for service access. If a security group is not specified, Amazon EVS uses the
        /// default security group in your account for service access.
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
        ///  The subnet that is used to establish connectivity between the Amazon EVS control
        /// plane and VPC. Amazon EVS uses this subnet to perform validations and create the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=24)]
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
        /// The Broadcom Site ID that is associated with your Amazon EVS environment. Amazon EVS
        /// uses the Broadcom Site ID that you provide to meet Broadcom VCF license usage reporting
        /// requirements for Amazon EVS.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// A detailed description of the <c>environmentState</c> of an environment.
        /// </para>
        /// </summary>
        public string StateDetails
        {
            get { return this._stateDetails; }
            set { this._stateDetails = value; }
        }

        // Check to see if StateDetails property is set
        internal bool IsSetStateDetails()
        {
            return this._stateDetails != null;
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
        /// The DNS hostnames to be used by the VCF management appliances in your environment.
        /// </para>
        ///  
        /// <para>
        /// For environment creation to be successful, each hostname entry must resolve to a domain
        /// name that you've registered in your DNS service of choice and configured in the DHCP
        /// option set of your VPC. DNS hostnames cannot be changed after environment creation
        /// has started.
        /// </para>
        /// </summary>
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
        /// The VCF version of the environment.
        /// </para>
        /// </summary>
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
        /// The VPC associated with the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=21)]
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