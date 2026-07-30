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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Configuration of an Amazon S3 destination for a channel.
    /// </summary>
    public partial class S3DestinationConfiguration
    {
        private int? _dataFreshnessInSeconds;
        private DeadLetterQueueS3 _deadLetterQueueS3;
        private string _serviceExecutionRoleArn;
        private S3Storage _storage;

        /// <summary>
        /// Gets and sets the property DataFreshnessInSeconds. 
        /// <para>
        /// The maximum time, in seconds, that records buffer in MSK before being flushed to the
        /// destination. Allowed range: 300 to 900. Default: 600.
        /// </para>
        /// </summary>
        public int? DataFreshnessInSeconds
        {
            get { return this._dataFreshnessInSeconds; }
            set { this._dataFreshnessInSeconds = value; }
        }

        // Check to see if DataFreshnessInSeconds property is set
        internal bool IsSetDataFreshnessInSeconds()
        {
            return this._dataFreshnessInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeadLetterQueueS3. 
        /// <para>
        /// The Amazon S3 bucket and prefix where MSK writes records that fail to deliver.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeadLetterQueueS3 DeadLetterQueueS3
        {
            get { return this._deadLetterQueueS3; }
            set { this._deadLetterQueueS3 = value; }
        }

        // Check to see if DeadLetterQueueS3 property is set
        internal bool IsSetDeadLetterQueueS3()
        {
            return this._deadLetterQueueS3 != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that MSK assumes to write to the destination
        /// Amazon S3 bucket and the dead-letter bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceExecutionRoleArn
        {
            get { return this._serviceExecutionRoleArn; }
            set { this._serviceExecutionRoleArn = value; }
        }

        // Check to see if ServiceExecutionRoleArn property is set
        internal bool IsSetServiceExecutionRoleArn()
        {
            return this._serviceExecutionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// The Amazon S3 bucket, prefix, and storage class for delivered records.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Storage Storage
        {
            get { return this._storage; }
            set { this._storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this._storage != null;
        }

    }
}