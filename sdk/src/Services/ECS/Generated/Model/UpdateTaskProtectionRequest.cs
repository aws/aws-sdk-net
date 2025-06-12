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
    /// Container for the parameters to the UpdateTaskProtection operation.
    /// Updates the protection status of a task. You can set <c>protectionEnabled</c> to <c>true</c>
    /// to protect your task from termination during scale-in events from <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-auto-scaling.html">Service
    /// Autoscaling</a> or <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">deployments</a>.
    /// 
    ///  
    /// <para>
    /// Task-protection, by default, expires after 2 hours at which point Amazon ECS clears
    /// the <c>protectionEnabled</c> property making the task eligible for termination by
    /// a subsequent scale-in event.
    /// </para>
    ///  
    /// <para>
    /// You can specify a custom expiration period for task protection from 1 minute to up
    /// to 2,880 minutes (48 hours). To specify the custom expiration period, set the <c>expiresInMinutes</c>
    /// property. The <c>expiresInMinutes</c> property is always reset when you invoke this
    /// operation for a task that already has <c>protectionEnabled</c> set to <c>true</c>.
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
    /// this operation for a standalone task will result in an <c>TASK_NOT_VALID</c> failure.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/api_failures_messages.html">API
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
        private List<string> _tasks = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// If you set <c>protectionEnabled</c> to <c>true</c>, you can specify the duration for
        /// task protection in minutes. You can specify a value from 1 minute to up to 2,880 minutes
        /// (48 hours). During this time, your task will not be terminated by scale-in events
        /// from Service Auto Scaling or deployments. After this time period lapses, <c>protectionEnabled</c>
        /// will be reset to <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// If you don’t specify the time, then the task is automatically protected for 120 minutes
        /// (2 hours).
        /// </para>
        /// </summary>
        public int? ExpiresInMinutes
        {
            get { return this._expiresInMinutes; }
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
        /// Specify <c>true</c> to mark a task for protection and <c>false</c> to unset protection,
        /// making it eligible for termination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ProtectionEnabled
        {
            get { return this._protectionEnabled; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tasks != null && (this._tasks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}