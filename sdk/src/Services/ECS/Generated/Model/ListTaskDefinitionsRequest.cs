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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ListTaskDefinitions operation.
    /// Returns a list of task definitions that are registered to your account. You can filter
    /// the results by family name with the <c>familyPrefix</c> parameter or by status with
    /// the <c>status</c> parameter.
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
        /// The full family name to filter the <c>ListTaskDefinitions</c> results with. Specifying
        /// a <c>familyPrefix</c> limits the listed task definitions to task definition revisions
        /// that belong to that family.
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
        /// The maximum number of task definition results that <c>ListTaskDefinitions</c> returned
        /// in paginated output. When this parameter is used, <c>ListTaskDefinitions</c> only
        /// returns <c>maxResults</c> results in a single page along with a <c>nextToken</c> response
        /// element. The remaining results of the initial request can be seen by sending another
        /// <c>ListTaskDefinitions</c> request with the returned <c>nextToken</c> value. This
        /// value can be between 1 and 100. If this parameter isn't used, then <c>ListTaskDefinitions</c>
        /// returns up to 100 results and a <c>nextToken</c> value if applicable.
        /// </para>
        /// </summary>
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
        /// The <c>nextToken</c> value returned from a <c>ListTaskDefinitions</c> request indicating
        /// that more results are available to fulfill the request and further calls will be needed.
        /// If <c>maxResults</c> was provided, it is possible the number of results to be fewer
        /// than <c>maxResults</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
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
        /// The order to sort the results in. Valid values are <c>ASC</c> and <c>DESC</c>. By
        /// default, (<c>ASC</c>) task definitions are listed lexicographically by family name
        /// and in ascending numerical order by revision so that the newest task definitions in
        /// a family are listed last. Setting this parameter to <c>DESC</c> reverses the sort
        /// order on family name and revision. This is so that the newest task definitions in
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
        /// The task definition status to filter the <c>ListTaskDefinitions</c> results with.
        /// By default, only <c>ACTIVE</c> task definitions are listed. By setting this parameter
        /// to <c>INACTIVE</c>, you can view task definitions that are <c>INACTIVE</c> as long
        /// as an active task or service still references them. If you paginate the resulting
        /// output, be sure to keep the <c>status</c> value constant in each subsequent request.
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