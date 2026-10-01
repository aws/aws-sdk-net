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

namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Container for the parameters to the ListResources operation. Returns a list of resources
    /// and their details that match the specified criteria. This query must use a view. If
    /// you don’t explicitly specify a view, then Resource Explorer uses the default view
    /// for the Amazon Web Services Region in which you call this operation.
    /// </summary>
    public partial class ListResourcesRequest : AmazonResourceExplorer2Request
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of strings that specify which resources are included in the results of queries
        /// made using this view. When you use this view in a <a>Search</a> operation, the filter
        /// string is combined with the search's <c>QueryString</c> parameter using a logical
        /// <c>AND</c> operator.
        /// </para>
        ///  
        /// <para>
        /// For information about the supported syntax, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/using-search-query-syntax.html">Search
        /// query reference for Resource Explorer</a> in the <i>Amazon Web Services Resource Explorer
        /// User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// This query string in the context of this operation supports only <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/using-search-query-syntax.html#query-syntax-filters">filter
        /// prefixes</a> with optional <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/using-search-query-syntax.html#query-syntax-operators">operators</a>.
        /// It doesn't support free-form text. For example, the string <c>region:us* service:ec2
        /// -tag:stage=prod</c> includes all Amazon EC2 resources in any Amazon Web Services Region
        /// that begins with the letters <c>us</c> and is <i>not</i> tagged with a key <c>Stage</c>
        /// that has the value <c>prod</c>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public SearchFilter Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that you want included on each page of the response.
        /// If you do not include this parameter, it defaults to a value appropriate to the operation.
        /// If additional items exist beyond those included in the current response, the <c>NextToken</c>
        /// response element is present and has a value (is not null). Include that value as the
        /// <c>NextToken</c> request parameter in the next call to the operation to get the next
        /// part of the results.
        /// </para>
        ///  <note> 
        /// <para>
        /// An API operation can return fewer results than the maximum even when there are more
        /// results available. You should check <c>NextToken</c> after every operation to ensure
        /// that you receive all of the results.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The parameter for receiving additional results if you receive a <c>NextToken</c> response
        /// in a previous request. A <c>NextToken</c> response indicates that more output is available.
        /// Set this parameter to the value of the previous call's <c>NextToken</c> response to
        /// indicate where the output should continue from. The pagination tokens expire after
        /// 24 hours.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>ListResources</c> operation does not generate a <c>NextToken</c> if you set
        /// <c>MaxResults</c> to 1000. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ViewArn. 
        /// <para>
        /// Specifies the Amazon resource name (ARN) of the view to use for the query. If you
        /// don't specify a value for this parameter, then the operation automatically uses the
        /// default view for the Amazon Web Services Region in which you called this operation.
        /// If the Region either doesn't have a default view or if you don't have permission to
        /// use the default view, then the operation fails with a 401 Unauthorized exception.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string ViewArn { get; set; }

        /// <summary>
        /// Checks to see if the ViewArn property is set.
        /// </summary>
        internal bool IsSetViewArn() => this.ViewArn != null;
    }
}
