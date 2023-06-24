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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCommunications operation.
    /// Returns communications and attachments for one or more support cases. Use the <code>afterTime</code>
    /// and <code>beforeTime</code> parameters to filter by date. You can use the <code>caseId</code>
    /// parameter to restrict the results to a specific case.
    /// 
    ///  
    /// <para>
    /// Case data is available for 12 months after creation. If a case was created more than
    /// 12 months ago, a request for data might cause an error.
    /// </para>
    ///  
    /// <para>
    /// You can use the <code>maxResults</code> and <code>nextToken</code> parameters to control
    /// the pagination of the results. Set <code>maxResults</code> to the number of cases
    /// that you want to display on each page, and use <code>nextToken</code> to specify the
    /// resumption of pagination.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan to use the
    /// Amazon Web Services Support API. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the Amazon Web Services Support API from an account that doesn't have
    /// a Business, Enterprise On-Ramp, or Enterprise Support plan, the <code>SubscriptionRequiredException</code>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class DescribeCommunicationsRequest : AmazonAWSSupportRequest
    {
        private string _afterTime;
        private string _beforeTime;
        private string _caseId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AfterTime. 
        /// <para>
        /// The start date for a filtered date search on support case communications. Case communications
        /// are available for 12 months after creation.
        /// </para>
        /// </summary>
        public string AfterTime
        {
            get { return this._afterTime; }
            set { this._afterTime = value; }
        }

        // Check to see if AfterTime property is set
        internal bool IsSetAfterTime()
        {
            return this._afterTime != null;
        }

        /// <summary>
        /// Gets and sets the property BeforeTime. 
        /// <para>
        /// The end date for a filtered date search on support case communications. Case communications
        /// are available for 12 months after creation.
        /// </para>
        /// </summary>
        public string BeforeTime
        {
            get { return this._beforeTime; }
            set { this._beforeTime = value; }
        }

        // Check to see if BeforeTime property is set
        internal bool IsSetBeforeTime()
        {
            return this._beforeTime != null;
        }

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// The support case ID requested or returned in the call. The case ID is an alphanumeric
        /// string formatted as shown in this example: case-<i>12345678910-2013-c4c1d2bf33c5cf47</i>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CaseId
        {
            get { return this._caseId; }
            set { this._caseId = value; }
        }

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this._caseId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return before paginating.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// A resumption point for pagination.
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

    }
}