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
    /// This is the response object from the CreateOneTimeDeepLinkCode operation.
    /// </summary>
    public partial class CreateOneTimeDeepLinkCodeResponse : AmazonWebServiceResponse
    {
        private string _code;
        private string _deepLinkUrl;
        private DateTime? _expiresAt;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The one-time deep-link code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property DeepLinkUrl. 
        /// <para>
        /// The deep-link URL containing the one-time code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string DeepLinkUrl
        {
            get { return this._deepLinkUrl; }
            set { this._deepLinkUrl = value; }
        }

        // Check to see if DeepLinkUrl property is set
        internal bool IsSetDeepLinkUrl()
        {
            return this._deepLinkUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The timestamp when the code expires.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

    }
}