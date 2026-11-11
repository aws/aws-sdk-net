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
    /// An object that represents a listener's Transport Layer Security (TLS) certificate.
    /// </summary>
    public partial class ListenerTlsCertificate
    {
        /// <summary>
        /// Gets and sets the property Acm. 
        /// <para>
        /// A reference to an object that represents an Certificate Manager certificate.
        /// </para>
        /// </summary>
        public ListenerTlsAcmCertificate Acm { get; set; }

        /// <summary>
        /// Checks to see if the Acm property is set.
        /// </summary>
        internal bool IsSetAcm() => this.Acm != null;

        /// <summary>
        /// Gets and sets the property File. 
        /// <para>
        /// A reference to an object that represents a local file certificate.
        /// </para>
        /// </summary>
        public ListenerTlsFileCertificate File { get; set; }

        /// <summary>
        /// Checks to see if the File property is set.
        /// </summary>
        internal bool IsSetFile() => this.File != null;

        /// <summary>
        /// Gets and sets the property Sds. 
        /// <para>
        /// A reference to an object that represents a listener's Secret Discovery Service certificate.
        /// </para>
        /// </summary>
        public ListenerTlsSdsCertificate Sds { get; set; }

        /// <summary>
        /// Checks to see if the Sds property is set.
        /// </summary>
        internal bool IsSetSds() => this.Sds != null;
    }
}
