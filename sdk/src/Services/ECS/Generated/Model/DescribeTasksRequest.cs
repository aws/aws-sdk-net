/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTasks operation.
    /// Describes a specified task or tasks.
    /// </summary>
    public partial class DescribeTasksRequest : AmazonECSRequest
    {
        private string _cluster;
        private List<string> _tasks = new List<string>();

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the task
        /// to describe. If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

        /// <summary>
        /// Gets and sets the property Tasks. 
        /// <para>
        /// A list of up to 100 task IDs or full Amazon Resource Name (ARN) entries.
        /// </para>
        /// </summary>
        public List<string> Tasks
        {
            get { return this._tasks; }
            set { this._tasks = value; }
        }

        // Check to see if Tasks property is set
        internal bool IsSetTasks()
        {
            return this._tasks != null && this._tasks.Count > 0; 
        }

    }
}