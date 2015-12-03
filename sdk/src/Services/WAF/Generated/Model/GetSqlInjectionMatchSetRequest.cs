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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Container for the parameters to the GetSqlInjectionMatchSet operation.
    /// Returns the <a>SqlInjectionMatchSet</a> that is specified by <code>SqlInjectionMatchSetId</code>.
    /// </summary>
    public partial class GetSqlInjectionMatchSetRequest : AmazonWAFRequest
    {
        private string _sqlInjectionMatchSetId;

        /// <summary>
        /// Gets and sets the property SqlInjectionMatchSetId. 
        /// <para>
        /// The <code>SqlInjectionMatchSetId</code> of the <a>SqlInjectionMatchSet</a> that you
        /// want to get. <code>SqlInjectionMatchSetId</code> is returned by <a>CreateSqlInjectionMatchSet</a>
        /// and by <a>ListSqlInjectionMatchSets</a>.
        /// </para>
        /// </summary>
        public string SqlInjectionMatchSetId
        {
            get { return this._sqlInjectionMatchSetId; }
            set { this._sqlInjectionMatchSetId = value; }
        }

        // Check to see if SqlInjectionMatchSetId property is set
        internal bool IsSetSqlInjectionMatchSetId()
        {
            return this._sqlInjectionMatchSetId != null;
        }

    }
}