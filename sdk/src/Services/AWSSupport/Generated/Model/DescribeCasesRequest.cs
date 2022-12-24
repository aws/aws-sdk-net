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
    /// Container for the parameters to the DescribeCases operation.
    /// Returns a list of cases that you specify by passing one or more case IDs. You can
    /// use the <code>afterTime</code> and <code>beforeTime</code> parameters to filter the
    /// cases by date. You can set values for the <code>includeResolvedCases</code> and <code>includeCommunications</code>
    /// parameters to specify how much information to return.
    /// 
    ///  
    /// <para>
    /// The response returns the following in JSON format:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// One or more <a href="https://docs.aws.amazon.com/awssupport/latest/APIReference/API_CaseDetails.html">CaseDetails</a>
    /// data types.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// One or more <code>nextToken</code> values, which specify where to paginate the returned
    /// records represented by the <code>CaseDetails</code> objects.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Case data is available for 12 months after creation. If a case was created more than
    /// 12 months ago, a request might return an error.
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
    public partial class DescribeCasesRequest : AmazonAWSSupportRequest
    {
        private string _afterTime;
        private string _beforeTime;
        private List<string> _caseIdList = new List<string>();
        private string _displayId;
        private bool? _includeCommunications;
        private bool? _includeResolvedCases;
        private string _language;
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
        /// Gets and sets the property CaseIdList. 
        /// <para>
        /// A list of ID numbers of the support cases you want returned. The maximum number of
        /// cases is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> CaseIdList
        {
            get { return this._caseIdList; }
            set { this._caseIdList = value; }
        }

        // Check to see if CaseIdList property is set
        internal bool IsSetCaseIdList()
        {
            return this._caseIdList != null && this._caseIdList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DisplayId. 
        /// <para>
        /// The ID displayed for a case in the Amazon Web Services Support Center user interface.
        /// </para>
        /// </summary>
        public string DisplayId
        {
            get { return this._displayId; }
            set { this._displayId = value; }
        }

        // Check to see if DisplayId property is set
        internal bool IsSetDisplayId()
        {
            return this._displayId != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeCommunications. 
        /// <para>
        /// Specifies whether to include communications in the <code>DescribeCases</code> response.
        /// By default, communications are included.
        /// </para>
        /// </summary>
        public bool IncludeCommunications
        {
            get { return this._includeCommunications.GetValueOrDefault(); }
            set { this._includeCommunications = value; }
        }

        // Check to see if IncludeCommunications property is set
        internal bool IsSetIncludeCommunications()
        {
            return this._includeCommunications.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeResolvedCases. 
        /// <para>
        /// Specifies whether to include resolved support cases in the <code>DescribeCases</code>
        /// response. By default, resolved cases aren't included.
        /// </para>
        /// </summary>
        public bool IncludeResolvedCases
        {
            get { return this._includeResolvedCases.GetValueOrDefault(); }
            set { this._includeResolvedCases = value; }
        }

        // Check to see if IncludeResolvedCases property is set
        internal bool IsSetIncludeResolvedCases()
        {
            return this._includeResolvedCases.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language in which Amazon Web Services Support handles the case. Amazon Web Services
        /// Support currently supports English ("en") and Japanese ("ja"). You must specify the
        /// ISO 639-1 code for the <code>language</code> parameter if you want support in that
        /// language.
        /// </para>
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
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