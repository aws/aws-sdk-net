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
    /// Summary of the cluster policy.
    /// </summary>
    public partial class ClusterSchedulerConfigSummary
    {
        private string _clusterArn;
        private string _clusterSchedulerConfigArn;
        private string _clusterSchedulerConfigId;
        private int? _clusterSchedulerConfigVersion;
        private DateTime? _creationTime;
        private DateTime? _lastModifiedTime;
        private string _name;
        private SchedulerResourceStatus _status;

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