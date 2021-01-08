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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// This is the response object from the ListSipRules operation.
    /// </summary>
    public partial class ListSipRulesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SipRule> _sipRules = new List<SipRule>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=65535)]
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
        /// Gets and sets the property SipRules. 
        /// <para>
        /// List of SIP rules and rule details.
        /// </para>
        /// </summary>
        public List<SipRule> SipRules
        {
            get { return this._sipRules; }
            set { this._sipRules = value; }
        }

        // Check to see if SipRules property is set
        internal bool IsSetSipRules()
        {
            return this._sipRules != null && this._sipRules.Count > 0; 
        }

    }
}