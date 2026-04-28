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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Contains metadata about a certificate. Currently supports ACM certificate metadata.
    /// </summary>
    public partial class CertificateMetadata
    {
        private AcmCertificateMetadata _acmCertificateMetadata;

        /// <summary>
        /// Gets and sets the property AcmCertificateMetadata. 
        /// <para>
        /// Metadata for an ACM certificate.
        /// </para>
        /// </summary>
        public AcmCertificateMetadata AcmCertificateMetadata
        {
            get { return this._acmCertificateMetadata; }
            set { this._acmCertificateMetadata = value; }
        }

        // Check to see if AcmCertificateMetadata property is set
        internal bool IsSetAcmCertificateMetadata()
        {
            return this._acmCertificateMetadata != null;
        }

    }
}