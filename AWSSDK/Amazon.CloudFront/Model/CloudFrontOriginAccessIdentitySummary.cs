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
    /// Summary of the information about a CloudFront origin access identity.
    /// </summary>
    public partial class CloudFrontOriginAccessIdentitySummary
    {
        private string _comment;
        private string _id;
        private string _s3CanonicalUserId;


        /// <summary>
        /// Gets and sets the property Comment. The comment for this origin access identity, as
        /// originally specified when created.
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }


        /// <summary>
        /// Sets the Comment property
        /// </summary>
        /// <param name="comment">The value to set for the Comment property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontOriginAccessIdentitySummary WithComment(string comment)
        {
            this._comment = comment;
            return this;
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }


        /// <summary>
        /// Gets and sets the property Id. The ID for the origin access identity. For example:
        /// E74FTE3AJFJ256A.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }


        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontOriginAccessIdentitySummary WithId(string id)
        {
            this._id = id;
            return this;
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }


        /// <summary>
        /// Gets and sets the property S3CanonicalUserId. The Amazon S3 canonical user ID for
        /// the origin access identity, which you use when     giving the origin access identity
        /// read permission to an object in Amazon S3.
        /// </summary>
        public string S3CanonicalUserId
        {
            get { return this._s3CanonicalUserId; }
            set { this._s3CanonicalUserId = value; }
        }


        /// <summary>
        /// Sets the S3CanonicalUserId property
        /// </summary>
        /// <param name="s3CanonicalUserId">The value to set for the S3CanonicalUserId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontOriginAccessIdentitySummary WithS3CanonicalUserId(string s3CanonicalUserId)
        {
            this._s3CanonicalUserId = s3CanonicalUserId;
            return this;
        }

        // Check to see if S3CanonicalUserId property is set
        internal bool IsSetS3CanonicalUserId()
        {
            return this._s3CanonicalUserId != null;
        }

    }
}