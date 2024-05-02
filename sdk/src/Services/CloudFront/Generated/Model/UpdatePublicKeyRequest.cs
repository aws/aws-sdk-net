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
    /// Container for the parameters to the UpdatePublicKey operation.
    /// Update public key information. Note that the only value you can change is the comment.
    /// </summary>
    public partial class UpdatePublicKeyRequest : AmazonCloudFrontRequest
    {
        private string _id;
        private string _ifMatch;
        private PublicKeyConfig _publicKeyConfig;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the public key that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The value of the <c>ETag</c> header that you received when retrieving the public key
        /// to update. For example: <c>E2QWRUHAPOMQZL</c>.
        /// </para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKeyConfig. 
        /// <para>
        /// A public key configuration.
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