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

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Defines the changes to the teams configured for Apache Airflow multi-team support
    /// when you update your Amazon MWAA environment. Use <c>AddOrUpdate</c> to add or modify
    /// teams, and <c>Remove</c> to remove teams by name.
    /// </summary>
    public partial class UpdateTeamsInput
    {
        /// <summary>
        /// Gets and sets the property AddOrUpdate. 
        /// <para>
        /// A map of teams to add to your environment, or to update if they already exist. Each
        /// entry maps a team name to its settings. Each team name must match the display name
        /// of an Amazon Web Services IAM Identity Center group associated with your environment.
        /// You can configure between <c>1</c> and <c>20</c> teams.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public Dictionary<string, TeamConfig> AddOrUpdate { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, TeamConfig>() : null;

        /// <summary>
        /// Checks to see if the AddOrUpdate property is set.
        /// </summary>
        internal bool IsSetAddOrUpdate() => this.AddOrUpdate != null && (this.AddOrUpdate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Remove. 
        /// <para>
        /// A list of team names to remove from your environment. For example, <c>team-a</c>.
        /// You can remove between <c>1</c> and <c>20</c> teams in a single update. Removing a
        /// team does not delete the team's DAG code from Amazon S3.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> Remove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Remove property is set.
        /// </summary>
        internal bool IsSetRemove() => this.Remove != null && (this.Remove.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
