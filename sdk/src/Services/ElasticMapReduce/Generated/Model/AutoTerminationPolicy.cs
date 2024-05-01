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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// An auto-termination policy for an Amazon EMR cluster. An auto-termination policy defines
    /// the amount of idle time in seconds after which a cluster automatically terminates.
    /// For alternative cluster termination options, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-termination.html">Control
    /// cluster termination</a>.
    /// </summary>
    public partial class AutoTerminationPolicy
    {
        private long? _idleTimeout;

        /// <summary>
        /// Gets and sets the property IdleTimeout. 
        /// <para>
        /// Specifies the amount of idle time in seconds after which the cluster automatically
        /// terminates. You can specify a minimum of 60 seconds and a maximum of 604800 seconds
        /// (seven days).
        /// </para>
        /// </summary>
        public long? IdleTimeout
        {
            get { return this._idleTimeout; }
            set { this._idleTimeout = value; }
        }

        // Check to see if IdleTimeout property is set
        internal bool IsSetIdleTimeout()
        {
            return this._idleTimeout.HasValue; 
        }

    }
}