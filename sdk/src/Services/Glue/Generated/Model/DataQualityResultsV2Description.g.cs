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
    /// Describes a data quality result returned by <c>ListDataQualityResultsV2</c>.
    /// </summary>
    public partial class DataQualityResultsV2Description
    {
        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The table associated with the data quality result, if any.
        /// </para>
        /// </summary>
        public DataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property Descriptors. 
        /// <para>
        /// A map of user-provided descriptors that add contextual metadata and configuration
        /// to the data quality result, such as database name, table name, team, or environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public Dictionary<string, string> Descriptors { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Descriptors property is set.
        /// </summary>
        internal bool IsSetDescriptors() => this.Descriptors != null && (this.Descriptors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// A map of platform-specific identifiers, such as cluster, application, workgroup, or
        /// project IDs, that identify where the data quality evaluation ran.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public Dictionary<string, string> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// The evaluation context for the data quality result. This value identifies a specific
        /// data quality result, or a series of related results, within a run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EvaluationContext { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationContext property is set.
        /// </summary>
        internal bool IsSetEvaluationContext() => this.EvaluationContext != null;

        /// <summary>
        /// Gets and sets the property ResultId. 
        /// <para>
        /// The unique result ID for this data quality result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ResultId { get; set; }

        /// <summary>
        /// Checks to see if the ResultId property is set.
        /// </summary>
        internal bool IsSetResultId() => this.ResultId != null;

        /// <summary>
        /// Gets and sets the property ResultPublishedOn. 
        /// <para>
        /// The date and time when this data quality result was published.
        /// </para>
        /// </summary>
        public DateTime? ResultPublishedOn { get; set; }

        /// <summary>
        /// Checks to see if the ResultPublishedOn property is set.
        /// </summary>
        internal bool IsSetResultPublishedOn() => this.ResultPublishedOn.HasValue;
    }
}
