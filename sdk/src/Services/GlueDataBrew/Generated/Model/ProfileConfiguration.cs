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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Configuration for profile jobs. Configuration can be used to select columns, do evaluations,
    /// and override default parameters of evaluations. When configuration is undefined, the
    /// profile job will apply default settings to all supported columns.
    /// </summary>
    public partial class ProfileConfiguration
    {
        private List<ColumnStatisticsConfiguration> _columnStatisticsConfigurations = AWSConfigs.InitializeCollections ? new List<ColumnStatisticsConfiguration>() : null;
        private StatisticsConfiguration _datasetStatisticsConfiguration;
        private EntityDetectorConfiguration _entityDetectorConfiguration;
        private List<ColumnSelector> _profileColumns = AWSConfigs.InitializeCollections ? new List<ColumnSelector>() : null;

        /// <summary>
        /// Gets and sets the property ColumnStatisticsConfigurations. 
        /// <para>
        /// List of configurations for column evaluations. ColumnStatisticsConfigurations are
        /// used to select evaluations and override parameters of evaluations for particular columns.
        /// When ColumnStatisticsConfigurations is undefined, the profile job will profile all
        /// supported columns and run all supported evaluations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ColumnStatisticsConfiguration> ColumnStatisticsConfigurations
        {
            get { return this._columnStatisticsConfigurations; }
            set { this._columnStatisticsConfigurations = value; }
        }

        // Check to see if ColumnStatisticsConfigurations property is set
        internal bool IsSetColumnStatisticsConfigurations()
        {
            return this._columnStatisticsConfigurations != null && (this._columnStatisticsConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatasetStatisticsConfiguration. 
        /// <para>
        /// Configuration for inter-column evaluations. Configuration can be used to select evaluations
        /// and override parameters of evaluations. When configuration is undefined, the profile
        /// job will run all supported inter-column evaluations. 
        /// </para>
        /// </summary>
        public StatisticsConfiguration DatasetStatisticsConfiguration
        {
            get { return this._datasetStatisticsConfiguration; }
            set { this._datasetStatisticsConfiguration = value; }
        }

        // Check to see if DatasetStatisticsConfiguration property is set
        internal bool IsSetDatasetStatisticsConfiguration()
        {
            return this._datasetStatisticsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EntityDetectorConfiguration. 
        /// <para>
        /// Configuration of entity detection for a profile job. When undefined, entity detection
        /// is disabled.
        /// </para>
        /// </summary>
        public EntityDetectorConfiguration EntityDetectorConfiguration
        {
            get { return this._entityDetectorConfiguration; }
            set { this._entityDetectorConfiguration = value; }
        }

        // Check to see if EntityDetectorConfiguration property is set
        internal bool IsSetEntityDetectorConfiguration()
        {
            return this._entityDetectorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileColumns. 
        /// <para>
        /// List of column selectors. ProfileColumns can be used to select columns from the dataset.
        /// When ProfileColumns is undefined, the profile job will profile all supported columns.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ColumnSelector> ProfileColumns
        {
            get { return this._profileColumns; }
            set { this._profileColumns = value; }
        }

        // Check to see if ProfileColumns property is set
        internal bool IsSetProfileColumns()
        {
            return this._profileColumns != null && (this._profileColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}