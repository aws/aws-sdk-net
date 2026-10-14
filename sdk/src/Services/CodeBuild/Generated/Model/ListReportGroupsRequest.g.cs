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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the ListReportGroups operation. Gets a list ARNs for
    /// the report groups in the current Amazon Web Services account.
    /// </summary>
    public partial class ListReportGroupsRequest : AmazonCodeBuildRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of paginated report groups returned per response. Use <c>nextToken</c>
        /// to iterate pages in the list of returned <c>ReportGroup</c> objects. The default value
        /// is 100. 
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
        ///  During a previous call, the maximum number of items that can be returned is the value
        /// specified in <c>maxResults</c>. If there more items in the list, then a unique string
        /// called a <i>nextToken</i> is returned. To get the next batch of items in the list,
        /// call this operation again, adding the next token to the call. To get all of the items
        /// in the list, keep calling this operation with each subsequent next token that is returned,
        /// until no more next tokens are returned. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        ///  The criterion to be used to list build report groups. Valid values include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATED_TIME</c>: List based on when each report group was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LAST_MODIFIED_TIME</c>: List based on when each report group was last changed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NAME</c>: List based on each report group's name.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReportGroupSortByType SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        ///  Used to specify the order to sort the list of returned report groups. Valid values
        /// are <c>ASCENDING</c> and <c>DESCENDING</c>. 
        /// </para>
        /// </summary>
        public SortOrderType SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
