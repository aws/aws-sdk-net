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
    /// This is the response object from the DescribeComputeQuota operation.
    /// </summary>
    public partial class DescribeComputeQuotaResponse : AmazonWebServiceResponse
    {
        private ActivationState _activationState;
        private string _clusterArn;
        private string _computeQuotaArn;
        private ComputeQuotaConfig _computeQuotaConfig;
        private string _computeQuotaId;
        private ComputeQuotaTarget _computeQuotaTarget;
        private int? _computeQuotaVersion;
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private string _description;
        private string _failureReason;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private string _name;
        private SchedulerResourceStatus _status;

        /// <summary>
        /// Gets and sets the property ActivationState. 
        /// <para>
        /// The state of the compute allocation being described. Use to enable or disable compute
        /// allocation.
        /// </para>
        ///  
        /// <para>
        /// Default is <c>Enabled</c>.
        /// </para>
        /// </summary>
        public ActivationState ActivationState
        {
            get { return this._activationState; }
            set { this._activationState = value; }
        }

        // Check to see if ActivationState property is set
        internal bool IsSetActivationState()
        {
            return this._activationState != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// ARN of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeQuotaArn. 
        /// <para>
        /// ARN of the compute allocation definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string ComputeQuotaArn
        {
            get { return this._computeQuotaArn; }
            set { this._computeQuotaArn = value; }
        }

        // Check to see if ComputeQuotaArn property is set
        internal bool IsSetComputeQuotaArn()
        {
            return this._computeQuotaArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeQuotaConfig. 
        /// <para>
        /// Configuration of the compute allocation definition. This includes the resource sharing
        /// option, and the setting to preempt low priority tasks.
        /// </para>
        /// </summary>
        public ComputeQuotaConfig ComputeQuotaConfig
        {
            get { return this._computeQuotaConfig; }
            set { this._computeQuotaConfig = value; }
        }

        // Check to see if ComputeQuotaConfig property is set
        internal bool IsSetComputeQuotaConfig()
        {
            return this._computeQuotaConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeQuotaId. 
        /// <para>
        /// ID of the compute allocation definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComputeQuotaId
        {
            get { return this._computeQuotaId; }
            set { this._computeQuotaId = value; }
        }

        // Check to see if ComputeQuotaId property is set
        internal bool IsSetComputeQuotaId()
        {
            return this._computeQuotaId != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeQuotaTarget. 
        /// <para>
        /// The target entity to allocate compute resources to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputeQuotaTarget ComputeQuotaTarget
        {
            get { return this._computeQuotaTarget; }
            set { this._computeQuotaTarget = value; }
        }

        // Check to see if ComputeQuotaTarget property is set
        internal bool IsSetComputeQuotaTarget()
        {
            return this._computeQuotaTarget != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeQuotaVersion. 
        /// <para>
        /// Version of the compute allocation definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ComputeQuotaVersion
        {
            get { return this._computeQuotaVersion; }
            set { this._computeQuotaVersion = value; }
        }

        // Check to see if ComputeQuotaVersion property is set
        internal bool IsSetComputeQuotaVersion()
        {
            return this._computeQuotaVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the compute allocation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the compute allocation definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Failure reason of the compute allocation definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Last modified time of the compute allocation configuration.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the compute allocation definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the compute allocation definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchedulerResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}