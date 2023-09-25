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
    /// Match against the request's JA3 fingerprint header. The header contains a hash fingerprint
    /// of the TLS Client Hello packet for the request. 
    /// 
    ///  <note> 
    /// <para>
    /// You can use this choice only with a string match <code>ByteMatchStatement</code> with
    /// the <code>PositionalConstraint</code> set to <code>EXACTLY</code>. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class JA3Fingerprint
    {
        private FallbackBehavior _fallbackBehavior;

        /// <summary>
        /// Gets and sets the property FallbackBehavior. 
        /// <para>
        /// The match status to assign to the web request if the request doesn't have a JA3 fingerprint.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can specify the following fallback behaviors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>MATCH</code> - Treat the web request as matching the rule statement. WAF applies
        /// the rule action to the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NO_MATCH</code> - Treat the web request as not matching the rule statement.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public FallbackBehavior FallbackBehavior
        {
            get { return this._fallbackBehavior; }
            set { this._fallbackBehavior = value; }
        }

        // Check to see if FallbackBehavior property is set
        internal bool IsSetFallbackBehavior()
        {
            return this._fallbackBehavior != null;
        }

    }
}