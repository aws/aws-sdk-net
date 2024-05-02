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
    /// The response to a <c>CreateSqlInjectionMatchSet</c> request.
    /// </summary>
    public partial class CreateSqlInjectionMatchSetResponse : AmazonWebServiceResponse
    {
        private string _changeToken;
        private SqlInjectionMatchSet _sqlInjectionMatchSet;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The <c>ChangeToken</c> that you used to submit the <c>CreateSqlInjectionMatchSet</c>
        /// request. You can also use this value to query the status of the request. For more
        /// information, see <a>GetChangeTokenStatus</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ChangeToken
        {
            get { return this._changeToken; }
            set { this._changeToken = value; }
        }

        // Check to see if ChangeToken property is set
        internal bool IsSetChangeToken()
        {
            return this._changeToken != null;
        }

        /// <summary>
        /// Gets and sets the property SqlInjectionMatchSet. 
        /// <para>
        /// A <a>SqlInjectionMatchSet</a>.
        /// </para>
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