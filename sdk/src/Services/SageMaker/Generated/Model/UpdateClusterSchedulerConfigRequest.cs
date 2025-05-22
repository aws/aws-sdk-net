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
    /// Container for the parameters to the UpdateClusterSchedulerConfig operation.
    /// Update the cluster policy configuration.
    /// </summary>
    public partial class UpdateClusterSchedulerConfigRequest : AmazonSageMakerRequest
    {
        private string _clusterSchedulerConfigId;
        private string _description;
        private SchedulerConfig _schedulerConfig;
        private int? _targetVersion;

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
        /// Gets and sets the property SchedulerConfig. 
        /// <para>
        /// Cluster policy configuration.
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
        /// Gets and sets the property TargetVersion. 
        /// <para>
        /// Target version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TargetVersion
        {
            get { return this._targetVersion; }
            set { this._targetVersion = value; }
        }

        // Check to see if TargetVersion property is set
        internal bool IsSetTargetVersion()
        {
            return this._targetVersion.HasValue; 
        }

    }
}