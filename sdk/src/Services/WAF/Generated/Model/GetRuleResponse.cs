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
    /// 
    /// </summary>
    public partial class GetRuleResponse : AmazonWebServiceResponse
    {
        private Rule _rule;

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// Information about the <a>Rule</a> that you specified in the <code>GetRule</code> request.
        /// For more information, see the following topics:
        /// </para>
        ///  <ul> <li><a>Rule</a>: Contains <code>MetricName</code>, <code>Name</code>, an array
        /// of <code>Predicate</code> objects, and <code>RuleId</code></li> <li><a>Predicate</a>:
        /// Each <code>Predicate</code> object contains <code>DataId</code>, <code>Negated</code>,
        /// and <code>Type</code></li> </ul>
        /// </summary>
        public Rule Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

    }
}