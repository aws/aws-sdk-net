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
    /// Container for the parameters to the CreateNotebookInstance operation.
    /// Creates an Amazon SageMaker notebook instance. A notebook instance is a machine learning
    /// (ML) compute instance running on a Jupyter notebook. 
    /// 
    ///  
    /// <para>
    /// In a <code>CreateNotebookInstance</code> request, specify the type of ML compute instance
    /// that you want to run. Amazon SageMaker launches the instance, installs common libraries
    /// that you can use to explore datasets for model training, and attaches an ML storage
    /// volume to the notebook instance. 
    /// </para>
    ///  
    /// <para>
    /// Amazon SageMaker also provides a set of example notebooks. Each notebook demonstrates
    /// how to use Amazon SageMaker with a specific algorithm or with a machine learning framework.
    /// 
    /// </para>
    ///  
    /// <para>
    /// After receiving the request, Amazon SageMaker does the following:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Creates a network interface in the Amazon SageMaker VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Option) If you specified <code>SubnetId</code>, Amazon SageMaker creates a network
    /// interface in your own VPC, which is inferred from the subnet ID that you provide in
    /// the input. When creating this network interface, Amazon SageMaker attaches the security
    /// group that you specified in the request to the network interface that it creates in
    /// your VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Launches an EC2 instance of the type specified in the request in the Amazon SageMaker
    /// VPC. If you specified <code>SubnetId</code> of your VPC, Amazon SageMaker specifies
    /// both network interfaces when launching this instance. This enables inbound traffic
    /// from your own VPC to the notebook instance, assuming that the security groups allow
    /// it.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// After creating the notebook instance, Amazon SageMaker returns its Amazon Resource
    /// Name (ARN). You can't change the name of a notebook instance after you create it.
    /// </para>
    ///  
    /// <para>
    /// After Amazon SageMaker creates the notebook instance, you can connect to the Jupyter
    /// server and work in Jupyter notebooks. For example, you can write code to explore a
    /// dataset that you can use for model training, train a model, host models by creating
    /// Amazon SageMaker endpoints, and validate hosted models. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
    /// It Works</a>. 
    /// </para>
    /// </summary>
    public partial class CreateNotebookInstanceRequest : AmazonSageMakerRequest
    {
        private List<string> _acceleratorTypes = new List<string>();
        private List<string> _additionalCodeRepositories = new List<string>();
        private string _defaultCodeRepository;
        private DirectInternetAccess _directInternetAccess;
        private InstanceType _instanceType;
        private string _kmsKeyId;
        private string _lifecycleConfigName;
        private string _notebookInstanceName;
        private string _roleArn;
        private RootAccess _rootAccess;
        private List<string> _securityGroupIds = new List<string>();
        private string _subnetId;
        private List<Tag> _tags = new List<Tag>();
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property AcceleratorTypes. 
        /// <para>
        /// A list of Elastic Inference (EI) instance types to associate with this notebook instance.
        /// Currently, only one instance type can be associated with a notebook instance. For
        /// more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/ei.html">Using
        /// Elastic Inference in Amazon SageMaker</a>.
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
        /// An array of up to three Git repositories to associate with the notebook instance.
        /// These can be either the names of Git repositories stored as resources in your account,
        /// or the URL of Git repositories in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">AWS
        /// CodeCommit</a> or in any other Git repository. These repositories are cloned at the
        /// same level as the default repository of your notebook instance. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-git-repo.html">Associating
        /// Git Repositories with Amazon SageMaker Notebook Instances</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=3)]
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
        /// A Git repository to associate with the notebook instance as its default code repository.
        /// This can be either the name of a Git repository stored as a resource in your account,
        /// or the URL of a Git repository in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">AWS
        /// CodeCommit</a> or in any other Git repository. When you open a notebook instance,
        /// it opens in the directory that contains this repository. For more information, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-git-repo.html">Associating
        /// Git Repositories with Amazon SageMaker Notebook Instances</a>.
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
        /// Sets whether Amazon SageMaker provides internet access to the notebook instance. If
        /// you set this to <code>Disabled</code> this notebook instance will be able to access
        /// resources only in your VPC, and will not be able to connect to Amazon SageMaker training
        /// and endpoint services unless your configure a NAT Gateway in your VPC.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/appendix-additional-considerations.html#appendix-notebook-and-internet-access">Notebook
        /// Instances Are Internet-Enabled by Default</a>. You can set the value of this parameter
        /// to <code>Disabled</code> only if you set a value for the <code>SubnetId</code> parameter.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a AWS Key Management Service key that Amazon SageMaker
        /// uses to encrypt data on the storage volume attached to your notebook instance. The
        /// KMS key you provide must be enabled. For information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/enabling-keys.html">Enabling
        /// and Disabling Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
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
        /// Gets and sets the property LifecycleConfigName. 
        /// <para>
        /// The name of a lifecycle configuration to associate with the notebook instance. For
        /// information about lifestyle configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
        /// 2.1: (Optional) Customize a Notebook Instance</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
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
        [AWSProperty(Required=true, Max=63)]
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
        ///  When you send any requests to AWS resources from the notebook instance, Amazon SageMaker
        /// assumes this role to perform tasks on your behalf. You must grant this role necessary
        /// permissions so Amazon SageMaker can perform these tasks. The policy must allow the
        /// Amazon SageMaker service principal (sagemaker.amazonaws.com) permissions to assume
        /// this role. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html">Amazon
        /// SageMaker Roles</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To be able to pass this role to Amazon SageMaker, the caller of this API must have
        /// the <code>iam:PassRole</code> permission.
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
        /// default value is <code>Enabled</code>.
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
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in a VPC to which you would like to have a connectivity from
        /// your ML compute instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
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
        /// An array of key-value pairs. You can use tags to categorize your AWS resources in
        /// different ways, for example, by purpose, owner, or environment. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a>.
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
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The size, in GB, of the ML storage volume to attach to the notebook instance. The
        /// default value is 5 GB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=16384)]
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