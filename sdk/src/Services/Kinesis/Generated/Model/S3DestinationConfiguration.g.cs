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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// The configuration for delivery to a general purpose Amazon S3 bucket. Used in <a>CreateChannel</a>.
    /// </summary>
    public partial class S3DestinationConfiguration
    {
        /// <summary>
        /// Gets and sets the property DataFreshnessInSeconds. 
        /// <para>
        /// The maximum age, in seconds, of undelivered data before the channel delivers it to
        /// the destination. The default value is 300 seconds.
        /// </para>
        /// </summary>
        public int? DataFreshnessInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DataFreshnessInSeconds property is set.
        /// </summary>
        internal bool IsSetDataFreshnessInSeconds() => this.DataFreshnessInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property DeadLetterQueueS3Configuration. 
        /// <para>
        /// The dead-letter queue configuration for records that cannot be delivered. Optional
        /// for general purpose Amazon S3 destinations. If not specified, it defaults to the destination
        /// bucket with an error prefix.
        /// </para>
        /// </summary>
        public DeadLetterQueueS3Configuration DeadLetterQueueS3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the DeadLetterQueueS3Configuration property is set.
        /// </summary>
        internal bool IsSetDeadLetterQueueS3Configuration() => this.DeadLetterQueueS3Configuration != null;

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// The Amazon S3 storage configuration for the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3StorageConfiguration StorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StorageConfiguration property is set.
        /// </summary>
        internal bool IsSetStorageConfiguration() => this.StorageConfiguration != null;
    }
}
