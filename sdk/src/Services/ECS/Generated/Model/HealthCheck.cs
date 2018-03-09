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
    /// An object representing a container health check. Health check parameters that are
    /// specified in a container definition override any Docker health checks that exist in
    /// the container image (such as those specified in a parent image or from the image's
    /// Dockerfile).
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
        /// is healthy. The string array must start with <code>CMD</code> to execute the command
        /// arguments directly, or <code>CMD-SHELL</code> to run the command with the container's
        /// default shell. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>[ "CMD-SHELL", "curl -f http://localhost/ || exit 1" ]</code> 
        /// </para>
        ///  
        /// <para>
        /// An exit code of 0 indicates success, and non-zero exit code indicates failure. For
        /// more information, see <code>HealthCheck</code> in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.27/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.27/">Docker
        /// Remote API</a>.
        /// </para>
        /// </summary>
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
        /// unhealthy. You may specify between 1 and 10 retries. The default value is 3 retries.
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
        /// The optional grace period within which to provide containers time to bootstrap before
        /// failed health checks count towards the maximum number of retries. You may specify
        /// between 0 and 300 seconds. The <code>startPeriod</code> is disabled by default.
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
        /// a failure. You may specify between 2 and 60 seconds. The default value is 5 seconds.
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