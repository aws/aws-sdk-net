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
    /// Container for the parameters to the ListApps operation.
    /// Lists your Resilience Hub applications.
    /// 
    ///  <note> 
    /// <para>
    /// You can filter applications using only one filter at a time or without using any filter.
    /// If you try to filter applications using multiple filters, you will get the following
    /// error:
    /// </para>
    ///  
    /// <para>
    ///  <c>An error occurred (ValidationException) when calling the ListApps operation: Only
    /// one filter is supported for this operation.</c> 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListAppsRequest : AmazonResilienceHubRequest
    {
        private string _appArn;
        private string _awsApplicationArn;
        private DateTime? _fromLastAssessmentTime;
        private int? _maxResults;
        private string _name;
        private string _nextToken;
        private bool? _reverseOrder;
        private DateTime? _toLastAssessmentTime;

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
        /// Gets and sets the property AwsApplicationArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of Resource Groups group that is integrated with an AppRegistry
        /// application. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        public string AwsApplicationArn
        {
            get { return this._awsApplicationArn; }
            set { this._awsApplicationArn = value; }
        }

        // Check to see if AwsApplicationArn property is set
        internal bool IsSetAwsApplicationArn()
        {
            return this._awsApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property FromLastAssessmentTime. 
        /// <para>
        /// Lower limit of the range that is used to filter applications based on their last assessment
        /// times.
        /// </para>
        /// </summary>
        public DateTime? FromLastAssessmentTime
        {
            get { return this._fromLastAssessmentTime; }
            set { this._fromLastAssessmentTime = value; }
        }

        // Check to see if FromLastAssessmentTime property is set
        internal bool IsSetFromLastAssessmentTime()
        {
            return this._fromLastAssessmentTime.HasValue; 
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the one of the listed applications.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
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
        /// The application list is sorted based on the values of <c>lastAppComplianceEvaluationTime</c>
        /// field. By default, application list is sorted in ascending order. To sort the application
        /// list in descending order, set this field to <c>True</c>.
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

        /// <summary>
        /// Gets and sets the property ToLastAssessmentTime. 
        /// <para>
        /// Upper limit of the range that is used to filter the applications based on their last
        /// assessment times.
        /// </para>
        /// </summary>
        public DateTime? ToLastAssessmentTime
        {
            get { return this._toLastAssessmentTime; }
            set { this._toLastAssessmentTime = value; }
        }

        // Check to see if ToLastAssessmentTime property is set
        internal bool IsSetToLastAssessmentTime()
        {
            return this._toLastAssessmentTime.HasValue; 
        }

    }
}