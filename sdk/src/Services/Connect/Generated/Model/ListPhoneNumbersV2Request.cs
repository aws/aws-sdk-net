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
    /// Container for the parameters to the ListPhoneNumbersV2 operation.
    /// Lists phone numbers claimed to your Amazon Connect instance or traffic distribution
    /// group. If the provided <code>TargetArn</code> is a traffic distribution group, you
    /// can call this API in both Amazon Web Services Regions associated with traffic distribution
    /// group.
    /// 
    ///  
    /// <para>
    /// For more information about phone numbers, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-center-phone-number.html">Set
    /// Up Phone Numbers for Your Contact Center</a> in the <i>Amazon Connect Administrator
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class ListPhoneNumbersV2Request : AmazonConnectRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _phoneNumberCountryCodes = new List<string>();
        private string _phoneNumberPrefix;
        private List<string> _phoneNumberTypes = new List<string>();
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
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
        [AWSProperty(Min=1, Max=100000)]
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
        /// Gets and sets the property PhoneNumberPrefix. 
        /// <para>
        /// The prefix of the phone number. If provided, it must contain <code>+</code> as part
        /// of the country code.
        /// </para>
        /// </summary>
        public string PhoneNumberPrefix
        {
            get { return this._phoneNumberPrefix; }
            set { this._phoneNumberPrefix = value; }
        }

        // Check to see if PhoneNumberPrefix property is set
        internal bool IsSetPhoneNumberPrefix()
        {
            return this._phoneNumberPrefix != null;
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

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for Amazon Connect instances or traffic distribution
        /// groups that phone numbers are claimed to. If <code>TargetArn</code> input is not provided,
        /// this API lists numbers claimed to all the Amazon Connect instances belonging to your
        /// account in the same Amazon Web Services Region as the request.
        /// </para>
        /// </summary>
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}