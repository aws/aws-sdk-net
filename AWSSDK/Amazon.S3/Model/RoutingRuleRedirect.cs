/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for redirect information. You can redirect requests to another host, to 
    /// another page, or with another protocol. In the event of an error, you can can specify a different error code to return.
    /// </summary>
    public class RoutingRuleRedirect
    {
        string _protocol;
        string _hostName;
        string _replaceKeyPrefixWith;
        string _replaceKeyWith;
        string _httpRedirectCode;

        #region Protocol

        /// <summary>
        /// The protocol to use in the redirect request.
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        /// <summary>
        /// The protocol to use in the redirect request.
        /// </summary>
        /// <param name="protocol">The protocol to use in the redirect request</param>
        /// <returns>the RoutingRuleCondition with the Protocol set</returns>
        public RoutingRuleRedirect WithProtocol(string protocol)
        {
            this._protocol = protocol;
            return this;
        }

        /// <summary>
        /// Checks if the Protocol property is set.
        /// </summary>
        /// <returns>true if Protocol property is set.</returns>
        internal bool IsSetProtocol()
        {
            return !System.String.IsNullOrEmpty(this._protocol);
        }

        #endregion

        #region HostName

        /// <summary>
        /// The host name to use in the redirect request.
        /// </summary>
        public string HostName
        {
            get { return this._hostName; }
            set { this._hostName = value; }
        }

        /// <summary>
        /// The host name to use in the redirect request.
        /// </summary>
        /// <param name="hostName">The host name to use in the redirect request</param>
        /// <returns>the RoutingRuleCondition with the HostName set</returns>
        public RoutingRuleRedirect WithHostName(string hostName)
        {
            this._hostName = hostName;
            return this;
        }

        /// <summary>
        /// Checks if the HostName property is set.
        /// </summary>
        /// <returns>true if HostName property is set.</returns>
        internal bool IsSetHostName()
        {
            return !System.String.IsNullOrEmpty(this._hostName);
        }

        #endregion

        #region ReplaceKeyPrefixWith

        /// <summary>
        /// The object key prefix to use in the redirect request. For example, to redirect requests for all pages 
        /// with prefix docs/ (objects in the docs/ folder) to documents/, you can set a condition block with 
        /// KeyPrefixEquals set to docs/ and in the Redirect set ReplaceKeyPrefixWith to /documents.
        /// </summary>
        public string ReplaceKeyPrefixWith
        {
            get { return this._replaceKeyPrefixWith; }
            set { this._replaceKeyPrefixWith = value; }
        }

        /// <summary>
        /// The object key prefix to use in the redirect request. For example, to redirect requests for all pages 
        /// with prefix docs/ (objects in the docs/ folder) to documents/, you can set a condition block with 
        /// KeyPrefixEquals set to docs/ and in the Redirect set ReplaceKeyPrefixWith to /documents.
        /// </summary>
        /// <param name="replaceKeyPrefixWith">The object key prefix to use in the redirect request</param>
        /// <returns>the RoutingRuleCondition with the ReplaceKeyPrefixWith set</returns>
        public RoutingRuleRedirect WithReplaceKeyPrefixWith(string replaceKeyPrefixWith)
        {
            this._replaceKeyPrefixWith = replaceKeyPrefixWith;
            return this;
        }

        /// <summary>
        /// Checks if the ReplaceKeyPrefixWith property is set.
        /// </summary>
        /// <returns>true if ReplaceKeyPrefixWith property is set.</returns>
        internal bool IsSetReplaceKeyPrefixWith()
        {
            return !System.String.IsNullOrEmpty(this._replaceKeyPrefixWith);
        }

        #endregion

        #region ReplaceKeyWith

        /// <summary>
        /// The specific object key to use in the redirect request. For example, redirect request to error.html.
        /// </summary>
        public string ReplaceKeyWith
        {
            get { return this._replaceKeyWith; }
            set { this._replaceKeyWith = value; }
        }

        /// <summary>
        /// The specific object key to use in the redirect request. For example, redirect request to error.html.
        /// </summary>
        /// <param name="replaceKeyWith">The specific object key to use in the redirect request</param>
        /// <returns>the RoutingRuleCondition with the ReplaceKeyWith set</returns>
        public RoutingRuleRedirect WithReplaceKeyWith(string replaceKeyWith)
        {
            this._replaceKeyWith = replaceKeyWith;
            return this;
        }

        /// <summary>
        /// Checks if the ReplaceKeyWith property is set.
        /// </summary>
        /// <returns>true if ReplaceKeyWith property is set.</returns>
        internal bool IsSetReplaceKeyWith()
        {
            return !System.String.IsNullOrEmpty(this._replaceKeyWith);
        }

        #endregion

        #region HttpRedirectCode

        /// <summary>
        /// The HTTP redirect code to use on the response.
        /// </summary>
        public string HttpRedirectCode
        {
            get { return this._httpRedirectCode; }
            set { this._httpRedirectCode = value; }
        }

        /// <summary>
        /// The HTTP redirect code to use on the response.
        /// </summary>
        /// <param name="httpRedirectCode">The HTTP redirect code to use on the response</param>
        /// <returns>the RoutingRuleCondition with the HttpRedirectCode set</returns>
        public RoutingRuleRedirect WithHttpRedirectCode(string httpRedirectCode)
        {
            this._httpRedirectCode = httpRedirectCode;
            return this;
        }

        /// <summary>
        /// Checks if the HttpRedirectCode property is set.
        /// </summary>
        /// <returns>true if HttpRedirectCode property is set.</returns>
        internal bool IsSetHttpRedirectCode()
        {
            return !System.String.IsNullOrEmpty(this._httpRedirectCode);
        }

        #endregion
    }
}
