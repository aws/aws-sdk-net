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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePublicKey operation.
    /// Add a new public key to CloudFront to use, for example, for field-level encryption.
    /// You can add a maximum of 10 public keys with one AWS account.
    /// </summary>
    public partial class CreatePublicKeyRequest : AmazonCloudFrontRequest
    {
        private PublicKeyConfig _publicKeyConfig;

        /// <summary>
        /// Gets and sets the property PublicKeyConfig. 
        /// <para>
        /// The request to add a public key to CloudFront.
        /// </para>
        /// </summary>
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