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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// This is the response object from the CreateAccessToken operation.
    /// </summary>
    public partial class CreateAccessTokenResponse : AmazonWebServiceResponse
    {
        private string _accessTokenId;
        private DateTime? _expiresTime;
        private string _name;
        private string _secret;

        /// <summary>
        /// Gets and sets the property AccessTokenId. 
        /// <para>
        /// The system-generated unique ID of the access token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string AccessTokenId
        {
            get { return this._accessTokenId; }
            set { this._accessTokenId = value; }
        }

        // Check to see if AccessTokenId property is set
        internal bool IsSetAccessTokenId()
        {
            return this._accessTokenId != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresTime. 
        /// <para>
        /// The date and time the personal access token expires, in coordinated universal time
        /// (UTC) timestamp format as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339</a>. If not specified, the default is one year from creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ExpiresTime
        {
            get { return this._expiresTime.GetValueOrDefault(); }
            set { this._expiresTime = value; }
        }

        // Check to see if ExpiresTime property is set
        internal bool IsSetExpiresTime()
        {
            return this._expiresTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the personal access token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Secret. 
        /// <para>
        /// The secret value of the personal access token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4000)]
        public string Secret
        {
            get { return this._secret; }
            set { this._secret = value; }
        }

        // Check to see if Secret property is set
        internal bool IsSetSecret()
        {
            return this._secret != null;
        }

    }
}