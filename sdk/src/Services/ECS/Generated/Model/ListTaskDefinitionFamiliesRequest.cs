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
    /// Container for the parameters to the ListTaskDefinitionFamilies operation.
    /// Returns a list of task definition families that are registered to your account. This
    /// list includes task definition families that no longer have any <c>ACTIVE</c> task
    /// definition revisions.
    /// 
    ///  
    /// <para>
    /// You can filter out task definition families that don't contain any <c>ACTIVE</c> task
    /// definition revisions by setting the <c>status</c> parameter to <c>ACTIVE</c>. You
    /// can also filter the results with the <c>familyPrefix</c> parameter.
    /// </para>
    /// </summary>
    public partial class ListTaskDefinitionFamiliesRequest : AmazonECSRequest
    {
        private string _familyPrefix;
        private int? _maxResults;
        private string _nextToken;
        private TaskDefinitionFamilyStatus _status;

        /// <summary>
        /// Gets and sets the property FamilyPrefix. 
        /// <para>
        /// The <c>familyPrefix</c> is a string that's used to filter the results of <c>ListTaskDefinitionFamilies</c>.
        /// If you specify a <c>familyPrefix</c>, only task definition family names that begin
        /// with the <c>familyPrefix</c> string are returned.
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
        /// The maximum number of task definition family results that <c>ListTaskDefinitionFamilies</c>
        /// returned in paginated output. When this parameter is used, <c>ListTaskDefinitions</c>
        /// only returns <c>maxResults</c> results in a single page along with a <c>nextToken</c>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <c>ListTaskDefinitionFamilies</c> request with the returned <c>nextToken</c>
        /// value. This value can be between 1 and 100. If this parameter isn't used, then <c>ListTaskDefinitionFamilies</c>
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
        /// The <c>nextToken</c> value returned from a <c>ListTaskDefinitionFamilies</c> request
        /// indicating that more results are available to fulfill the request and further calls
        /// will be needed. If <c>maxResults</c> was provided, it is possible the number of results
        /// to be fewer than <c>maxResults</c>.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The task definition family status to filter the <c>ListTaskDefinitionFamilies</c>
        /// results with. By default, both <c>ACTIVE</c> and <c>INACTIVE</c> task definition families
        /// are listed. If this parameter is set to <c>ACTIVE</c>, only task definition families
        /// that have an <c>ACTIVE</c> task definition revision are returned. If this parameter
        /// is set to <c>INACTIVE</c>, only task definition families that do not have any <c>ACTIVE</c>
        /// task definition revisions are returned. If you paginate the resulting output, be sure
        /// to keep the <c>status</c> value constant in each subsequent request.
        /// </para>
        /// </summary>
        public TaskDefinitionFamilyStatus Status
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