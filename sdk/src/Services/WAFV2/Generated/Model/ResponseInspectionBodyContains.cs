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
    /// Configures inspection of the response body. This is part of the <code>ResponseInspection</code>
    /// configuration for <code>AWSManagedRulesATPRuleSet</code>. 
    /// 
    ///  <note> 
    /// <para>
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront distributions.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// For regional web ACLs in Region US East (N. Virginia) us-east-1, it's possible to
    /// configure response inspection through the APIs, but ATP response inspection will not
    /// be enabled. You can only use the response inspection capabilities of the ATP managed
    /// rule group in web ACLs that protect CloudFront distributions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ResponseInspectionBodyContains
    {
        private List<string> _failureStrings = new List<string>();
        private List<string> _successStrings = new List<string>();

        /// <summary>
        /// Gets and sets the property FailureStrings. 
        /// <para>
        /// Strings in the body of the response that indicate a failed login attempt. To be counted
        /// as a failed login, the string can be anywhere in the body and must be an exact match,
        /// including case. Each string must be unique among the success and failure strings.
        /// 
        /// </para>
        ///  
        /// <para>
        /// JSON example: <code>"FailureStrings": [ "Login failed" ]</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> FailureStrings
        {
            get { return this._failureStrings; }
            set { this._failureStrings = value; }
        }

        // Check to see if FailureStrings property is set
        internal bool IsSetFailureStrings()
        {
            return this._failureStrings != null && this._failureStrings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SuccessStrings. 
        /// <para>
        /// Strings in the body of the response that indicate a successful login attempt. To be
        /// counted as a successful login, the string can be anywhere in the body and must be
        /// an exact match, including case. Each string must be unique among the success and failure
        /// strings. 
        /// </para>
        ///  
        /// <para>
        /// JSON example: <code>"SuccessStrings": [ "Login successful", "Welcome to our site!"
        /// ]</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> SuccessStrings
        {
            get { return this._successStrings; }
            set { this._successStrings = value; }
        }

        // Check to see if SuccessStrings property is set
        internal bool IsSetSuccessStrings()
        {
            return this._successStrings != null && this._successStrings.Count > 0; 
        }

    }
}