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
    /// Container for the parameters to the DescribeTestCases operation. Returns a list of
    /// details about test cases for a report.
    /// </summary>
    public partial class DescribeTestCasesRequest : AmazonCodeBuildRequest
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        ///  A <c>TestCaseFilter</c> object used to filter the returned reports. 
        /// </para>
        /// </summary>
        public TestCaseFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of paginated test cases returned per response. Use <c>nextToken</c>
        /// to iterate pages in the list of returned <c>TestCase</c> objects. The default value
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
        /// Gets and sets the property ReportArn. 
        /// <para>
        ///  The ARN of the report for which test cases are returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReportArn { get; set; }

        /// <summary>
        /// Checks to see if the ReportArn property is set.
        /// </summary>
        internal bool IsSetReportArn() => this.ReportArn != null;
    }
}
