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
    /// This is the response object from the DescribeNotebookInstance operation.
    /// </summary>
    public partial class DescribeNotebookInstanceResponse : AmazonWebServiceResponse
    {
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
        /// An array of up to three Git repositories associated with the notebook instance. These
        /// can be either the names of Git repositories stored as resources in your account, or
        /// the URL of Git repositories in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">Amazon
        /// Web Services CodeCommit</a> or in any other Git repository. These repositories are
        /// cloned at the same level as the default repository of your notebook instance. For
        /// more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-git-repo.html">Associating
        /// Git Repositories with SageMaker AI Notebook Instances</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> AdditionalCodeRepositories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalCodeRepositories property is set.
        /// </summary>
        internal bool IsSetAdditionalCodeRepositories() => this.AdditionalCodeRepositories != null && (this.AdditionalCodeRepositories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp. Use this parameter to return the time when the notebook instance was
        /// created
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

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
        [AWSProperty(Min = 1, Max = 1024)]
        public string DefaultCodeRepository { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCodeRepository property is set.
        /// </summary>
        internal bool IsSetDefaultCodeRepository() => this.DefaultCodeRepository != null;

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
        public DirectInternetAccess DirectInternetAccess { get; set; }

        /// <summary>
        /// Checks to see if the DirectInternetAccess property is set.
        /// </summary>
        internal bool IsSetDirectInternetAccess() => this.DirectInternetAccess != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If status is <c>Failed</c>, the reason it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property InstanceMetadataServiceConfiguration. 
        /// <para>
        /// Information on the IMDS configuration of the notebook instance
        /// </para>
        /// </summary>
        public InstanceMetadataServiceConfiguration InstanceMetadataServiceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMetadataServiceConfiguration property is set.
        /// </summary>
        internal bool IsSetInstanceMetadataServiceConfiguration() => this.InstanceMetadataServiceConfiguration != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of ML compute instance running on the notebook instance.
        /// </para>
        /// </summary>
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type configured for the notebook instance. Returns <c>ipv4</c> for
        /// IPv4-only connectivity or <c>dualstack</c> for both IPv4 and IPv6 connectivity.
        /// </para>
        /// </summary>
        public IPAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key ID SageMaker AI uses to encrypt data when storing
        /// it on the ML storage volume attached to the instance. 
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
        /// A timestamp. Use this parameter to retrieve the time when the notebook instance was
        /// last modified. 
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The network interface IDs that SageMaker AI created at the time of creating the instance.
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
        /// The Amazon Resource Name (ARN) of the notebook instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NotebookInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceArn property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceArn() => this.NotebookInstanceArn != null;

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
        [AWSProperty(Min = 0, Max = 63)]
        public string NotebookInstanceLifecycleConfigName { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceLifecycleConfigName property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceLifecycleConfigName() => this.NotebookInstanceLifecycleConfigName != null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceName. 
        /// <para>
        /// The name of the SageMaker AI notebook instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string NotebookInstanceName { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceName property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceName() => this.NotebookInstanceName != null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceStatus. 
        /// <para>
        /// The status of the notebook instance.
        /// </para>
        /// </summary>
        public NotebookInstanceStatus NotebookInstanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceStatus property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceStatus() => this.NotebookInstanceStatus != null;

        /// <summary>
        /// Gets and sets the property PlatformIdentifier. 
        /// <para>
        /// The platform identifier of the notebook instance runtime environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public string PlatformIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PlatformIdentifier property is set.
        /// </summary>
        internal bool IsSetPlatformIdentifier() => this.PlatformIdentifier != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role associated with the instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

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
        public RootAccess RootAccess { get; set; }

        /// <summary>
        /// Checks to see if the RootAccess property is set.
        /// </summary>
        internal bool IsSetRootAccess() => this.RootAccess != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The IDs of the VPC security groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the VPC subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL that you use to connect to the Jupyter notebook that is running in your notebook
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
        /// The size, in GB, of the ML storage volume attached to the notebook instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 16384)]
        public int? VolumeSizeInGB { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSizeInGB property is set.
        /// </summary>
        internal bool IsSetVolumeSizeInGB() => this.VolumeSizeInGB.HasValue;
    }
}
