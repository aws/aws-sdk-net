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


using System;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The established temporary security credentials of the session.
    /// 
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - These session credentials are only supported for the authentication
    /// and authorization of Zonal endpoint APIs on directory buckets.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SessionCredentials
    {
        private string _accessKeyId;
        private DateTime? _expiration;
        private string _secretAccessKey;
        private string _sessionToken;

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// A unique identifier that's associated with a secret access key. The access key ID
        /// and the secret access key are used together to sign programmatic Amazon Web Services
        /// requests cryptographically. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccessKeyId
        {
            get { return this._accessKeyId; }
            set { this._accessKeyId = value; }
        }

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this._accessKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// Temporary security credentials expire after a specified interval. After temporary
        /// credentials expire, any calls that you make with those credentials will fail. So you
        /// must generate a new set of temporary credentials. Temporary credentials cannot be
        /// extended or refreshed beyond the original specified interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration.HasValue;
        }

        /// <summary>
        /// Gets and sets the property SecretAccessKey. 
        /// <para>
        /// A key that's used with the access key ID to cryptographically sign programmatic Amazon
        /// Web Services requests. Signing a request identifies the sender and prevents the request
        /// from being altered. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string SecretAccessKey
        {
            get { return this._secretAccessKey; }
            set { this._secretAccessKey = value; }
        }

        // Check to see if SecretAccessKey property is set
        internal bool IsSetSecretAccessKey()
        {
            return this._secretAccessKey != null;
        }

        /// <summary>
        /// Gets and sets the property SessionToken. 
        /// <para>
        /// A part of the temporary security credentials. The session token is used to validate
        /// the temporary security credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string SessionToken
        {
            get { return this._sessionToken; }
            set { this._sessionToken = value; }
        }

        // Check to see if SessionToken property is set
        internal bool IsSetSessionToken()
        {
            return this._sessionToken != null;
        }

    }
}