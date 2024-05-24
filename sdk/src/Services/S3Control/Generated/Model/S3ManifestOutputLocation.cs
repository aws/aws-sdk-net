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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Location details for where the generated manifest should be written.
    /// </summary>
    public partial class S3ManifestOutputLocation
    {
        private string _bucket;
        private string _expectedManifestBucketOwner;
        private GeneratedManifestEncryption _manifestEncryption;
        private GeneratedManifestFormat _manifestFormat;
        private string _manifestPrefix;

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
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedManifestBucketOwner. 
        /// <para>
        /// The Account ID that owns the bucket the generated manifest is written to.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string ExpectedManifestBucketOwner
        {
            get { return this._expectedManifestBucketOwner; }
            set { this._expectedManifestBucketOwner = value; }
        }

        // Check to see if ExpectedManifestBucketOwner property is set
        internal bool IsSetExpectedManifestBucketOwner()
        {
            return this._expectedManifestBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestEncryption. 
        /// <para>
        /// Specifies what encryption should be used when the generated manifest objects are written.
        /// </para>
        /// </summary>
        public GeneratedManifestEncryption ManifestEncryption
        {
            get { return this._manifestEncryption; }
            set { this._manifestEncryption = value; }
        }

        // Check to see if ManifestEncryption property is set
        internal bool IsSetManifestEncryption()
        {
            return this._manifestEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestFormat. 
        /// <para>
        /// The format of the generated manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeneratedManifestFormat ManifestFormat
        {
            get { return this._manifestFormat; }
            set { this._manifestFormat = value; }
        }

        // Check to see if ManifestFormat property is set
        internal bool IsSetManifestFormat()
        {
            return this._manifestFormat != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestPrefix. 
        /// <para>
        /// Prefix identifying one or more objects to which the manifest applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ManifestPrefix
        {
            get { return this._manifestPrefix; }
            set { this._manifestPrefix = value; }
        }

        // Check to see if ManifestPrefix property is set
        internal bool IsSetManifestPrefix()
        {
            return this._manifestPrefix != null;
        }

    }
}