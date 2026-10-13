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
    /// This is the response object from the DescribeDomain operation.
    /// </summary>
    public partial class DescribeDomainResponse : AmazonWebServiceResponse
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
        /// is provided.
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
        /// The domain's authentication mode.
        /// </para>
        /// </summary>
        public AuthMode AuthMode { get; set; }

        /// <summary>
        /// Checks to see if the AuthMode property is set.
        /// </summary>
        internal bool IsSetAuthMode() => this.AuthMode != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

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
        /// Settings which are applied to UserProfiles in this domain if settings are not explicitly
        /// specified in a given UserProfile. 
        /// </para>
        /// </summary>
        public UserSettings DefaultUserSettings { get; set; }

        /// <summary>
        /// Checks to see if the DefaultUserSettings property is set.
        /// </summary>
        internal bool IsSetDefaultUserSettings() => this.DefaultUserSettings != null;

        /// <summary>
        /// Gets and sets the property DomainArn. 
        /// <para>
        /// The domain's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DomainArn { get; set; }

        /// <summary>
        /// Checks to see if the DomainArn property is set.
        /// </summary>
        internal bool IsSetDomainArn() => this.DomainArn != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The domain ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property HomeEfsFileSystemCreation. 
        /// <para>
        /// Indicates whether a home EFS file system is created for the domain.
        /// </para>
        /// </summary>
        public HomeEfsFileSystemCreation HomeEfsFileSystemCreation { get; set; }

        /// <summary>
        /// Checks to see if the HomeEfsFileSystemCreation property is set.
        /// </summary>
        internal bool IsSetHomeEfsFileSystemCreation() => this.HomeEfsFileSystemCreation != null;

        /// <summary>
        /// Gets and sets the property HomeEfsFileSystemId. 
        /// <para>
        /// The ID of the Amazon Elastic File System managed by this Domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string HomeEfsFileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the HomeEfsFileSystemId property is set.
        /// </summary>
        internal bool IsSetHomeEfsFileSystemId() => this.HomeEfsFileSystemId != null;

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
        /// The Amazon Web Services KMS customer managed key used to encrypt the EFS volume attached
        /// to the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityGroupIdForDomainBoundary. 
        /// <para>
        /// The ID of the security group that authorizes traffic between the <c>RSessionGateway</c>
        /// apps and the <c>RStudioServerPro</c> app.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string SecurityGroupIdForDomainBoundary { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupIdForDomainBoundary property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIdForDomainBoundary() => this.SecurityGroupIdForDomainBoundary != null;

        /// <summary>
        /// Gets and sets the property SingleSignOnApplicationArn. 
        /// <para>
        /// The ARN of the application managed by SageMaker AI in IAM Identity Center. This value
        /// is only returned for domains created after October 1, 2023.
        /// </para>
        /// </summary>
        public string SingleSignOnApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the SingleSignOnApplicationArn property is set.
        /// </summary>
        internal bool IsSetSingleSignOnApplicationArn() => this.SingleSignOnApplicationArn != null;

        /// <summary>
        /// Gets and sets the property SingleSignOnManagedApplicationInstanceId. 
        /// <para>
        /// The IAM Identity Center managed application instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SingleSignOnManagedApplicationInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the SingleSignOnManagedApplicationInstanceId property is set.
        /// </summary>
        internal bool IsSetSingleSignOnManagedApplicationInstanceId() => this.SingleSignOnManagedApplicationInstanceId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public DomainStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The VPC subnets that the domain uses for communication.
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
        /// Indicates whether custom tag propagation is supported for the domain.
        /// </para>
        /// </summary>
        public TagPropagation TagPropagation { get; set; }

        /// <summary>
        /// Checks to see if the TagPropagation property is set.
        /// </summary>
        internal bool IsSetTagPropagation() => this.TagPropagation != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The domain's URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the Amazon Virtual Private Cloud (VPC) that the domain uses for communication.
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
