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
    /// This is the response object from the DescribeNotebookInstance operation.
    /// </summary>
    public partial class DescribeNotebookInstanceResponse : AmazonWebServiceResponse
    {
        private List<string> _acceleratorTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _additionalCodeRepositories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _creationTime;
        private string _defaultCodeRepository;
        private DirectInternetAccess _directInternetAccess;
        private string _failureReason;
        private InstanceMetadataServiceConfiguration _instanceMetadataServiceConfiguration;
        private InstanceType _instanceType;
        private IPAddressType _ipAddressType;
        private string _kmsKeyId;
        private DateTime? _lastModifiedTime;
        private string _networkInterfaceId;
        private string _notebookInstanceArn;
        private string _notebookInstanceLifecycleConfigName;
        private string _notebookInstanceName;
        private NotebookInstanceStatus _notebookInstanceStatus;
        private string _platformIdentifier;
        private string _roleArn;
        private RootAccess _rootAccess;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subnetId;
        private string _url;
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property AcceleratorTypes. 
        /// <para>
        /// This parameter is no longer supported. Elastic Inference (EI) is no longer available.
        /// </para>
        ///  
        /// <para>
        /// This parameter was used to specify a list of the EI instance types associated with
        /// this notebook instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AcceleratorTypes
        {
            get { return this._acceleratorTypes; }
            set { this._acceleratorTypes = value; }
        }

        // Check to see if AcceleratorTypes property is set
        internal bool IsSetAcceleratorTypes()
        {
            return this._acceleratorTypes != null && (this._acceleratorTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AdditionalCodeRepositories. 
        /// <para>
        /// An array of up to three Git repositories associated with the notebook instance. These
        /// can be either the names of Git repositories stored as resources in your account, or
        /// the URL of Git repositories in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">Amazon
        /// Web Services CodeCommit</a> or in any other Git repository. These repositories are
        /// cloned at the same level as the default repository of your notebook instance. For
        /// more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-git-repo.html">Associating
        /// Git Repositories with SageMaker AI Notebook Instances</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> AdditionalCodeRepositories
        {
            get { return this._additionalCodeRepositories; }
            set { this._additionalCodeRepositories = value; }
        }

        // Check to see if AdditionalCodeRepositories property is set
        internal bool IsSetAdditionalCodeRepositories()
        {
            return this._additionalCodeRepositories != null && (this._additionalCodeRepositories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp. Use this parameter to return the time when the notebook instance was
        /// created
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
        /// Gets and sets the property DefaultCodeRepository. 
        /// <para>
        /// The Git repository associated with the notebook instance as its default code repository.
        /// This can be either the name of a Git repository stored as a resource in your account,
        /// or the URL of a Git repository in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">Amazon
        /// Web Services CodeCommit</a> or in any other Git repository. When you open a notebook
        /// instance, it opens in the directory that contains this repository. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-git-repo.html">Associating
        /// Git Repositories with SageMaker AI Notebook Instances</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DefaultCodeRepository
        {
            get { return this._defaultCodeRepository; }
            set { this._defaultCodeRepository = value; }
        }

        // Check to see if DefaultCodeRepository property is set
        internal bool IsSetDefaultCodeRepository()
        {
            return this._defaultCodeRepository != null;
        }

        /// <summary>
        /// Gets and sets the property DirectInternetAccess. 
        /// <para>
        /// Describes whether SageMaker AI provides internet access to the notebook instance.
        /// If this value is set to <i>Disabled</i>, the notebook instance does not have internet
        /// access, and cannot connect to SageMaker AI training and endpoint services.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/appendix-additional-considerations.html#appendix-notebook-and-internet-access">Notebook
        /// Instances Are Internet-Enabled by Default</a>.
        /// </para>
        /// </summary>
        public DirectInternetAccess DirectInternetAccess
        {
            get { return this._directInternetAccess; }
            set { this._directInternetAccess = value; }
        }

        // Check to see if DirectInternetAccess property is set
        internal bool IsSetDirectInternetAccess()
        {
            return this._directInternetAccess != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If status is <c>Failed</c>, the reason it failed.
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
        /// Gets and sets the property InstanceMetadataServiceConfiguration. 
        /// <para>
        /// Information on the IMDS configuration of the notebook instance
        /// </para>
        /// </summary>
        public InstanceMetadataServiceConfiguration InstanceMetadataServiceConfiguration
        {
            get { return this._instanceMetadataServiceConfiguration; }
            set { this._instanceMetadataServiceConfiguration = value; }
        }

        // Check to see if InstanceMetadataServiceConfiguration property is set
        internal bool IsSetInstanceMetadataServiceConfiguration()
        {
            return this._instanceMetadataServiceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of ML compute instance running on the notebook instance.
        /// </para>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type configured for the notebook instance. Returns <c>ipv4</c> for
        /// IPv4-only connectivity or <c>dualstack</c> for both IPv4 and IPv6 connectivity.
        /// </para>
        /// </summary>
        public IPAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key ID SageMaker AI uses to encrypt data when storing
        /// it on the ML storage volume attached to the instance. 
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
        /// A timestamp. Use this parameter to retrieve the time when the notebook instance was
        /// last modified. 
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
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The network interface IDs that SageMaker AI created at the time of creating the instance.
        /// 
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the notebook instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string NotebookInstanceArn
        {
            get { return this._notebookInstanceArn; }
            set { this._notebookInstanceArn = value; }
        }

        // Check to see if NotebookInstanceArn property is set
        internal bool IsSetNotebookInstanceArn()
        {
            return this._notebookInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookInstanceLifecycleConfigName. 
        /// <para>
        /// Returns the name of a notebook instance lifecycle configuration.
        /// </para>
        ///  
        /// <para>
        /// For information about notebook instance lifestyle configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
        /// 2.1: (Optional) Customize a Notebook Instance</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string NotebookInstanceLifecycleConfigName
        {
            get { return this._notebookInstanceLifecycleConfigName; }
            set { this._notebookInstanceLifecycleConfigName = value; }
        }

        // Check to see if NotebookInstanceLifecycleConfigName property is set
        internal bool IsSetNotebookInstanceLifecycleConfigName()
        {
            return this._notebookInstanceLifecycleConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookInstanceName. 
        /// <para>
        /// The name of the SageMaker AI notebook instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string NotebookInstanceName
        {
            get { return this._notebookInstanceName; }
            set { this._notebookInstanceName = value; }
        }

        // Check to see if NotebookInstanceName property is set
        internal bool IsSetNotebookInstanceName()
        {
            return this._notebookInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookInstanceStatus. 
        /// <para>
        /// The status of the notebook instance.
        /// </para>
        /// </summary>
        public NotebookInstanceStatus NotebookInstanceStatus
        {
            get { return this._notebookInstanceStatus; }
            set { this._notebookInstanceStatus = value; }
        }

        // Check to see if NotebookInstanceStatus property is set
        internal bool IsSetNotebookInstanceStatus()
        {
            return this._notebookInstanceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformIdentifier. 
        /// <para>
        /// The platform identifier of the notebook instance runtime environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public string PlatformIdentifier
        {
            get { return this._platformIdentifier; }
            set { this._platformIdentifier = value; }
        }

        // Check to see if PlatformIdentifier property is set
        internal bool IsSetPlatformIdentifier()
        {
            return this._platformIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role associated with the instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RootAccess. 
        /// <para>
        /// Whether root access is enabled or disabled for users of the notebook instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// Lifecycle configurations need root access to be able to set up a notebook instance.
        /// Because of this, lifecycle configurations associated with a notebook instance always
        /// run with root access even if you disable root access for users.
        /// </para>
        ///  </note>
        /// </summary>
        public RootAccess RootAccess
        {
            get { return this._rootAccess; }
            set { this._rootAccess = value; }
        }

        // Check to see if RootAccess property is set
        internal bool IsSetRootAccess()
        {
            return this._rootAccess != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The IDs of the VPC security groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the VPC subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL that you use to connect to the Jupyter notebook that is running in your notebook
        /// instance. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The size, in GB, of the ML storage volume attached to the notebook instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=16384)]
        public int? VolumeSizeInGB
        {
            get { return this._volumeSizeInGB; }
            set { this._volumeSizeInGB = value; }
        }

        // Check to see if VolumeSizeInGB property is set
        internal bool IsSetVolumeSizeInGB()
        {
            return this._volumeSizeInGB.HasValue; 
        }

    }
}