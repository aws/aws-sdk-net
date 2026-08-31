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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCommunications operation.
    /// Returns communications and attachments for one or more support cases. Use the <c>afterTime</c>
    /// and <c>beforeTime</c> parameters to filter by date. You can use the <c>caseId</c>
    /// parameter to restrict the results to a specific case.
    /// 
    ///  
    /// <para>
    /// Case data is available for 24 months after creation. If a case was created more than
    /// 24 months ago, a request for data might cause an error.
    /// </para>
    ///  
    /// <para>
    /// You can use the <c>maxResults</c> and <c>nextToken</c> parameters to control the pagination
    /// of the results. Set <c>maxResults</c> to the number of cases that you want to display
    /// on each page, and use <c>nextToken</c> to specify the resumption of pagination.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// You must have an Amazon Web Services Business Support+, Amazon Web Services Enterprise
    /// Support, or Amazon Web Services Unified Operations plan to use the Amazon Web Services
    /// Support API. If you're in an Amazon Web Services Region that doesn't offer one of
    /// these Amazon Web Services Support plans, or if you haven't transitioned to one of
    /// these plans, you can use the Amazon Web Services Support API with a Business, Enterprise
    /// On-Ramp, or Enterprise Support plan.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the Amazon Web Services Support API from an account that doesn't have
    /// an Amazon Web Services Business Support+, Amazon Web Services Enterprise Support,
    /// or Amazon Web Services Unified Operations plan, the <c>SubscriptionRequiredException</c>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </li> </ul> </note> <important> 
    /// <para>
    /// Each <a>Communication</a> returned by this operation includes attachment information
    /// in two fields:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>attachmentSet</c>: returns only attachments that are 5 MB or smaller. Attachments
    /// larger than 5 MB are not included in this field.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>attachments</c>: returns all attachments regardless of size.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon Web Services recommends that you use the <c>attachments</c> field and download
    /// each attachment with <a>GetAttachmentDownloadLink</a>, which supports attachments
    /// of any size. The <c>attachmentSet</c> field and <a>DescribeAttachment</a> return only
    /// attachments that are 5 MB or smaller.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DescribeCommunicationsRequest : AmazonAWSSupportRequest
    {
        private string _afterTime;
        private string _beforeTime;
        private string _caseId;
        private bool? _dryRun;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AfterTime. 
        /// <para>
        /// The start date for a filtered date search on support case communications. Case communications
        /// are available for 24 months after creation.
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
        /// are available for 24 months after creation.
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
        /// string formatted as shown in this example: case-<i>12345678910-exen-2025-c4c1d2bf33c5cf47</i>
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether to validate the request without actually returning communications.
        /// When set to <c>true</c>, the request is validated but no communications are returned,
        /// and the operation returns a <c>DryRunOperationException</c>. When omitted or set to
        /// <c>false</c>, the request runs normally.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return before paginating.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=100)]
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