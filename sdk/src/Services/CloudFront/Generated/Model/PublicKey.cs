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
    /// A complex data type of public keys you add to CloudFront to use with features like
    /// field-level encryption.
    /// </summary>
    public partial class PublicKey
    {
        private DateTime? _createdTime;
        private string _id;
        private PublicKeyConfig _publicKeyConfig;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// A time you added a public key to CloudFront.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique ID assigned to a public key you've added to CloudFront.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKeyConfig. 
        /// <para>
        /// A complex data type for a public key you add to CloudFront to use with features like
        /// field-level encryption.
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