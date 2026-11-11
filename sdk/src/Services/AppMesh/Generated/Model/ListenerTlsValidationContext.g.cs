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
    /// An object that represents a listener's Transport Layer Security (TLS) validation context.
    /// </summary>
    public partial class ListenerTlsValidationContext
    {
        /// <summary>
        /// Gets and sets the property SubjectAlternativeNames. 
        /// <para>
        /// A reference to an object that represents the SANs for a listener's Transport Layer
        /// Security (TLS) validation context.
        /// </para>
        /// </summary>
        public SubjectAlternativeNames SubjectAlternativeNames { get; set; }

        /// <summary>
        /// Checks to see if the SubjectAlternativeNames property is set.
        /// </summary>
        internal bool IsSetSubjectAlternativeNames() => this.SubjectAlternativeNames != null;

        /// <summary>
        /// Gets and sets the property Trust. 
        /// <para>
        /// A reference to where to retrieve the trust chain when validating a peer’s Transport
        /// Layer Security (TLS) certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ListenerTlsValidationContextTrust Trust { get; set; }

        /// <summary>
        /// Checks to see if the Trust property is set.
        /// </summary>
        internal bool IsSetTrust() => this.Trust != null;
    }
}
