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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// This is the response object from the SearchAvailablePhoneNumbers operation.
    /// </summary>
    public partial class SearchAvailablePhoneNumbersResponse : AmazonWebServiceResponse
    {
        private List<string> _e164PhoneNumbers = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property E164PhoneNumbers. 
        /// <para>
        /// Confines a search to just the phone numbers in the E.164 format.
        /// </para>
        /// </summary>
        public List<string> E164PhoneNumbers
        {
            get { return this._e164PhoneNumbers; }
            set { this._e164PhoneNumbers = value; }
        }

        // Check to see if E164PhoneNumbers property is set
        internal bool IsSetE164PhoneNumbers()
        {
            return this._e164PhoneNumbers != null && this._e164PhoneNumbers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to return the next page of results.
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