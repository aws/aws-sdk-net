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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePublicKey operation.
    /// Uploads a public key to CloudFront that you can use with <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">signed
    /// URLs and signed cookies</a>, or with <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/field-level-encryption.html">field-level
    /// encryption</a>.
    /// </summary>
    public partial class CreatePublicKeyRequest : AmazonCloudFrontRequest
    {
        private PublicKeyConfig _publicKeyConfig;

        /// <summary>
        /// Gets and sets the property PublicKeyConfig. 
        /// <para>
        /// A CloudFront public key configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PublicKeyConfig PublicKeyConfig
        {
            get { return this._publicKeyConfig; }
            set { this._publicKeyConfig = value; }
        }

        // Check to see if PublicKeyConfig property is set
        internal bool IsSetPublicKeyConfig()
        {
            return this._publicKeyConfig != null;
        }

    }
}