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

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Identifies the S3 bucket and object that contains the reference data. Also identifies
    /// the IAM role Amazon Kinesis Analytics can assume to read this object on your behalf.
    /// 
    ///  
    /// <para>
    /// An Amazon Kinesis Analytics application loads reference data only once. If the data
    /// changes, you call the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_UpdateApplication.html">UpdateApplication</a>
    /// operation to trigger reloading of data into your application.
    /// </para>
    /// </summary>
    public partial class S3ReferenceDataSource
    {
        /// <summary>
        /// Gets and sets the property BucketARN. 
        /// <para>
        /// Amazon Resource Name (ARN) of the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string BucketARN { get; set; }

        /// <summary>
        /// Checks to see if the BucketARN property is set.
        /// </summary>
        internal bool IsSetBucketARN() => this.BucketARN != null;

        /// <summary>
        /// Gets and sets the property FileKey. 
        /// <para>
        /// Object key name containing reference data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string FileKey { get; set; }

        /// <summary>
        /// Checks to see if the FileKey property is set.
        /// </summary>
        internal bool IsSetFileKey() => this.FileKey != null;

        /// <summary>
        /// Gets and sets the property ReferenceRoleARN. 
        /// <para>
        /// ARN of the IAM role that the service can assume to read data on your behalf. This
        /// role must have permission for the <c>s3:GetObject</c> action on the object and trust
        /// policy that allows Amazon Kinesis Analytics service principal to assume this role.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ReferenceRoleARN { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceRoleARN property is set.
        /// </summary>
        internal bool IsSetReferenceRoleARN() => this.ReferenceRoleARN != null;
    }
}
