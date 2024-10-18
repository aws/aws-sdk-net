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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Indicates that an Amazon S3 canned ACL should be set to control ownership of stored
    /// query results, including data files inserted by Athena as the result of statements
    /// like CTAS or INSERT INTO. When Athena stores query results in Amazon S3, the canned
    /// ACL is set with the <c>x-amz-acl</c> request header. For more information about S3
    /// Object Ownership, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html#object-ownership-overview">Object
    /// Ownership settings</a> in the <i>Amazon S3 User Guide</i>.
    /// </summary>
    public partial class AclConfiguration
    {
        private S3AclOption _s3AclOption;

        /// <summary>
        /// Gets and sets the property S3AclOption. 
        /// <para>
        /// The Amazon S3 canned ACL that Athena should specify when storing query results, including
        /// data files inserted by Athena as the result of statements like CTAS or INSERT INTO.
        /// Currently the only supported canned ACL is <c>BUCKET_OWNER_FULL_CONTROL</c>. If a
        /// query runs in a workgroup and the workgroup overrides client-side settings, then the
        /// Amazon S3 canned ACL specified in the workgroup's settings is used for all queries
        /// that run in the workgroup. For more information about Amazon S3 canned ACLs, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/acl-overview.html#canned-acl">Canned
        /// ACL</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3AclOption S3AclOption
        {
            get { return this._s3AclOption; }
            set { this._s3AclOption = value; }
        }

        // Check to see if S3AclOption property is set
        internal bool IsSetS3AclOption()
        {
            return this._s3AclOption != null;
        }

    }
}