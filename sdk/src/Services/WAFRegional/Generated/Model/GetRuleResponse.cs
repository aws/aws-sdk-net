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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
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
namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// This is the response object from the GetRule operation.
    /// </summary>
    public partial class GetRuleResponse : AmazonWebServiceResponse
    {
        private Rule _rule;

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// Information about the <a>Rule</a> that you specified in the <c>GetRule</c> request.
        /// For more information, see the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Rule</a>: Contains <c>MetricName</c>, <c>Name</c>, an array of <c>Predicate</c>
        /// objects, and <c>RuleId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Predicate</a>: Each <c>Predicate</c> object contains <c>DataId</c>, <c>Negated</c>,
        /// and <c>Type</c> 
        /// </para>
        ///  </li> </ul>
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