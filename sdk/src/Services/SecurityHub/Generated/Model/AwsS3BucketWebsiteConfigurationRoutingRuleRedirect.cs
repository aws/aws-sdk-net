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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The rules to redirect the request if the condition in <c>Condition</c> is met.
    /// </summary>
    public partial class AwsS3BucketWebsiteConfigurationRoutingRuleRedirect
    {
        private string _hostname;
        private string _httpRedirectCode;
        private string _protocol;
        private string _replaceKeyPrefixWith;
        private string _replaceKeyWith;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The host name to use in the redirect request.
        /// </para>
        /// </summary>
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }

        /// <summary>
        /// Gets and sets the property HttpRedirectCode. 
        /// <para>
        /// The HTTP redirect code to use in the response.
        /// </para>
        /// </summary>
        public string HttpRedirectCode
        {
            get { return this._httpRedirectCode; }
            set { this._httpRedirectCode = value; }
        }

        // Check to see if HttpRedirectCode property is set
        internal bool IsSetHttpRedirectCode()
        {
            return this._httpRedirectCode != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol to use to redirect the request. By default, uses the protocol from the
        /// original request.
        /// </para>
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property ReplaceKeyPrefixWith. 
        /// <para>
        /// The object key prefix to use in the redirect request.
        /// </para>
        ///  
        /// <para>
        /// Cannot be provided if <c>ReplaceKeyWith</c> is present.
        /// </para>
        /// </summary>
        public string ReplaceKeyPrefixWith
        {
            get { return this._replaceKeyPrefixWith; }
            set { this._replaceKeyPrefixWith = value; }
        }

        // Check to see if ReplaceKeyPrefixWith property is set
        internal bool IsSetReplaceKeyPrefixWith()
        {
            return this._replaceKeyPrefixWith != null;
        }

        /// <summary>
        /// Gets and sets the property ReplaceKeyWith. 
        /// <para>
        /// The specific object key to use in the redirect request.
        /// </para>
        ///  
        /// <para>
        /// Cannot be provided if <c>ReplaceKeyPrefixWith</c> is present.
        /// </para>
        /// </summary>
        public string ReplaceKeyWith
        {
            get { return this._replaceKeyWith; }
            set { this._replaceKeyWith = value; }
        }

        // Check to see if ReplaceKeyWith property is set
        internal bool IsSetReplaceKeyWith()
        {
            return this._replaceKeyWith != null;
        }

    }
}