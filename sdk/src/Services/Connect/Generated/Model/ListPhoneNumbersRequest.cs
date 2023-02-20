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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the ListPhoneNumbers operation.
    /// Provides information about the phone numbers for the specified Amazon Connect instance.
    /// 
    /// 
    ///  
    /// <para>
    /// For more information about phone numbers, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-center-phone-number.html">Set
    /// Up Phone Numbers for Your Contact Center</a> in the <i>Amazon Connect Administrator
    /// Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// The phone number <code>Arn</code> value that is returned from each of the items in
    /// the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbers.html#connect-ListPhoneNumbers-response-PhoneNumberSummaryList">PhoneNumberSummaryList</a>
    /// cannot be used to tag phone number resources. It will fail with a <code>ResourceNotFoundException</code>.
    /// Instead, use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbersV2.html">ListPhoneNumbersV2</a>
    /// API. It returns the new phone number ARN that can be used to tag phone number resources.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ListPhoneNumbersRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _phoneNumberCountryCodes = new List<string>();
        private List<string> _phoneNumberTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page. The default MaxResult size is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
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
        /// Gets and sets the property PhoneNumberCountryCodes. 
        /// <para>
        /// The ISO country code.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<string> PhoneNumberCountryCodes
        {
            get { return this._phoneNumberCountryCodes; }
            set { this._phoneNumberCountryCodes = value; }
        }

        // Check to see if PhoneNumberCountryCodes property is set
        internal bool IsSetPhoneNumberCountryCodes()
        {
            return this._phoneNumberCountryCodes != null && this._phoneNumberCountryCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberTypes. 
        /// <para>
        /// The type of phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2)]
        public List<string> PhoneNumberTypes
        {
            get { return this._phoneNumberTypes; }
            set { this._phoneNumberTypes = value; }
        }

        // Check to see if PhoneNumberTypes property is set
        internal bool IsSetPhoneNumberTypes()
        {
            return this._phoneNumberTypes != null && this._phoneNumberTypes.Count > 0; 
        }

    }
}