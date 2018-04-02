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
    /// This is the response object from the CreatePublicKey operation.
    /// </summary>
    public partial class CreatePublicKeyResponse : AmazonWebServiceResponse
    {
        private string _eTag;
        private string _location;
        private PublicKey _publicKey;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The current version of the public key. For example: <code>E2QWRUHAPOMQZL</code>.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The fully qualified URI of the new public key resource just created. For example:
        /// <code>https://cloudfront.amazonaws.com/2010-11-01/cloudfront-public-key/EDFDVBD632BHDS5</code>.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// Returned when you add a public key.
        /// </para>
        /// </summary>
        public PublicKey PublicKey
        {
            get { return this._publicKey; }
            set { this._publicKey = value; }
        }

        // Check to see if PublicKey property is set
        internal bool IsSetPublicKey()
        {
            return this._publicKey != null;
        }

    }
}