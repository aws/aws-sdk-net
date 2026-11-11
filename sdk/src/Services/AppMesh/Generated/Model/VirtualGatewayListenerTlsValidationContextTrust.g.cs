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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// (TLS) validation context trust.
    /// </summary>
    public partial class VirtualGatewayListenerTlsValidationContextTrust
    {
        /// <summary>
        /// Gets and sets the property File. 
        /// <para>
        /// An object that represents a Transport Layer Security (TLS) validation context trust
        /// for a local file.
        /// </para>
        /// </summary>
        public VirtualGatewayTlsValidationContextFileTrust File { get; set; }

        /// <summary>
        /// Checks to see if the File property is set.
        /// </summary>
        internal bool IsSetFile() => this.File != null;

        /// <summary>
        /// Gets and sets the property Sds. 
        /// <para>
        /// A reference to an object that represents a virtual gateway's listener's Transport
        /// Layer Security (TLS) Secret Discovery Service validation context trust.
        /// </para>
        /// </summary>
        public VirtualGatewayTlsValidationContextSdsTrust Sds { get; set; }

        /// <summary>
        /// Checks to see if the Sds property is set.
        /// </summary>
        internal bool IsSetSds() => this.Sds != null;
    }
}
