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
    /// Location details for where the generated manifest should be written.
    /// </summary>
    public partial class S3ManifestOutputLocation
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The bucket ARN the generated manifest should be written to.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - Directory buckets aren't supported as the buckets to store
        /// the generated manifest.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property ExpectedManifestBucketOwner. 
        /// <para>
        /// The Account ID that owns the bucket the generated manifest is written to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string ExpectedManifestBucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedManifestBucketOwner property is set.
        /// </summary>
        internal bool IsSetExpectedManifestBucketOwner() => this.ExpectedManifestBucketOwner != null;

        /// <summary>
        /// Gets and sets the property ManifestEncryption. 
        /// <para>
        /// Specifies what encryption should be used when the generated manifest objects are written.
        /// </para>
        /// </summary>
        public GeneratedManifestEncryption ManifestEncryption { get; set; }

        /// <summary>
        /// Checks to see if the ManifestEncryption property is set.
        /// </summary>
        internal bool IsSetManifestEncryption() => this.ManifestEncryption != null;

        /// <summary>
        /// Gets and sets the property ManifestFormat. 
        /// <para>
        /// The format of the generated manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GeneratedManifestFormat ManifestFormat { get; set; }

        /// <summary>
        /// Checks to see if the ManifestFormat property is set.
        /// </summary>
        internal bool IsSetManifestFormat() => this.ManifestFormat != null;

        /// <summary>
        /// Gets and sets the property ManifestPrefix. 
        /// <para>
        /// Prefix identifying one or more objects to which the manifest applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ManifestPrefix { get; set; }

        /// <summary>
        /// Checks to see if the ManifestPrefix property is set.
        /// </summary>
        internal bool IsSetManifestPrefix() => this.ManifestPrefix != null;
    }
}
