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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// The Shutdown event configuration.
    /// </summary>
    public partial class ShutdownEventConfiguration
    {
        private bool? _delayUntilElbConnectionsDrained;
        private int? _executionTimeout;

        /// <summary>
        /// Gets and sets the property DelayUntilElbConnectionsDrained. 
        /// <para>
        /// Whether to enable Elastic Load Balancing connection draining. For more information,
        /// see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#conn-drain">Connection
        /// Draining</a> 
        /// </para>
        /// </summary>
        public bool DelayUntilElbConnectionsDrained
        {
            get { return this._delayUntilElbConnectionsDrained.GetValueOrDefault(); }
            set { this._delayUntilElbConnectionsDrained = value; }
        }

        // Check to see if DelayUntilElbConnectionsDrained property is set
        internal bool IsSetDelayUntilElbConnectionsDrained()
        {
            return this._delayUntilElbConnectionsDrained.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionTimeout. 
        /// <para>
        /// The time, in seconds, that AWS OpsWorks Stacks will wait after triggering a Shutdown
        /// event before shutting down an instance.
        /// </para>
        /// </summary>
        public int ExecutionTimeout
        {
            get { return this._executionTimeout.GetValueOrDefault(); }
            set { this._executionTimeout = value; }
        }

        // Check to see if ExecutionTimeout property is set
        internal bool IsSetExecutionTimeout()
        {
            return this._executionTimeout.HasValue; 
        }

    }
}