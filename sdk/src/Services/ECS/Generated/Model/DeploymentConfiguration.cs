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
    /// Optional deployment parameters that control how many tasks run during the deployment
    /// and the ordering of stopping and starting tasks.
    /// </summary>
    public partial class DeploymentConfiguration
    {
        private int? _maximumPercent;
        private int? _minimumHealthyPercent;

        /// <summary>
        /// Gets and sets the property MaximumPercent. 
        /// <para>
        /// If a service is using the rolling update (<code>ECS</code>) deployment type, the <b>maximum
        /// percent</b> parameter represents an upper limit on the number of tasks in a service
        /// that are allowed in the <code>RUNNING</code> or <code>PENDING</code> state during
        /// a deployment, as a percentage of the desired number of tasks (rounded down to the
        /// nearest integer), and while any container instances are in the <code>DRAINING</code>
        /// state if the service contains tasks using the EC2 launch type. This parameter enables
        /// you to define the deployment batch size. For example, if your service has a desired
        /// number of four tasks and a maximum percent value of 200%, the scheduler may start
        /// four new tasks before stopping the four older tasks (provided that the cluster resources
        /// required to do this are available). The default value for maximum percent is 200%.
        /// </para>
        ///  
        /// <para>
        /// If a service is using the blue/green (<code>CODE_DEPLOY</code>) deployment type and
        /// tasks that use the EC2 launch type, the <b>maximum percent</b> value is set to the
        /// default value and is used to define the upper limit on the number of the tasks in
        /// the service that remain in the <code>RUNNING</code> state while the container instances
        /// are in the <code>DRAINING</code> state. If the tasks in the service use the Fargate
        /// launch type, the maximum percent value is not used, although it is returned when describing
        /// your service.
        /// </para>
        /// </summary>
        public int MaximumPercent
        {
            get { return this._maximumPercent.GetValueOrDefault(); }
            set { this._maximumPercent = value; }
        }

        // Check to see if MaximumPercent property is set
        internal bool IsSetMaximumPercent()
        {
            return this._maximumPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumHealthyPercent. 
        /// <para>
        /// If a service is using the rolling update (<code>ECS</code>) deployment type, the <b>minimum
        /// healthy percent</b> represents a lower limit on the number of tasks in a service that
        /// must remain in the <code>RUNNING</code> state during a deployment, as a percentage
        /// of the desired number of tasks (rounded up to the nearest integer), and while any
        /// container instances are in the <code>DRAINING</code> state if the service contains
        /// tasks using the EC2 launch type. This parameter enables you to deploy without using
        /// additional cluster capacity. For example, if your service has a desired number of
        /// four tasks and a minimum healthy percent of 50%, the scheduler may stop two existing
        /// tasks to free up cluster capacity before starting two new tasks. Tasks for services
        /// that <i>do not</i> use a load balancer are considered healthy if they are in the <code>RUNNING</code>
        /// state; tasks for services that <i>do</i> use a load balancer are considered healthy
        /// if they are in the <code>RUNNING</code> state and they are reported as healthy by
        /// the load balancer. The default value for minimum healthy percent is 100%.
        /// </para>
        ///  
        /// <para>
        /// If a service is using the blue/green (<code>CODE_DEPLOY</code>) deployment type and
        /// tasks that use the EC2 launch type, the <b>minimum healthy percent</b> value is set
        /// to the default value and is used to define the lower limit on the number of the tasks
        /// in the service that remain in the <code>RUNNING</code> state while the container instances
        /// are in the <code>DRAINING</code> state. If the tasks in the service use the Fargate
        /// launch type, the minimum healthy percent value is not used, although it is returned
        /// when describing your service.
        /// </para>
        /// </summary>
        public int MinimumHealthyPercent
        {
            get { return this._minimumHealthyPercent.GetValueOrDefault(); }
            set { this._minimumHealthyPercent = value; }
        }

        // Check to see if MinimumHealthyPercent property is set
        internal bool IsSetMinimumHealthyPercent()
        {
            return this._minimumHealthyPercent.HasValue; 
        }

    }
}