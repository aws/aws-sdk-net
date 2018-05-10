/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBEngineVersions operation.
    /// Returns a list of the available DB engines.
    /// </summary>
    public partial class DescribeDBEngineVersionsRequest : AmazonRDSRequest
    {
        private string _dbParameterGroupFamily;
        private bool? _defaultOnly;
        private string _engine;
        private string _engineVersion;
        private List<Filter> _filters = new List<Filter>();
        private bool? _listSupportedCharacterSets;
        private bool? _listSupportedTimezones;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeDBEngineVersionsRequest() { }

        /// <summary>
        /// Gets and sets the property DBParameterGroupFamily. 
        /// <para>
        /// The name of a specific DB parameter group family to return details for.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match an existing DBParameterGroupFamily.
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
        public bool DefaultOnly
        {
            get { return this._defaultOnly.GetValueOrDefault(); }
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
        /// Example: <code>5.1.49</code> 
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
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ListSupportedCharacterSets. 
        /// <para>
        /// If this parameter is specified and the requested engine supports the <code>CharacterSetName</code>
        /// parameter for <code>CreateDBInstance</code>, the response includes a list of supported
        /// character sets for each engine version. 
        /// </para>
        /// </summary>
        public bool ListSupportedCharacterSets
        {
            get { return this._listSupportedCharacterSets.GetValueOrDefault(); }
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
        /// If this parameter is specified and the requested engine supports the <code>TimeZone</code>
        /// parameter for <code>CreateDBInstance</code>, the response includes a list of supported
        /// time zones for each engine version. 
        /// </para>
        /// </summary>
        public bool ListSupportedTimezones
        {
            get { return this._listSupportedTimezones.GetValueOrDefault(); }
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
        ///  An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <code>MaxRecords</code>. 
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
        ///  The maximum number of records to include in the response. If more than the <code>MaxRecords</code>
        /// value is available, a pagination token called a marker is included in the response
        /// so that the following results can be retrieved. 
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

    }
}