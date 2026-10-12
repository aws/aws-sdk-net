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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// An object that represents an Amazon EVS environment.
    /// </summary>
    public partial class Environment
    {
        /// <summary>
        /// Gets and sets the property Checks. 
        /// <para>
        /// A check on the environment to identify connector health.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Check> Checks { get; set; } = AWSConfigs.InitializeCollections ? new List<Check>() : null;

        /// <summary>
        /// Checks to see if the Checks property is set.
        /// </summary>
        internal bool IsSetChecks() => this.Checks != null && (this.Checks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectivityInfo. 
        /// <para>
        /// The connectivity configuration for the environment. Amazon EVS requires that you specify
        /// two route server peer IDs. During environment creation, the route server endpoints
        /// peer with the NSX uplink VLAN for connectivity to the NSX overlay network.
        /// </para>
        /// </summary>
        public ConnectivityInfo ConnectivityInfo { get; set; }

        /// <summary>
        /// Checks to see if the ConnectivityInfo property is set.
        /// </summary>
        internal bool IsSetConnectivityInfo() => this.ConnectivityInfo != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the environment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Secret> Credentials { get; set; } = AWSConfigs.InitializeCollections ? new List<Secret>() : null;

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null && (this.Credentials.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string EnvironmentArn { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentArn property is set.
        /// </summary>
        internal bool IsSetEnvironmentArn() => this.EnvironmentArn != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The unique ID for the environment.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property EnvironmentState. 
        /// <para>
        /// The state of an environment.
        /// </para>
        /// </summary>
        public EnvironmentState EnvironmentState { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentState property is set.
        /// </summary>
        internal bool IsSetEnvironmentState() => this.EnvironmentState != null;

        /// <summary>
        /// Gets and sets the property EnvironmentStatus. 
        /// <para>
        /// Reports impaired functionality that stems from issues internal to the environment,
        /// such as impaired reachability.
        /// </para>
        /// </summary>
        public CheckResult EnvironmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentStatus property is set.
        /// </summary>
        internal bool IsSetEnvironmentStatus() => this.EnvironmentStatus != null;

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
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LicenseInfo. 
        /// <para>
        ///  The license information that Amazon EVS requires to create an environment. Amazon
        /// EVS requires two license keys: a VCF solution key and a vSAN license key. The VCF
        /// solution key must meet minimum core requirements, and the vSAN license key must meet
        /// minimum capacity requirements for your selected instance type.
        /// </para>
        ///  
        /// <para>
        /// For information about minimum license requirements, see <a href="https://docs.aws.amazon.com/evs/latest/userguide/vcf-license-mgmt.html">the
        /// VCF subscriptions section</a> in the <i>Amazon EVS User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<LicenseInfo> LicenseInfo { get; set; } = AWSConfigs.InitializeCollections ? new List<LicenseInfo>() : null;

        /// <summary>
        /// Checks to see if the LicenseInfo property is set.
        /// </summary>
        internal bool IsSetLicenseInfo() => this.LicenseInfo != null && (this.LicenseInfo.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        ///  The date and time that the environment was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceAccessSecurityGroups. 
        /// <para>
        /// The security groups that allow traffic between the Amazon EVS control plane and your
        /// VPC for service access. If a security group is not specified, Amazon EVS uses the
        /// default security group in your account for service access.
        /// </para>
        /// </summary>
        public ServiceAccessSecurityGroups ServiceAccessSecurityGroups { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessSecurityGroups property is set.
        /// </summary>
        internal bool IsSetServiceAccessSecurityGroups() => this.ServiceAccessSecurityGroups != null;

        /// <summary>
        /// Gets and sets the property ServiceAccessSubnetId. 
        /// <para>
        ///  The subnet that is used to establish connectivity between the Amazon EVS control
        /// plane and VPC. Amazon EVS uses this subnet to perform validations and create the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 24)]
        public string ServiceAccessSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessSubnetId property is set.
        /// </summary>
        internal bool IsSetServiceAccessSubnetId() => this.ServiceAccessSubnetId != null;

        /// <summary>
        /// Gets and sets the property SiteId. 
        /// <para>
        /// The Broadcom Site ID that is associated with your Amazon EVS environment. Amazon EVS
        /// uses the Broadcom Site ID that you provide to meet Broadcom VCF license usage reporting
        /// requirements for Amazon EVS.
        /// </para>
        /// </summary>
        public string SiteId { get; set; }

        /// <summary>
        /// Checks to see if the SiteId property is set.
        /// </summary>
        internal bool IsSetSiteId() => this.SiteId != null;

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// A detailed description of the <c>environmentState</c> of an environment.
        /// </para>
        /// </summary>
        public string StateDetails { get; set; }

        /// <summary>
        /// Checks to see if the StateDetails property is set.
        /// </summary>
        internal bool IsSetStateDetails() => this.StateDetails != null;

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
        public bool? TermsAccepted { get; set; }

        /// <summary>
        /// Checks to see if the TermsAccepted property is set.
        /// </summary>
        internal bool IsSetTermsAccepted() => this.TermsAccepted.HasValue;

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
        public VcfHostnames VcfHostnames { get; set; }

        /// <summary>
        /// Checks to see if the VcfHostnames property is set.
        /// </summary>
        internal bool IsSetVcfHostnames() => this.VcfHostnames != null;

        /// <summary>
        /// Gets and sets the property VcfVersion. 
        /// <para>
        /// The VCF version of the environment.
        /// </para>
        /// </summary>
        public VcfVersion VcfVersion { get; set; }

        /// <summary>
        /// Checks to see if the VcfVersion property is set.
        /// </summary>
        internal bool IsSetVcfVersion() => this.VcfVersion != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC associated with the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 21)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
