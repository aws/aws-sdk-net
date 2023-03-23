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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateComputeEnvironment operation.
    /// Updates an Batch compute environment.
    /// </summary>
    public partial class UpdateComputeEnvironmentRequest : AmazonBatchRequest
    {
        private string _computeEnvironment;
        private ComputeResourceUpdate _computeResources;
        private string _serviceRole;
        private CEState _state;
        private int? _unmanagedvCpus;
        private UpdatePolicy _updatePolicy;

        /// <summary>
        /// Gets and sets the property ComputeEnvironment. 
        /// <para>
        /// The name or full Amazon Resource Name (ARN) of the compute environment to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComputeEnvironment
        {
            get { return this._computeEnvironment; }
            set { this._computeEnvironment = value; }
        }

        // Check to see if ComputeEnvironment property is set
        internal bool IsSetComputeEnvironment()
        {
            return this._computeEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeResources. 
        /// <para>
        /// Details of the compute resources managed by the compute environment. Required for
        /// a managed compute environment. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
        /// Environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public ComputeResourceUpdate ComputeResources
        {
            get { return this._computeResources; }
            set { this._computeResources = value; }
        }

        // Check to see if ComputeResources property is set
        internal bool IsSetComputeResources()
        {
            return this._computeResources != null;
        }

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
        /// If your specified role has a path other than <code>/</code>, then you must either
        /// specify the full role ARN (recommended) or prefix the role name with the path.
        /// </para>
        ///  <note> 
        /// <para>
        /// Depending on how you created your Batch service role, its ARN might contain the <code>service-role</code>
        /// path prefix. When you only specify the name of the service role, Batch assumes that
        /// your ARN doesn't use the <code>service-role</code> path prefix. Because of this, we
        /// recommend that you specify the full ARN of your service role when you create compute
        /// environments.
        /// </para>
        ///  </note>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the compute environment. Compute environments in the <code>ENABLED</code>
        /// state can accept jobs from a queue and scale in or out automatically based on the
        /// workload demand of its associated queues.
        /// </para>
        ///  
        /// <para>
        /// If the state is <code>ENABLED</code>, then the Batch scheduler can attempt to place
        /// jobs from an associated job queue on the compute resources within the environment.
        /// If the compute environment is managed, then it can scale its instances out or in automatically,
        /// based on the job queue demand.
        /// </para>
        ///  
        /// <para>
        /// If the state is <code>DISABLED</code>, then the Batch scheduler doesn't attempt to
        /// place jobs within the environment. Jobs in a <code>STARTING</code> or <code>RUNNING</code>
        /// state continue to progress normally. Managed compute environments in the <code>DISABLED</code>
        /// state don't scale out. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Compute environments in a <code>DISABLED</code> state may continue to incur billing
        /// charges. To prevent additional charges, turn off and then delete the compute environment.
        /// For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environment_parameters.html#compute_environment_state">State</a>
        /// in the <i>Batch User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When an instance is idle, the instance scales down to the <code>minvCpus</code> value.
        /// However, the instance size doesn't change. For example, consider a <code>c5.8xlarge</code>
        /// instance with a <code>minvCpus</code> value of <code>4</code> and a <code>desiredvCpus</code>
        /// value of <code>36</code>. This instance doesn't scale down to a <code>c5.large</code>
        /// instance.
        /// </para>
        /// </summary>
        public CEState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property UnmanagedvCpus. 
        /// <para>
        /// The maximum number of vCPUs expected to be used for an unmanaged compute environment.
        /// Don't specify this parameter for a managed compute environment. This parameter is
        /// only used for fair share scheduling to reserve vCPU capacity for new share identifiers.
        /// If this parameter isn't provided for a fair share job queue, no vCPU capacity is reserved.
        /// </para>
        /// </summary>
        public int UnmanagedvCpus
        {
            get { return this._unmanagedvCpus.GetValueOrDefault(); }
            set { this._unmanagedvCpus = value; }
        }

        // Check to see if UnmanagedvCpus property is set
        internal bool IsSetUnmanagedvCpus()
        {
            return this._unmanagedvCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatePolicy. 
        /// <para>
        /// Specifies the updated infrastructure update policy for the compute environment. For
        /// more information about infrastructure updates, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public UpdatePolicy UpdatePolicy
        {
            get { return this._updatePolicy; }
            set { this._updatePolicy = value; }
        }

        // Check to see if UpdatePolicy property is set
        internal bool IsSetUpdatePolicy()
        {
            return this._updatePolicy != null;
        }

    }
}