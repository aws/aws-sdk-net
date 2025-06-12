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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBEngineVersions operation.
    /// Describes the properties of specific versions of DB engines.
    /// </summary>
    public partial class DescribeDBEngineVersionsRequest : AmazonRDSRequest
    {
        private string _dbParameterGroupFamily;
        private bool? _defaultOnly;
        private string _engine;
        private string _engineVersion;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
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
        /// If supplied, must match an existing DB parameter group family.
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
        /// Specifies whether to return only the default version of the specified engine or the
        /// engine and major version combination.
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
        /// The database engine to return version details for.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aurora-mysql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-postgresql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-oracle-ee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-oracle-ee-cdb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-oracle-se2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-oracle-se2-cdb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db2-ae</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db2-se</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mariadb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mysql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-ee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-ee-cdb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se2-cdb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>postgres</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-se</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ex</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-web</c> 
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
        /// A specific database engine version to return details for.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>5.1.49</c> 
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
        ///  <c>db-parameter-group-family</c> - Accepts parameter groups family names. The results
        /// list only includes information about the DB engine versions for these parameter group
        /// families.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>engine</c> - Accepts engine names. The results list only includes information
        /// about the DB engine versions for these engines.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>engine-mode</c> - Accepts DB engine modes. The results list only includes information
        /// about the DB engine versions for these engine modes. Valid DB engine modes are the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>global</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>multimaster</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>parallelquery</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>provisioned</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>serverless</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>engine-version</c> - Accepts engine versions. The results list only includes information
        /// about the DB engine versions for these engine versions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status</c> - Accepts engine version statuses. The results list only includes information
        /// about the DB engine versions for these statuses. Valid statuses are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>available</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deprecated</c> 
        /// </para>
        ///  </li> </ul> </li> </ul>
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
        /// Gets and sets the property IncludeAll. 
        /// <para>
        /// Specifies whether to also list the engine versions that aren't available. The default
        /// is to list only available engine versions.
        /// </para>
        /// </summary>
        public bool? IncludeAll
        {
            get { return this._includeAll; }
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
        /// Specifies whether to list the supported character sets for each engine version.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is enabled and the requested engine supports the <c>CharacterSetName</c>
        /// parameter for <c>CreateDBInstance</c>, the response includes a list of supported character
        /// sets for each engine version.
        /// </para>
        ///  
        /// <para>
        /// For RDS Custom, the default is not to list supported character sets. If you enable
        /// this parameter, RDS Custom returns no results.
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
        /// Specifies whether to list the supported time zones for each engine version.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is enabled and the requested engine supports the <c>TimeZone</c>
        /// parameter for <c>CreateDBInstance</c>, the response includes a list of supported time
        /// zones for each engine version.
        /// </para>
        ///  
        /// <para>
        /// For RDS Custom, the default is not to list supported time zones. If you enable this
        /// parameter, RDS Custom returns no results.
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
        /// The maximum number of records to include in the response. If more than the <c>MaxRecords</c>
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