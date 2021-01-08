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
    /// An object representing an AWS Batch compute environment.
    /// </summary>
    public partial class ComputeEnvironmentDetail
    {
        private string _computeEnvironmentArn;
        private string _computeEnvironmentName;
        private ComputeResource _computeResources;
        private string _ecsClusterArn;
        private string _serviceRole;
        private CEState _state;
        private CEStatus _status;
        private string _statusReason;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private CEType _type;

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
        /// The name of the compute environment. Up to 128 letters (uppercase and lowercase),
        /// numbers, hyphens, and underscores are allowed.
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
        /// Environments</a> in the <i>AWS Batch User Guide</i>.
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
        /// Gets and sets the property EcsClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the underlying Amazon ECS cluster used by the compute
        /// environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The service role associated with the compute environment that allows AWS Batch to
        /// make calls to AWS API operations on your behalf. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/service_IAM_role.html">AWS
        /// Batch service IAM role</a> in the <i>AWS Batch User Guide</i>.
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
        /// If the state is <code>ENABLED</code>, then the AWS Batch scheduler can attempt to
        /// place jobs from an associated job queue on the compute resources within the environment.
        /// If the compute environment is managed, then it can scale its instances out or in automatically,
        /// based on the job queue demand.
        /// </para>
        ///  
        /// <para>
        /// If the state is <code>DISABLED</code>, then the AWS Batch scheduler doesn't attempt
        /// to place jobs within the environment. Jobs in a <code>STARTING</code> or <code>RUNNING</code>
        /// state continue to progress normally. Managed compute environments in the <code>DISABLED</code>
        /// state don't scale out. However, they scale in to <code>minvCpus</code> value after
        /// instances become idle.
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
        /// A short, human-readable string to provide additional details about the current status
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
        /// Environments</a> in the <i>AWS Batch User Guide</i>.
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

    }
}