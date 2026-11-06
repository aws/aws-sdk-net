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
    /// The container for the service that will create the S3 manifest.
    /// </summary>
    public partial class S3JobManifestGenerator
    {
        /// <summary>
        /// Gets and sets the property EnableManifestOutput. 
        /// <para>
        /// Determines whether or not to write the job's generated manifest to a bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? EnableManifestOutput { get; set; }

        /// <summary>
        /// Checks to see if the EnableManifestOutput property is set.
        /// </summary>
        internal bool IsSetEnableManifestOutput() => this.EnableManifestOutput.HasValue;

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The Amazon Web Services account ID that owns the source bucket specified in <c>SourceBucket</c>.
        /// If provided, the manifest source bucket owner's Amazon Web Services account ID must
        /// match this value, else the job fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string ExpectedBucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedBucketOwner property is set.
        /// </summary>
        internal bool IsSetExpectedBucketOwner() => this.ExpectedBucketOwner != null;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Specifies rules the S3JobManifestGenerator should use to decide whether an object
        /// in the source bucket should or should not be included in the generated job manifest.
        /// </para>
        /// </summary>
        public JobManifestGeneratorFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property ManifestOutputLocation. 
        /// <para>
        /// Specifies the location the generated manifest will be written to. Manifests can't
        /// be written to directory buckets. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-overview.html">Directory
        /// buckets</a>.
        /// </para>
        /// </summary>
        public S3ManifestOutputLocation ManifestOutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the ManifestOutputLocation property is set.
        /// </summary>
        internal bool IsSetManifestOutputLocation() => this.ManifestOutputLocation != null;

        /// <summary>
        /// Gets and sets the property SourceBucket. 
        /// <para>
        /// The ARN of the source bucket used by the ManifestGenerator.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - Directory buckets aren't supported as the source buckets
        /// used by <c>S3JobManifestGenerator</c> to generate the job manifest.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string SourceBucket { get; set; }

        /// <summary>
        /// Checks to see if the SourceBucket property is set.
        /// </summary>
        internal bool IsSetSourceBucket() => this.SourceBucket != null;
    }
}
