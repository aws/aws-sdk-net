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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Configures mutual TLS authentication between CloudFront and your origin server.
    /// </summary>
    public partial class OriginMtlsConfig
    {
        private string _clientCertificateArn;

        /// <summary>
        /// Gets and sets the property ClientCertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the client certificate stored in Amazon Web Services
        /// Certificate Manager (ACM) that CloudFront uses to authenticate with your origin using
        /// Mutual TLS.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientCertificateArn
        {
            get { return this._clientCertificateArn; }
            set { this._clientCertificateArn = value; }
        }

        // Check to see if ClientCertificateArn property is set
        internal bool IsSetClientCertificateArn()
        {
            return this._clientCertificateArn != null;
        }

    }
}