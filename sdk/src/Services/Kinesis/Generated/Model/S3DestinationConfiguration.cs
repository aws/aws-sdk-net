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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// The configuration for delivery to a general purpose Amazon S3 bucket. Used in <a>CreateChannel</a>.
    /// </summary>
    public partial class S3DestinationConfiguration
    {
        private int? _dataFreshnessInSeconds;
        private DeadLetterQueueS3Configuration _deadLetterQueueS3Configuration;
        private S3StorageConfiguration _storageConfiguration;

        /// <summary>
        /// Gets and sets the property DataFreshnessInSeconds. 
        /// <para>
        /// The maximum age, in seconds, of undelivered data. Valid range is 300 to 900 seconds
        /// (5 to 15 minutes). The default value is 300 seconds.
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
        /// Gets and sets the property DeadLetterQueueS3Configuration. 
        /// <para>
        /// The dead-letter queue configuration for records that cannot be delivered. Optional
        /// for general purpose Amazon S3 destinations. If not specified, it defaults to the destination
        /// bucket with an error prefix.
        /// </para>
        /// </summary>
        public DeadLetterQueueS3Configuration DeadLetterQueueS3Configuration
        {
            get { return this._deadLetterQueueS3Configuration; }
            set { this._deadLetterQueueS3Configuration = value; }
        }

        // Check to see if DeadLetterQueueS3Configuration property is set
        internal bool IsSetDeadLetterQueueS3Configuration()
        {
            return this._deadLetterQueueS3Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// The Amazon S3 storage configuration for the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3StorageConfiguration StorageConfiguration
        {
            get { return this._storageConfiguration; }
            set { this._storageConfiguration = value; }
        }

        // Check to see if StorageConfiguration property is set
        internal bool IsSetStorageConfiguration()
        {
            return this._storageConfiguration != null;
        }

    }
}