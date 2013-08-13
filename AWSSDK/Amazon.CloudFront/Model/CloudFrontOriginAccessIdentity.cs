/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> CloudFront origin access identity. </para>
    /// </summary>
    public class CloudFrontOriginAccessIdentity
    {
        
        private string id;
        private string s3CanonicalUserId;
        private CloudFrontOriginAccessIdentityConfig cloudFrontOriginAccessIdentityConfig;

        /// <summary>
        /// The ID for the origin access identity. For example: E74FTE3AJFJ256A.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontOriginAccessIdentity WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The Amazon S3 canonical user ID for the origin access identity, which you use when giving the origin access identity read permission to an
        /// object in Amazon S3.
        ///  
        /// </summary>
        public string S3CanonicalUserId
        {
            get { return this.s3CanonicalUserId; }
            set { this.s3CanonicalUserId = value; }
        }

        /// <summary>
        /// Sets the S3CanonicalUserId property
        /// </summary>
        /// <param name="s3CanonicalUserId">The value to set for the S3CanonicalUserId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontOriginAccessIdentity WithS3CanonicalUserId(string s3CanonicalUserId)
        {
            this.s3CanonicalUserId = s3CanonicalUserId;
            return this;
        }
            

        // Check to see if S3CanonicalUserId property is set
        internal bool IsSetS3CanonicalUserId()
        {
            return this.s3CanonicalUserId != null;
        }

        /// <summary>
        /// The current configuration information for the identity.
        ///  
        /// </summary>
        public CloudFrontOriginAccessIdentityConfig CloudFrontOriginAccessIdentityConfig
        {
            get { return this.cloudFrontOriginAccessIdentityConfig; }
            set { this.cloudFrontOriginAccessIdentityConfig = value; }
        }

        /// <summary>
        /// Sets the CloudFrontOriginAccessIdentityConfig property
        /// </summary>
        /// <param name="cloudFrontOriginAccessIdentityConfig">The value to set for the CloudFrontOriginAccessIdentityConfig property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontOriginAccessIdentity WithCloudFrontOriginAccessIdentityConfig(CloudFrontOriginAccessIdentityConfig cloudFrontOriginAccessIdentityConfig)
        {
            this.cloudFrontOriginAccessIdentityConfig = cloudFrontOriginAccessIdentityConfig;
            return this;
        }
            

        // Check to see if CloudFrontOriginAccessIdentityConfig property is set
        internal bool IsSetCloudFrontOriginAccessIdentityConfig()
        {
            return this.cloudFrontOriginAccessIdentityConfig != null;
        }
    }
}
