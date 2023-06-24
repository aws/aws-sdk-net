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
    /// An object representing a container health check. Health check parameters that are
    /// specified in a container definition override any Docker health checks that exist in
    /// the container image (such as those specified in a parent image or from the image's
    /// Dockerfile). This configuration maps to the <code>HEALTHCHECK</code> parameter of
    /// <a href="https://docs.docker.com/engine/reference/run/">docker run</a>.
    /// 
    ///  <note> 
    /// <para>
    /// The Amazon ECS container agent only monitors and reports on the health checks specified
    /// in the task definition. Amazon ECS does not monitor Docker health checks that are
    /// embedded in a container image and not specified in the container definition. Health
    /// check parameters that are specified in a container definition override any Docker
    /// health checks that exist in the container image.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can view the health status of both individual containers and a task with the DescribeTasks
    /// API operation or when viewing the task details in the console.
    /// </para>
    ///  
    /// <para>
    /// The following describes the possible <code>healthStatus</code> values for a container:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>HEALTHY</code>-The container health check has passed successfully.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UNHEALTHY</code>-The container health check has failed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UNKNOWN</code>-The container health check is being evaluated or there's no
    /// container health check defined.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following describes the possible <code>healthStatus</code> values for a task.
    /// The container health check status of non-essential containers don't have an effect
    /// on the health status of a task.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>HEALTHY</code>-All essential containers within the task have passed their health
    /// checks.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UNHEALTHY</code>-One or more essential containers have failed their health
    /// check.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UNKNOWN</code>-The essential containers within the task are still having their
    /// health checks evaluated, there are only nonessential containers with health checks
    /// defined, or there are no container health checks defined.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If a task is run manually, and not as part of a service, the task will continue its
    /// lifecycle regardless of its health status. For tasks that are part of a service, if
    /// the task reports as unhealthy then the task will be stopped and the service scheduler
    /// will replace it.
    /// </para>
    ///  
    /// <para>
    /// The following are notes about container health check support:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Container health checks require version 1.17.0 or greater of the Amazon ECS container
    /// agent. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html">Updating
    /// the Amazon ECS container agent</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Container health checks are supported for Fargate tasks if you're using platform version
    /// <code>1.1.0</code> or greater. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
    /// platform versions</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Container health checks aren't supported for tasks that are part of a service that's
    /// configured to use a Classic Load Balancer.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class HealthCheck
    {
        private List<string> _command = new List<string>();
        private int? _interval;
        private int? _retries;
        private int? _startPeriod;
        private int? _timeout;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// A string array representing the command that the container runs to determine if it
        /// is healthy. The string array must start with <code>CMD</code> to run the command arguments
        /// directly, or <code>CMD-SHELL</code> to run the command with the container's default
        /// shell. 
        /// </para>
        ///  
        /// <para>
        ///  When you use the Amazon Web Services Management Console JSON panel, the Command Line
        /// Interface, or the APIs, enclose the list of commands in double quotes and brackets.
        /// </para>
        ///  
        /// <para>
        ///  <code>[ "CMD-SHELL", "curl -f http://localhost/ || exit 1" ]</code> 
        /// </para>
        ///  
        /// <para>
        /// You don't include the double quotes and brackets when you use the Amazon Web Services
        /// Management Console.
        /// </para>
        ///  
        /// <para>
        ///  <code> CMD-SHELL, curl -f http://localhost/ || exit 1</code> 
        /// </para>
        ///  
        /// <para>
        /// An exit code of 0 indicates success, and non-zero exit code indicates failure. For
        /// more information, see <code>HealthCheck</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null && this._command.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The time period in seconds between each health check execution. You may specify between
        /// 5 and 300 seconds. The default value is 30 seconds.
        /// </para>
        /// </summary>
        public int Interval
        {
            get { return this._interval.GetValueOrDefault(); }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Retries. 
        /// <para>
        /// The number of times to retry a failed health check before the container is considered
        /// unhealthy. You may specify between 1 and 10 retries. The default value is 3.
        /// </para>
        /// </summary>
        public int Retries
        {
            get { return this._retries.GetValueOrDefault(); }
            set { this._retries = value; }
        }

        // Check to see if Retries property is set
        internal bool IsSetRetries()
        {
            return this._retries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartPeriod. 
        /// <para>
        /// The optional grace period to provide containers time to bootstrap before failed health
        /// checks count towards the maximum number of retries. You can specify between 0 and
        /// 300 seconds. By default, the <code>startPeriod</code> is off.
        /// </para>
        ///  <note> 
        /// <para>
        /// If a health check succeeds within the <code>startPeriod</code>, then the container
        /// is considered healthy and any subsequent failures count toward the maximum number
        /// of retries.
        /// </para>
        ///  </note>
        /// </summary>
        public int StartPeriod
        {
            get { return this._startPeriod.GetValueOrDefault(); }
            set { this._startPeriod = value; }
        }

        // Check to see if StartPeriod property is set
        internal bool IsSetStartPeriod()
        {
            return this._startPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The time period in seconds to wait for a health check to succeed before it is considered
        /// a failure. You may specify between 2 and 60 seconds. The default value is 5.
        /// </para>
        /// </summary>
        public int Timeout
        {
            get { return this._timeout.GetValueOrDefault(); }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

    }
}