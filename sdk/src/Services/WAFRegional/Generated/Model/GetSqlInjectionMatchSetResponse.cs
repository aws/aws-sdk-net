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
    /// The response to a <a>GetSqlInjectionMatchSet</a> request.
    /// </summary>
    public partial class GetSqlInjectionMatchSetResponse : AmazonWebServiceResponse
    {
        private SqlInjectionMatchSet _sqlInjectionMatchSet;

        /// <summary>
        /// Gets and sets the property SqlInjectionMatchSet. 
        /// <para>
        /// Information about the <a>SqlInjectionMatchSet</a> that you specified in the <c>GetSqlInjectionMatchSet</c>
        /// request. For more information, see the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>SqlInjectionMatchSet</a>: Contains <c>Name</c>, <c>SqlInjectionMatchSetId</c>,
        /// and an array of <c>SqlInjectionMatchTuple</c> objects
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SqlInjectionMatchTuple</a>: Each <c>SqlInjectionMatchTuple</c> object contains
        /// <c>FieldToMatch</c> and <c>TextTransformation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SqlInjectionMatchSet SqlInjectionMatchSet
        {
            get { return this._sqlInjectionMatchSet; }
            set { this._sqlInjectionMatchSet = value; }
        }

        // Check to see if SqlInjectionMatchSet property is set
        internal bool IsSetSqlInjectionMatchSet()
        {
            return this._sqlInjectionMatchSet != null;
        }

    }
}