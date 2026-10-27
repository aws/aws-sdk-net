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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains Runtime Monitoring-specific details for a custom detection rule.
    /// </summary>
    public partial class DetectionRuleRuntimeMonitoringDetails
    {
        /// <summary>
        /// Gets and sets the property Platforms. 
        /// <para>
        /// The platforms on which the rule can run. The presence of a platform member indicates
        /// that the rule is supported on that platform; the absence of a member indicates that
        /// the rule cannot run on that platform at any agent version.
        /// </para>
        /// </summary>
        public DetectionRuleRuntimePlatforms Platforms { get; set; }

        /// <summary>
        /// Checks to see if the Platforms property is set.
        /// </summary>
        internal bool IsSetPlatforms() => this.Platforms != null;
    }
}
