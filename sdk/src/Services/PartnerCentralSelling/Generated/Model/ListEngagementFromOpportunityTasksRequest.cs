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
    /// Container for the parameters to the ListEngagementFromOpportunityTasks operation.
    /// Lists all in-progress, completed, or failed <c>EngagementFromOpportunity</c> tasks
    /// that were initiated by the caller's account.
    /// </summary>
    public partial class ListEngagementFromOpportunityTasksRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private List<string> _engagementIdentifier = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _opportunityIdentifier = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ListTasksSortBase _sort;
        private List<string> _taskIdentifier = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _taskStatus = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        ///  Specifies the catalog related to the request. Valid values are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  AWS: Retrieves the request from the production AWS environment. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Sandbox: Retrieves the request from a sandbox environment used for testing or development
        /// purposes. 
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property EngagementIdentifier. 
        /// <para>
        ///  Filters tasks by the identifiers of the engagements they created or are associated
        /// with. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> EngagementIdentifier
        {
            get { return this._engagementIdentifier; }
            set { this._engagementIdentifier = value; }
        }

        // Check to see if EngagementIdentifier property is set
        internal bool IsSetEngagementIdentifier()
        {
            return this._engagementIdentifier != null && (this._engagementIdentifier.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Specifies the maximum number of results to return in a single page of the response.Use
        /// this parameter to control the number of items returned in each request, which can
        /// be useful for performance tuning and managing large result sets. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        ///  The token for requesting the next page of results. This value is obtained from the
        /// NextToken field in the response of a previous call to this API. Use this parameter
        /// for pagination when the result set spans multiple pages. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property OpportunityIdentifier. 
        /// <para>
        ///  The identifier of the original opportunity associated with this task. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> OpportunityIdentifier
        {
            get { return this._opportunityIdentifier; }
            set { this._opportunityIdentifier = value; }
        }

        // Check to see if OpportunityIdentifier property is set
        internal bool IsSetOpportunityIdentifier()
        {
            return this._opportunityIdentifier != null && (this._opportunityIdentifier.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        ///  Specifies the sorting criteria for the returned results. This allows you to order
        /// the tasks based on specific attributes. 
        /// </para>
        /// </summary>
        public ListTasksSortBase Sort
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
        /// Gets and sets the property TaskIdentifier. 
        /// <para>
        ///  Filters tasks by their unique identifiers. Use this when you want to retrieve information
        /// about specific tasks. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// Gets and sets the property TaskStatus. 
        /// <para>
        ///  Filters the tasks based on their current status. This allows you to focus on tasks
        /// in specific states. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> TaskStatus
        {
            get { return this._taskStatus; }
            set { this._taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this._taskStatus != null && (this._taskStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}