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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// This is the response object from the GetWhatsAppBusinessPublicKey operation.
    /// </summary>
    public partial class GetWhatsAppBusinessPublicKeyResponse : AmazonWebServiceResponse
    {
        private string _businessPublicKey;
        private string _businessPublicKeySignatureStatus;

        /// <summary>
        /// Gets and sets the property BusinessPublicKey. 
        /// <para>
        /// The stored RSA business public key (PEM), if present.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
        public string BusinessPublicKey
        {
            get { return this._businessPublicKey; }
            set { this._businessPublicKey = value; }
        }

        // Check to see if BusinessPublicKey property is set
        internal bool IsSetBusinessPublicKey()
        {
            return this._businessPublicKey != null;
        }

        /// <summary>
        /// Gets and sets the property BusinessPublicKeySignatureStatus. 
        /// <para>
        /// Meta's signing status: &quot;VALID&quot; | &quot;MISMATCH&quot;.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string BusinessPublicKeySignatureStatus
        {
            get { return this._businessPublicKeySignatureStatus; }
            set { this._businessPublicKeySignatureStatus = value; }
        }

        // Check to see if BusinessPublicKeySignatureStatus property is set
        internal bool IsSetBusinessPublicKeySignatureStatus()
        {
            return this._businessPublicKeySignatureStatus != null;
        }

    }
}