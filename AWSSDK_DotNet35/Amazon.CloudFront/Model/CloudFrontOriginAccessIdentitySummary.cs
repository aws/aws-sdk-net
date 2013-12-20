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
    /// <para> Summary of the information about a CloudFront origin access identity. </para>
    /// </summary>
    public class CloudFrontOriginAccessIdentitySummary
    {
        
        private string id;
        private string s3CanonicalUserId;
        private string comment;


        /// <summary>
        /// The ID for the origin access identity. For example: E74FTE3AJFJ256A.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
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

        // Check to see if S3CanonicalUserId property is set
        internal bool IsSetS3CanonicalUserId()
        {
            return this.s3CanonicalUserId != null;
        }

        /// <summary>
        /// The comment for this origin access identity, as originally specified when created.
        ///  
        /// </summary>
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this.comment != null;
        }
    }
}
