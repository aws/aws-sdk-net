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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// KMS uses the authentication credential to sign requests that it sends to the external
    /// key store proxy (XKS proxy) on your behalf. You establish these credentials on your
    /// external key store proxy and report them to KMS.
    /// 
    ///  
    /// <para>
    /// The <code>XksProxyAuthenticationCredential</code> includes two required elements.
    /// </para>
    /// </summary>
    public partial class XksProxyAuthenticationCredentialType
    {
        private string _accessKeyId;
        private string _rawSecretAccessKey;

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// A unique identifier for the raw secret access key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=20, Max=30)]
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
        /// Gets and sets the property RawSecretAccessKey. 
        /// <para>
        /// A secret string of 43-64 characters. Valid characters are a-z, A-Z, 0-9, /, +, and
        /// =.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=43, Max=64)]
        public string RawSecretAccessKey
        {
            get { return this._rawSecretAccessKey; }
            set { this._rawSecretAccessKey = value; }
        }

        // Check to see if RawSecretAccessKey property is set
        internal bool IsSetRawSecretAccessKey()
        {
            return this._rawSecretAccessKey != null;
        }

    }
}