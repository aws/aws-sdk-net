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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ExecuteCommand operation.
    /// Runs a command remotely on a container within a task.
    /// 
    ///  
    /// <para>
    /// If you use a condition key in your IAM policy to refine the conditions for the policy
    /// statement, for example limit the actions to a specific cluster, you receive an <code>AccessDeniedException</code>
    /// when there is a mismatch between the condition key value and the corresponding parameter
    /// value.
    /// </para>
    ///  
    /// <para>
    /// For information about required permissions and considerations, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-exec.htm">Using
    /// Amazon ECS Exec for debugging</a> in the <i>Amazon ECS Developer Guide</i>. 
    /// </para>
    /// </summary>
    public partial class ExecuteCommandRequest : AmazonECSRequest
    {
        private string _cluster;
        private string _command;
        private string _container;
        private bool? _interactive;
        private string _task;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The Amazon Resource Name (ARN) or short name of the cluster the task is running in.
        /// If you do not specify a cluster, the default cluster is assumed.
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
        /// Gets and sets the property Command. 
        /// <para>
        /// The command to run on the container.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null;
        }

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// The name of the container to execute the command on. A container name only needs to
        /// be specified for tasks containing multiple containers.
        /// </para>
        /// </summary>
        public string Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property Interactive. 
        /// <para>
        /// Use this flag to run your command in interactive mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Interactive
        {
            get { return this._interactive.GetValueOrDefault(); }
            set { this._interactive = value; }
        }

        // Check to see if Interactive property is set
        internal bool IsSetInteractive()
        {
            return this._interactive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Task. 
        /// <para>
        /// The Amazon Resource Name (ARN) or ID of the task the container is part of.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Task
        {
            get { return this._task; }
            set { this._task = value; }
        }

        // Check to see if Task property is set
        internal bool IsSetTask()
        {
            return this._task != null;
        }

    }
}