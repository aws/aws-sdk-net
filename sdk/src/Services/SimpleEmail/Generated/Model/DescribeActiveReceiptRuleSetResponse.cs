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
    /// Represents the metadata and receipt rules for the receipt rule set that is currently
    /// active.
    /// </summary>
    public partial class DescribeActiveReceiptRuleSetResponse : AmazonWebServiceResponse
    {
        private ReceiptRuleSetMetadata _metadata;
        private List<ReceiptRule> _rules = new List<ReceiptRule>();

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata for the currently active receipt rule set. The metadata consists of the
        /// rule set name and a timestamp of when the rule set was created.
        /// </para>
        /// </summary>
        public ReceiptRuleSetMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The receipt rules that belong to the active rule set.
        /// </para>
        /// </summary>
        public List<ReceiptRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

    }
}