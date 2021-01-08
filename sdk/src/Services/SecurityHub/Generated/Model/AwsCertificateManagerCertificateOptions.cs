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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains other options for the certificate.
    /// </summary>
    public partial class AwsCertificateManagerCertificateOptions
    {
        private string _certificateTransparencyLoggingPreference;

        /// <summary>
        /// Gets and sets the property CertificateTransparencyLoggingPreference. 
        /// <para>
        /// Whether to add the certificate to a transparency log.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>DISABLED</code> | <code>ENABLED</code> 
        /// </para>
        /// </summary>
        public string CertificateTransparencyLoggingPreference
        {
            get { return this._certificateTransparencyLoggingPreference; }
            set { this._certificateTransparencyLoggingPreference = value; }
        }

        // Check to see if CertificateTransparencyLoggingPreference property is set
        internal bool IsSetCertificateTransparencyLoggingPreference()
        {
            return this._certificateTransparencyLoggingPreference != null;
        }

    }
}