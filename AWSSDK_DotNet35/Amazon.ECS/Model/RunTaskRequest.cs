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
    /// Container for the parameters to the RunTask operation.
    /// Start a task using random placement and the default Amazon ECS scheduler. If you want
    /// to use your own scheduler or place a task on a specific container instance, use <code>StartTask</code>
    /// instead.
    /// 
    ///  <important> 
    /// <para>
    /// The <code>count</code> parameter is limited to 10 tasks per call.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class RunTaskRequest : AmazonECSRequest
    {
        private string _cluster;
        private int? _count;
        private TaskOverride _overrides;
        private string _startedBy;
        private string _taskDefinition;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that you want to
        /// run your task on. If you do not specify a cluster, the default cluster is assumed..
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
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of instantiations of the specified task that you would like to place on
        /// your cluster.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <code>count</code> parameter is limited to 10 tasks per call.
        /// </para>
        ///  </important>
        /// </summary>
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// A list of container overrides in JSON format that specify the name of a container
        /// in the specified task definition and the command it should run instead of its default.
        /// A total of 8192 characters are allowed for overrides. This limit includes the JSON
        /// formatting characters of the override structure.
        /// </para>
        /// </summary>
        public TaskOverride Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null;
        }

        /// <summary>
        /// Gets and sets the property StartedBy.
        /// </summary>
        public string StartedBy
        {
            get { return this._startedBy; }
            set { this._startedBy = value; }
        }

        // Check to see if StartedBy property is set
        internal bool IsSetStartedBy()
        {
            return this._startedBy != null;
        }

        /// <summary>
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The <code>family</code> and <code>revision</code> (<code>family:revision</code>) or
        /// full Amazon Resource Name (ARN) of the task definition that you want to run.
        /// </para>
        /// </summary>
        public string TaskDefinition
        {
            get { return this._taskDefinition; }
            set { this._taskDefinition = value; }
        }

        // Check to see if TaskDefinition property is set
        internal bool IsSetTaskDefinition()
        {
            return this._taskDefinition != null;
        }

    }
}