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
 * Do not modify this file. This file is generated from the bcm-data-exports-2023-11-26.normal.json service model.
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
namespace Amazon.BCMDataExports.Model
{
    /// <summary>
    /// Describes the destination Amazon Simple Storage Service (Amazon S3) bucket name and
    /// object keys of a data exports file.
    /// </summary>
    public partial class S3Destination
    {
        private string _s3Bucket;
        private S3OutputConfigurations _s3OutputConfigurations;
        private string _s3Prefix;
        private string _s3Region;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket used as the destination of a data export file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3OutputConfigurations. 
        /// <para>
        /// The output configuration for the data export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3OutputConfigurations S3OutputConfigurations
        {
            get { return this._s3OutputConfigurations; }
            set { this._s3OutputConfigurations = value; }
        }

        // Check to see if S3OutputConfigurations property is set
        internal bool IsSetS3OutputConfigurations()
        {
            return this._s3OutputConfigurations != null;
        }

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The S3 path prefix you want prepended to the name of your data export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string S3Prefix
        {
            get { return this._s3Prefix; }
            set { this._s3Prefix = value; }
        }

        // Check to see if S3Prefix property is set
        internal bool IsSetS3Prefix()
        {
            return this._s3Prefix != null;
        }

        /// <summary>
        /// Gets and sets the property S3Region. 
        /// <para>
        /// The S3 bucket Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string S3Region
        {
            get { return this._s3Region; }
            set { this._s3Region = value; }
        }

        // Check to see if S3Region property is set
        internal bool IsSetS3Region()
        {
            return this._s3Region != null;
        }

    }
}