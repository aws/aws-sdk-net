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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// Container for the parameters to the GetTrustStoreCertificate operation.
    /// Gets the trust store certificate.
    /// </summary>
    public partial class GetTrustStoreCertificateRequest : AmazonWorkSpacesWebRequest
    {
        private string _thumbprint;
        private string _trustStoreArn;

        /// <summary>
        /// Gets and sets the property Thumbprint. 
        /// <para>
        /// The thumbprint of the trust store certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=64, Max=64)]
        public string Thumbprint
        {
            get { return this._thumbprint; }
            set { this._thumbprint = value; }
        }

        // Check to see if Thumbprint property is set
        internal bool IsSetThumbprint()
        {
            return this._thumbprint != null;
        }

        /// <summary>
        /// Gets and sets the property TrustStoreArn. 
        /// <para>
        /// The ARN of the trust store certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TrustStoreArn
        {
            get { return this._trustStoreArn; }
            set { this._trustStoreArn = value; }
        }

        // Check to see if TrustStoreArn property is set
        internal bool IsSetTrustStoreArn()
        {
            return this._trustStoreArn != null;
        }

    }
}