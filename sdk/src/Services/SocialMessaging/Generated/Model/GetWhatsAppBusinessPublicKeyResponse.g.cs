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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// This is the response object from the GetWhatsAppBusinessPublicKey operation.
    /// </summary>
    public partial class GetWhatsAppBusinessPublicKeyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BusinessPublicKey. 
        /// <para>
        /// The stored PEM-encoded 2048-bit RSA public key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string BusinessPublicKey { get; set; }

        /// <summary>
        /// Checks to see if the BusinessPublicKey property is set.
        /// </summary>
        internal bool IsSetBusinessPublicKey() => this.BusinessPublicKey != null;

        /// <summary>
        /// Gets and sets the property BusinessPublicKeySignatureStatus. 
        /// <para>
        /// The signature status of the stored business public key. Valid values are VALID and
        /// MISMATCH.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string BusinessPublicKeySignatureStatus { get; set; }

        /// <summary>
        /// Checks to see if the BusinessPublicKeySignatureStatus property is set.
        /// </summary>
        internal bool IsSetBusinessPublicKeySignatureStatus() => this.BusinessPublicKeySignatureStatus != null;
    }
}
