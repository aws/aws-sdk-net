/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// The response from the <code>ListPhoneNumbersOptedOut</code> action.
    /// </summary>
    public partial class ListPhoneNumbersOptedOutResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _phoneNumbers = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A <code>NextToken</code> string is returned when you call the <code>ListPhoneNumbersOptedOut</code>
        /// action if additional records are available after the first page of results.
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
        /// Gets and sets the property PhoneNumbers. 
        /// <para>
        /// A list of phone numbers that are opted out of receiving SMS messages. The list is
        /// paginated, and each page can contain up to 100 phone numbers.
        /// </para>
        /// </summary>
        public List<string> PhoneNumbers
        {
            get { return this._phoneNumbers; }
            set { this._phoneNumbers = value; }
        }

        // Check to see if PhoneNumbers property is set
        internal bool IsSetPhoneNumbers()
        {
            return this._phoneNumbers != null && this._phoneNumbers.Count > 0; 
        }

    }
}