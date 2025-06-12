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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
        private string _databaseName;
        private List<DimensionMapping> _dimensionMappings = AWSConfigs.InitializeCollections ? new List<DimensionMapping>() : null;
        private string _measureNameColumn;
        private List<MixedMeasureMapping> _mixedMeasureMappings = AWSConfigs.InitializeCollections ? new List<MixedMeasureMapping>() : null;
        private MultiMeasureMappings _multiMeasureMappings;
        private string _tableName;
        private string _timeColumn;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Name of Timestream database to which the query result will be written.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionMappings. 
        /// <para>
        ///  This is to allow mapping column(s) from the query result to the dimension in the
        /// destination table. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DimensionMapping> DimensionMappings
        {
            get { return this._dimensionMappings; }
            set { this._dimensionMappings = value; }
        }

        // Check to see if DimensionMappings property is set
        internal bool IsSetDimensionMappings()
        {
            return this._dimensionMappings != null && (this._dimensionMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MeasureNameColumn. 
        /// <para>
        /// Name of the measure column.
        /// </para>
        /// </summary>
        public string MeasureNameColumn
        {
            get { return this._measureNameColumn; }
            set { this._measureNameColumn = value; }
        }

        // Check to see if MeasureNameColumn property is set
        internal bool IsSetMeasureNameColumn()
        {
            return this._measureNameColumn != null;
        }

        /// <summary>
        /// Gets and sets the property MixedMeasureMappings. 
        /// <para>
        /// Specifies how to map measures to multi-measure records.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<MixedMeasureMapping> MixedMeasureMappings
        {
            get { return this._mixedMeasureMappings; }
            set { this._mixedMeasureMappings = value; }
        }

        // Check to see if MixedMeasureMappings property is set
        internal bool IsSetMixedMeasureMappings()
        {
            return this._mixedMeasureMappings != null && (this._mixedMeasureMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MultiMeasureMappings. 
        /// <para>
        /// Multi-measure mappings.
        /// </para>
        /// </summary>
        public MultiMeasureMappings MultiMeasureMappings
        {
            get { return this._multiMeasureMappings; }
            set { this._multiMeasureMappings = value; }
        }

        // Check to see if MultiMeasureMappings property is set
        internal bool IsSetMultiMeasureMappings()
        {
            return this._multiMeasureMappings != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// Name of Timestream table that the query result will be written to. The table should
        /// be within the same database that is provided in Timestream configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property TimeColumn. 
        /// <para>
        /// Column from query result that should be used as the time column in destination table.
        /// Column type for this should be TIMESTAMP.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TimeColumn
        {
            get { return this._timeColumn; }
            set { this._timeColumn = value; }
        }

        // Check to see if TimeColumn property is set
        internal bool IsSetTimeColumn()
        {
            return this._timeColumn != null;
        }

    }
}