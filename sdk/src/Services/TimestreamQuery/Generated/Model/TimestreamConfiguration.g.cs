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

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Configuration to write data into Timestream database and table. This configuration
    /// allows the user to map the query result select columns into the destination table
    /// columns.
    /// </summary>
    public partial class TimestreamConfiguration
    {
        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Name of Timestream database to which the query result will be written.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property DimensionMappings. 
        /// <para>
        ///  This is to allow mapping column(s) from the query result to the dimension in the
        /// destination table. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<DimensionMapping> DimensionMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DimensionMapping>() : null;

        /// <summary>
        /// Checks to see if the DimensionMappings property is set.
        /// </summary>
        internal bool IsSetDimensionMappings() => this.DimensionMappings != null && (this.DimensionMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MeasureNameColumn. 
        /// <para>
        /// Name of the measure column.
        /// </para>
        /// </summary>
        public string MeasureNameColumn { get; set; }

        /// <summary>
        /// Checks to see if the MeasureNameColumn property is set.
        /// </summary>
        internal bool IsSetMeasureNameColumn() => this.MeasureNameColumn != null;

        /// <summary>
        /// Gets and sets the property MixedMeasureMappings. 
        /// <para>
        /// Specifies how to map measures to multi-measure records.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<MixedMeasureMapping> MixedMeasureMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<MixedMeasureMapping>() : null;

        /// <summary>
        /// Checks to see if the MixedMeasureMappings property is set.
        /// </summary>
        internal bool IsSetMixedMeasureMappings() => this.MixedMeasureMappings != null && (this.MixedMeasureMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MultiMeasureMappings. 
        /// <para>
        /// Multi-measure mappings.
        /// </para>
        /// </summary>
        public MultiMeasureMappings MultiMeasureMappings { get; set; }

        /// <summary>
        /// Checks to see if the MultiMeasureMappings property is set.
        /// </summary>
        internal bool IsSetMultiMeasureMappings() => this.MultiMeasureMappings != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// Name of Timestream table that the query result will be written to. The table should
        /// be within the same database that is provided in Timestream configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property TimeColumn. 
        /// <para>
        /// Column from query result that should be used as the time column in destination table.
        /// Column type for this should be TIMESTAMP.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TimeColumn { get; set; }

        /// <summary>
        /// Checks to see if the TimeColumn property is set.
        /// </summary>
        internal bool IsSetTimeColumn() => this.TimeColumn != null;
    }
}
