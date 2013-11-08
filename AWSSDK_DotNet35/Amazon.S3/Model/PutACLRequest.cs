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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutAcl operation.
    /// <para>uses the acl subresource to set the access control list (ACL) permissions for an object that already exists in a bucket</para>
    /// </summary>
    public partial class PutACLRequest : AmazonWebServiceRequest
    {
        private S3CannedACL cannedACL;
        private S3AccessControlList accessControlPolicy;
        private string bucket;
        private string key;
        private string versionId;

        /// <summary>
        /// The canned ACL to apply to the bucket.
        ///  
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this.cannedACL; }
            set { this.cannedACL = value; }
        }

        // Check to see if CannedACL property is set
        internal bool IsSetCannedACL()
        {
            return this.cannedACL != null;
        }


        /// <summary>
        /// Custom ACLs to be applied to the bucket or object.
        /// </summary>
        public S3AccessControlList AccessControlList
        {
            get { return this.accessControlPolicy; }
            set { this.accessControlPolicy = value; }
        }

        // Check to see if AccessControlPolicy property is set
        internal bool IsSetAccessControlPolicy()
        {
            return this.accessControlPolicy != null;
        }

        /// <summary>
        /// The name of the bucket.
        /// If an object key is not specified, the ACLs are applied to the bucket.
        /// </summary>
        public string BucketName
        {
            get { return this.bucket; }
            set { this.bucket = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucket != null;
        }

        /// <summary>
        /// The key of an S3 object.
        /// If not specified, the ACLs are applied to the bucket.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// If set and an object key has been specified, the ACLs are applied
        /// to the specific version of the object.
        /// This property is ignored if the ACL is to be set on a Bucket.
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Checks if VersionId property is set.
        /// </summary>
        /// <returns>true if VersionId property is set.</returns>
        internal bool IsSetVersionId()
        {
            return this.versionId != null;
        }
    }
}
    
