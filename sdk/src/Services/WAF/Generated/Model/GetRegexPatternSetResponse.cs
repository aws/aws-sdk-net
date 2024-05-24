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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
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
namespace Amazon.WAF.Model
{
    /// <summary>
    /// This is the response object from the GetRegexPatternSet operation.
    /// </summary>
    public partial class GetRegexPatternSetResponse : AmazonWebServiceResponse
    {
        private RegexPatternSet _regexPatternSet;

        /// <summary>
        /// Gets and sets the property RegexPatternSet. 
        /// <para>
        /// Information about the <a>RegexPatternSet</a> that you specified in the <c>GetRegexPatternSet</c>
        /// request, including the identifier of the pattern set and the regular expression patterns
        /// you want AWS WAF to search for. 
        /// </para>
        /// </summary>
        public RegexPatternSet RegexPatternSet
        {
            get { return this._regexPatternSet; }
            set { this._regexPatternSet = value; }
        }

        // Check to see if RegexPatternSet property is set
        internal bool IsSetRegexPatternSet()
        {
            return this._regexPatternSet != null;
        }

    }
}