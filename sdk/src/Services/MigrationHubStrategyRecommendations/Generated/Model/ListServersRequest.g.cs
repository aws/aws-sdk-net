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

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Container for the parameters to the ListServers operation. Returns a list of all the
    /// servers.
    /// </summary>
    public partial class ListServersRequest : AmazonMigrationHubStrategyRecommendationsRequest
    {
        /// <summary>
        /// Gets and sets the property FilterValue. 
        /// <para>
        ///  Specifies the filter value, which is based on the type of server criteria. For example,
        /// if <c>serverCriteria</c> is <c>OS_NAME</c>, and the <c>filterValue</c> is equal to
        /// <c>WindowsServer</c>, then <c>ListServers</c> returns all of the servers matching
        /// the OS name <c>WindowsServer</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FilterValue { get; set; }

        /// <summary>
        /// Checks to see if the FilterValue property is set.
        /// </summary>
        internal bool IsSetFilterValue() => this.FilterValue != null;

        /// <summary>
        /// Gets and sets the property GroupIdFilter. 
        /// <para>
        ///  Specifies the group ID to filter on. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Group> GroupIdFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<Group>() : null;

        /// <summary>
        /// Checks to see if the GroupIdFilter property is set.
        /// </summary>
        internal bool IsSetGroupIdFilter() => this.GroupIdFilter != null && (this.GroupIdFilter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of items to include in the response. The maximum value is 100.
        /// 
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token from a previous call that you use to retrieve the next set of results.
        /// For example, if a previous call to this action returned 100 items, but you set <c>maxResults</c>
        /// to 10. You'll receive a set of 10 results along with a token. You then use the returned
        /// token to retrieve the next set of 10. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServerCriteria. 
        /// <para>
        ///  Criteria for filtering servers. 
        /// </para>
        /// </summary>
        public ServerCriteria ServerCriteria { get; set; }

        /// <summary>
        /// Checks to see if the ServerCriteria property is set.
        /// </summary>
        internal bool IsSetServerCriteria() => this.ServerCriteria != null;

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        ///  Specifies whether to sort by ascending (<c>ASC</c>) or descending (<c>DESC</c>) order.
        /// 
        /// </para>
        /// </summary>
        public SortOrder Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;
    }
}
