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
    /// Container for the parameters to the UpdateCertificateOptions operation.
    /// Updates a certificate. Currently, you can use this function to specify whether to
    /// opt in to or out of recording your certificate in a certificate transparency log.
    /// For more information, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-bestpractices.html#best-practices-transparency">
    /// Opting Out of Certificate Transparency Logging</a>.
    /// </summary>
    public partial class UpdateCertificateOptionsRequest : AmazonCertificateManagerRequest
    {
        private string _certificateArn;
        private CertificateOptions _options;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// ARN of the requested certificate to update. This must be of the form:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm:us-east-1:<i>account</i>:certificate/<i>12345678-1234-1234-1234-123456789012</i>
        /// </code> 
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Use to update the options for your certificate. Currently, you can specify whether
        /// to add your certificate to a transparency log. Certificate transparency makes it possible
        /// to detect SSL/TLS certificates that have been mistakenly or maliciously issued. Certificates
        /// that have not been logged typically produce an error message in a browser. 
        /// </para>
        /// </summary>
        public CertificateOptions Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

    }
}