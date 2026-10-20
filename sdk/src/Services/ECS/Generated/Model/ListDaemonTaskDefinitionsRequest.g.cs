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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ListDaemonTaskDefinitions operation. Returns a
    /// list of daemon task definitions that are registered to your account. You can filter
    /// the results by family name, status, or both to find daemon task definitions that match
    /// your criteria.
    /// </summary>
    public partial class ListDaemonTaskDefinitionsRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Family. 
        /// <para>
        /// The exact name of the daemon task definition family to filter results with.
        /// </para>
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// Checks to see if the Family property is set.
        /// </summary>
        internal bool IsSetFamily() => this.Family != null;

        /// <summary>
        /// Gets and sets the property FamilyPrefix. 
        /// <para>
        /// The full family name to filter the <c>ListDaemonTaskDefinitions</c> results with.
        /// Specifying a <c>familyPrefix</c> limits the listed daemon task definitions to daemon
        /// task definition families that start with the <c>familyPrefix</c> string.
        /// </para>
        /// </summary>
        public string FamilyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the FamilyPrefix property is set.
        /// </summary>
        internal bool IsSetFamilyPrefix() => this.FamilyPrefix != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of daemon task definition results that <c>ListDaemonTaskDefinitions</c>
        /// returned in paginated output. When this parameter is used, <c>ListDaemonTaskDefinitions</c>
        /// only returns <c>maxResults</c> results in a single page along with a <c>nextToken</c>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <c>ListDaemonTaskDefinitions</c> request with the returned <c>nextToken</c>
        /// value. This value can be between 1 and 100. If this parameter isn't used, then <c>ListDaemonTaskDefinitions</c>
        /// returns up to 100 results and a <c>nextToken</c> value if applicable.
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
        /// The <c>nextToken</c> value returned from a <c>ListDaemonTaskDefinitions</c> request
        /// indicating that more results are available to fulfill the request and further calls
        /// will be needed. If <c>maxResults</c> was provided, it's possible for the number of
        /// results to be fewer than <c>maxResults</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision filter to apply. Specify <c>LAST_REGISTERED</c> to return only the last
        /// registered revision for each daemon task definition family.
        /// </para>
        /// </summary>
        public DaemonTaskDefinitionRevisionFilter Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The order to sort the results. Valid values are <c>ASC</c> and <c>DESC</c>. By default
        /// (<c>ASC</c>), daemon task definitions are listed in ascending order by family name
        /// and revision number.
        /// </para>
        /// </summary>
        public SortOrder Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The daemon task definition status to filter the <c>ListDaemonTaskDefinitions</c> results
        /// with. By default, only <c>ACTIVE</c> daemon task definitions are listed. If you set
        /// this parameter to <c>DELETE_IN_PROGRESS</c>, only daemon task definitions that are
        /// in the process of being deleted are listed. If you set this parameter to <c>ALL</c>,
        /// all daemon task definitions are listed regardless of status.
        /// </para>
        /// </summary>
        public DaemonTaskDefinitionStatusFilter Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
