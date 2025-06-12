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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBEngineVersions operation.
    /// Returns a list of the available engines.
    /// </summary>
    public partial class DescribeDBEngineVersionsRequest : AmazonDocDBRequest
    {
        private string _dbParameterGroupFamily;
        private bool? _defaultOnly;
        private string _engine;
        private string _engineVersion;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private bool? _listSupportedCharacterSets;
        private bool? _listSupportedTimezones;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Gets and sets the property DBParameterGroupFamily. 
        /// <para>
        /// The name of a specific parameter group family to return details for.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If provided, must match an existing <c>DBParameterGroupFamily</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBParameterGroupFamily
        {
            get { return this._dbParameterGroupFamily; }
            set { this._dbParameterGroupFamily = value; }
        }

        // Check to see if DBParameterGroupFamily property is set
        internal bool IsSetDBParameterGroupFamily()
        {
            return this._dbParameterGroupFamily != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultOnly. 
        /// <para>
        /// Indicates that only the default version of the specified engine or engine and major
        /// version combination is returned.
        /// </para>
        /// </summary>
        public bool? DefaultOnly
        {
            get { return this._defaultOnly; }
            set { this._defaultOnly = value; }
        }

        // Check to see if DefaultOnly property is set
        internal bool IsSetDefaultOnly()
        {
            return this._defaultOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine to return.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The database engine version to return.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>3.6.0</c> 
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// This parameter is not currently supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property ListSupportedCharacterSets. 
        /// <para>
        /// If this parameter is specified and the requested engine supports the <c>CharacterSetName</c>
        /// parameter for <c>CreateDBInstance</c>, the response includes a list of supported character
        /// sets for each engine version. 
        /// </para>
        /// </summary>
        public bool? ListSupportedCharacterSets
        {
            get { return this._listSupportedCharacterSets; }
            set { this._listSupportedCharacterSets = value; }
        }

        // Check to see if ListSupportedCharacterSets property is set
        internal bool IsSetListSupportedCharacterSets()
        {
            return this._listSupportedCharacterSets.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ListSupportedTimezones. 
        /// <para>
        /// If this parameter is specified and the requested engine supports the <c>TimeZone</c>
        /// parameter for <c>CreateDBInstance</c>, the response includes a list of supported time
        /// zones for each engine version. 
        /// </para>
        /// </summary>
        public bool? ListSupportedTimezones
        {
            get { return this._listSupportedTimezones; }
            set { this._listSupportedTimezones = value; }
        }

        // Check to see if ListSupportedTimezones property is set
        internal bool IsSetListSupportedTimezones()
        {
            return this._listSupportedTimezones.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <c>MaxRecords</c>.
        /// </para>
        /// </summary>
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
        ///  The maximum number of records to include in the response. If more records exist than
        /// the specified <c>MaxRecords</c> value, a pagination token (marker) is included in
        /// the response so that the remaining results can be retrieved.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum 20, maximum 100.
        /// </para>
        /// </summary>
        public int? MaxRecords
        {
            get { return this._maxRecords; }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

    }
}