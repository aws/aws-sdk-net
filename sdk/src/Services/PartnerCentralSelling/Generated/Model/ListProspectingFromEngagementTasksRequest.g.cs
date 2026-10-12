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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the ListProspectingFromEngagementTasks operation.
    /// Lists all prospecting tasks initiated by the caller's account. Supports optional filters
    /// by task identifier, task name, or start time range. Results can be sorted using configurable
    /// options. The response is paginated. Use the <c>NextToken</c> value from each response
    /// to retrieve subsequent pages.
    /// </summary>
    public partial class ListProspectingFromEngagementTasksRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog to list tasks from. Specify <c>AWS</c> for production environments
        /// and <c>Sandbox</c> for testing and development purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single page. If additional results exist,
        /// the response includes a <c>NextToken</c> value for retrieving the next page. If omitted,
        /// the API uses a service-defined default page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token from a previous call to this API. Include this value to retrieve
        /// the next page of results. If omitted, the first page is returned.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// Specifies the field and order used to sort the returned tasks. If omitted, tasks are
        /// returned in the default sort order.
        /// </para>
        /// </summary>
        public ProspectingFromEngagementTaskSort Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;

        /// <summary>
        /// Gets and sets the property StartAfter. 
        /// <para>
        /// Filters tasks to include only those that started after the specified timestamp. Use
        /// this with <c>StartBefore</c> to define a start-time range for your query. The format
        /// follows ISO 8601 date-time notation.
        /// </para>
        /// </summary>
        public DateTime? StartAfter { get; set; }

        /// <summary>
        /// Checks to see if the StartAfter property is set.
        /// </summary>
        internal bool IsSetStartAfter() => this.StartAfter.HasValue;

        /// <summary>
        /// Gets and sets the property StartBefore. 
        /// <para>
        /// Filters tasks to include only those that started before the specified timestamp. Use
        /// this with <c>StartAfter</c> to define a start-time range for your query. The format
        /// follows ISO 8601 date-time notation.
        /// </para>
        /// </summary>
        public DateTime? StartBefore { get; set; }

        /// <summary>
        /// Checks to see if the StartBefore property is set.
        /// </summary>
        internal bool IsSetStartBefore() => this.StartBefore.HasValue;

        /// <summary>
        /// Gets and sets the property TaskIdentifier. 
        /// <para>
        /// Filters the results to include only the tasks with the specified identifiers. Provide
        /// up to 10 task IDs to narrow the list to specific tasks. If omitted, tasks are not
        /// filtered by identifier.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> TaskIdentifier { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TaskIdentifier property is set.
        /// </summary>
        internal bool IsSetTaskIdentifier() => this.TaskIdentifier != null && (this.TaskIdentifier.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// Filters the results to include only tasks with the specified names. Provide up to
        /// 10 task names to narrow the list. If omitted, tasks are not filtered by name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> TaskName { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TaskName property is set.
        /// </summary>
        internal bool IsSetTaskName() => this.TaskName != null && (this.TaskName.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
