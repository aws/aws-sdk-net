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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDomain operation.
    /// Creates a <code>Domain</code> used by Amazon SageMaker Studio. A domain consists of
    /// an associated Amazon Elastic File System (EFS) volume, a list of authorized users,
    /// and a variety of security, application, policy, and Amazon Virtual Private Cloud (VPC)
    /// configurations. An Amazon Web Services account is limited to one domain per region.
    /// Users within a domain can share notebook files and other artifacts with each other.
    /// 
    ///  
    /// <para>
    ///  <b>EFS storage</b> 
    /// </para>
    ///  
    /// <para>
    /// When a domain is created, an EFS volume is created for use by all of the users within
    /// the domain. Each user receives a private home directory within the EFS volume for
    /// notebooks, Git repositories, and data files.
    /// </para>
    ///  
    /// <para>
    /// SageMaker uses the Amazon Web Services Key Management Service (Amazon Web Services
    /// KMS) to encrypt the EFS volume attached to the domain with an Amazon Web Services
    /// managed key by default. For more control, you can specify a customer managed key.
    /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/encryption-at-rest.html">Protect
    /// Data at Rest Using Encryption</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>VPC configuration</b> 
    /// </para>
    ///  
    /// <para>
    /// All SageMaker Studio traffic between the domain and the EFS volume is through the
    /// specified VPC and subnets. For other Studio traffic, you can specify the <code>AppNetworkAccessType</code>
    /// parameter. <code>AppNetworkAccessType</code> corresponds to the network access type
    /// that you choose when you onboard to Studio. The following options are available:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>PublicInternetOnly</code> - Non-EFS traffic goes through a VPC managed by Amazon
    /// SageMaker, which allows internet access. This is the default value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>VpcOnly</code> - All Studio traffic is through the specified VPC and subnets.
    /// Internet access is disabled by default. To allow internet access, you must specify
    /// a NAT gateway.
    /// </para>
    ///  
    /// <para>
    /// When internet access is disabled, you won't be able to run a Studio notebook or to
    /// train or host models unless your VPC has an interface endpoint to the SageMaker API
    /// and runtime or a NAT gateway and your security groups allow outbound connections.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// NFS traffic over TCP on port 2049 needs to be allowed in both inbound and outbound
    /// rules in order to launch a SageMaker Studio app successfully.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-notebooks-and-internet-access.html">Connect
    /// SageMaker Studio Notebooks to Resources in a VPC</a>.
    /// </para>
    /// </summary>
    public partial class CreateDomainRequest : AmazonSageMakerRequest
    {
        private AppNetworkAccessType _appNetworkAccessType;
        private AppSecurityGroupManagement _appSecurityGroupManagement;
        private AuthMode _authMode;
        private DefaultSpaceSettings _defaultSpaceSettings;
        private UserSettings _defaultUserSettings;
        private string _domainName;
        private DomainSettings _domainSettings;
        private string _homeEfsFileSystemKmsKeyId;
        private string _kmsKeyId;
        private List<string> _subnetIds = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AppNetworkAccessType. 
        /// <para>
        /// Specifies the VPC used for non-EFS traffic. The default value is <code>PublicInternetOnly</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PublicInternetOnly</code> - Non-EFS traffic is through a VPC managed by Amazon
        /// SageMaker, which allows direct internet access
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VpcOnly</code> - All Studio traffic is through the specified VPC and subnets
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AppNetworkAccessType AppNetworkAccessType
        {
            get { return this._appNetworkAccessType; }
            set { this._appNetworkAccessType = value; }
        }

        // Check to see if AppNetworkAccessType property is set
        internal bool IsSetAppNetworkAccessType()
        {
            return this._appNetworkAccessType != null;
        }

        /// <summary>
        /// Gets and sets the property AppSecurityGroupManagement. 
        /// <para>
        /// The entity that creates and manages the required security groups for inter-app communication
        /// in <code>VPCOnly</code> mode. Required when <code>CreateDomain.AppNetworkAccessType</code>
        /// is <code>VPCOnly</code> and <code>DomainSettings.RStudioServerProDomainSettings.DomainExecutionRoleArn</code>
        /// is provided.
        /// </para>
        /// </summary>
        public AppSecurityGroupManagement AppSecurityGroupManagement
        {
            get { return this._appSecurityGroupManagement; }
            set { this._appSecurityGroupManagement = value; }
        }

        // Check to see if AppSecurityGroupManagement property is set
        internal bool IsSetAppSecurityGroupManagement()
        {
            return this._appSecurityGroupManagement != null;
        }

        /// <summary>
        /// Gets and sets the property AuthMode. 
        /// <para>
        /// The mode of authentication that members use to access the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthMode AuthMode
        {
            get { return this._authMode; }
            set { this._authMode = value; }
        }

        // Check to see if AuthMode property is set
        internal bool IsSetAuthMode()
        {
            return this._authMode != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultSpaceSettings. 
        /// <para>
        /// The default settings used to create a space.
        /// </para>
        /// </summary>
        public DefaultSpaceSettings DefaultSpaceSettings
        {
            get { return this._defaultSpaceSettings; }
            set { this._defaultSpaceSettings = value; }
        }

        // Check to see if DefaultSpaceSettings property is set
        internal bool IsSetDefaultSpaceSettings()
        {
            return this._defaultSpaceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultUserSettings. 
        /// <para>
        /// The default settings to use to create a user profile when <code>UserSettings</code>
        /// isn't specified in the call to the <code>CreateUserProfile</code> API.
        /// </para>
        ///  
        /// <para>
        ///  <code>SecurityGroups</code> is aggregated when specified in both calls. For all other
        /// settings in <code>UserSettings</code>, the values specified in <code>CreateUserProfile</code>
        /// take precedence over those specified in <code>CreateDomain</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserSettings DefaultUserSettings
        {
            get { return this._defaultUserSettings; }
            set { this._defaultUserSettings = value; }
        }

        // Check to see if DefaultUserSettings property is set
        internal bool IsSetDefaultUserSettings()
        {
            return this._defaultUserSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// A name for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property DomainSettings. 
        /// <para>
        /// A collection of <code>Domain</code> settings.
        /// </para>
        /// </summary>
        public DomainSettings DomainSettings
        {
            get { return this._domainSettings; }
            set { this._domainSettings = value; }
        }

        // Check to see if DomainSettings property is set
        internal bool IsSetDomainSettings()
        {
            return this._domainSettings != null;
        }

        /// <summary>
        /// Gets and sets the property HomeEfsFileSystemKmsKeyId. 
        /// <para>
        /// Use <code>KmsKeyId</code>.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated, use KmsKeyId instead.")]
        [AWSProperty(Max=2048)]
        public string HomeEfsFileSystemKmsKeyId
        {
            get { return this._homeEfsFileSystemKmsKeyId; }
            set { this._homeEfsFileSystemKmsKeyId = value; }
        }

        // Check to see if HomeEfsFileSystemKmsKeyId property is set
        internal bool IsSetHomeEfsFileSystemKmsKeyId()
        {
            return this._homeEfsFileSystemKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// SageMaker uses Amazon Web Services KMS to encrypt the EFS volume attached to the domain
        /// with an Amazon Web Services managed key by default. For more control, specify a customer
        /// managed key.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The VPC subnets that Studio uses for communication.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associated with the Domain. Each tag consists of a key and an optional value.
        /// Tag keys must be unique per resource. Tags are searchable using the <code>Search</code>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// Tags that you specify for the Domain are also added to all Apps that the Domain launches.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the Amazon Virtual Private Cloud (VPC) that Studio uses for communication.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
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