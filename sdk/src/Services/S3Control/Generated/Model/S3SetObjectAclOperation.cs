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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Contains the configuration parameters for a PUT Object ACL operation. S3 Batch Operations
    /// passes every object to the underlying <code>PutObjectAcl</code> API operation. For
    /// more information about the parameters for this operation, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectPUTacl.html">PutObjectAcl</a>.
    /// </summary>
    public partial class S3SetObjectAclOperation
    {
        private S3AccessControlPolicy _accessControlPolicy;

        /// <summary>
        /// Gets and sets the property AccessControlPolicy.
        /// </summary>
        public S3AccessControlPolicy AccessControlPolicy
        {
            get { return this._accessControlPolicy; }
            set { this._accessControlPolicy = value; }
        }

        // Check to see if AccessControlPolicy property is set
        internal bool IsSetAccessControlPolicy()
        {
            return this._accessControlPolicy != null;
        }

    }
}