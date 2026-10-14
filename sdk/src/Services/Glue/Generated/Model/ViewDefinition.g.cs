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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure containing details for representations.
    /// </summary>
    public partial class ViewDefinition
    {
        /// <summary>
        /// Gets and sets the property Definer. 
        /// <para>
        /// The definer of a view in SQL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Definer { get; set; }

        /// <summary>
        /// Checks to see if the Definer property is set.
        /// </summary>
        internal bool IsSetDefiner() => this.Definer != null;

        /// <summary>
        /// Gets and sets the property IsManaged. 
        /// <para>
        /// Specifies whether the materialized view is managed by Glue.
        /// </para>
        /// </summary>
        public bool? IsManaged { get; set; }

        /// <summary>
        /// Checks to see if the IsManaged property is set.
        /// </summary>
        internal bool IsSetIsManaged() => this.IsManaged.HasValue;

        /// <summary>
        /// Gets and sets the property IsProtected. 
        /// <para>
        /// You can set this flag as true to instruct the engine not to push user-provided operations
        /// into the logical plan of the view during query planning. However, setting this flag
        /// does not guarantee that the engine will comply. Refer to the engine's documentation
        /// to understand the guarantees provided, if any.
        /// </para>
        /// </summary>
        public bool? IsProtected { get; set; }

        /// <summary>
        /// Checks to see if the IsProtected property is set.
        /// </summary>
        internal bool IsSetIsProtected() => this.IsProtected.HasValue;

        /// <summary>
        /// Gets and sets the property LastRefreshType. 
        /// <para>
        /// Sets the method used for the most recent refresh.
        /// </para>
        /// </summary>
        public LastRefreshType LastRefreshType { get; set; }

        /// <summary>
        /// Checks to see if the LastRefreshType property is set.
        /// </summary>
        internal bool IsSetLastRefreshType() => this.LastRefreshType != null;

        /// <summary>
        /// Gets and sets the property RefreshSeconds. 
        /// <para>
        /// Auto refresh interval in seconds for the materialized view. If not specified, the
        /// view will not automatically refresh.
        /// </para>
        /// </summary>
        public long? RefreshSeconds { get; set; }

        /// <summary>
        /// Checks to see if the RefreshSeconds property is set.
        /// </summary>
        internal bool IsSetRefreshSeconds() => this.RefreshSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Representations. 
        /// <para>
        /// A list of representations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public List<ViewRepresentation> Representations { get; set; } = AWSConfigs.InitializeCollections ? new List<ViewRepresentation>() : null;

        /// <summary>
        /// Checks to see if the Representations property is set.
        /// </summary>
        internal bool IsSetRepresentations() => this.Representations != null && (this.Representations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SparkPipelineInfo. 
        /// <para>
        /// A map of key-value pairs containing Spark Declarative Pipelines (SDP) information
        /// for the materialized view.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> SparkPipelineInfo { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SparkPipelineInfo property is set.
        /// </summary>
        internal bool IsSetSparkPipelineInfo() => this.SparkPipelineInfo != null && (this.SparkPipelineInfo.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubObjectVersionIds. 
        /// <para>
        /// List of the Apache Iceberg table versions referenced by the materialized view.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<long> SubObjectVersionIds { get; set; } = AWSConfigs.InitializeCollections ? new List<long>() : null;

        /// <summary>
        /// Checks to see if the SubObjectVersionIds property is set.
        /// </summary>
        internal bool IsSetSubObjectVersionIds() => this.SubObjectVersionIds != null && (this.SubObjectVersionIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubObjects. 
        /// <para>
        /// A list of table Amazon Resource Names (ARNs).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> SubObjects { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubObjects property is set.
        /// </summary>
        internal bool IsSetSubObjects() => this.SubObjects != null && (this.SubObjects.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubObjectsStatistics. 
        /// <para>
        /// Statistics captured for each sub-object referenced by the materialized view as of
        /// its most recent refresh, such as the source type, Glue version ID, and the partition,
        /// file, and byte counts. Each entry describes one sub-object, identified by its source
        /// type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<SubObjectStatistics> SubObjectsStatistics { get; set; } = AWSConfigs.InitializeCollections ? new List<SubObjectStatistics>() : null;

        /// <summary>
        /// Checks to see if the SubObjectsStatistics property is set.
        /// </summary>
        internal bool IsSetSubObjectsStatistics() => this.SubObjectsStatistics != null && (this.SubObjectsStatistics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ViewVersionId. 
        /// <para>
        /// The ID value that identifies this view's version. For materialized views, the version
        /// ID is the Apache Iceberg table's snapshot ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = -1)]
        public long? ViewVersionId { get; set; }

        /// <summary>
        /// Checks to see if the ViewVersionId property is set.
        /// </summary>
        internal bool IsSetViewVersionId() => this.ViewVersionId.HasValue;

        /// <summary>
        /// Gets and sets the property ViewVersionToken. 
        /// <para>
        /// The version ID of the Apache Iceberg table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ViewVersionToken { get; set; }

        /// <summary>
        /// Checks to see if the ViewVersionToken property is set.
        /// </summary>
        internal bool IsSetViewVersionToken() => this.ViewVersionToken != null;
    }
}
