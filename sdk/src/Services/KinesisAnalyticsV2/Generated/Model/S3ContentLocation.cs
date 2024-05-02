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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// For a Managed Service for Apache Flink application provides a description of an Amazon
    /// S3 object, including the Amazon Resource Name (ARN) of the S3 bucket, the name of
    /// the Amazon S3 object that contains the data, and the version number of the Amazon
    /// S3 object that contains the data.
    /// </summary>
    public partial class S3ContentLocation
    {
        private string _bucketARN;
        private string _fileKey;
        private string _objectVersion;

        /// <summary>
        /// Gets and sets the property BucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the S3 bucket containing the application code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string BucketARN
        {
            get { return this._bucketARN; }
            set { this._bucketARN = value; }
        }

        // Check to see if BucketARN property is set
        internal bool IsSetBucketARN()
        {
            return this._bucketARN != null;
        }

        /// <summary>
        /// Gets and sets the property FileKey. 
        /// <para>
        /// The file key for the object containing the application code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string FileKey
        {
            get { return this._fileKey; }
            set { this._fileKey = value; }
        }

        // Check to see if FileKey property is set
        internal bool IsSetFileKey()
        {
            return this._fileKey != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectVersion. 
        /// <para>
        /// The version of the object containing the application code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ObjectVersion
        {
            get { return this._objectVersion; }
            set { this._objectVersion = value; }
        }

        // Check to see if ObjectVersion property is set
        internal bool IsSetObjectVersion()
        {
            return this._objectVersion != null;
        }

    }
}