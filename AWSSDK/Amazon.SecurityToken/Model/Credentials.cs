/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// AWS credentials for API authentication.
    /// </summary>
    public partial class Credentials
    {
        private string _accessKeyId;
        private DateTime? _expiration;
        private string _secretAccessKey;
        private string _sessionToken;


        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The access key ID that identifies the temporary security credentials.
        /// </para>
        /// </summary>
        public string AccessKeyId
        {
            get { return this._accessKeyId; }
            set { this._accessKeyId = value; }
        }


        /// <summary>
        /// Sets the AccessKeyId property
        /// </summary>
        /// <param name="accessKeyId">The value to set for the AccessKeyId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Credentials WithAccessKeyId(string accessKeyId)
        {
            this._accessKeyId = accessKeyId;
            return this;
        }

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this._accessKeyId != null;
        }


        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The date on which the current credentials expire.
        /// </para>
        /// </summary>
        public DateTime Expiration
        {
            get { return this._expiration.GetValueOrDefault(); }
            set { this._expiration = value; }
        }


        /// <summary>
        /// Sets the Expiration property
        /// </summary>
        /// <param name="expiration">The value to set for the Expiration property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Credentials WithExpiration(DateTime expiration)
        {
            this._expiration = expiration;
            return this;
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property SecretAccessKey. 
        /// <para>
        /// The secret access key that can be used to sign requests.
        /// </para>
        /// </summary>
        public string SecretAccessKey
        {
            get { return this._secretAccessKey; }
            set { this._secretAccessKey = value; }
        }


        /// <summary>
        /// Sets the SecretAccessKey property
        /// </summary>
        /// <param name="secretAccessKey">The value to set for the SecretAccessKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Credentials WithSecretAccessKey(string secretAccessKey)
        {
            this._secretAccessKey = secretAccessKey;
            return this;
        }

        // Check to see if SecretAccessKey property is set
        internal bool IsSetSecretAccessKey()
        {
            return this._secretAccessKey != null;
        }


        /// <summary>
        /// Gets and sets the property SessionToken. 
        /// <para>
        /// The token that users must pass to the service API to use the temporary credentials.
        /// </para>
        /// </summary>
        public string SessionToken
        {
            get { return this._sessionToken; }
            set { this._sessionToken = value; }
        }


        /// <summary>
        /// Sets the SessionToken property
        /// </summary>
        /// <param name="sessionToken">The value to set for the SessionToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Credentials WithSessionToken(string sessionToken)
        {
            this._sessionToken = sessionToken;
            return this;
        }

        // Check to see if SessionToken property is set
        internal bool IsSetSessionToken()
        {
            return this._sessionToken != null;
        }

    }
}