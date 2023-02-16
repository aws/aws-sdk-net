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
    /// Details for your use of the account takeover prevention managed rule group, <code>AWSManagedRulesATPRuleSet</code>.
    /// This configuration is used in <code>ManagedRuleGroupConfig</code>.
    /// </summary>
    public partial class AWSManagedRulesATPRuleSet
    {
        private string _loginPath;
        private RequestInspection _requestInspection;
        private ResponseInspection _responseInspection;

        /// <summary>
        /// Gets and sets the property LoginPath. 
        /// <para>
        /// The path of the login endpoint for your application. For example, for the URL <code>https://example.com/web/login</code>,
        /// you would provide the path <code>/web/login</code>.
        /// </para>
        ///  
        /// <para>
        /// The rule group inspects only HTTP <code>POST</code> requests to your specified login
        /// endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LoginPath
        {
            get { return this._loginPath; }
            set { this._loginPath = value; }
        }

        // Check to see if LoginPath property is set
        internal bool IsSetLoginPath()
        {
            return this._loginPath != null;
        }

        /// <summary>
        /// Gets and sets the property RequestInspection. 
        /// <para>
        /// The criteria for inspecting login requests, used by the ATP rule group to validate
        /// credentials usage. 
        /// </para>
        /// </summary>
        public RequestInspection RequestInspection
        {
            get { return this._requestInspection; }
            set { this._requestInspection = value; }
        }

        // Check to see if RequestInspection property is set
        internal bool IsSetRequestInspection()
        {
            return this._requestInspection != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseInspection. 
        /// <para>
        /// The criteria for inspecting responses to login requests, used by the ATP rule group
        /// to track login failure rates. 
        /// </para>
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
        ///  </note> <note> 
        /// <para>
        /// For regional web ACLs in Region US East (N. Virginia) us-east-1, it's possible to
        /// configure response inspection through the APIs, but ATP response inspection will not
        /// be enabled. You can only use the response inspection capabilities of the ATP managed
        /// rule group in web ACLs that protect CloudFront distributions.
        /// </para>
        ///  </note>
        /// </summary>
        public ResponseInspection ResponseInspection
        {
            get { return this._responseInspection; }
            set { this._responseInspection = value; }
        }

        // Check to see if ResponseInspection property is set
        internal bool IsSetResponseInspection()
        {
            return this._responseInspection != null;
        }

    }
}