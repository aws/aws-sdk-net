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
    /// Container for the parameters to the UpdateTaskProtection operation.
    /// Updates the protection status of a task. You can set <code>protectionEnabled</code>
    /// to <code>true</code> to protect your task from termination during scale-in events
    /// from <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-auto-scaling.html">Service
    /// Autoscaling</a> or <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">deployments</a>.
    /// 
    ///  
    /// <para>
    /// Task-protection, by default, expires after 2 hours at which point Amazon ECS unsets
    /// the <code>protectionEnabled</code> property making the task eligible for termination
    /// by a subsequent scale-in event.
    /// </para>
    ///  
    /// <para>
    /// You can specify a custom expiration period for task protection from 1 minute to up
    /// to 2,880 minutes (48 hours). To specify the custom expiration period, set the <code>expiresInMinutes</code>
    /// property. The <code>expiresInMinutes</code> property is always reset when you invoke
    /// this operation for a task that already has <code>protectionEnabled</code> set to <code>true</code>.
    /// You can keep extending the protection expiration period of a task by invoking this
    /// operation repeatedly.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Amazon ECS task protection, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-scale-in-protection.html">Task
    /// scale-in protection</a> in the <i> <i>Amazon Elastic Container Service Developer Guide</i>
    /// </i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is only supported for tasks belonging to an Amazon ECS service. Invoking
    /// this operation for a standalone task will result in an <code>TASK_NOT_VALID</code>
    /// failure. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/api_failures_messages.html">API
    /// failure reasons</a>.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// If you prefer to set task protection from within the container, we recommend using
    /// the <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-scale-in-protection-endpoint.html">Task
    /// scale-in protection endpoint</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateTaskProtectionRequest : AmazonECSRequest
    {
        private string _cluster;
        private int? _expiresInMinutes;
        private bool? _protectionEnabled;
        private List<string> _tasks = new List<string>();

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the service
        /// that the task sets exist in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ExpiresInMinutes. 
        /// <para>
        /// If you set <code>protectionEnabled</code> to <code>true</code>, you can specify the
        /// duration for task protection in minutes. You can specify a value from 1 minute to
        /// up to 2,880 minutes (48 hours). During this time, your task will not be terminated
        /// by scale-in events from Service Auto Scaling or deployments. After this time period
        /// lapses, <code>protectionEnabled</code> will be reset to <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// If you don’t specify the time, then the task is automatically protected for 120 minutes
        /// (2 hours).
        /// </para>
        /// </summary>
        public int ExpiresInMinutes
        {
            get { return this._expiresInMinutes.GetValueOrDefault(); }
            set { this._expiresInMinutes = value; }
        }

        // Check to see if ExpiresInMinutes property is set
        internal bool IsSetExpiresInMinutes()
        {
            return this._expiresInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProtectionEnabled. 
        /// <para>
        /// Specify <code>true</code> to mark a task for protection and <code>false</code> to
        /// unset protection, making it eligible for termination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool ProtectionEnabled
        {
            get { return this._protectionEnabled.GetValueOrDefault(); }
            set { this._protectionEnabled = value; }
        }

        // Check to see if ProtectionEnabled property is set
        internal bool IsSetProtectionEnabled()
        {
            return this._protectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tasks. 
        /// <para>
        /// A list of up to 10 task IDs or full ARN entries.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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