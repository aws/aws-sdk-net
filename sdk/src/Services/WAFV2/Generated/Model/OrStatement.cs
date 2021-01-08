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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
    /// 2019. For information, including how to migrate your AWS WAF resources from the prior
    /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// A logical rule statement used to combine other rule statements with OR logic. You
    /// provide more than one <a>Statement</a> within the <code>OrStatement</code>. 
    /// </para>
    /// </summary>
    public partial class OrStatement
    {
        private List<Statement> _statements = new List<Statement>();

        /// <summary>
        /// Gets and sets the property Statements. 
        /// <para>
        /// The statements to combine with OR logic. You can use any statements that can be nested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Statement> Statements
        {
            get { return this._statements; }
            set { this._statements = value; }
        }

        // Check to see if Statements property is set
        internal bool IsSetStatements()
        {
            return this._statements != null && this._statements.Count > 0; 
        }

    }
}