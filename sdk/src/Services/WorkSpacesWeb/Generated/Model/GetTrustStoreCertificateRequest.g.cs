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

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// Container for the parameters to the GetTrustStoreCertificate operation. Gets the trust
    /// store certificate.
    /// </summary>
    public partial class GetTrustStoreCertificateRequest : AmazonWorkSpacesWebRequest
    {
        /// <summary>
        /// Gets and sets the property Thumbprint. 
        /// <para>
        /// The thumbprint of the trust store certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 64, Max = 64)]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Checks to see if the Thumbprint property is set.
        /// </summary>
        internal bool IsSetThumbprint() => this.Thumbprint != null;

        /// <summary>
        /// Gets and sets the property TrustStoreArn. 
        /// <para>
        /// The ARN of the trust store certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string TrustStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the TrustStoreArn property is set.
        /// </summary>
        internal bool IsSetTrustStoreArn() => this.TrustStoreArn != null;
    }
}
