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
    /// Container for the parameters to the ListAppAssessments operation. Lists the assessments
    /// for an Resilience Hub application. You can use request parameters to refine the results
    /// for the response object.
    /// </summary>
    public partial class ListAppAssessmentsRequest : AmazonResilienceHubRequest
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
        /// Gets and sets the property AssessmentName. 
        /// <para>
        /// The name for the assessment.
        /// </para>
        /// </summary>
        public string AssessmentName { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentName property is set.
        /// </summary>
        internal bool IsSetAssessmentName() => this.AssessmentName != null;

        /// <summary>
        /// Gets and sets the property AssessmentStatus. 
        /// <para>
        /// The current status of the assessment for the resiliency policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> AssessmentStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssessmentStatus property is set.
        /// </summary>
        internal bool IsSetAssessmentStatus() => this.AssessmentStatus != null && (this.AssessmentStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// The current status of compliance for the resiliency policy.
        /// </para>
        /// </summary>
        public ComplianceStatus ComplianceStatus { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceStatus property is set.
        /// </summary>
        internal bool IsSetComplianceStatus() => this.ComplianceStatus != null;

        /// <summary>
        /// Gets and sets the property Invoker. 
        /// <para>
        /// Specifies the entity that invoked a specific assessment, either a <c>User</c> or the
        /// <c>System</c>.
        /// </para>
        /// </summary>
        public AssessmentInvoker Invoker { get; set; }

        /// <summary>
        /// Checks to see if the Invoker property is set.
        /// </summary>
        internal bool IsSetInvoker() => this.Invoker != null;

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
        /// The default is to sort by ascending <b>startTime</b>. To sort by descending <b>startTime</b>,
        /// set reverseOrder to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? ReverseOrder { get; set; }

        /// <summary>
        /// Checks to see if the ReverseOrder property is set.
        /// </summary>
        internal bool IsSetReverseOrder() => this.ReverseOrder.HasValue;
    }
}
