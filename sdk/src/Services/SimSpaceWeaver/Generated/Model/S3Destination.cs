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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
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
namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// An Amazon S3 bucket and optional folder (object key prefix) where SimSpace Weaver
    /// creates a file.
    /// </summary>
    public partial class S3Destination
    {
        private string _bucketName;
        private string _objectKeyPrefix;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of an Amazon S3 bucket. For more information about buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/creating-buckets-s3.html">Creating,
        /// configuring, and working with Amazon S3 buckets</a> in the <i>Amazon Simple Storage
        /// Service User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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
        /// Gets and sets the property ObjectKeyPrefix. 
        /// <para>
        /// A string prefix for an Amazon S3 object key. It's usually a folder name. For more
        /// information about folders in Amazon S3, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-folders.html">Organizing
        /// objects in the Amazon S3 console using folders</a> in the <i>Amazon Simple Storage
        /// Service User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ObjectKeyPrefix
        {
            get { return this._objectKeyPrefix; }
            set { this._objectKeyPrefix = value; }
        }

        // Check to see if ObjectKeyPrefix property is set
        internal bool IsSetObjectKeyPrefix()
        {
            return this._objectKeyPrefix != null;
        }

    }
}