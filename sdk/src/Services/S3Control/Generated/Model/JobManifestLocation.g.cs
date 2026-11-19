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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Contains the information required to locate a manifest object. Manifests can't be
    /// imported from directory buckets. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-overview.html">Directory
    /// buckets</a>.
    /// </summary>
    public partial class JobManifestLocation
    {
        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The ETag for the specified manifest object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property ObjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for a manifest object.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you're using XML requests, you must replace special characters (such as carriage
        /// returns) in object keys with their equivalent XML entity codes. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-xml-related-constraints">
        /// XML-related object key constraints</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2000)]
        public string ObjectArn { get; set; }

        /// <summary>
        /// Checks to see if the ObjectArn property is set.
        /// </summary>
        internal bool IsSetObjectArn() => this.ObjectArn != null;

        /// <summary>
        /// Gets and sets the property ObjectVersionId. 
        /// <para>
        /// The optional version ID to identify a specific version of the manifest object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string ObjectVersionId { get; set; }

        /// <summary>
        /// Checks to see if the ObjectVersionId property is set.
        /// </summary>
        internal bool IsSetObjectVersionId() => this.ObjectVersionId != null;
    }
}
