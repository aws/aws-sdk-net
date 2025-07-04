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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A single regular expression. This is used in a <a>RegexPatternSet</a> and also in
    /// the configuration for the Amazon Web Services Managed Rules rule group <c>AWSManagedRulesAntiDDoSRuleSet</c>.
    /// </summary>
    public partial class Regex
    {
        private string _regexString;

        /// <summary>
        /// Gets and sets the property RegexString. 
        /// <para>
        /// The string representing the regular expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string RegexString
        {
            get { return this._regexString; }
            set { this._regexString = value; }
        }

        // Check to see if RegexString property is set
        internal bool IsSetRegexString()
        {
            return this._regexString != null;
        }

    }
}