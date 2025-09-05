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
    /// Container for the parameters to the CreateNotebookInstance operation.
    /// Creates an SageMaker AI notebook instance. A notebook instance is a machine learning
    /// (ML) compute instance running on a Jupyter notebook. 
    /// 
    ///  
    /// <para>
    /// In a <c>CreateNotebookInstance</c> request, specify the type of ML compute instance
    /// that you want to run. SageMaker AI launches the instance, installs common libraries
    /// that you can use to explore datasets for model training, and attaches an ML storage
    /// volume to the notebook instance. 
    /// </para>
    ///  
    /// <para>
    /// SageMaker AI also provides a set of example notebooks. Each notebook demonstrates
    /// how to use SageMaker AI with a specific algorithm or with a machine learning framework.
    /// 
    /// </para>
    ///  
    /// <para>
    /// After receiving the request, SageMaker AI does the following:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Creates a network interface in the SageMaker AI VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Option) If you specified <c>SubnetId</c>, SageMaker AI creates a network interface
    /// in your own VPC, which is inferred from the subnet ID that you provide in the input.
    /// When creating this network interface, SageMaker AI attaches the security group that
    /// you specified in the request to the network interface that it creates in your VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Launches an EC2 instance of the type specified in the request in the SageMaker AI
    /// VPC. If you specified <c>SubnetId</c> of your VPC, SageMaker AI specifies both network
    /// interfaces when launching this instance. This enables inbound traffic from your own
    /// VPC to the notebook instance, assuming that the security groups allow it.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// After creating the notebook instance, SageMaker AI returns its Amazon Resource Name
    /// (ARN). You can't change the name of a notebook instance after you create it.
    /// </para>
    ///  
    /// <para>
    /// After SageMaker AI creates the notebook instance, you can connect to the Jupyter server
    /// and work in Jupyter notebooks. For example, you can write code to explore a dataset
    /// that you can use for model training, train a model, host models by creating SageMaker
    /// AI endpoints, and validate hosted models. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
    /// It Works</a>. 
    /// </para>
    /// </summary>
    public partial class CreateNotebookInstanceRequest : AmazonSageMakerRequest
    {
        private List<string> _acceleratorTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _additionalCodeRepositories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _defaultCodeRepository;
        private DirectInternetAccess _directInternetAccess;
        private InstanceMetadataServiceConfiguration _instanceMetadataServiceConfiguration;
        private InstanceType _instanceType;
        private IPAddressType _ipAddressType;
        private string _kmsKeyId;
        private string _lifecycleConfigName;
        private string _notebookInstanceName;
        private string _platformIdentifier;
        private string _roleArn;
        private RootAccess _rootAccess;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subnetId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property AcceleratorTypes. 
        /// <para>
        /// This parameter is no longer supported. Elastic Inference (EI) is no longer available.
        /// </para>
        ///  
        /// <para>
        /// This parameter was used to specify a list of EI instance types to associate with this
        /// notebook instance.
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
        /// A Git repository to associate with the notebook instance as its default code repository.
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
        /// Sets whether SageMaker AI provides internet access to the notebook instance. If you
        /// set this to <c>Disabled</c> this notebook instance is able to access resources only
        /// in your VPC, and is not be able to connect to SageMaker AI training and endpoint services
        /// unless you configure a NAT Gateway in your VPC.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/appendix-additional-considerations.html#appendix-notebook-and-internet-access">Notebook
        /// Instances Are Internet-Enabled by Default</a>. You can set the value of this parameter
        /// to <c>Disabled</c> only if you set a value for the <c>SubnetId</c> parameter.
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
        /// The type of ML compute instance to launch for the notebook instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// or <c>dualstack</c> for both IPv4 and IPv6 connectivity. When you specify <c>dualstack</c>,
        /// the subnet must support IPv6 CIDR blocks. If not specified, defaults to <c>ipv4</c>.
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
        /// The Amazon Resource Name (ARN) of a Amazon Web Services Key Management Service key
        /// that SageMaker AI uses to encrypt data on the storage volume attached to your notebook
        /// instance. The KMS key you provide must be enabled. For information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/enabling-keys.html">Enabling
        /// and Disabling Keys</a> in the <i>Amazon Web Services Key Management Service Developer
        /// Guide</i>.
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
        /// The name of the new notebook instance.
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
        ///  When you send any requests to Amazon Web Services resources from the notebook instance,
        /// SageMaker AI assumes this role to perform tasks on your behalf. You must grant this
        /// role necessary permissions so SageMaker AI can perform these tasks. The policy must
        /// allow the SageMaker AI service principal (sagemaker.amazonaws.com) permissions to
        /// assume this role. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html">SageMaker
        /// AI Roles</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To be able to pass this role to SageMaker AI, the caller of this API must have the
        /// <c>iam:PassRole</c> permission.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The VPC security group IDs, in the form sg-xxxxxxxx. The security groups must be for
        /// the same VPC as specified in the subnet. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in a VPC to which you would like to have a connectivity from
        /// your ML compute instance. 
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The size, in GB, of the ML storage volume to attach to the notebook instance. The
        /// default value is 5 GB.
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