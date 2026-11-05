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
    /// Container for the parameters to the CreateIngestionJob operation. Creates an ingestion
    /// job that performs a one-time bulk ingestion of data from an Amazon S3 bucket into
    /// an index in an OpenSearch Serverless collection. An ingestion job scans the source
    /// bucket, indexes the documents it finds, and then completes. To continuously ingest
    /// new data as it arrives, use <c>CreateIngestionStream</c> instead.
    /// </summary>
    public partial class CreateIngestionJobRequest : AmazonOpenSearchServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// The unique identifier of the collection to ingest data into.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 40)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Checks to see if the CollectionId property is set.
        /// </summary>
        internal bool IsSetCollectionId() => this.CollectionId != null;

        /// <summary>
        /// Gets and sets the property FailureIndexName. 
        /// <para>
        /// The name of the index where documents that fail to be ingested are recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string FailureIndexName { get; set; }

        /// <summary>
        /// Checks to see if the FailureIndexName property is set.
        /// </summary>
        internal bool IsSetFailureIndexName() => this.FailureIndexName != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the index to ingest documents into.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property IngestionJobName. 
        /// <para>
        /// The name of the ingestion job. The name must be unique within the collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 32)]
        public string IngestionJobName { get; set; }

        /// <summary>
        /// Checks to see if the IngestionJobName property is set.
        /// </summary>
        internal bool IsSetIngestionJobName() => this.IngestionJobName != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon S3 source to ingest data from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IngestionJobSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An arbitrary set of tags (key–value pairs) to associate with the ingestion job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
