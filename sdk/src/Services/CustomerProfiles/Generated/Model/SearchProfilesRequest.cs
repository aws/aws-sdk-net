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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the SearchProfiles operation.
    /// Searches for profiles within a specific domain using one or more predefined search
    /// keys (e.g., _fullName, _phone, _email, _account, etc.) and/or custom-defined search
    /// keys. A search key is a data type pair that consists of a <c>KeyName</c> and <c>Values</c>
    /// list.
    /// 
    ///  
    /// <para>
    /// This operation supports searching for profiles with a minimum of 1 key-value(s) pair
    /// and up to 5 key-value(s) pairs using either <c>AND</c> or <c>OR</c> logic.
    /// </para>
    /// </summary>
    public partial class SearchProfilesRequest : AmazonCustomerProfilesRequest
    {
        private List<AdditionalSearchKey> _additionalSearchKeys = AWSConfigs.InitializeCollections ? new List<AdditionalSearchKey>() : null;
        private string _domainName;
        private string _keyName;
        private LogicalOperator _logicalOperator;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalSearchKeys. 
        /// <para>
        /// A list of <c>AdditionalSearchKey</c> objects that are each searchable identifiers
        /// of a profile. Each <c>AdditionalSearchKey</c> object contains a <c>KeyName</c> and
        /// a list of <c>Values</c> associated with that specific key (i.e., a key-value(s) pair).
        /// These additional search keys will be used in conjunction with the <c>LogicalOperator</c>
        /// and the required <c>KeyName</c> and <c>Values</c> parameters to search for profiles
        /// that satisfy the search criteria. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<AdditionalSearchKey> AdditionalSearchKeys
        {
            get { return this._additionalSearchKeys; }
            set { this._additionalSearchKeys = value; }
        }

        // Check to see if AdditionalSearchKeys property is set
        internal bool IsSetAdditionalSearchKeys()
        {
            return this._additionalSearchKeys != null && (this._additionalSearchKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// A searchable identifier of a customer profile. The predefined keys you can use to
        /// search include: _account, _profileId, _assetId, _caseId, _orderId, _fullName, _phone,
        /// _email, _ctrContactId, _marketoLeadId, _salesforceAccountId, _salesforceContactId,
        /// _salesforceAssetId, _zendeskUserId, _zendeskExternalId, _zendeskTicketId, _serviceNowSystemId,
        /// _serviceNowIncidentId, _segmentUserId, _shopifyCustomerId, _shopifyOrderId.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property LogicalOperator. 
        /// <para>
        /// Relationship between all specified search keys that will be used to search for profiles.
        /// This includes the required <c>KeyName</c> and <c>Values</c> parameters as well as
        /// any key-value(s) pairs specified in the <c>AdditionalSearchKeys</c> list.
        /// </para>
        ///  
        /// <para>
        /// This parameter influences which profiles will be returned in the response in the following
        /// manner:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AND</c> - The response only includes profiles that match all of the search keys.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OR</c> - The response includes profiles that match at least one of the search
        /// keys.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The <c>OR</c> relationship is the default behavior if this parameter is not included
        /// in the request.
        /// </para>
        /// </summary>
        public LogicalOperator LogicalOperator
        {
            get { return this._logicalOperator; }
            set { this._logicalOperator = value; }
        }

        // Check to see if LogicalOperator property is set
        internal bool IsSetLogicalOperator()
        {
            return this._logicalOperator != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects returned per page.
        /// </para>
        ///  
        /// <para>
        /// The default is 20 if this parameter is not included in the request.
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
        /// The pagination token from the previous SearchProfiles API call.
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
        /// Gets and sets the property Values. 
        /// <para>
        /// A list of key values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}