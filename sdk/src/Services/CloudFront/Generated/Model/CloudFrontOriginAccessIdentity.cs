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
    /// CloudFront origin access identity.
    /// </summary>
    public partial class CloudFrontOriginAccessIdentity
    {
        private CloudFrontOriginAccessIdentityConfig _cloudFrontOriginAccessIdentityConfig;
        private string _id;
        private string _s3CanonicalUserId;

        /// <summary>
        /// Gets and sets the property CloudFrontOriginAccessIdentityConfig. 
        /// <para>
        /// The current configuration information for the identity.
        /// </para>
        /// </summary>
        public CloudFrontOriginAccessIdentityConfig CloudFrontOriginAccessIdentityConfig
        {
            get { return this._cloudFrontOriginAccessIdentityConfig; }
            set { this._cloudFrontOriginAccessIdentityConfig = value; }
        }

        // Check to see if CloudFrontOriginAccessIdentityConfig property is set
        internal bool IsSetCloudFrontOriginAccessIdentityConfig()
        {
            return this._cloudFrontOriginAccessIdentityConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for the origin access identity, for example, <code>E74FTE3AJFJ256A</code>.
        /// 
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
        /// Gets and sets the property S3CanonicalUserId. 
        /// <para>
        /// The Amazon S3 canonical user ID for the origin access identity, used when giving the
        /// origin access identity read permission to an object in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string S3CanonicalUserId
        {
            get { return this._s3CanonicalUserId; }
            set { this._s3CanonicalUserId = value; }
        }

        // Check to see if S3CanonicalUserId property is set
        internal bool IsSetS3CanonicalUserId()
        {
            return this._s3CanonicalUserId != null;
        }

    }
}