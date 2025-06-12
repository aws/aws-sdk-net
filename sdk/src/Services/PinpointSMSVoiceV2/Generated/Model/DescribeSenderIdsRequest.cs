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
    /// Container for the parameters to the DescribeSenderIds operation.
    /// Describes the specified SenderIds or all SenderIds associated with your Amazon Web
    /// Services account.
    /// 
    ///  
    /// <para>
    /// If you specify SenderIds, the output includes information for only the specified SenderIds.
    /// If you specify filters, the output includes information for only those SenderIds that
    /// meet the filter criteria. If you don't specify SenderIds or filters, the output includes
    /// information for all SenderIds.
    /// </para>
    ///  
    /// <para>
    /// f you specify a sender ID that isn't valid, an error is returned.
    /// </para>
    /// </summary>
    public partial class DescribeSenderIdsRequest : AmazonPinpointSMSVoiceV2Request
    {
        private List<SenderIdFilter> _filters = AWSConfigs.InitializeCollections ? new List<SenderIdFilter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private Owner _owner;
        private List<SenderIdAndCountry> _senderIds = AWSConfigs.InitializeCollections ? new List<SenderIdAndCountry>() : null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of SenderIdFilter objects to filter the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<SenderIdFilter> Filters
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// Use <c>SELF</c> to filter the list of Sender Ids to ones your account owns or use
        /// <c>SHARED</c> to filter on Sender Ids shared with your account. The <c>Owner</c> and
        /// <c>SenderIds</c> parameters can't be used at the same time. 
        /// </para>
        /// </summary>
        public Owner Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property SenderIds. 
        /// <para>
        /// An array of SenderIdAndCountry objects to search for.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared AWS End User Messaging SMS and Voice resource then you must
        /// use the full Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<SenderIdAndCountry> SenderIds
        {
            get { return this._senderIds; }
            set { this._senderIds = value; }
        }

        // Check to see if SenderIds property is set
        internal bool IsSetSenderIds()
        {
            return this._senderIds != null && (this._senderIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}