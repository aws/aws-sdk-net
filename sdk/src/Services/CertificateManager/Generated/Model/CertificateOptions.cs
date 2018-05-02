/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Structure that contains options for your certificate. Currently, you can use this
    /// only to specify whether to opt in to or out of certificate transparency logging. Some
    /// browsers require that public certificates issued for your domain be recorded in a
    /// log. Certificates that are not logged typically generate a browser error. Transparency
    /// makes it possible for you to detect SSL/TLS certificates that have been mistakenly
    /// or maliciously issued for your domain. For general information, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-concepts.html#concept-transparency">Certificate
    /// Transparency Logging</a>.
    /// </summary>
    public partial class CertificateOptions
    {
        private CertificateTransparencyLoggingPreference _certificateTransparencyLoggingPreference;

        /// <summary>
        /// Gets and sets the property CertificateTransparencyLoggingPreference. 
        /// <para>
        /// You can opt out of certificate transparency logging by specifying the <code>DISABLED</code>
        /// option. Opt in by specifying <code>ENABLED</code>. 
        /// </para>
        /// </summary>
        public CertificateTransparencyLoggingPreference CertificateTransparencyLoggingPreference
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