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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Available for use with Amazon CloudFront distributions and Application Load Balancers.
    /// Match against the request's JA3 fingerprint. The JA3 fingerprint is a 32-character
    /// hash derived from the TLS Client Hello of an incoming request. This fingerprint serves
    /// as a unique identifier for the client's TLS configuration. WAF calculates and logs
    /// this fingerprint for each request that has enough TLS Client Hello information for
    /// the calculation. Almost all web requests include this information.
    /// 
    ///  <note> 
    /// <para>
    /// You can use this choice with a <c>ByteMatchStatement</c>, <c>RegexMatchStatement</c>,
    /// <c>RegexPatternSetReferenceStatement</c>, or <c>SizeConstraintStatement</c>. You can't
    /// use it with <c>SqliMatchStatement</c> or <c>XssMatchStatement</c>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// You can obtain the JA3 fingerprint for client requests from the web ACL logs. If WAF
    /// is able to calculate the fingerprint, it includes it in the logs. For information
    /// about the logging fields, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html">Log
    /// fields</a> in the <i>WAF Developer Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// Provide the JA3 fingerprint string from the logs in your string match statement specification,
    /// to match with any future requests that have the same TLS configuration. To match a
    /// group of TLS configurations with a single pattern, use a regex statement.
    /// </para>
    /// </summary>
    public partial class JA3Fingerprint
    {
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
        ///  <c>MATCH</c> - Treat the web request as matching the rule statement. WAF applies
        /// the rule action to the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_MATCH</c> - Treat the web request as not matching the rule statement.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public FallbackBehavior FallbackBehavior { get; set; }

        /// <summary>
        /// Checks to see if the FallbackBehavior property is set.
        /// </summary>
        internal bool IsSetFallbackBehavior() => this.FallbackBehavior != null;
    }
}
