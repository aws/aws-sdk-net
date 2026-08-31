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
    /// Container for the parameters to the UpdateComputeEnvironment operation. Updates an
    /// Batch compute environment.
    /// </summary>
    public partial class UpdateComputeEnvironmentRequest : AmazonBatchRequest
    {
        /// <summary>
        /// Gets and sets the property ComputeEnvironment. 
        /// <para>
        /// The name or full Amazon Resource Name (ARN) of the compute environment to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ComputeEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the ComputeEnvironment property is set.
        /// </summary>
        internal bool IsSetComputeEnvironment() => this.ComputeEnvironment != null;

        /// <summary>
        /// Gets and sets the property ComputeResources. 
        /// <para>
        /// Details of the compute resources managed by the compute environment. Required for
        /// a managed compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
        /// Environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public ComputeResourceUpdate ComputeResources { get; set; }

        /// <summary>
        /// Checks to see if the ComputeResources property is set.
        /// </summary>
        internal bool IsSetComputeResources() => this.ComputeResources != null;

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
        /// Gets and sets the property EcsSettings. 
        /// <para>
        /// The Amazon ECS settings for the compute environment. These settings control CloudWatch
        /// Container Insights collection for the compute environment.
        /// </para>
        /// </summary>
        public EcsSettings EcsSettings { get; set; }

        /// <summary>
        /// Checks to see if the EcsSettings property is set.
        /// </summary>
        internal bool IsSetEcsSettings() => this.EcsSettings != null;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that allows Batch to make calls
        /// to other Amazon Web Services services on your behalf. For more information, see <a
        /// href="https://docs.aws.amazon.com/batch/latest/userguide/service_IAM_role.html">Batch
        /// service IAM role</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the compute environment has a service-linked role, it can't be changed to use a
        /// regular IAM role. Likewise, if the compute environment has a regular IAM role, it
        /// can't be changed to use a service-linked role. To update the parameters for the compute
        /// environment that require an infrastructure update to change, the <b>AWSServiceRoleForBatch</b>
        /// service-linked role must be used. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If your specified role has a path other than <c>/</c>, then you must either specify
        /// the full role ARN (recommended) or prefix the role name with the path.
        /// </para>
        ///  <note> 
        /// <para>
        /// Depending on how you created your Batch service role, its ARN might contain the <c>service-role</c>
        /// path prefix. When you only specify the name of the service role, Batch assumes that
        /// your ARN doesn't use the <c>service-role</c> path prefix. Because of this, we recommend
        /// that you specify the full ARN of your service role when you create compute environments.
        /// </para>
        ///  </note>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the compute environment. Compute environments in the <c>ENABLED</c> state
        /// can accept jobs from a queue and scale in or out automatically based on the workload
        /// demand of its associated queues.
        /// </para>
        ///  
        /// <para>
        /// If the state is <c>ENABLED</c>, then the Batch scheduler can attempt to place jobs
        /// from an associated job queue on the compute resources within the environment. If the
        /// compute environment is managed, then it can scale its instances out or in automatically,
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
        /// Gets and sets the property UnmanagedvCpus. 
        /// <para>
        /// The maximum number of vCPUs expected to be used for an unmanaged compute environment.
        /// Don't specify this parameter for a managed compute environment. This parameter is
        /// only used for fair-share scheduling to reserve vCPU capacity for new share identifiers.
        /// If this parameter isn't provided for a fair-share job queue, no vCPU capacity is reserved.
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
        /// Specifies the updated infrastructure update policy for the compute environment. For
        /// more information about infrastructure updates, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public UpdatePolicy UpdatePolicy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatePolicy property is set.
        /// </summary>
        internal bool IsSetUpdatePolicy() => this.UpdatePolicy != null;
    }
}
