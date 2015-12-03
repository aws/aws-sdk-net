/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ListTaskDefinitions operation.
    /// Returns a list of task definitions that are registered to your account. You can filter
    /// the results by family name with the <code>familyPrefix</code> parameter or by status
    /// with the <code>status</code> parameter.
    /// </summary>
    public partial class ListTaskDefinitionsRequest : AmazonECSRequest
    {
        private string _familyPrefix;
        private int? _maxResults;
        private string _nextToken;
        private SortOrder _sort;
        private TaskDefinitionStatus _status;

        /// <summary>
        /// Gets and sets the property FamilyPrefix. 
        /// <para>
        /// The full family name with which to filter the <code>ListTaskDefinitions</code> results.
        /// Specifying a <code>familyPrefix</code> limits the listed task definitions to task
        /// definition revisions that belong to that family.
        /// </para>
        /// </summary>
        public string FamilyPrefix
        {
            get { return this._familyPrefix; }
            set { this._familyPrefix = value; }
        }

        // Check to see if FamilyPrefix property is set
        internal bool IsSetFamilyPrefix()
        {
            return this._familyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of task definition results returned by <code>ListTaskDefinitions</code>
        /// in paginated output. When this parameter is used, <code>ListTaskDefinitions</code>
        /// only returns <code>maxResults</code> results in a single page along with a <code>nextToken</code>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <code>ListTaskDefinitions</code> request with the returned <code>nextToken</code>
        /// value. This value can be between 1 and 100. If this parameter is not used, then <code>ListTaskDefinitions</code>
        /// returns up to 100 results and a <code>nextToken</code> value if applicable.
        /// </para>
        /// </summary>
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
        /// The <code>nextToken</code> value returned from a previous paginated <code>ListTaskDefinitions</code>
        /// request where <code>maxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>nextToken</code> value. This value is <code>null</code> when there
        /// are no more results to return.
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
        /// The order in which to sort the results. Valid values are <code>ASC</code> and <code>DESC</code>.
        /// By default (<code>ASC</code>), task definitions are listed lexicographically by family
        /// name and in ascending numerical order by revision so that the newest task definitions
        /// in a family are listed last. Setting this parameter to <code>DESC</code> reverses
        /// the sort order on family name and revision so that the newest task definitions in
        /// a family are listed first.
        /// </para>
        /// </summary>
        public SortOrder Sort
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The task definition status with which to filter the <code>ListTaskDefinitions</code>
        /// results. By default, only <code>ACTIVE</code> task definitions are listed. By setting
        /// this parameter to <code>INACTIVE</code>, you can view task definitions that are <code>INACTIVE</code>
        /// as long as an active task or service still references them. If you paginate the resulting
        /// output, be sure to keep the <code>status</code> value constant in each subsequent
        /// request.
        /// </para>
        /// </summary>
        public TaskDefinitionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}