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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Details for your use of the account creation fraud prevention managed rule group,
    /// <c>AWSManagedRulesACFPRuleSet</c>. This configuration is used in <c>ManagedRuleGroupConfig</c>.
    /// 
    /// 
    ///  
    /// <para>
    /// For additional information about this and the other intelligent threat mitigation
    /// rule groups, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-managed-protections">Intelligent
    /// threat mitigation in WAF</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-managed-rule-groups-list">Amazon
    /// Web Services Managed Rules rule groups list</a> in the <i>WAF Developer Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial class AWSManagedRulesACFPRuleSet
    {
        private string _creationPath;
        private bool? _enableRegexInPath;
        private string _registrationPagePath;
        private RequestInspectionACFP _requestInspection;
        private ResponseInspection _responseInspection;

        /// <summary>
        /// Gets and sets the property CreationPath. 
        /// <para>
        /// The path of the account creation endpoint for your application. This is the page on
        /// your website that accepts the completed registration form for a new user. This page
        /// must accept <c>POST</c> requests.
        /// </para>
        ///  
        /// <para>
        /// For example, for the URL <c>https://example.com/web/newaccount</c>, you would provide
        /// the path <c>/web/newaccount</c>. Account creation page paths that start with the path
        /// that you provide are considered a match. For example <c>/web/newaccount</c> matches
        /// the account creation paths <c>/web/newaccount</c>, <c>/web/newaccount/</c>, <c>/web/newaccountPage</c>,
        /// and <c>/web/newaccount/thisPage</c>, but doesn't match the path <c>/home/web/newaccount</c>
        /// or <c>/website/newaccount</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string CreationPath
        {
            get { return this._creationPath; }
            set { this._creationPath = value; }
        }

        // Check to see if CreationPath property is set
        internal bool IsSetCreationPath()
        {
            return this._creationPath != null;
        }

        /// <summary>
        /// Gets and sets the property EnableRegexInPath. 
        /// <para>
        /// Allow the use of regular expressions in the registration page path and the account
        /// creation path. 
        /// </para>
        /// </summary>
        public bool? EnableRegexInPath
        {
            get { return this._enableRegexInPath; }
            set { this._enableRegexInPath = value; }
        }

        // Check to see if EnableRegexInPath property is set
        internal bool IsSetEnableRegexInPath()
        {
            return this._enableRegexInPath.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistrationPagePath. 
        /// <para>
        /// The path of the account registration endpoint for your application. This is the page
        /// on your website that presents the registration form to new users. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This page must accept <c>GET</c> text/html requests.
        /// </para>
        ///  </note> 
        /// <para>
        /// For example, for the URL <c>https://example.com/web/registration</c>, you would provide
        /// the path <c>/web/registration</c>. Registration page paths that start with the path
        /// that you provide are considered a match. For example <c>/web/registration</c> matches
        /// the registration paths <c>/web/registration</c>, <c>/web/registration/</c>, <c>/web/registrationPage</c>,
        /// and <c>/web/registration/thisPage</c>, but doesn't match the path <c>/home/web/registration</c>
        /// or <c>/website/registration</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string RegistrationPagePath
        {
            get { return this._registrationPagePath; }
            set { this._registrationPagePath = value; }
        }

        // Check to see if RegistrationPagePath property is set
        internal bool IsSetRegistrationPagePath()
        {
            return this._registrationPagePath != null;
        }

        /// <summary>
        /// Gets and sets the property RequestInspection. 
        /// <para>
        /// The criteria for inspecting account creation requests, used by the ACFP rule group
        /// to validate and track account creation attempts. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RequestInspectionACFP RequestInspection
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
        /// The criteria for inspecting responses to account creation requests, used by the ACFP
        /// rule group to track account creation success rates. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Response inspection is available only in web ACLs that protect Amazon CloudFront distributions.
        /// </para>
        ///  </note> 
        /// <para>
        /// The ACFP rule group evaluates the responses that your protected resources send back
        /// to client account creation attempts, keeping count of successful and failed attempts
        /// from each IP address and client session. Using this information, the rule group labels
        /// and mitigates requests from client sessions and IP addresses that have had too many
        /// successful account creation attempts in a short amount of time. 
        /// </para>
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