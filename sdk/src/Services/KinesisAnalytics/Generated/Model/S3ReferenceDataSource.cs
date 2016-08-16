/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Identifies the S3 bucket and object that contains the reference data. Also identifies
    /// the IAM role Amazon Kinesis Analytics can assume to read this object on your behalf.
    /// 
    ///  
    /// <para>
    /// An Amazon Kinesis Analytics application loads reference data only once. If the data
    /// changes, you call the <a>UpdateApplication</a> operation to trigger reloading of data
    /// into your application.
    /// </para>
    /// </summary>
    public partial class S3ReferenceDataSource
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
        /// Object key name containing reference data.
        /// </para>
        /// </summary>
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
        /// ARN of the IAM role that the service can assume to read data on your behalf. This
        /// role must have permission for the <code>s3:GetObject</code> action on the object and
        /// trust policy that allows Amazon Kinesis Analytics service principal to assume this
        /// role.
        /// </para>
        /// </summary>
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