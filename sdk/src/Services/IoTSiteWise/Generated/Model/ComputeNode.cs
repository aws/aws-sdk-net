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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// A single compute node in a pipeline DAG. Each compute node references a task and can
    /// declare dependencies on other nodes.
    /// </summary>
    public partial class ComputeNode
    {
        private string _computeNodeName;
        private List<string> _dependsOn = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _taskName;

        /// <summary>
        /// Gets and sets the property ComputeNodeName. 
        /// <para>
        /// The unique name for this compute node within the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ComputeNodeName
        {
            get { return this._computeNodeName; }
            set { this._computeNodeName = value; }
        }

        // Check to see if ComputeNodeName property is set
        internal bool IsSetComputeNodeName()
        {
            return this._computeNodeName != null;
        }

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// A list of compute node names that must complete successfully before this node can
        /// start.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }

        // Check to see if DependsOn property is set
        internal bool IsSetDependsOn()
        {
            return this._dependsOn != null && (this._dependsOn.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Environment variables specific to this compute node. These override pipeline-level
        /// environment variables with the same key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=20)]
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// The name of the task to execute for this compute node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TaskName
        {
            get { return this._taskName; }
            set { this._taskName = value; }
        }

        // Check to see if TaskName property is set
        internal bool IsSetTaskName()
        {
            return this._taskName != null;
        }

    }
}