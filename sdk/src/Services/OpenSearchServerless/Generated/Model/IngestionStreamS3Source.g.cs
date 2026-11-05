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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// The Amazon S3 source configuration for an ingestion stream.
    /// </summary>
    public partial class IngestionStreamS3Source
    {
        /// <summary>
        /// Gets and sets the property Buckets. 
        /// <para>
        /// The configuration for each Amazon S3 bucket that the ingestion stream ingests data
        /// from.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<StreamBucketConfig> Buckets { get; set; } = AWSConfigs.InitializeCollections ? new List<StreamBucketConfig>() : null;

        /// <summary>
        /// Checks to see if the Buckets property is set.
        /// </summary>
        internal bool IsSetBuckets() => this.Buckets != null && (this.Buckets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SqsArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SQS queue that receives Amazon S3 event
        /// notifications for the source buckets.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string SqsArn { get; set; }

        /// <summary>
        /// Checks to see if the SqsArn property is set.
        /// </summary>
        internal bool IsSetSqsArn() => this.SqsArn != null;
    }
}
