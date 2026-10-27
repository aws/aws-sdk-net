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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Specifies the details for the file location for the file that's being used in the
    /// workflow. Only applicable if you are using S3 storage.
    /// </summary>
    public partial class S3FileLocation
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// Specifies the S3 bucket that contains the file being used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property Etag. 
        /// <para>
        /// The entity tag is a hash of the object. The ETag reflects changes only to the contents
        /// of an object, not its metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string Etag { get; set; }

        /// <summary>
        /// Checks to see if the Etag property is set.
        /// </summary>
        internal bool IsSetEtag() => this.Etag != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name assigned to the file when it was created in Amazon S3. You use the object
        /// key to retrieve the object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Specifies the file version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
