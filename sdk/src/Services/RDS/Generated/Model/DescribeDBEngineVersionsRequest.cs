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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        private bool? _includeAll;
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
        /// A value that indicates whether only the default version of the specified engine or
        /// engine and major version combination is returned.
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
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aurora-mysql</code> (for MySQL 5.7-compatible and MySQL 8.0-compatible Aurora)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-postgresql</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mariadb</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mysql</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-ee</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-ee-cdb</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-se2</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-se2-cdb</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>postgres</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ee</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-se</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ex</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-web</code> 
        /// </para>
        ///  </li> </ul>
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
        /// A filter that specifies one or more DB engine versions to describe.
        /// </para>
        ///  
        /// <para>
        /// Supported filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>db-parameter-group-family</code> - Accepts parameter groups family names. The
        /// results list only includes information about the DB engine versions for these parameter
        /// group families.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>engine</code> - Accepts engine names. The results list only includes information
        /// about the DB engine versions for these engines.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>engine-mode</code> - Accepts DB engine modes. The results list only includes
        /// information about the DB engine versions for these engine modes. Valid DB engine modes
        /// are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>global</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>multimaster</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>parallelquery</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>provisioned</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>serverless</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>engine-version</code> - Accepts engine versions. The results list only includes
        /// information about the DB engine versions for these engine versions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>status</code> - Accepts engine version statuses. The results list only includes
        /// information about the DB engine versions for these statuses. Valid statuses are the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>available</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>deprecated</code> 
        /// </para>
        ///  </li> </ul> </li> </ul>
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
        /// Gets and sets the property IncludeAll. 
        /// <para>
        /// A value that indicates whether to include engine versions that aren't available in
        /// the list. The default is to list only available engine versions.
        /// </para>
        /// </summary>
        public bool IncludeAll
        {
            get { return this._includeAll.GetValueOrDefault(); }
            set { this._includeAll = value; }
        }

        // Check to see if IncludeAll property is set
        internal bool IsSetIncludeAll()
        {
            return this._includeAll.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ListSupportedCharacterSets. 
        /// <para>
        /// A value that indicates whether to list the supported character sets for each engine
        /// version.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is enabled and the requested engine supports the <code>CharacterSetName</code>
        /// parameter for <code>CreateDBInstance</code>, the response includes a list of supported
        /// character sets for each engine version.
        /// </para>
        ///  
        /// <para>
        /// For RDS Custom, the default is not to list supported character sets. If you set <code>ListSupportedCharacterSets</code>
        /// to <code>true</code>, RDS Custom returns no results.
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
        /// A value that indicates whether to list the supported time zones for each engine version.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is enabled and the requested engine supports the <code>TimeZone</code>
        /// parameter for <code>CreateDBInstance</code>, the response includes a list of supported
        /// time zones for each engine version.
        /// </para>
        ///  
        /// <para>
        /// For RDS Custom, the default is not to list supported time zones. If you set <code>ListSupportedTimezones</code>
        /// to <code>true</code>, RDS Custom returns no results.
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
        /// An optional pagination token provided by a previous request. If this parameter is
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
        /// The maximum number of records to include in the response. If more than the <code>MaxRecords</code>
        /// value is available, a pagination token called a marker is included in the response
        /// so you can retrieve the remaining results.
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