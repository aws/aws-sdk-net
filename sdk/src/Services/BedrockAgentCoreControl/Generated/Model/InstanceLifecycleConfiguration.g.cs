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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration that manages the lifecycle of instances in a capacity provider,
    /// including idle timeout and maximum lifetime.
    /// </summary>
    public partial class InstanceLifecycleConfiguration
    {
        /// <summary>
        /// Gets and sets the property IdleInstanceTimeout. 
        /// <para>
        /// The number of seconds an instance can remain idle before it is stopped. An instance
        /// is considered idle when all of its agents are idle. The default is 900 seconds (15
        /// minutes).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 1209600)]
        public int? IdleInstanceTimeout { get; set; }

        /// <summary>
        /// Checks to see if the IdleInstanceTimeout property is set.
        /// </summary>
        internal bool IsSetIdleInstanceTimeout() => this.IdleInstanceTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property MaxLifetime. 
        /// <para>
        /// The maximum lifetime of an instance, in seconds. When an instance reaches this limit,
        /// the service terminates it regardless of activity. The default is 28800 seconds (8
        /// hours). The maximum is 1209600 seconds (14 days).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 1209600)]
        public int? MaxLifetime { get; set; }

        /// <summary>
        /// Checks to see if the MaxLifetime property is set.
        /// </summary>
        internal bool IsSetMaxLifetime() => this.MaxLifetime.HasValue;
    }
}
