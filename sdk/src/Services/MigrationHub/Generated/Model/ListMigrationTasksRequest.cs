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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
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
namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Container for the parameters to the ListMigrationTasks operation.
    /// Lists all, or filtered by resource name, migration tasks associated with the user
    /// account making this call. This API has the following traits:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Can show a summary list of the most recent migration tasks.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Can show a summary list of migration tasks associated with a given discovered resource.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Lists migration tasks in a paginated interface.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListMigrationTasksRequest : AmazonMigrationHubRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _resourceName;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Value to specify how many results are returned per page.
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
        /// If a <c>NextToken</c> was returned by a previous call, there are more results available.
        /// To retrieve the next page of results, make the call again using the returned token
        /// in <c>NextToken</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// Filter migration tasks by discovered resource name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

    }
}