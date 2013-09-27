/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// <para>AWS credentials for API authentication.</para>
    /// </summary>
    public class Credentials
    {
        
        private string accessKeyId;
        private string secretAccessKey;
        private string sessionToken;
        private DateTime? expiration;

        /// <summary>
        /// The access key ID that identifies the temporary security credentials.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>16 - 32</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AccessKeyId
        {
            get { return this.accessKeyId; }
            set { this.accessKeyId = value; }
        }

        /// <summary>
        /// Sets the AccessKeyId property
        /// </summary>
        /// <param name="accessKeyId">The value to set for the AccessKeyId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Credentials WithAccessKeyId(string accessKeyId)
        {
            this.accessKeyId = accessKeyId;
            return this;
        }
            

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this.accessKeyId != null;
        }

        /// <summary>
        /// The secret access key that can be used to sign requests.
        ///  
        /// </summary>
        public string SecretAccessKey
        {
            get { return this.secretAccessKey; }
            set { this.secretAccessKey = value; }
        }

        /// <summary>
        /// Sets the SecretAccessKey property
        /// </summary>
        /// <param name="secretAccessKey">The value to set for the SecretAccessKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Credentials WithSecretAccessKey(string secretAccessKey)
        {
            this.secretAccessKey = secretAccessKey;
            return this;
        }
            

        // Check to see if SecretAccessKey property is set
        internal bool IsSetSecretAccessKey()
        {
            return this.secretAccessKey != null;
        }

        /// <summary>
        /// The token that users must pass to the service API to use the temporary credentials.
        ///  
        /// </summary>
        public string SessionToken
        {
            get { return this.sessionToken; }
            set { this.sessionToken = value; }
        }

        /// <summary>
        /// Sets the SessionToken property
        /// </summary>
        /// <param name="sessionToken">The value to set for the SessionToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Credentials WithSessionToken(string sessionToken)
        {
            this.sessionToken = sessionToken;
            return this;
        }
            

        // Check to see if SessionToken property is set
        internal bool IsSetSessionToken()
        {
            return this.sessionToken != null;
        }

        /// <summary>
        /// The date on which the current credentials expire.
        ///  
        /// </summary>
        public DateTime Expiration
        {
            get { return this.expiration ?? default(DateTime); }
            set { this.expiration = value; }
        }

        /// <summary>
        /// Sets the Expiration property
        /// </summary>
        /// <param name="expiration">The value to set for the Expiration property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Credentials WithExpiration(DateTime expiration)
        {
            this.expiration = expiration;
            return this;
        }
            

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this.expiration.HasValue;
        }
    }
}
