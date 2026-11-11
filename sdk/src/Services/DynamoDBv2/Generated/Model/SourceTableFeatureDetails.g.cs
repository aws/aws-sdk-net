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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Contains the details of the features enabled on the table when the backup was created.
    /// For example, LSIs, GSIs, streams, TTL.
    /// </summary>
    public partial class SourceTableFeatureDetails
    {
        /// <summary>
        /// Gets and sets the property GlobalSecondaryIndexes. 
        /// <para>
        /// Represents the GSI properties for the table when the backup was created. It includes
        /// the IndexName, KeySchema, Projection, and ProvisionedThroughput for the GSIs on the
        /// table at the time of backup. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlobalSecondaryIndexInfo> GlobalSecondaryIndexes { get; set; } = AWSConfigs.InitializeCollections ? new List<GlobalSecondaryIndexInfo>() : null;

        /// <summary>
        /// Checks to see if the GlobalSecondaryIndexes property is set.
        /// </summary>
        internal bool IsSetGlobalSecondaryIndexes() => this.GlobalSecondaryIndexes != null && (this.GlobalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LocalSecondaryIndexes. 
        /// <para>
        /// Represents the LSI properties for the table when the backup was created. It includes
        /// the IndexName, KeySchema and Projection for the LSIs on the table at the time of backup.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LocalSecondaryIndexInfo> LocalSecondaryIndexes { get; set; } = AWSConfigs.InitializeCollections ? new List<LocalSecondaryIndexInfo>() : null;

        /// <summary>
        /// Checks to see if the LocalSecondaryIndexes property is set.
        /// </summary>
        internal bool IsSetLocalSecondaryIndexes() => this.LocalSecondaryIndexes != null && (this.LocalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SSEDescription. 
        /// <para>
        /// The description of the server-side encryption status on the table when the backup
        /// was created.
        /// </para>
        /// </summary>
        public SSEDescription SSEDescription { get; set; }

        /// <summary>
        /// Checks to see if the SSEDescription property is set.
        /// </summary>
        internal bool IsSetSSEDescription() => this.SSEDescription != null;

        /// <summary>
        /// Gets and sets the property StreamDescription. 
        /// <para>
        /// Stream settings on the table when the backup was created.
        /// </para>
        /// </summary>
        public StreamSpecification StreamDescription { get; set; }

        /// <summary>
        /// Checks to see if the StreamDescription property is set.
        /// </summary>
        internal bool IsSetStreamDescription() => this.StreamDescription != null;

        /// <summary>
        /// Gets and sets the property TimeToLiveDescription. 
        /// <para>
        /// Time to Live settings on the table when the backup was created.
        /// </para>
        /// </summary>
        public TimeToLiveDescription TimeToLiveDescription { get; set; }

        /// <summary>
        /// Checks to see if the TimeToLiveDescription property is set.
        /// </summary>
        internal bool IsSetTimeToLiveDescription() => this.TimeToLiveDescription != null;

        /// <summary>
        /// Gets and sets the property VectorIndexes. 
        /// <para>
        /// The vector index properties for the table at the time the backup was created, including
        /// the index name, vector attribute, dimensions, distance function, search schema, and
        /// projection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VectorIndexInfo> VectorIndexes { get; set; } = AWSConfigs.InitializeCollections ? new List<VectorIndexInfo>() : null;

        /// <summary>
        /// Checks to see if the VectorIndexes property is set.
        /// </summary>
        internal bool IsSetVectorIndexes() => this.VectorIndexes != null && (this.VectorIndexes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
