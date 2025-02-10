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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The server certificate configuration.
    /// </summary>
    public partial class ServerCertificateConfig
    {
        private bool? _enableocspCheck;
        private string _ocspAuthorizedResponderArn;
        private string _ocspLambdaArn;

        /// <summary>
        /// Gets and sets the property EnableOCSPCheck. 
        /// <para>
        /// A Boolean value that indicates whether Online Certificate Status Protocol (OCSP) server
        /// certificate check is enabled or not.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-custom-endpoints-cert-config.html">
        /// Server certificate configuration for OCSP stapling</a> from Amazon Web Services IoT
        /// Core Developer Guide.
        /// </para>
        /// </summary>
        public bool? EnableOCSPCheck
        {
            get { return this._enableocspCheck; }
            set { this._enableocspCheck = value; }
        }

        // Check to see if EnableOCSPCheck property is set
        internal bool IsSetEnableOCSPCheck()
        {
            return this._enableocspCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OcspAuthorizedResponderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for an X.509 certificate stored in Amazon Web Services
        /// Certificate Manager (ACM). If provided, Amazon Web Services IoT Core will use this
        /// certificate to validate the signature of the received OCSP response. The OCSP responder
        /// must sign responses using either this authorized responder certificate or the issuing
        /// certificate, depending on whether the ARN is provided or not. The certificate must
        /// be in the same Amazon Web Services account and region as the domain configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string OcspAuthorizedResponderArn
        {
            get { return this._ocspAuthorizedResponderArn; }
            set { this._ocspAuthorizedResponderArn = value; }
        }

        // Check to see if OcspAuthorizedResponderArn property is set
        internal bool IsSetOcspAuthorizedResponderArn()
        {
            return this._ocspAuthorizedResponderArn != null;
        }

        /// <summary>
        /// Gets and sets the property OcspLambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for a Lambda function that acts as a Request for Comments
        /// (RFC) 6960-compliant Online Certificate Status Protocol (OCSP) responder, supporting
        /// basic OCSP responses. The Lambda function accepts a base64-encoding of the OCSP request
        /// in the Distinguished Encoding Rules (DER) format. The Lambda function's response is
        /// also a base64-encoded OCSP response in the DER format. The response size must not
        /// exceed 4 kilobytes (KiB). The Lambda function must be in the same Amazon Web Services
        /// account and region as the domain configuration. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-custom-endpoints-cert-config.html#iot-custom-endpoints-cert-config-ocsp-private-endpoint.html">Configuring
        /// server certificate OCSP for private endpoints in Amazon Web Services IoT Core</a>
        /// from the Amazon Web Services IoT Core developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Max=140)]
        public string OcspLambdaArn
        {
            get { return this._ocspLambdaArn; }
            set { this._ocspLambdaArn = value; }
        }

        // Check to see if OcspLambdaArn property is set
        internal bool IsSetOcspLambdaArn()
        {
            return this._ocspLambdaArn != null;
        }

    }
}