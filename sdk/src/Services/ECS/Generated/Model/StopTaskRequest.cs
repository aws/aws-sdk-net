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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the StopTask operation.
    /// Stops a running task. Any tags associated with the task will be deleted.
    /// 
    ///  
    /// <para>
    /// When you call <c>StopTask</c> on a task, the equivalent of <c>docker stop</c> is issued
    /// to the containers running in the task. This results in a <c>SIGTERM</c> value and
    /// a default 30-second timeout, after which the <c>SIGKILL</c> value is sent and the
    /// containers are forcibly stopped. If the container handles the <c>SIGTERM</c> value
    /// gracefully and exits within 30 seconds from receiving it, no <c>SIGKILL</c> value
    /// is sent.
    /// </para>
    ///  
    /// <para>
    /// For Windows containers, POSIX signals do not work and runtime stops the container
    /// by sending a <c>CTRL_SHUTDOWN_EVENT</c>. For more information, see <a href="https://github.com/moby/moby/issues/25982">Unable
    /// to react to graceful shutdown of (Windows) container #25982</a> on GitHub.
    /// </para>
    ///  <note> 
    /// <para>
    /// The default 30-second timeout can be configured on the Amazon ECS container agent
    /// with the <c>ECS_CONTAINER_STOP_TIMEOUT</c> variable. For more information, see <a
    /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html">Amazon
    /// ECS Container Agent Configuration</a> in the <i>Amazon Elastic Container Service Developer
    /// Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StopTaskRequest : AmazonECSRequest
    {
        private string _cluster;
        private string _reason;
        private string _task;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the task
        /// to stop. If you do not specify a cluster, the default cluster is assumed.
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// An optional message specified when a task is stopped. For example, if you're using
        /// a custom scheduler, you can use this parameter to specify the reason for stopping
        /// the task here, and the message appears in subsequent <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DescribeTasks.html">DescribeTasks</a>&gt;
        /// API operations on this task.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property Task. 
        /// <para>
        /// Thefull Amazon Resource Name (ARN) of the task.
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