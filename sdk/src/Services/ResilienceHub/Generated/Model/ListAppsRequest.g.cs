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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Container for the parameters to the ListApps operation. Lists your Resilience Hub
    /// applications. <note> <para> You can filter applications using only one filter at a
    /// time or without using any filter. If you try to filter applications using multiple
    /// filters, you will get the following error: </para> <para> <c>An error occurred (ValidationException)
    /// when calling the ListApps operation: Only one filter is supported for this operation.</c>
    /// </para> </note>
    /// </summary>
    public partial class ListAppsRequest : AmazonResilienceHubRequest
    {
        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Resilience Hub application. The format for this
        /// ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:app/<c>app-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        public string AppArn { get; set; }

        /// <summary>
        /// Checks to see if the AppArn property is set.
        /// </summary>
        internal bool IsSetAppArn() => this.AppArn != null;

        /// <summary>
        /// Gets and sets the property AwsApplicationArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of Resource Groups group that is integrated with an AppRegistry
        /// application. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        public string AwsApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the AwsApplicationArn property is set.
        /// </summary>
        internal bool IsSetAwsApplicationArn() => this.AwsApplicationArn != null;

        /// <summary>
        /// Gets and sets the property FromLastAssessmentTime. 
        /// <para>
        /// Lower limit of the range that is used to filter applications based on their last assessment
        /// times.
        /// </para>
        /// </summary>
        public DateTime? FromLastAssessmentTime { get; set; }

        /// <summary>
        /// Checks to see if the FromLastAssessmentTime property is set.
        /// </summary>
        internal bool IsSetFromLastAssessmentTime() => this.FromLastAssessmentTime.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to include in the response. If more results exist than the
        /// specified <c>MaxResults</c> value, a token is included in the response so that the
        /// remaining results can be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the one of the listed applications.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Null, or the token from a previous call to get the next set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ReverseOrder. 
        /// <para>
        /// The application list is sorted based on the values of <c>lastAppComplianceEvaluationTime</c>
        /// field. By default, application list is sorted in ascending order. To sort the application
        /// list in descending order, set this field to <c>True</c>.
        /// </para>
        /// </summary>
        public bool? ReverseOrder { get; set; }

        /// <summary>
        /// Checks to see if the ReverseOrder property is set.
        /// </summary>
        internal bool IsSetReverseOrder() => this.ReverseOrder.HasValue;

        /// <summary>
        /// Gets and sets the property ToLastAssessmentTime. 
        /// <para>
        /// Upper limit of the range that is used to filter the applications based on their last
        /// assessment times.
        /// </para>
        /// </summary>
        public DateTime? ToLastAssessmentTime { get; set; }

        /// <summary>
        /// Checks to see if the ToLastAssessmentTime property is set.
        /// </summary>
        internal bool IsSetToLastAssessmentTime() => this.ToLastAssessmentTime.HasValue;
    }
}
