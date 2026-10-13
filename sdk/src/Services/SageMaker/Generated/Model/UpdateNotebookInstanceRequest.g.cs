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
    /// Container for the parameters to the UpdateNotebookInstance operation. Updates a notebook
    /// instance. NotebookInstance updates include upgrading or downgrading the ML compute
    /// instance used for your notebook instance to accommodate changes in your workload requirements.
    /// <note> <para> This API can attach lifecycle configurations to notebook instances.
    /// Lifecycle configuration scripts execute with root access and the notebook instance's
    /// IAM execution role privileges. Principals with this permission and access to lifecycle
    /// configurations can execute code with the execution role's credentials. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Customize
    /// a Notebook Instance Using a Lifecycle Configuration Script</a> for security best practices.
    /// </para> </note>
    /// </summary>
    public partial class UpdateNotebookInstanceRequest : AmazonSageMakerRequest
    {
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
        /// An array of up to three Git repositories to associate with the notebook instance.
        /// These can be either the names of Git repositories stored as resources in your account,
        /// or the URL of Git repositories in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">Amazon
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
        [AWSProperty(Min = 1, Max = 1024)]
        public string DefaultCodeRepository { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCodeRepository property is set.
        /// </summary>
        internal bool IsSetDefaultCodeRepository() => this.DefaultCodeRepository != null;

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
        public bool? DisassociateAcceleratorTypes { get; set; }

        /// <summary>
        /// Checks to see if the DisassociateAcceleratorTypes property is set.
        /// </summary>
        internal bool IsSetDisassociateAcceleratorTypes() => this.DisassociateAcceleratorTypes.HasValue;

        /// <summary>
        /// Gets and sets the property DisassociateAdditionalCodeRepositories. 
        /// <para>
        /// A list of names or URLs of the default Git repositories to remove from this notebook
        /// instance. This operation is idempotent. If you specify a Git repository that is not
        /// associated with the notebook instance when you call this method, it does not throw
        /// an error.
        /// </para>
        /// </summary>
        public bool? DisassociateAdditionalCodeRepositories { get; set; }

        /// <summary>
        /// Checks to see if the DisassociateAdditionalCodeRepositories property is set.
        /// </summary>
        internal bool IsSetDisassociateAdditionalCodeRepositories() => this.DisassociateAdditionalCodeRepositories.HasValue;

        /// <summary>
        /// Gets and sets the property DisassociateDefaultCodeRepository. 
        /// <para>
        /// The name or URL of the default Git repository to remove from this notebook instance.
        /// This operation is idempotent. If you specify a Git repository that is not associated
        /// with the notebook instance when you call this method, it does not throw an error.
        /// </para>
        /// </summary>
        public bool? DisassociateDefaultCodeRepository { get; set; }

        /// <summary>
        /// Checks to see if the DisassociateDefaultCodeRepository property is set.
        /// </summary>
        internal bool IsSetDisassociateDefaultCodeRepository() => this.DisassociateDefaultCodeRepository.HasValue;

        /// <summary>
        /// Gets and sets the property DisassociateLifecycleConfig. 
        /// <para>
        /// Set to <c>true</c> to remove the notebook instance lifecycle configuration currently
        /// associated with the notebook instance. This operation is idempotent. If you specify
        /// a lifecycle configuration that is not associated with the notebook instance when you
        /// call this method, it does not throw an error.
        /// </para>
        /// </summary>
        public bool? DisassociateLifecycleConfig { get; set; }

        /// <summary>
        /// Checks to see if the DisassociateLifecycleConfig property is set.
        /// </summary>
        internal bool IsSetDisassociateLifecycleConfig() => this.DisassociateLifecycleConfig.HasValue;

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
        /// The Amazon ML compute instance type.
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
        /// The IP address type for the notebook instance. Specify <c>ipv4</c> for IPv4-only connectivity
        /// or <c>dualstack</c> for both IPv4 and IPv6 connectivity. The notebook instance must
        /// be stopped before updating this setting. When you specify <c>dualstack</c>, the subnet
        /// must support IPv6 addressing.
        /// </para>
        /// </summary>
        public IPAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property LifecycleConfigName. 
        /// <para>
        /// The name of a lifecycle configuration to associate with the notebook instance. For
        /// information about lifestyle configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
        /// 2.1: (Optional) Customize a Notebook Instance</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string LifecycleConfigName { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleConfigName property is set.
        /// </summary>
        internal bool IsSetLifecycleConfigName() => this.LifecycleConfigName != null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceName. 
        /// <para>
        /// The name of the notebook instance to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string NotebookInstanceName { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceName property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceName() => this.NotebookInstanceName != null;

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
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

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
        public RootAccess RootAccess { get; set; }

        /// <summary>
        /// Checks to see if the RootAccess property is set.
        /// </summary>
        internal bool IsSetRootAccess() => this.RootAccess != null;

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
        [AWSProperty(Min = 5, Max = 16384)]
        public int? VolumeSizeInGB { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSizeInGB property is set.
        /// </summary>
        internal bool IsSetVolumeSizeInGB() => this.VolumeSizeInGB.HasValue;
    }
}
