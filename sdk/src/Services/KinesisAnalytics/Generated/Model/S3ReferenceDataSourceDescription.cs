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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
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
namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Provides the bucket name and object key name that stores the reference data.
    /// </summary>
    public partial class S3ReferenceDataSourceDescription
    {
        private string _bucketARN;
        private string _fileKey;
        private string _referenceRoleARN;

        /// <summary>
        /// Gets and sets the property BucketARN. 
        /// <para>
        /// Amazon Resource Name (ARN) of the S3 bucket.
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
        /// Amazon S3 object key name.
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
        /// Gets and sets the property ReferenceRoleARN. 
        /// <para>
        /// ARN of the IAM role that Amazon Kinesis Analytics can assume to read the Amazon S3
        /// object on your behalf to populate the in-application reference table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ReferenceRoleARN
        {
            get { return this._referenceRoleARN; }
            set { this._referenceRoleARN = value; }
        }

        // Check to see if ReferenceRoleARN property is set
        internal bool IsSetReferenceRoleARN()
        {
            return this._referenceRoleARN != null;
        }

    }
}