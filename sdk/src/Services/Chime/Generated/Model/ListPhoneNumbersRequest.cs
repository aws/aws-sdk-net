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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the ListPhoneNumbers operation.
    /// Lists the phone numbers for the specified Amazon Chime account, Amazon Chime user,
    /// Amazon Chime Voice Connector, or Amazon Chime Voice Connector group.
    /// </summary>
    public partial class ListPhoneNumbersRequest : AmazonChimeRequest
    {
        private PhoneNumberAssociationName _filterName;
        private string _filterValue;
        private int? _maxResults;
        private string _nextToken;
        private PhoneNumberProductType _productType;
        private PhoneNumberStatus _status;

        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// The filter to use to limit the number of results.
        /// </para>
        /// </summary>
        public PhoneNumberAssociationName FilterName
        {
            get { return this._filterName; }
            set { this._filterName = value; }
        }

        // Check to see if FilterName property is set
        internal bool IsSetFilterName()
        {
            return this._filterName != null;
        }

        /// <summary>
        /// Gets and sets the property FilterValue. 
        /// <para>
        /// The value to use for the filter.
        /// </para>
        /// </summary>
        public string FilterValue
        {
            get { return this._filterValue; }
            set { this._filterValue = value; }
        }

        // Check to see if FilterValue property is set
        internal bool IsSetFilterValue()
        {
            return this._filterValue != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=99)]
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
        /// The token to use to retrieve the next page of results.
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
        /// Gets and sets the property ProductType. 
        /// <para>
        /// The phone number product type.
        /// </para>
        /// </summary>
        public PhoneNumberProductType ProductType
        {
            get { return this._productType; }
            set { this._productType = value; }
        }

        // Check to see if ProductType property is set
        internal bool IsSetProductType()
        {
            return this._productType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The phone number status.
        /// </para>
        /// </summary>
        public PhoneNumberStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}