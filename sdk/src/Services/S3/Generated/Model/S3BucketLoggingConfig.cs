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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Describes where logs are stored and the prefix that Amazon S3 assigns to all log object
    /// keys for a bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTlogging.html">PUT
    /// Bucket logging</a> in the <i>Amazon S3 API Reference</i>.
    /// </summary>
    public partial class S3BucketLoggingConfig
    {
        private List<S3Grant> _grants = AWSConfigs.InitializeCollections ? new List<S3Grant>() : null;
        private string _targetBucketName;
        private TargetObjectKeyFormat _targetObjectKeyFormat;
        private string _targetPrefix;

        /// <summary>
        /// Gets and sets the property Grants. 
        /// <para>
        /// Container for granting information.
        /// </para>
        ///  
        /// <para>
        /// Buckets that use the bucket owner enforced setting for Object Ownership don't support
        /// target grants. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/enable-server-access-logging.html#grant-log-delivery-permissions-general">Permissions
        /// for server access log delivery</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Grant> Grants
        {
            get { return this._grants; }
            set { this._grants = value; }
        }

        // Check to see if Grants property is set
        internal bool IsSetGrants()
        {
            return this._grants != null && (this._grants.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetBucketName. 
        /// <para>
        /// Specifies the bucket where you want Amazon S3 to store server access logs. You can
        /// have your logs delivered to any bucket that you own, including the same bucket that
        /// is being logged. You can also configure multiple buckets to deliver their logs to
        /// the same target bucket. In this case, you should choose a different <c>TargetPrefix</c>
        /// for each source bucket so that the delivered log files can be distinguished by key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetBucketName
        {
            get { return this._targetBucketName; }
            set { this._targetBucketName = value; }
        }

        // Check to see if TargetBucketName property is set
        internal bool IsSetTargetBucketName()
        {
            return this._targetBucketName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetObjectKeyFormat. 
        /// <para>
        /// Amazon S3 key format for log objects.
        /// </para>
        /// </summary>
        public TargetObjectKeyFormat TargetObjectKeyFormat
        {
            get { return this._targetObjectKeyFormat; }
            set { this._targetObjectKeyFormat = value; }
        }

        // Check to see if TargetObjectKeyFormat property is set
        internal bool IsSetTargetObjectKeyFormat()
        {
            return this._targetObjectKeyFormat != null;
        }

        /// <summary>
        /// Gets and sets the property TargetPrefix. 
        /// <para>
        /// A prefix for all log object keys. If you store log files from multiple Amazon S3 buckets
        /// in a single bucket, you can use a prefix to distinguish which log files came from
        /// which bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetPrefix
        {
            get { return this._targetPrefix; }
            set { this._targetPrefix = value; }
        }

        // Check to see if TargetPrefix property is set
        internal bool IsSetTargetPrefix()
        {
            return this._targetPrefix != null;
        }

    }
}