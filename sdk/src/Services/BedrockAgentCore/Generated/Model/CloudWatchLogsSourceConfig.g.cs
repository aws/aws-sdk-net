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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A CloudWatch Logs source for a dataset generation. Specify either <c>logGroupNames</c>
    /// or <c>logGroupNamePrefixes</c>.
    /// </summary>
    public partial class CloudWatchLogsSourceConfig
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time window to read sessions from. The default is the time the generation
        /// starts.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property LogGroupNamePrefixes. 
        /// <para>
        /// Prefixes of the names of the log groups to read, from 1 to 5. You can't specify this
        /// together with <c>logGroupNames</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> LogGroupNamePrefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogGroupNamePrefixes property is set.
        /// </summary>
        internal bool IsSetLogGroupNamePrefixes() => this.LogGroupNamePrefixes != null && (this.LogGroupNamePrefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogGroupNames. 
        /// <para>
        /// The names of the log groups to read, from 1 to 5. You can't specify this together
        /// with <c>logGroupNamePrefixes</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> LogGroupNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogGroupNames property is set.
        /// </summary>
        internal bool IsSetLogGroupNames() => this.LogGroupNames != null && (this.LogGroupNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceNames. 
        /// <para>
        /// The service name of the agent, which matches the <c>service.name</c> resource attribute
        /// in its traces. Specify exactly one.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> ServiceNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ServiceNames property is set.
        /// </summary>
        internal bool IsSetServiceNames() => this.ServiceNames != null && (this.ServiceNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time window to read sessions from. The default is 7 days before <c>endTime</c>.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
