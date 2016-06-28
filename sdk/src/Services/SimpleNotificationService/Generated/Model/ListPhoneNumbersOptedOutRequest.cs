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
    /// Container for the parameters to the ListPhoneNumbersOptedOut operation.
    /// Returns a list of phone numbers that are opted out, meaning you cannot send SMS messages
    /// to them.
    /// 
    ///  
    /// <para>
    /// The results for <code>ListPhoneNumbersOptedOut</code> are paginated, and each page
    /// returns up to 100 phone numbers. If additional phone numbers are available after the
    /// first page of results, then a <code>NextToken</code> string will be returned. To receive
    /// the next page, you call <code>ListPhoneNumbersOptedOut</code> again using the <code>NextToken</code>
    /// string received from the previous call. When there are no more records to return,
    /// <code>NextToken</code> will be null.
    /// </para>
    /// </summary>
    public partial class ListPhoneNumbersOptedOutRequest : AmazonSimpleNotificationServiceRequest
    {
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A <code>NextToken</code> string is used when you call the <code>ListPhoneNumbersOptedOut</code>
        /// action to retrieve additional records that are available after the first page of results.
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