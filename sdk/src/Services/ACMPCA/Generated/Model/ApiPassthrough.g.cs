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

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Contains X.509 certificate information to be placed in an issued certificate. An <c>APIPassthrough</c>
    /// or <c>APICSRPassthrough</c> template variant must be selected, or else this parameter
    /// is ignored. 
    /// 
    ///  
    /// <para>
    /// If conflicting or duplicate certificate information is supplied from other sources,
    /// Amazon Web Services Private CA applies <a href="https://docs.aws.amazon.com/privateca/latest/userguide/UsingTemplates.html#template-order-of-operations">order
    /// of operation rules</a> to determine what information is used.
    /// </para>
    /// </summary>
    public partial class ApiPassthrough
    {
        /// <summary>
        /// Gets and sets the property Extensions. 
        /// <para>
        /// Specifies X.509 extension information for a certificate.
        /// </para>
        /// </summary>
        public Extensions Extensions { get; set; }

        /// <summary>
        /// Checks to see if the Extensions property is set.
        /// </summary>
        internal bool IsSetExtensions() => this.Extensions != null;

        /// <summary>
        /// Gets and sets the property Subject.
        /// </summary>
        public ASN1Subject Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;
    }
}
