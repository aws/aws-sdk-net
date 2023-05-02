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
    /// An object that represents an Batch compute environment.
    /// </summary>
    public partial class ComputeEnvironmentDetail
    {
        private string _computeEnvironmentArn;
        private string _computeEnvironmentName;
        private ComputeResource _computeResources;
        private OrchestrationType _containerOrchestrationType;
        private string _ecsClusterArn;
        private EksConfiguration _eksConfiguration;
        private string _serviceRole;
        private CEState _state;
        private CEStatus _status;
        private string _statusReason;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private CEType _type;
        private int? _unmanagedvCpus;
        private UpdatePolicy _updatePolicy;
        private string _uuid;

        /// <summary>
        /// Gets and sets the property ComputeEnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the compute environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComputeEnvironmentArn
        {
            get { return this._computeEnvironmentArn; }
            set { this._computeEnvironmentArn = value; }
        }

        // Check to see if ComputeEnvironmentArn property is set
        internal bool IsSetComputeEnvironmentArn()
        {
            return this._computeEnvironmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeEnvironmentName. 
        /// <para>
        /// The name of the compute environment. It can be up to 128 characters long. It can contain
        /// uppercase and lowercase letters, numbers, hyphens (-), and underscores (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComputeEnvironmentName
        {
            get { return this._computeEnvironmentName; }
            set { this._computeEnvironmentName = value; }
        }

        // Check to see if ComputeEnvironmentName property is set
        internal bool IsSetComputeEnvironmentName()
        {
            return this._computeEnvironmentName != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeResources. 
        /// <para>
        /// The compute resources defined for the compute environment. For more information, see
        /// <a href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
        /// environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public ComputeResource ComputeResources
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
        /// Gets and sets the property ContainerOrchestrationType. 
        /// <para>
        /// The orchestration type of the compute environment. The valid values are <code>ECS</code>
        /// (default) or <code>EKS</code>.
        /// </para>
        /// </summary>
        public OrchestrationType ContainerOrchestrationType
        {
            get { return this._containerOrchestrationType; }
            set { this._containerOrchestrationType = value; }
        }

        // Check to see if ContainerOrchestrationType property is set
        internal bool IsSetContainerOrchestrationType()
        {
            return this._containerOrchestrationType != null;
        }

        /// <summary>
        /// Gets and sets the property EcsClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the underlying Amazon ECS cluster that the compute
        /// environment uses.
        /// </para>
        /// </summary>
        public string EcsClusterArn
        {
            get { return this._ecsClusterArn; }
            set { this._ecsClusterArn = value; }
        }

        // Check to see if EcsClusterArn property is set
        internal bool IsSetEcsClusterArn()
        {
            return this._ecsClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property EksConfiguration. 
        /// <para>
        /// The configuration for the Amazon EKS cluster that supports the Batch compute environment.
        /// Only specify this parameter if the <code>containerOrchestrationType</code> is <code>EKS</code>.
        /// </para>
        /// </summary>
        public EksConfiguration EksConfiguration
        {
            get { return this._eksConfiguration; }
            set { this._eksConfiguration = value; }
        }

        // Check to see if EksConfiguration property is set
        internal bool IsSetEksConfiguration()
        {
            return this._eksConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The service role that's associated with the compute environment that allows Batch
        /// to make calls to Amazon Web Services API operations on your behalf. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/service_IAM_role.html">Batch
        /// service IAM role</a> in the <i>Batch User Guide</i>.
        /// </para>
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
        /// The state of the compute environment. The valid values are <code>ENABLED</code> or
        /// <code>DISABLED</code>.
        /// </para>
        ///  
        /// <para>
        /// If the state is <code>ENABLED</code>, then the Batch scheduler can attempt to place
        /// jobs from an associated job queue on the compute resources within the environment.
        /// If the compute environment is managed, then it can scale its instances out or in automatically
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the compute environment (for example, <code>CREATING</code>
        /// or <code>VALID</code>).
        /// </para>
        /// </summary>
        public CEStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide additional details for the current status
        /// of the compute environment.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags applied to the compute environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the compute environment: <code>MANAGED</code> or <code>UNMANAGED</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html">Compute
        /// environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public CEType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UnmanagedvCpus. 
        /// <para>
        /// The maximum number of VCPUs expected to be used for an unmanaged compute environment.
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
        /// Specifies the infrastructure update policy for the compute environment. For more information
        /// about infrastructure updates, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
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

        /// <summary>
        /// Gets and sets the property Uuid. 
        /// <para>
        /// Unique identifier for the compute environment.
        /// </para>
        /// </summary>
        public string Uuid
        {
            get { return this._uuid; }
            set { this._uuid = value; }
        }

        // Check to see if Uuid property is set
        internal bool IsSetUuid()
        {
            return this._uuid != null;
        }

    }
}