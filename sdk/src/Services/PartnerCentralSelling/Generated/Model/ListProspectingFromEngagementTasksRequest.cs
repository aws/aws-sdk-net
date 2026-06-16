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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
        private string _catalog;
        private int? _maxResults;
        private string _nextToken;
        private ProspectingFromEngagementTaskSort _sort;
        private DateTime? _startAfter;
        private DateTime? _startBefore;
        private List<string> _taskIdentifier = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _taskName = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog to list tasks from. Specify <c>AWS</c> for production environments
        /// and <c>Sandbox</c> for testing and development purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single page. If additional results exist,
        /// the response includes a <c>NextToken</c> value for retrieving the next page. If omitted,
        /// the API uses a service-defined default page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token from a previous call to this API. Include this value to retrieve
        /// the next page of results. If omitted, the first page is returned.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// Specifies the field and order used to sort the returned tasks. If omitted, tasks are
        /// returned in the default sort order.
        /// </para>
        /// </summary>
        public ProspectingFromEngagementTaskSort Sort
        {
            get { return this._sort; }
            set { this._sort = value; }
        }

        // Check to see if Sort property is set
        internal bool IsSetSort()
        {
            return this._sort != null;
        }

        /// <summary>
        /// Gets and sets the property StartAfter. 
        /// <para>
        /// Filters tasks to include only those that started after the specified timestamp. Use
        /// this with <c>StartBefore</c> to define a start-time range for your query. The format
        /// follows ISO 8601 date-time notation.
        /// </para>
        /// </summary>
        public DateTime? StartAfter
        {
            get { return this._startAfter; }
            set { this._startAfter = value; }
        }

        // Check to see if StartAfter property is set
        internal bool IsSetStartAfter()
        {
            return this._startAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartBefore. 
        /// <para>
        /// Filters tasks to include only those that started before the specified timestamp. Use
        /// this with <c>StartAfter</c> to define a start-time range for your query. The format
        /// follows ISO 8601 date-time notation.
        /// </para>
        /// </summary>
        public DateTime? StartBefore
        {
            get { return this._startBefore; }
            set { this._startBefore = value; }
        }

        // Check to see if StartBefore property is set
        internal bool IsSetStartBefore()
        {
            return this._startBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskIdentifier. 
        /// <para>
        /// Filters the results to include only the tasks with the specified identifiers. Provide
        /// up to 10 task IDs to narrow the list to specific tasks. If omitted, tasks are not
        /// filtered by identifier.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> TaskIdentifier
        {
            get { return this._taskIdentifier; }
            set { this._taskIdentifier = value; }
        }

        // Check to see if TaskIdentifier property is set
        internal bool IsSetTaskIdentifier()
        {
            return this._taskIdentifier != null && (this._taskIdentifier.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// Filters the results to include only tasks with the specified names. Provide up to
        /// 10 task names to narrow the list. If omitted, tasks are not filtered by name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> TaskName
        {
            get { return this._taskName; }
            set { this._taskName = value; }
        }

        // Check to see if TaskName property is set
        internal bool IsSetTaskName()
        {
            return this._taskName != null && (this._taskName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}