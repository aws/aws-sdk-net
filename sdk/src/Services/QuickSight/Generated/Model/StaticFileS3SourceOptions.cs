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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The structure that contains the Amazon S3 location to download the static file from.
    /// </summary>
    public partial class StaticFileS3SourceOptions
    {
        private string _bucketName;
        private string _objectKey;
        private string _region;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectKey. 
        /// <para>
        /// The identifier of the static file in the Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ObjectKey
        {
            get { return this._objectKey; }
            set { this._objectKey = value; }
        }

        // Check to see if ObjectKey property is set
        internal bool IsSetObjectKey()
        {
            return this._objectKey != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region of the Amazon S3 account that contains the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}