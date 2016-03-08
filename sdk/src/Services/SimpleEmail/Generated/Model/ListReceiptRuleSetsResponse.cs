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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// This is the response object from the ListReceiptRuleSets operation.
    /// </summary>
    public partial class ListReceiptRuleSetsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ReceiptRuleSetMetadata> _ruleSets = new List<ReceiptRuleSetMetadata>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token indicating that there are additional receipt rule sets available to be listed.
        /// Pass this token to successive calls of <code>ListReceiptRuleSets</code> to retrieve
        /// up to 100 receipt rule sets at a time.
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
        /// Gets and sets the property RuleSets. 
        /// <para>
        /// The metadata for the currently active receipt rule set. The metadata consists of the
        /// rule set name and the timestamp of when the rule set was created.
        /// </para>
        /// </summary>
        public List<ReceiptRuleSetMetadata> RuleSets
        {
            get { return this._ruleSets; }
            set { this._ruleSets = value; }
        }

        // Check to see if RuleSets property is set
        internal bool IsSetRuleSets()
        {
            return this._ruleSets != null && this._ruleSets.Count > 0; 
        }

    }
}