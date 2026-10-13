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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDomain operation. Creates a <c>Domain</c>.
    /// A domain consists of an associated Amazon Elastic File System volume, a list of authorized
    /// users, and a variety of security, application, policy, and Amazon Virtual Private
    /// Cloud (VPC) configurations. Users within a domain can share notebook files and other
    /// artifacts with each other. <para> <b>EFS storage</b> </para> <para> When a domain
    /// is created, an EFS volume is created for use by all of the users within the domain.
    /// Each user receives a private home directory within the EFS volume for notebooks, Git
    /// repositories, and data files. </para> <para> SageMaker AI uses the Amazon Web Services
    /// Key Management Service (Amazon Web Services KMS) to encrypt the EFS volume attached
    /// to the domain with an Amazon Web Services managed key by default. For more control,
    /// you can specify a customer managed key. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/encryption-at-rest.html">Protect
    /// Data at Rest Using Encryption</a>. </para> <para> <b>VPC configuration</b> </para>
    /// <para> All traffic between the domain and the Amazon EFS volume is through the specified
    /// VPC and subnets. For other traffic, you can specify the <c>AppNetworkAccessType</c>
    /// parameter. <c>AppNetworkAccessType</c> corresponds to the network access type that
    /// you choose when you onboard to the domain. The following options are available: </para>
    /// <ul> <li> <para> <c>PublicInternetOnly</c> - Non-EFS traffic goes through a VPC managed
    /// by Amazon SageMaker AI, which allows internet access. This is the default value. </para>
    /// </li> <li> <para> <c>VpcOnly</c> - All traffic is through the specified VPC and subnets.
    /// Internet access is disabled by default. To allow internet access, you must specify
    /// a NAT gateway. </para> <para> When internet access is disabled, you won't be able
    /// to run a Amazon SageMaker AI Studio notebook or to train or host models unless your
    /// VPC has an interface endpoint to the SageMaker AI API and runtime or a NAT gateway
    /// and your security groups allow outbound connections. </para> </li> </ul> <important>
    /// <para> NFS traffic over TCP on port 2049 needs to be allowed in both inbound and outbound
    /// rules in order to launch a Amazon SageMaker AI Studio app successfully. </para> </important>
    /// <para> For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-notebooks-and-internet-access.html">Connect
    /// Amazon SageMaker AI Studio Notebooks to Resources in a VPC</a>. </para>
    /// </summary>
    public partial class CreateDomainRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AppNetworkAccessType. 
        /// <para>
        /// Specifies the VPC used for non-EFS traffic. The default value is <c>PublicInternetOnly</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PublicInternetOnly</c> - Non-EFS traffic is through a VPC managed by Amazon SageMaker
        /// AI, which allows direct internet access
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VpcOnly</c> - All traffic is through the specified VPC and subnets
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AppNetworkAccessType AppNetworkAccessType { get; set; }

        /// <summary>
        /// Checks to see if the AppNetworkAccessType property is set.
        /// </summary>
        internal bool IsSetAppNetworkAccessType() => this.AppNetworkAccessType != null;

        /// <summary>
        /// Gets and sets the property AppSecurityGroupManagement. 
        /// <para>
        /// The entity that creates and manages the required security groups for inter-app communication
        /// in <c>VPCOnly</c> mode. Required when <c>CreateDomain.AppNetworkAccessType</c> is
        /// <c>VPCOnly</c> and <c>DomainSettings.RStudioServerProDomainSettings.DomainExecutionRoleArn</c>
        /// is provided. If setting up the domain for use with RStudio, this value must be set
        /// to <c>Service</c>.
        /// </para>
        /// </summary>
        public AppSecurityGroupManagement AppSecurityGroupManagement { get; set; }

        /// <summary>
        /// Checks to see if the AppSecurityGroupManagement property is set.
        /// </summary>
        internal bool IsSetAppSecurityGroupManagement() => this.AppSecurityGroupManagement != null;

        /// <summary>
        /// Gets and sets the property AuthMode. 
        /// <para>
        /// The mode of authentication that members use to access the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthMode AuthMode { get; set; }

        /// <summary>
        /// Checks to see if the AuthMode property is set.
        /// </summary>
        internal bool IsSetAuthMode() => this.AuthMode != null;

        /// <summary>
        /// Gets and sets the property DefaultSpaceSettings. 
        /// <para>
        /// The default settings for shared spaces that users create in the domain.
        /// </para>
        /// </summary>
        public DefaultSpaceSettings DefaultSpaceSettings { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSpaceSettings property is set.
        /// </summary>
        internal bool IsSetDefaultSpaceSettings() => this.DefaultSpaceSettings != null;

        /// <summary>
        /// Gets and sets the property DefaultUserSettings. 
        /// <para>
        /// The default settings to use to create a user profile when <c>UserSettings</c> isn't
        /// specified in the call to the <c>CreateUserProfile</c> API.
        /// </para>
        ///  
        /// <para>
        ///  <c>SecurityGroups</c> is aggregated when specified in both calls. For all other settings
        /// in <c>UserSettings</c>, the values specified in <c>CreateUserProfile</c> take precedence
        /// over those specified in <c>CreateDomain</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UserSettings DefaultUserSettings { get; set; }

        /// <summary>
        /// Checks to see if the DefaultUserSettings property is set.
        /// </summary>
        internal bool IsSetDefaultUserSettings() => this.DefaultUserSettings != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// A name for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DomainSettings. 
        /// <para>
        /// A collection of <c>Domain</c> settings.
        /// </para>
        /// </summary>
        public DomainSettings DomainSettings { get; set; }

        /// <summary>
        /// Checks to see if the DomainSettings property is set.
        /// </summary>
        internal bool IsSetDomainSettings() => this.DomainSettings != null;

        /// <summary>
        /// Gets and sets the property HomeEfsFileSystemCreation. 
        /// <para>
        /// Indicates whether to create a home EFS file system for the domain. Defaults to <c>Enabled</c>.
        /// Set to <c>Disabled</c> to skip EFS creation and reduce domain creation time. You can
        /// enable EFS later by calling <c>UpdateDomain</c>.
        /// </para>
        /// </summary>
        public HomeEfsFileSystemCreation HomeEfsFileSystemCreation { get; set; }

        /// <summary>
        /// Checks to see if the HomeEfsFileSystemCreation property is set.
        /// </summary>
        internal bool IsSetHomeEfsFileSystemCreation() => this.HomeEfsFileSystemCreation != null;

        /// <summary>
        /// Gets and sets the property HomeEfsFileSystemKmsKeyId. 
        /// <para>
        /// Use <c>KmsKeyId</c>.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated, use KmsKeyId instead.")]
        [AWSProperty(Min = 0, Max = 2048)]
        public string HomeEfsFileSystemKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the HomeEfsFileSystemKmsKeyId property is set.
        /// </summary>
        internal bool IsSetHomeEfsFileSystemKmsKeyId() => this.HomeEfsFileSystemKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// SageMaker AI uses Amazon Web Services KMS to encrypt EFS and EBS volumes attached
        /// to the domain with an Amazon Web Services managed key by default. For more control,
        /// specify a customer managed key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The VPC subnets that the domain uses for communication.
        /// </para>
        ///  
        /// <para>
        /// The field is optional when the <c>AppNetworkAccessType</c> parameter is set to <c>PublicInternetOnly</c>
        /// for domains created from Amazon SageMaker Unified Studio.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagPropagation. 
        /// <para>
        /// Indicates whether custom tag propagation is supported for the domain. Defaults to
        /// <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public TagPropagation TagPropagation { get; set; }

        /// <summary>
        /// Checks to see if the TagPropagation property is set.
        /// </summary>
        internal bool IsSetTagPropagation() => this.TagPropagation != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associated with the Domain. Each tag consists of a key and an optional value.
        /// Tag keys must be unique per resource. Tags are searchable using the <c>Search</c>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// Tags that you specify for the Domain are also added to all Apps that the Domain launches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the Amazon Virtual Private Cloud (VPC) that the domain uses for communication.
        /// </para>
        ///  
        /// <para>
        /// The field is optional when the <c>AppNetworkAccessType</c> parameter is set to <c>PublicInternetOnly</c>
        /// for domains created from Amazon SageMaker Unified Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
