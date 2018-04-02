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
    /// Summary of the information about a CloudFront origin access identity.
    /// </summary>
    public partial class CloudFrontOriginAccessIdentitySummary
    {
        private string _comment;
        private string _id;
        private string _s3CanonicalUserId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CloudFrontOriginAccessIdentitySummary() { }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The comment for this origin access identity, as originally specified when created.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for the origin access identity. For example: <code>E74FTE3AJFJ256A</code>.
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
        /// Gets and sets the property S3CanonicalUserId. 
        /// <para>
        /// The Amazon S3 canonical user ID for the origin access identity, which you use when
        /// giving the origin access identity read permission to an object in Amazon S3.
        /// </para>
        /// </summary>
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