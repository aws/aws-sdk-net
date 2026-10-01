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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The container health check command and associated configuration parameters for the
    /// container.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsHealthCheckDetails
    {
        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that the container runs to determine whether it is healthy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Command { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Command property is set.
        /// </summary>
        internal bool IsSetCommand() => this.Command != null && (this.Command.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The time period in seconds between each health check execution. The default value
        /// is 30 seconds.
        /// </para>
        /// </summary>
        public int? Interval { get; set; }

        /// <summary>
        /// Checks to see if the Interval property is set.
        /// </summary>
        internal bool IsSetInterval() => this.Interval.HasValue;

        /// <summary>
        /// Gets and sets the property Retries. 
        /// <para>
        /// The number of times to retry a failed health check before the container is considered
        /// unhealthy. The default value is 3.
        /// </para>
        /// </summary>
        public int? Retries { get; set; }

        /// <summary>
        /// Checks to see if the Retries property is set.
        /// </summary>
        internal bool IsSetRetries() => this.Retries.HasValue;

        /// <summary>
        /// Gets and sets the property StartPeriod. 
        /// <para>
        /// The optional grace period in seconds that allows containers time to bootstrap before
        /// failed health checks count towards the maximum number of retries.
        /// </para>
        /// </summary>
        public int? StartPeriod { get; set; }

        /// <summary>
        /// Checks to see if the StartPeriod property is set.
        /// </summary>
        internal bool IsSetStartPeriod() => this.StartPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The time period in seconds to wait for a health check to succeed before it is considered
        /// a failure. The default value is 5.
        /// </para>
        /// </summary>
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;
    }
}
