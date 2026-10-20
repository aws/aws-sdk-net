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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ExecuteCommand operation. Runs a command remotely
    /// on a container within a task. <para> If you use a condition key in your IAM policy
    /// to refine the conditions for the policy statement, for example limit the actions to
    /// a specific cluster, you receive an <c>AccessDeniedException</c> when there is a mismatch
    /// between the condition key value and the corresponding parameter value. </para> <para>
    /// For information about required permissions and considerations, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-exec.html">Using
    /// Amazon ECS Exec for debugging</a> in the <i>Amazon ECS Developer Guide</i>. </para>
    /// </summary>
    public partial class ExecuteCommandRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The Amazon Resource Name (ARN) or short name of the cluster the task is running in.
        /// If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
        public string Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command to run on the container.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Command { get; set; }

        /// <summary>
        /// Checks to see if the Command property is set.
        /// </summary>
        internal bool IsSetCommand() => this.Command != null;

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// The name of the container to execute the command on. A container name only needs to
        /// be specified for tasks containing multiple containers.
        /// </para>
        /// </summary>
        public string Container { get; set; }

        /// <summary>
        /// Checks to see if the Container property is set.
        /// </summary>
        internal bool IsSetContainer() => this.Container != null;

        /// <summary>
        /// Gets and sets the property Interactive. 
        /// <para>
        /// Use this flag to run your command in interactive mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Interactive { get; set; }

        /// <summary>
        /// Checks to see if the Interactive property is set.
        /// </summary>
        internal bool IsSetInteractive() => this.Interactive.HasValue;

        /// <summary>
        /// Gets and sets the property Task. 
        /// <para>
        /// The Amazon Resource Name (ARN) or ID of the task the container is part of.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Task { get; set; }

        /// <summary>
        /// Checks to see if the Task property is set.
        /// </summary>
        internal bool IsSetTask() => this.Task != null;
    }
}
