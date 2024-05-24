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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
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
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents a virtual gateway's listener's Transport Layer Security
    /// (TLS) Secret Discovery Service validation context trust. The proxy must be configured
    /// with a local SDS provider via a Unix Domain Socket. See App Mesh <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/tls.html">TLS
    /// documentation</a> for more info.
    /// </summary>
    public partial class VirtualGatewayTlsValidationContextSdsTrust
    {
        private string _secretName;

        /// <summary>
        /// Gets and sets the property SecretName. 
        /// <para>
        /// A reference to an object that represents the name of the secret for a virtual gateway's
        /// Transport Layer Security (TLS) Secret Discovery Service validation context trust.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecretName
        {
            get { return this._secretName; }
            set { this._secretName = value; }
        }

        // Check to see if SecretName property is set
        internal bool IsSetSecretName()
        {
            return this._secretName != null;
        }

    }
}