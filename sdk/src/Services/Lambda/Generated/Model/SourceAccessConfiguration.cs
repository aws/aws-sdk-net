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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// (MQ) The Secrets Manager secret that stores your broker credentials. To store your
    /// secret, use the following format: <code> { "username": "your username", "password":
    /// "your password" }</code>
    /// </summary>
    public partial class SourceAccessConfiguration
    {
        private SourceAccessType _type;
        private string _uri;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// To reference the secret, use the following format: <code>[ { "Type": "BASIC_AUTH",
        /// "URI": "secretARN" } ]</code> 
        /// </para>
        ///  
        /// <para>
        /// The value of <code>Type</code> is always <code>BASIC_AUTH</code>. To encrypt the secret,
        /// you can use customer or service managed keys. When using a customer managed KMS key,
        /// the Lambda execution role requires <code>kms:Decrypt</code> permissions.
        /// </para>
        /// </summary>
        public SourceAccessType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property URI. 
        /// <para>
        /// To reference the secret, use the following format: <code>[ { "Type": "BASIC_AUTH",
        /// "URI": "secretARN" } ]</code> 
        /// </para>
        ///  
        /// <para>
        /// The value of <code>Type</code> is always <code>BASIC_AUTH</code>. To encrypt the secret,
        /// you can use customer or service managed keys. When using a customer managed KMS key,
        /// the Lambda execution role requires <code>kms:Decrypt</code> permissions.
        /// </para>
        /// </summary>
        public string URI
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if URI property is set
        internal bool IsSetURI()
        {
            return this._uri != null;
        }

    }
}