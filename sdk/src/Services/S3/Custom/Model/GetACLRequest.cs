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
    /// Container for the parameters to the GetACL operation.
    /// <para>Returns the access control list (ACL) of an object.</para>
    /// </summary>
    public partial class GetACLRequest : AmazonWebServiceRequest
    {
        /// <summary>
        /// The name of the bucket to be queried or containing the object to be queried.
        /// </summary>
        public string BucketName { get; set; }

        // Check to see if BucketName property is set
        internal bool IsSetBucket()
        {
            return this.BucketName != null;
        }

        /// <summary>
        /// The key of the S3 object to be queried.
        /// </summary>
        public string Key { get; set; }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.Key != null;
        }

        /// <summary>
        /// VersionId used to reference a specific version of the object.
        /// </summary>
        public string VersionId { get; set; }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this.VersionId != null;
        }
    }
}
    
