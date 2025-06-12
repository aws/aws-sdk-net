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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeOptedOutNumbers operation.
    /// Describes the specified opted out destination numbers or all opted out destination
    /// numbers in an opt-out list.
    /// 
    ///  
    /// <para>
    /// If you specify opted out numbers, the output includes information for only the specified
    /// opted out numbers. If you specify filters, the output includes information for only
    /// those opted out numbers that meet the filter criteria. If you don't specify opted
    /// out numbers or filters, the output includes information for all opted out destination
    /// numbers in your opt-out list.
    /// </para>
    ///  
    /// <para>
    /// If you specify an opted out number that isn't valid, an exception is returned.
    /// </para>
    /// </summary>
    public partial class DescribeOptedOutNumbersRequest : AmazonPinpointSMSVoiceV2Request
    {
        private List<OptedOutFilter> _filters = AWSConfigs.InitializeCollections ? new List<OptedOutFilter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _optedOutNumbers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _optOutListName;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of OptedOutFilter objects to filter the results on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<OptedOutFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per each request.
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
        /// Gets and sets the property OptedOutNumbers. 
        /// <para>
        /// An array of phone numbers to search for in the OptOutList.
        /// </para>
        ///  
        /// <para>
        /// If you specify an opted out number that isn't valid, an exception is returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> OptedOutNumbers
        {
            get { return this._optedOutNumbers; }
            set { this._optedOutNumbers = value; }
        }

        // Check to see if OptedOutNumbers property is set
        internal bool IsSetOptedOutNumbers()
        {
            return this._optedOutNumbers != null && (this._optedOutNumbers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The OptOutListName or OptOutListArn of the OptOutList. You can use <a>DescribeOptOutLists</a>
        /// to find the values for OptOutListName and OptOutListArn.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared AWS End User Messaging SMS and Voice resource then you must
        /// use the full Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string OptOutListName
        {
            get { return this._optOutListName; }
            set { this._optOutListName = value; }
        }

        // Check to see if OptOutListName property is set
        internal bool IsSetOptOutListName()
        {
            return this._optOutListName != null;
        }

    }
}