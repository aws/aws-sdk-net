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
    /// Container for the parameters to the ListReportsForReportGroup operation. Returns a
    /// list of ARNs for the reports that belong to a <c>ReportGroup</c>.
    /// </summary>
    public partial class ListReportsForReportGroupRequest : AmazonCodeBuildRequest
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        ///  A <c>ReportFilter</c> object used to filter the returned reports. 
        /// </para>
        /// </summary>
        public ReportFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of paginated reports in this report group returned per response.
        /// Use <c>nextToken</c> to iterate pages in the list of returned <c>Report</c> objects.
        /// The default value is 100. 
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
        /// Gets and sets the property ReportGroupArn. 
        /// <para>
        ///  The ARN of the report group for which you want to return report ARNs. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReportGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the ReportGroupArn property is set.
        /// </summary>
        internal bool IsSetReportGroupArn() => this.ReportGroupArn != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        ///  Use to specify whether the results are returned in ascending or descending order.
        /// 
        /// </para>
        /// </summary>
        public SortOrderType SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
