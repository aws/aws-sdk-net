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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// The configuration for publishing Amazon CloudWatch Internet Monitor internet measurements
    /// to Amazon S3. The configuration includes the bucket name and (optionally) prefix for
    /// the S3 bucket to store the measurements, and the delivery status. The delivery status
    /// is <code>ENABLED</code> or <code>DISABLED</code>, depending on whether you choose
    /// to deliver internet measurements to S3 logs.
    /// </summary>
    public partial class S3Config
    {
        private string _bucketName;
        private string _bucketPrefix;
        private LogDeliveryStatus _logDeliveryStatus;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The Amazon S3 bucket name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3)]
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
        /// Gets and sets the property BucketPrefix. 
        /// <para>
        /// The Amazon S3 bucket prefix.
        /// </para>
        /// </summary>
        public string BucketPrefix
        {
            get { return this._bucketPrefix; }
            set { this._bucketPrefix = value; }
        }

        // Check to see if BucketPrefix property is set
        internal bool IsSetBucketPrefix()
        {
            return this._bucketPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property LogDeliveryStatus. 
        /// <para>
        /// The status of publishing Internet Monitor internet measurements to an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public LogDeliveryStatus LogDeliveryStatus
        {
            get { return this._logDeliveryStatus; }
            set { this._logDeliveryStatus = value; }
        }

        // Check to see if LogDeliveryStatus property is set
        internal bool IsSetLogDeliveryStatus()
        {
            return this._logDeliveryStatus != null;
        }

    }
}