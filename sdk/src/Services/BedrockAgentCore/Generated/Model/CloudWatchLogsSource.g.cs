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
    /// The configuration for reading agent traces from CloudWatch Logs.
    /// </summary>
    public partial class CloudWatchLogsSource
    {
        /// <summary>
        /// Gets and sets the property FilterConfig. 
        /// <para>
        /// Optional filter configuration to narrow down which sessions to evaluate.
        /// </para>
        /// </summary>
        public CloudWatchFilterConfig FilterConfig { get; set; }

        /// <summary>
        /// Checks to see if the FilterConfig property is set.
        /// </summary>
        internal bool IsSetFilterConfig() => this.FilterConfig != null;

        /// <summary>
        /// Gets and sets the property LogGroupNamePrefixes. 
        /// <para>
        /// The list of CloudWatch log group name prefixes to read agent traces from. Specify
        /// this instead of <c>logGroupNames</c> to match log groups by prefix. Maximum of 5 prefixes.
        /// Specify either <c>logGroupNames</c> or <c>logGroupNamePrefixes</c>, not both. One
        /// of the two is required.
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
        /// The list of CloudWatch log group names to read agent traces from. Maximum of 10 log
        /// groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> LogGroupNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogGroupNames property is set.
        /// </summary>
        internal bool IsSetLogGroupNames() => this.LogGroupNames != null && (this.LogGroupNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceNames. 
        /// <para>
        /// The list of agent service names to filter traces within the specified log groups.
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
    }
}
