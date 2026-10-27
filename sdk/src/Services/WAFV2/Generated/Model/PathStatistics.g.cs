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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Statistics about bot traffic to a specific URI path, including the path, request count,
    /// percentage of total traffic, and the top bots accessing that path.
    /// </summary>
    public partial class PathStatistics
    {
        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The URI path. For example, <c>/api/</c> or <c>/api/v1/users</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Percentage. 
        /// <para>
        /// The percentage of total requests that were made to this path.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public double? Percentage { get; set; }

        /// <summary>
        /// Checks to see if the Percentage property is set.
        /// </summary>
        internal bool IsSetPercentage() => this.Percentage.HasValue;

        /// <summary>
        /// Gets and sets the property RequestCount. 
        /// <para>
        /// The number of requests to this path within the specified time window.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? RequestCount { get; set; }

        /// <summary>
        /// Checks to see if the RequestCount property is set.
        /// </summary>
        internal bool IsSetRequestCount() => this.RequestCount.HasValue;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Information about the bot filter that was applied to generate these statistics. This
        /// field is only populated when you filter by bot category, organization, or name.
        /// </para>
        /// </summary>
        public FilterSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property TopBots. 
        /// <para>
        /// The list of top bots accessing this path, ordered by request count. The number of
        /// bots included is determined by the <c>NumberOfTopTrafficBotsPerPath</c> parameter
        /// in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BotStatistics> TopBots { get; set; } = AWSConfigs.InitializeCollections ? new List<BotStatistics>() : null;

        /// <summary>
        /// Checks to see if the TopBots property is set.
        /// </summary>
        internal bool IsSetTopBots() => this.TopBots != null && (this.TopBots.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
