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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains information about the client certificate authentication settings for the
    /// <code>RegisterCertificate</code> and <code>DescribeCertificate</code> operations.
    /// </summary>
    public partial class ClientCertAuthSettings
    {
        private string _ocspUrl;

        /// <summary>
        /// Gets and sets the property OCSPUrl. 
        /// <para>
        /// Specifies the URL of the default OCSP server used to check for revocation status.
        /// A secondary value to any OCSP address found in the AIA extension of the user certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string OCSPUrl
        {
            get { return this._ocspUrl; }
            set { this._ocspUrl = value; }
        }

        // Check to see if OCSPUrl property is set
        internal bool IsSetOCSPUrl()
        {
            return this._ocspUrl != null;
        }

    }
}