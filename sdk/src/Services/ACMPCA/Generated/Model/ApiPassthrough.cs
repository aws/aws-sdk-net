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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Contains X.509 certificate information to be placed in an issued certificate. An <code>APIPassthrough</code>
    /// or <code>APICSRPassthrough</code> template variant must be selected, or else this
    /// parameter is ignored. 
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
        private Extensions _extensions;
        private ASN1Subject _subject;

        /// <summary>
        /// Gets and sets the property Extensions. 
        /// <para>
        /// Specifies X.509 extension information for a certificate.
        /// </para>
        /// </summary>
        public Extensions Extensions
        {
            get { return this._extensions; }
            set { this._extensions = value; }
        }

        // Check to see if Extensions property is set
        internal bool IsSetExtensions()
        {
            return this._extensions != null;
        }

        /// <summary>
        /// Gets and sets the property Subject.
        /// </summary>
        public ASN1Subject Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

    }
}