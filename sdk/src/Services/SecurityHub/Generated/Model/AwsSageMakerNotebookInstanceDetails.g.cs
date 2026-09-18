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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Amazon SageMaker AI notebook instance.
    /// </summary>
    public partial class AwsSageMakerNotebookInstanceDetails
    {
        /// <summary>
        /// Gets and sets the property AcceleratorTypes. 
        /// <para>
        ///  A list of Amazon Elastic Inference instance types to associate with the notebook
        /// instance. Currently, only one instance type can be associated with a notebook instance.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AcceleratorTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AcceleratorTypes property is set.
        /// </summary>
        internal bool IsSetAcceleratorTypes() => this.AcceleratorTypes != null && (this.AcceleratorTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdditionalCodeRepositories. 
        /// <para>
        ///  An array of up to three Git repositories associated with the notebook instance. These
        /// can be either the names of Git repositories stored as resources in your account, or
        /// the URL of Git repositories in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">CodeCommit</a>
        /// or in any other Git repository. These repositories are cloned at the same level as
        /// the default repository of your notebook instance. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-git-repo.html">Associating
        /// Git repositories with SageMaker AI notebook instances</a> in the <i>Amazon SageMaker
        /// AI Developer Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalCodeRepositories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalCodeRepositories property is set.
        /// </summary>
        internal bool IsSetAdditionalCodeRepositories() => this.AdditionalCodeRepositories != null && (this.AdditionalCodeRepositories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultCodeRepository. 
        /// <para>
        ///  The Git repository associated with the notebook instance as its default code repository.
        /// This can be either the name of a Git repository stored as a resource in your account,
        /// or the URL of a Git repository in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">CodeCommit</a>
        /// or in any other Git repository. When you open a notebook instance, it opens in the
        /// directory that contains this repository. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-git-repo.html">Associating
        /// Git repositories with SageMaker AI notebook instances</a> in the <i>Amazon SageMaker
        /// AI Developer Guide</i>. 
        /// </para>
        /// </summary>
        public string DefaultCodeRepository { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCodeRepository property is set.
        /// </summary>
        internal bool IsSetDefaultCodeRepository() => this.DefaultCodeRepository != null;

        /// <summary>
        /// Gets and sets the property DirectInternetAccess. 
        /// <para>
        ///  Sets whether SageMaker AI provides internet access to the notebook instance. If you
        /// set this to <c>Disabled</c>, this notebook instance is able to access resources only
        /// in your VPC, and is not be able to connect to SageMaker AI training and endpoint services
        /// unless you configure a Network Address Translation (NAT) Gateway in your VPC. 
        /// </para>
        /// </summary>
        public string DirectInternetAccess { get; set; }

        /// <summary>
        /// Checks to see if the DirectInternetAccess property is set.
        /// </summary>
        internal bool IsSetDirectInternetAccess() => this.DirectInternetAccess != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        ///  If status of the instance is <c>Failed</c>, the reason it failed. 
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property InstanceMetadataServiceConfiguration. 
        /// <para>
        ///  Information on the IMDS configuration of the notebook instance. 
        /// </para>
        /// </summary>
        public AwsSageMakerNotebookInstanceMetadataServiceConfigurationDetails InstanceMetadataServiceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMetadataServiceConfiguration property is set.
        /// </summary>
        internal bool IsSetInstanceMetadataServiceConfiguration() => this.InstanceMetadataServiceConfiguration != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        ///  The type of machine learning (ML) compute instance to launch for the notebook instance.
        /// 
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of an Key Management Service (KMS) key that SageMaker
        /// AI uses to encrypt data on the storage volume attached to your notebook instance.
        /// The KMS key you provide must be enabled. For information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/enabling-keys.html">Enabling
        /// and disabling keys</a> in the <i>Key Management Service Developer Guide</i>. 
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        ///  The network interface ID that SageMaker AI created when the instance was created.
        /// 
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the notebook instance. 
        /// </para>
        /// </summary>
        public string NotebookInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceArn property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceArn() => this.NotebookInstanceArn != null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceLifecycleConfigName. 
        /// <para>
        ///  The name of a notebook instance lifecycle configuration. 
        /// </para>
        /// </summary>
        public string NotebookInstanceLifecycleConfigName { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceLifecycleConfigName property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceLifecycleConfigName() => this.NotebookInstanceLifecycleConfigName != null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceName. 
        /// <para>
        ///  The name of the new notebook instance. 
        /// </para>
        /// </summary>
        public string NotebookInstanceName { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceName property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceName() => this.NotebookInstanceName != null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceStatus. 
        /// <para>
        ///  The status of the notebook instance. 
        /// </para>
        /// </summary>
        public string NotebookInstanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceStatus property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceStatus() => this.NotebookInstanceStatus != null;

        /// <summary>
        /// Gets and sets the property PlatformIdentifier. 
        /// <para>
        ///  The platform identifier of the notebook instance runtime environment. 
        /// </para>
        /// </summary>
        public string PlatformIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PlatformIdentifier property is set.
        /// </summary>
        internal bool IsSetPlatformIdentifier() => this.PlatformIdentifier != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role associated with the instance. 
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property RootAccess. 
        /// <para>
        ///  Whether root access is enabled or disabled for users of the notebook instance. 
        /// </para>
        /// </summary>
        public string RootAccess { get; set; }

        /// <summary>
        /// Checks to see if the RootAccess property is set.
        /// </summary>
        internal bool IsSetRootAccess() => this.RootAccess != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        ///  The VPC security group IDs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        ///  The ID of the VPC subnet to which you have a connectivity from your ML compute instance.
        /// 
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        ///  The URL that you use to connect to the Jupyter notebook that is running in your notebook
        /// instance. 
        /// </para>
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;

        /// <summary>
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        ///  The size, in GB, of the ML storage volume to attach to the notebook instance. 
        /// </para>
        /// </summary>
        public int? VolumeSizeInGB { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSizeInGB property is set.
        /// </summary>
        internal bool IsSetVolumeSizeInGB() => this.VolumeSizeInGB.HasValue;
    }
}
