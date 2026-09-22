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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOneTimeDeepLinkCode operation.
    /// Generates a one-time code for deep-link authentication.
    /// 
    ///  
    /// <para>
    /// Direct the user's browser to the returned deepLinkUrl before it expires. The code
    /// is exchanged for an authenticated, domain-scoped session and can be used only once.
    /// </para>
    /// </summary>
    public partial class CreateOneTimeDeepLinkCodeRequest : AmazonCloudWatchOmniRequest
    {
        private string _domainId;
        private string _redirectUrl;
        private int? _ttlSeconds;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the domain to generate the code for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectUrl. 
        /// <para>
        /// The URL to redirect to after the deep-link code is used. Must be an HTTPS URL in the
        /// domain with a path of /auth/callback, and cannot include a query string or fragment.
        /// If omitted, no redirect is applied.
        /// </para>
        /// </summary>
        public string RedirectUrl
        {
            get { return this._redirectUrl; }
            set { this._redirectUrl = value; }
        }

        // Check to see if RedirectUrl property is set
        internal bool IsSetRedirectUrl()
        {
            return this._redirectUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TtlSeconds. 
        /// <para>
        /// How long the code remains valid, in seconds. Defaults to 300.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=600)]
        public int? TtlSeconds
        {
            get { return this._ttlSeconds; }
            set { this._ttlSeconds = value; }
        }

        // Check to see if TtlSeconds property is set
        internal bool IsSetTtlSeconds()
        {
            return this._ttlSeconds.HasValue; 
        }

    }
}