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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDataMigrations operation.
    /// Returns information about data migrations.
    /// </summary>
    public partial class DescribeDataMigrationsRequest : AmazonDatabaseMigrationServiceRequest
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private string _marker;
        private int? _maxRecords;
        private bool? _withoutSettings;
        private bool? _withoutStatistics;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters applied to the data migrations.
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <c>MaxRecords</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <c>MaxRecords</c> value, a pagination token called a marker is included
        /// in the response so that the remaining results can be retrieved. 
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WithoutSettings. 
        /// <para>
        /// An option to set to avoid returning information about settings. Use this to reduce
        /// overhead when setting information is too large. To use this option, choose <c>true</c>;
        /// otherwise, choose <c>false</c> (the default).
        /// </para>
        /// </summary>
        public bool WithoutSettings
        {
            get { return this._withoutSettings.GetValueOrDefault(); }
            set { this._withoutSettings = value; }
        }

        // Check to see if WithoutSettings property is set
        internal bool IsSetWithoutSettings()
        {
            return this._withoutSettings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WithoutStatistics. 
        /// <para>
        /// An option to set to avoid returning information about statistics. Use this to reduce
        /// overhead when statistics information is too large. To use this option, choose <c>true</c>;
        /// otherwise, choose <c>false</c> (the default).
        /// </para>
        /// </summary>
        public bool WithoutStatistics
        {
            get { return this._withoutStatistics.GetValueOrDefault(); }
            set { this._withoutStatistics = value; }
        }

        // Check to see if WithoutStatistics property is set
        internal bool IsSetWithoutStatistics()
        {
            return this._withoutStatistics.HasValue; 
        }

    }
}