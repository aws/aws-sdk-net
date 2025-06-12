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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeDomain operation.
    /// </summary>
    public partial class DescribeDomainResponse : AmazonWebServiceResponse
    {
        private AppNetworkAccessType _appNetworkAccessType;
        private AppSecurityGroupManagement _appSecurityGroupManagement;
        private AuthMode _authMode;
        private DateTime? _creationTime;
        private DefaultSpaceSettings _defaultSpaceSettings;
        private UserSettings _defaultUserSettings;
        private string _domainArn;
        private string _domainId;
        private string _domainName;
        private DomainSettings _domainSettings;
        private string _failureReason;
        private string _homeEfsFileSystemId;
        private string _homeEfsFileSystemKmsKeyId;
        private string _kmsKeyId;
        private DateTime? _lastModifiedTime;
        private string _securityGroupIdForDomainBoundary;
        private string _singleSignOnApplicationArn;
        private string _singleSignOnManagedApplicationInstanceId;
        private DomainStatus _status;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TagPropagation _tagPropagation;
        private string _url;
        private string _vpcId;

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
        /// in <c>VPCOnly</c> mode. Required when <c>CreateDomain.AppNetworkAccessType</c> is
        /// <c>VPCOnly</c> and <c>DomainSettings.RStudioServerProDomainSettings.DomainExecutionRoleArn</c>
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
        /// The domain's authentication mode.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultSpaceSettings. 
        /// <para>
        /// The default settings for shared spaces that users create in the domain.
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
        /// Settings which are applied to UserProfiles in this domain if settings are not explicitly
        /// specified in a given UserProfile. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DomainArn. 
        /// <para>
        /// The domain's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string DomainArn
        {
            get { return this._domainArn; }
            set { this._domainArn = value; }
        }

        // Check to see if DomainArn property is set
        internal bool IsSetDomainArn()
        {
            return this._domainArn != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The domain ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
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
        /// A collection of <c>Domain</c> settings.
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property HomeEfsFileSystemId. 
        /// <para>
        /// The ID of the Amazon Elastic File System managed by this Domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public string HomeEfsFileSystemId
        {
            get { return this._homeEfsFileSystemId; }
            set { this._homeEfsFileSystemId = value; }
        }

        // Check to see if HomeEfsFileSystemId property is set
        internal bool IsSetHomeEfsFileSystemId()
        {
            return this._homeEfsFileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property HomeEfsFileSystemKmsKeyId. 
        /// <para>
        /// Use <c>KmsKeyId</c>.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated, use KmsKeyId instead.")]
        [AWSProperty(Min=0, Max=2048)]
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
        /// The Amazon Web Services KMS customer managed key used to encrypt the EFS volume attached
        /// to the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIdForDomainBoundary. 
        /// <para>
        /// The ID of the security group that authorizes traffic between the <c>RSessionGateway</c>
        /// apps and the <c>RStudioServerPro</c> app.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public string SecurityGroupIdForDomainBoundary
        {
            get { return this._securityGroupIdForDomainBoundary; }
            set { this._securityGroupIdForDomainBoundary = value; }
        }

        // Check to see if SecurityGroupIdForDomainBoundary property is set
        internal bool IsSetSecurityGroupIdForDomainBoundary()
        {
            return this._securityGroupIdForDomainBoundary != null;
        }

        /// <summary>
        /// Gets and sets the property SingleSignOnApplicationArn. 
        /// <para>
        /// The ARN of the application managed by SageMaker AI in IAM Identity Center. This value
        /// is only returned for domains created after October 1, 2023.
        /// </para>
        /// </summary>
        public string SingleSignOnApplicationArn
        {
            get { return this._singleSignOnApplicationArn; }
            set { this._singleSignOnApplicationArn = value; }
        }

        // Check to see if SingleSignOnApplicationArn property is set
        internal bool IsSetSingleSignOnApplicationArn()
        {
            return this._singleSignOnApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property SingleSignOnManagedApplicationInstanceId. 
        /// <para>
        /// The IAM Identity Center managed application instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string SingleSignOnManagedApplicationInstanceId
        {
            get { return this._singleSignOnManagedApplicationInstanceId; }
            set { this._singleSignOnManagedApplicationInstanceId = value; }
        }

        // Check to see if SingleSignOnManagedApplicationInstanceId property is set
        internal bool IsSetSingleSignOnManagedApplicationInstanceId()
        {
            return this._singleSignOnManagedApplicationInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public DomainStatus Status
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The VPC subnets that the domain uses for communication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagPropagation. 
        /// <para>
        /// Indicates whether custom tag propagation is supported for the domain.
        /// </para>
        /// </summary>
        public TagPropagation TagPropagation
        {
            get { return this._tagPropagation; }
            set { this._tagPropagation = value; }
        }

        // Check to see if TagPropagation property is set
        internal bool IsSetTagPropagation()
        {
            return this._tagPropagation != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The domain's URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the Amazon Virtual Private Cloud (VPC) that the domain uses for communication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
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