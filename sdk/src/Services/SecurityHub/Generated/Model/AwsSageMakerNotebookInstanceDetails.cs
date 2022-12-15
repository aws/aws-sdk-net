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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Amazon SageMaker notebook instance.
    /// </summary>
    public partial class AwsSageMakerNotebookInstanceDetails
    {
        private List<string> _acceleratorTypes = new List<string>();
        private List<string> _additionalCodeRepositories = new List<string>();
        private string _defaultCodeRepository;
        private string _directInternetAccess;
        private string _failureReason;
        private AwsSageMakerNotebookInstanceMetadataServiceConfigurationDetails _instanceMetadataServiceConfiguration;
        private string _instanceType;
        private string _kmsKeyId;
        private string _networkInterfaceId;
        private string _notebookInstanceArn;
        private string _notebookInstanceLifecycleConfigName;
        private string _notebookInstanceName;
        private string _notebookInstanceStatus;
        private string _platformIdentifier;
        private string _roleArn;
        private string _rootAccess;
        private List<string> _securityGroups = new List<string>();
        private string _subnetId;
        private string _url;
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property AcceleratorTypes. 
        /// <para>
        ///  A list of Amazon Elastic Inference instance types to associate with the notebook
        /// instance. Currently, only one instance type can be associated with a notebook instance.
        /// 
        /// </para>
        /// </summary>
        public List<string> AcceleratorTypes
        {
            get { return this._acceleratorTypes; }
            set { this._acceleratorTypes = value; }
        }

        // Check to see if AcceleratorTypes property is set
        internal bool IsSetAcceleratorTypes()
        {
            return this._acceleratorTypes != null && this._acceleratorTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AdditionalCodeRepositories. 
        /// <para>
        ///  An array of up to three Git repositories associated with the notebook instance. These
        /// can be either the names of Git repositories stored as resources in your account, or
        /// the URL of Git repositories in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">AWS
        /// CodeCommit</a> or in any other Git repository. These repositories are cloned at the
        /// same level as the default repository of your notebook instance. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-git-repo.html">Associating
        /// Git repositories with SageMaker notebook instances</a> in the <i>Amazon SageMaker
        /// Developer Guide</i>. 
        /// </para>
        /// </summary>
        public List<string> AdditionalCodeRepositories
        {
            get { return this._additionalCodeRepositories; }
            set { this._additionalCodeRepositories = value; }
        }

        // Check to see if AdditionalCodeRepositories property is set
        internal bool IsSetAdditionalCodeRepositories()
        {
            return this._additionalCodeRepositories != null && this._additionalCodeRepositories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultCodeRepository. 
        /// <para>
        ///  The Git repository associated with the notebook instance as its default code repository.
        /// This can be either the name of a Git repository stored as a resource in your account,
        /// or the URL of a Git repository in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">AWS
        /// CodeCommit</a> or in any other Git repository. When you open a notebook instance,
        /// it opens in the directory that contains this repository. For more information, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-git-repo.html">Associating
        /// Git repositories with SageMaker notebook instances</a> in the <i>Amazon SageMaker
        /// Developer Guide</i>. 
        /// </para>
        /// </summary>
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
        ///  Sets whether SageMaker provides internet access to the notebook instance. If you
        /// set this to <code>Disabled</code>, this notebook instance is able to access resources
        /// only in your VPC, and is not be able to connect to SageMaker training and endpoint
        /// services unless you configure a Network Address Translation (NAT) Gateway in your
        /// VPC. 
        /// </para>
        /// </summary>
        public string DirectInternetAccess
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
        ///  If status of the instance is <code>Failed</code>, the reason it failed. 
        /// </para>
        /// </summary>
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
        ///  Information on the IMDS configuration of the notebook instance. 
        /// </para>
        /// </summary>
        public AwsSageMakerNotebookInstanceMetadataServiceConfigurationDetails InstanceMetadataServiceConfiguration
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
        ///  The type of machine learning (ML) compute instance to launch for the notebook instance.
        /// 
        /// </para>
        /// </summary>
        public string InstanceType
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of an Key Management Service (KMS) key that SageMaker
        /// uses to encrypt data on the storage volume attached to your notebook instance. The
        /// KMS key you provide must be enabled. For information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/enabling-keys.html">Enabling
        /// and disabling keys</a> in the <i>Key Management Service Developer Guide</i>. 
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
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        ///  The network interface ID that SageMaker created when the instance was created. 
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
        ///  The Amazon Resource Name (ARN) of the notebook instance. 
        /// </para>
        /// </summary>
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
        ///  The name of a notebook instance lifecycle configuration. 
        /// </para>
        /// </summary>
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
        ///  The name of the new notebook instance. 
        /// </para>
        /// </summary>
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
        ///  The status of the notebook instance. 
        /// </para>
        /// </summary>
        public string NotebookInstanceStatus
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
        ///  The platform identifier of the notebook instance runtime environment. 
        /// </para>
        /// </summary>
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
        ///  The Amazon Resource Name (ARN) of the IAM role associated with the instance. 
        /// </para>
        /// </summary>
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
        ///  Whether root access is enabled or disabled for users of the notebook instance. 
        /// </para>
        /// </summary>
        public string RootAccess
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
        ///  The VPC security group IDs. 
        /// </para>
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        ///  The ID of the VPC subnet to which you have a connectivity from your ML compute instance.
        /// 
        /// </para>
        /// </summary>
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
        ///  The URL that you use to connect to the Jupyter notebook that is running in your notebook
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
        ///  The size, in GB, of the ML storage volume to attach to the notebook instance. 
        /// </para>
        /// </summary>
        public int VolumeSizeInGB
        {
            get { return this._volumeSizeInGB.GetValueOrDefault(); }
            set { this._volumeSizeInGB = value; }
        }

        // Check to see if VolumeSizeInGB property is set
        internal bool IsSetVolumeSizeInGB()
        {
            return this._volumeSizeInGB.HasValue; 
        }

    }
}