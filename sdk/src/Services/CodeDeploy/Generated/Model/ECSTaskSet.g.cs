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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about a set of Amazon ECS tasks in an CodeDeploy deployment. An Amazon
    /// ECS task set includes details such as the desired number of tasks, how many tasks
    /// are running, and whether the task set serves production traffic. An CodeDeploy application
    /// that uses the Amazon ECS compute platform deploys a containerized application in an
    /// Amazon ECS service as a task set.
    /// </summary>
    public partial class ECSTaskSet
    {
        /// <summary>
        /// Gets and sets the property DesiredCount. 
        /// <para>
        ///  The number of tasks in a task set. During a deployment that uses the Amazon ECS compute
        /// type, CodeDeploy instructs Amazon ECS to create a new task set and uses this value
        /// to determine how many tasks to create. After the updated task set is created, CodeDeploy
        /// shifts traffic to the new task set. 
        /// </para>
        /// </summary>
        public long? DesiredCount { get; set; }

        /// <summary>
        /// Checks to see if the DesiredCount property is set.
        /// </summary>
        internal bool IsSetDesiredCount() => this.DesiredCount.HasValue;

        /// <summary>
        /// Gets and sets the property Identifer. 
        /// <para>
        ///  A unique ID of an <c>ECSTaskSet</c>. 
        /// </para>
        /// </summary>
        public string Identifer { get; set; }

        /// <summary>
        /// Checks to see if the Identifer property is set.
        /// </summary>
        internal bool IsSetIdentifer() => this.Identifer != null;

        /// <summary>
        /// Gets and sets the property PendingCount. 
        /// <para>
        ///  The number of tasks in the task set that are in the <c>PENDING</c> status during
        /// an Amazon ECS deployment. A task in the <c>PENDING</c> state is preparing to enter
        /// the <c>RUNNING</c> state. A task set enters the <c>PENDING</c> status when it launches
        /// for the first time, or when it is restarted after being in the <c>STOPPED</c> state.
        /// 
        /// </para>
        /// </summary>
        public long? PendingCount { get; set; }

        /// <summary>
        /// Checks to see if the PendingCount property is set.
        /// </summary>
        internal bool IsSetPendingCount() => this.PendingCount.HasValue;

        /// <summary>
        /// Gets and sets the property RunningCount. 
        /// <para>
        ///  The number of tasks in the task set that are in the <c>RUNNING</c> status during
        /// an Amazon ECS deployment. A task in the <c>RUNNING</c> state is running and ready
        /// for use. 
        /// </para>
        /// </summary>
        public long? RunningCount { get; set; }

        /// <summary>
        /// Checks to see if the RunningCount property is set.
        /// </summary>
        internal bool IsSetRunningCount() => this.RunningCount.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the task set. There are three valid task set statuses: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PRIMARY</c>: Indicates the task set is serving production traffic. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: Indicates the task set is not serving production traffic. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DRAINING</c>: Indicates the tasks in the task set are being stopped and their
        /// corresponding targets are being deregistered from their target group. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetGroup. 
        /// <para>
        ///  The target group associated with the task set. The target group is used by CodeDeploy
        /// to manage traffic to a task set. 
        /// </para>
        /// </summary>
        public TargetGroupInfo TargetGroup { get; set; }

        /// <summary>
        /// Checks to see if the TargetGroup property is set.
        /// </summary>
        internal bool IsSetTargetGroup() => this.TargetGroup != null;

        /// <summary>
        /// Gets and sets the property TaskSetLabel. 
        /// <para>
        ///  A label that identifies whether the ECS task set is an original target (<c>BLUE</c>)
        /// or a replacement target (<c>GREEN</c>). 
        /// </para>
        /// </summary>
        public TargetLabel TaskSetLabel { get; set; }

        /// <summary>
        /// Checks to see if the TaskSetLabel property is set.
        /// </summary>
        internal bool IsSetTaskSetLabel() => this.TaskSetLabel != null;

        /// <summary>
        /// Gets and sets the property TrafficWeight. 
        /// <para>
        ///  The percentage of traffic served by this task set. 
        /// </para>
        /// </summary>
        public double? TrafficWeight { get; set; }

        /// <summary>
        /// Checks to see if the TrafficWeight property is set.
        /// </summary>
        internal bool IsSetTrafficWeight() => this.TrafficWeight.HasValue;
    }
}
