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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents an Batch compute environment.
    /// </summary>
    public partial class ComputeEnvironmentDetail
    {
        /// <summary>
        /// Gets and sets the property ComputeEnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the compute environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ComputeEnvironmentArn { get; set; }

        /// <summary>
        /// Checks to see if the ComputeEnvironmentArn property is set.
        /// </summary>
        internal bool IsSetComputeEnvironmentArn() => this.ComputeEnvironmentArn != null;

        /// <summary>
        /// Gets and sets the property ComputeEnvironmentName. 
        /// <para>
        /// The name of the compute environment. It can be up to 128 characters long. It can contain
        /// uppercase and lowercase letters, numbers, hyphens (-), and underscores (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ComputeEnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the ComputeEnvironmentName property is set.
        /// </summary>
        internal bool IsSetComputeEnvironmentName() => this.ComputeEnvironmentName != null;

        /// <summary>
        /// Gets and sets the property ComputeResources. 
        /// <para>
        /// The compute resources defined for the compute environment. For more information, see
        /// <a href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
        /// environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public ComputeResource ComputeResources { get; set; }

        /// <summary>
        /// Checks to see if the ComputeResources property is set.
        /// </summary>
        internal bool IsSetComputeResources() => this.ComputeResources != null;

        /// <summary>
        /// Gets and sets the property ContainerOrchestrationType. 
        /// <para>
        /// The orchestration type of the compute environment. The valid values are <c>ECS</c>
        /// (default) or <c>EKS</c>.
        /// </para>
        /// </summary>
        public OrchestrationType ContainerOrchestrationType { get; set; }

        /// <summary>
        /// Checks to see if the ContainerOrchestrationType property is set.
        /// </summary>
        internal bool IsSetContainerOrchestrationType() => this.ContainerOrchestrationType != null;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property EcsClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the underlying Amazon ECS cluster that the compute
        /// environment uses.
        /// </para>
        /// </summary>
        public string EcsClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the EcsClusterArn property is set.
        /// </summary>
        internal bool IsSetEcsClusterArn() => this.EcsClusterArn != null;

        /// <summary>
        /// Gets and sets the property EcsSettings. 
        /// <para>
        /// The Amazon ECS settings for the compute environment. These settings control CloudWatch
        /// Container Insights collection.
        /// </para>
        /// </summary>
        public EcsSettings EcsSettings { get; set; }

        /// <summary>
        /// Checks to see if the EcsSettings property is set.
        /// </summary>
        internal bool IsSetEcsSettings() => this.EcsSettings != null;

        /// <summary>
        /// Gets and sets the property EksConfiguration. 
        /// <para>
        /// The configuration for the Amazon EKS cluster that supports the Batch compute environment.
        /// Only specify this parameter if the <c>containerOrchestrationType</c> is <c>EKS</c>.
        /// </para>
        /// </summary>
        public EksConfiguration EksConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EksConfiguration property is set.
        /// </summary>
        internal bool IsSetEksConfiguration() => this.EksConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The service role that's associated with the compute environment that allows Batch
        /// to make calls to Amazon Web Services API operations on your behalf. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/service_IAM_role.html">Batch
        /// service IAM role</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the compute environment. The valid values are <c>ENABLED</c> or <c>DISABLED</c>.
        /// </para>
        ///  
        /// <para>
        /// If the state is <c>ENABLED</c>, then the Batch scheduler can attempt to place jobs
        /// from an associated job queue on the compute resources within the environment. If the
        /// compute environment is managed, then it can scale its instances out or in automatically
        /// based on the job queue demand.
        /// </para>
        ///  
        /// <para>
        /// If the state is <c>DISABLED</c>, then the Batch scheduler doesn't attempt to place
        /// jobs within the environment. Jobs in a <c>STARTING</c> or <c>RUNNING</c> state continue
        /// to progress normally. Managed compute environments in the <c>DISABLED</c> state don't
        /// scale out. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Compute environments in a <c>DISABLED</c> state may continue to incur billing charges,
        /// for example, if they have running instances due to jobs that are still executing or
        /// a non-zero <c>minvCpus</c> setting. To prevent additional charges, disable and delete
        /// the compute environment.
        /// </para>
        ///  </note> 
        /// <para>
        /// When an instance is idle, the instance scales down to the <c>minvCpus</c> value. However,
        /// the instance size doesn't change. For example, consider a <c>c5.8xlarge</c> instance
        /// with a <c>minvCpus</c> value of <c>4</c> and a <c>desiredvCpus</c> value of <c>36</c>.
        /// This instance doesn't scale down to a <c>c5.large</c> instance.
        /// </para>
        /// </summary>
        public CEState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the compute environment (for example, <c>CREATING</c> or <c>VALID</c>).
        /// </para>
        /// </summary>
        public CEStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide additional details for the current status
        /// of the compute environment.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags applied to the compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the compute environment: <c>MANAGED</c> or <c>UNMANAGED</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
        /// environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public CEType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UnmanagedvCpus. 
        /// <para>
        /// The maximum number of VCPUs expected to be used for an unmanaged compute environment.
        /// </para>
        /// </summary>
        public int? UnmanagedvCpus { get; set; }

        /// <summary>
        /// Checks to see if the UnmanagedvCpus property is set.
        /// </summary>
        internal bool IsSetUnmanagedvCpus() => this.UnmanagedvCpus.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatePolicy. 
        /// <para>
        /// Specifies the infrastructure update policy for the compute environment. For more information
        /// about infrastructure updates, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public UpdatePolicy UpdatePolicy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatePolicy property is set.
        /// </summary>
        internal bool IsSetUpdatePolicy() => this.UpdatePolicy != null;

        /// <summary>
        /// Gets and sets the property Uuid. 
        /// <para>
        /// Unique identifier for the compute environment.
        /// </para>
        /// </summary>
        public string Uuid { get; set; }

        /// <summary>
        /// Checks to see if the Uuid property is set.
        /// </summary>
        internal bool IsSetUuid() => this.Uuid != null;
    }
}
