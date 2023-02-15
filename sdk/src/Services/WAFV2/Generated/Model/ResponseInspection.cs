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
    /// The criteria for inspecting responses to login requests, used by the ATP rule group
    /// to track login failure rates. 
    /// 
    ///  
    /// <para>
    /// The ATP rule group evaluates the responses that your protected resources send back
    /// to client login attempts, keeping count of successful and failed attempts from each
    /// IP address and client session. Using this information, the rule group labels and mitigates
    /// requests from client sessions and IP addresses that submit too many failed login attempts
    /// in a short amount of time. 
    /// </para>
    ///  <note> 
    /// <para>
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront distributions.
    /// </para>
    ///  </note> 
    /// <para>
    /// This is part of the <code>AWSManagedRulesATPRuleSet</code> configuration in <code>ManagedRuleGroupConfig</code>.
    /// </para>
    ///  
    /// <para>
    /// Enable login response inspection by configuring exactly one component of the response
    /// to inspect. You can't configure more than one. If you don't configure any of the response
    /// inspection options, response inspection is disabled. 
    /// </para>
    /// </summary>
    public partial class ResponseInspection
    {
        private ResponseInspectionBodyContains _bodyContains;
        private ResponseInspectionHeader _header;
        private ResponseInspectionJson _json;
        private ResponseInspectionStatusCode _statusCode;

        /// <summary>
        /// Gets and sets the property BodyContains. 
        /// <para>
        /// Configures inspection of the response body. 
        /// </para>
        /// </summary>
        public ResponseInspectionBodyContains BodyContains
        {
            get { return this._bodyContains; }
            set { this._bodyContains = value; }
        }

        // Check to see if BodyContains property is set
        internal bool IsSetBodyContains()
        {
            return this._bodyContains != null;
        }

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// Configures inspection of the response header. 
        /// </para>
        /// </summary>
        public ResponseInspectionHeader Header
        {
            get { return this._header; }
            set { this._header = value; }
        }

        // Check to see if Header property is set
        internal bool IsSetHeader()
        {
            return this._header != null;
        }

        /// <summary>
        /// Gets and sets the property Json. 
        /// <para>
        /// Configures inspection of the response JSON. 
        /// </para>
        /// </summary>
        public ResponseInspectionJson Json
        {
            get { return this._json; }
            set { this._json = value; }
        }

        // Check to see if Json property is set
        internal bool IsSetJson()
        {
            return this._json != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// Configures inspection of the response status code. 
        /// </para>
        /// </summary>
        public ResponseInspectionStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

    }
}