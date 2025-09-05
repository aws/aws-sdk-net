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
    /// Container for the parameters to the UpdateNotebookInstance operation.
    /// Updates a notebook instance. NotebookInstance updates include upgrading or downgrading
    /// the ML compute instance used for your notebook instance to accommodate changes in
    /// your workload requirements.
    /// </summary>
    public partial class UpdateNotebookInstanceRequest : AmazonSageMakerRequest
    {
        private List<string> _acceleratorTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _additionalCodeRepositories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _defaultCodeRepository;
        private bool? _disassociateAcceleratorTypes;
        private bool? _disassociateAdditionalCodeRepositories;
        private bool? _disassociateDefaultCodeRepository;
        private bool? _disassociateLifecycleConfig;
        private InstanceMetadataServiceConfiguration _instanceMetadataServiceConfiguration;
        private InstanceType _instanceType;
        private IPAddressType _ipAddressType;
        private string _lifecycleConfigName;
        private string _notebookInstanceName;
        private string _roleArn;
        private RootAccess _rootAccess;
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property AcceleratorTypes. 
        /// <para>
        /// This parameter is no longer supported. Elastic Inference (EI) is no longer available.
        /// </para>
        ///  
        /// <para>
        /// This parameter was used to specify a list of the EI instance types to associate with
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
        /// An array of up to three Git repositories to associate with the notebook instance.
        /// These can be either the names of Git repositories stored as resources in your account,
        /// or the URL of Git repositories in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">Amazon
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
        /// Gets and sets the property DefaultCodeRepository. 
        /// <para>
        /// The Git repository to associate with the notebook instance as its default code repository.
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
        /// Gets and sets the property DisassociateAcceleratorTypes. 
        /// <para>
        /// This parameter is no longer supported. Elastic Inference (EI) is no longer available.
        /// </para>
        ///  
        /// <para>
        /// This parameter was used to specify a list of the EI instance types to remove from
        /// this notebook instance.
        /// </para>
        /// </summary>
        public bool? DisassociateAcceleratorTypes
        {
            get { return this._disassociateAcceleratorTypes; }
            set { this._disassociateAcceleratorTypes = value; }
        }

        // Check to see if DisassociateAcceleratorTypes property is set
        internal bool IsSetDisassociateAcceleratorTypes()
        {
            return this._disassociateAcceleratorTypes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisassociateAdditionalCodeRepositories. 
        /// <para>
        /// A list of names or URLs of the default Git repositories to remove from this notebook
        /// instance. This operation is idempotent. If you specify a Git repository that is not
        /// associated with the notebook instance when you call this method, it does not throw
        /// an error.
        /// </para>
        /// </summary>
        public bool? DisassociateAdditionalCodeRepositories
        {
            get { return this._disassociateAdditionalCodeRepositories; }
            set { this._disassociateAdditionalCodeRepositories = value; }
        }

        // Check to see if DisassociateAdditionalCodeRepositories property is set
        internal bool IsSetDisassociateAdditionalCodeRepositories()
        {
            return this._disassociateAdditionalCodeRepositories.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisassociateDefaultCodeRepository. 
        /// <para>
        /// The name or URL of the default Git repository to remove from this notebook instance.
        /// This operation is idempotent. If you specify a Git repository that is not associated
        /// with the notebook instance when you call this method, it does not throw an error.
        /// </para>
        /// </summary>
        public bool? DisassociateDefaultCodeRepository
        {
            get { return this._disassociateDefaultCodeRepository; }
            set { this._disassociateDefaultCodeRepository = value; }
        }

        // Check to see if DisassociateDefaultCodeRepository property is set
        internal bool IsSetDisassociateDefaultCodeRepository()
        {
            return this._disassociateDefaultCodeRepository.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisassociateLifecycleConfig. 
        /// <para>
        /// Set to <c>true</c> to remove the notebook instance lifecycle configuration currently
        /// associated with the notebook instance. This operation is idempotent. If you specify
        /// a lifecycle configuration that is not associated with the notebook instance when you
        /// call this method, it does not throw an error.
        /// </para>
        /// </summary>
        public bool? DisassociateLifecycleConfig
        {
            get { return this._disassociateLifecycleConfig; }
            set { this._disassociateLifecycleConfig = value; }
        }

        // Check to see if DisassociateLifecycleConfig property is set
        internal bool IsSetDisassociateLifecycleConfig()
        {
            return this._disassociateLifecycleConfig.HasValue; 
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
        /// The Amazon ML compute instance type.
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
        /// The IP address type for the notebook instance. Specify <c>ipv4</c> for IPv4-only connectivity
        /// or <c>dualstack</c> for both IPv4 and IPv6 connectivity. The notebook instance must
        /// be stopped before updating this setting. When you specify <c>dualstack</c>, the subnet
        /// must support IPv6 addressing.
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
        /// Gets and sets the property LifecycleConfigName. 
        /// <para>
        /// The name of a lifecycle configuration to associate with the notebook instance. For
        /// information about lifestyle configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
        /// 2.1: (Optional) Customize a Notebook Instance</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string LifecycleConfigName
        {
            get { return this._lifecycleConfigName; }
            set { this._lifecycleConfigName = value; }
        }

        // Check to see if LifecycleConfigName property is set
        internal bool IsSetLifecycleConfigName()
        {
            return this._lifecycleConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookInstanceName. 
        /// <para>
        /// The name of the notebook instance to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that SageMaker AI can assume to access
        /// the notebook instance. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html">SageMaker
        /// AI Roles</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To be able to pass this role to SageMaker AI, the caller of this API must have the
        /// <c>iam:PassRole</c> permission.
        /// </para>
        ///  </note>
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
        /// Whether root access is enabled or disabled for users of the notebook instance. The
        /// default value is <c>Enabled</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set this to <c>Disabled</c>, users don't have root access on the notebook instance,
        /// but lifecycle configuration scripts still run with root permissions.
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
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The size, in GB, of the ML storage volume to attach to the notebook instance. The
        /// default value is 5 GB. ML storage volumes are encrypted, so SageMaker AI can't determine
        /// the amount of available free space on the volume. Because of this, you can increase
        /// the volume size when you update a notebook instance, but you can't decrease the volume
        /// size. If you want to decrease the size of the ML storage volume in use, create a new
        /// notebook instance with the desired size.
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