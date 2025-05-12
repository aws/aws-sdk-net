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
    /// This is the response object from the DescribeClusterSchedulerConfig operation.
    /// </summary>
    public partial class DescribeClusterSchedulerConfigResponse : AmazonWebServiceResponse
    {
        private string _clusterArn;
        private string _clusterSchedulerConfigArn;
        private string _clusterSchedulerConfigId;
        private int? _clusterSchedulerConfigVersion;
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private string _description;
        private string _failureReason;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private string _name;
        private SchedulerConfig _schedulerConfig;
        private SchedulerResourceStatus _status;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// ARN of the cluster where the cluster policy is applied.
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
        /// Gets and sets the property ClusterSchedulerConfigArn. 
        /// <para>
        /// ARN of the cluster policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string ClusterSchedulerConfigArn
        {
            get { return this._clusterSchedulerConfigArn; }
            set { this._clusterSchedulerConfigArn = value; }
        }

        // Check to see if ClusterSchedulerConfigArn property is set
        internal bool IsSetClusterSchedulerConfigArn()
        {
            return this._clusterSchedulerConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterSchedulerConfigId. 
        /// <para>
        /// ID of the cluster policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=12)]
        public string ClusterSchedulerConfigId
        {
            get { return this._clusterSchedulerConfigId; }
            set { this._clusterSchedulerConfigId = value; }
        }

        // Check to see if ClusterSchedulerConfigId property is set
        internal bool IsSetClusterSchedulerConfigId()
        {
            return this._clusterSchedulerConfigId != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterSchedulerConfigVersion. 
        /// <para>
        /// Version of the cluster policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ClusterSchedulerConfigVersion
        {
            get { return this._clusterSchedulerConfigVersion; }
            set { this._clusterSchedulerConfigVersion = value; }
        }

        // Check to see if ClusterSchedulerConfigVersion property is set
        internal bool IsSetClusterSchedulerConfigVersion()
        {
            return this._clusterSchedulerConfigVersion.HasValue; 
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
        /// Creation time of the cluster policy.
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
        /// Description of the cluster policy.
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
        /// Failure reason of the cluster policy.
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
        /// Last modified time of the cluster policy.
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
        /// Name of the cluster policy.
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
        /// Gets and sets the property SchedulerConfig. 
        /// <para>
        /// Cluster policy configuration. This policy is used for task prioritization and fair-share
        /// allocation. This helps prioritize critical workloads and distributes idle compute
        /// across entities.
        /// </para>
        /// </summary>
        public SchedulerConfig SchedulerConfig
        {
            get { return this._schedulerConfig; }
            set { this._schedulerConfig = value; }
        }

        // Check to see if SchedulerConfig property is set
        internal bool IsSetSchedulerConfig()
        {
            return this._schedulerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the cluster policy.
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