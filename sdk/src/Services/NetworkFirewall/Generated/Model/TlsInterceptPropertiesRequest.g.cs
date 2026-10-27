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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// This data type is used specifically for the <a>CreateProxy</a> and <a>UpdateProxy</a>
    /// APIs.
    /// 
    ///  
    /// <para>
    /// TLS decryption on traffic to filter on attributes in the HTTP header. 
    /// </para>
    /// </summary>
    public partial class TlsInterceptPropertiesRequest
    {
        /// <summary>
        /// Gets and sets the property PcaArn. 
        /// <para>
        /// Private Certificate Authority (PCA) used to issue private TLS certificates so that
        /// the proxy can present PCA-signed certificates which applications trust through the
        /// same root, establishing a secure and consistent trust model for encrypted communication.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PcaArn { get; set; }

        /// <summary>
        /// Checks to see if the PcaArn property is set.
        /// </summary>
        internal bool IsSetPcaArn() => this.PcaArn != null;

        /// <summary>
        /// Gets and sets the property TlsInterceptMode. 
        /// <para>
        /// Specifies whether to enable or disable TLS Intercept Mode. 
        /// </para>
        /// </summary>
        public TlsInterceptMode TlsInterceptMode { get; set; }

        /// <summary>
        /// Checks to see if the TlsInterceptMode property is set.
        /// </summary>
        internal bool IsSetTlsInterceptMode() => this.TlsInterceptMode != null;
    }
}
