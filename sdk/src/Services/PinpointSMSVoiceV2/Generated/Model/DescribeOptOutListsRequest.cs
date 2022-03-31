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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeOptOutLists operation.
    /// Describes the specified opt-out list or all opt-out lists in your account.
    /// 
    ///  
    /// <para>
    /// If you specify opt-out list names, the output includes information for only the specified
    /// opt-out lists. Opt-out lists include only those that meet the filter criteria. If
    /// you don't specify opt-out list names or filters, the output includes information for
    /// all opt-out lists.
    /// </para>
    ///  
    /// <para>
    /// If you specify an opt-out list name that isn't valid, an Error is returned.
    /// </para>
    /// </summary>
    public partial class DescribeOptOutListsRequest : AmazonPinpointSMSVoiceV2Request
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _optOutListNames = new List<string>();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per each request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The token to be used for the next set of paginated results. You don't need to supply
        /// a value for this field in the initial request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property OptOutListNames. 
        /// <para>
        /// The OptOutLists to show the details of. This is an array of strings that can be either
        /// the OptOutListName or OptOutListArn.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> OptOutListNames
        {
            get { return this._optOutListNames; }
            set { this._optOutListNames = value; }
        }

        // Check to see if OptOutListNames property is set
        internal bool IsSetOptOutListNames()
        {
            return this._optOutListNames != null && this._optOutListNames.Count > 0; 
        }

    }
}