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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
    /// Container for the parameters to the ListAppAssessments operation.
    /// Lists the assessments for an Resilience Hub application. You can use request parameters
    /// to refine the results for the response object.
    /// </summary>
    public partial class ListAppAssessmentsRequest : AmazonResilienceHubRequest
    {
        private string _appArn;
        private string _assessmentName;
        private List<string> _assessmentStatus = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ComplianceStatus _complianceStatus;
        private AssessmentInvoker _invoker;
        private int? _maxResults;
        private string _nextToken;
        private bool? _reverseOrder;

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
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentName. 
        /// <para>
        /// The name for the assessment.
        /// </para>
        /// </summary>
        public string AssessmentName
        {
            get { return this._assessmentName; }
            set { this._assessmentName = value; }
        }

        // Check to see if AssessmentName property is set
        internal bool IsSetAssessmentName()
        {
            return this._assessmentName != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentStatus. 
        /// <para>
        /// The current status of the assessment for the resiliency policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> AssessmentStatus
        {
            get { return this._assessmentStatus; }
            set { this._assessmentStatus = value; }
        }

        // Check to see if AssessmentStatus property is set
        internal bool IsSetAssessmentStatus()
        {
            return this._assessmentStatus != null && (this._assessmentStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// The current status of compliance for the resiliency policy.
        /// </para>
        /// </summary>
        public ComplianceStatus ComplianceStatus
        {
            get { return this._complianceStatus; }
            set { this._complianceStatus = value; }
        }

        // Check to see if ComplianceStatus property is set
        internal bool IsSetComplianceStatus()
        {
            return this._complianceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Invoker. 
        /// <para>
        /// Specifies the entity that invoked a specific assessment, either a <c>User</c> or the
        /// <c>System</c>.
        /// </para>
        /// </summary>
        public AssessmentInvoker Invoker
        {
            get { return this._invoker; }
            set { this._invoker = value; }
        }

        // Check to see if Invoker property is set
        internal bool IsSetInvoker()
        {
            return this._invoker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to include in the response. If more results exist than the
        /// specified <c>MaxResults</c> value, a token is included in the response so that the
        /// remaining results can be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Null, or the token from a previous call to get the next set of results.
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
        /// Gets and sets the property ReverseOrder. 
        /// <para>
        /// The default is to sort by ascending <b>startTime</b>. To sort by descending <b>startTime</b>,
        /// set reverseOrder to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? ReverseOrder
        {
            get { return this._reverseOrder; }
            set { this._reverseOrder = value; }
        }

        // Check to see if ReverseOrder property is set
        internal bool IsSetReverseOrder()
        {
            return this._reverseOrder.HasValue; 
        }

    }
}