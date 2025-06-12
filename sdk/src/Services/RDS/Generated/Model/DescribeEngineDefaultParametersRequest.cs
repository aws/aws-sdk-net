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
    /// Container for the parameters to the DescribeEngineDefaultParameters operation.
    /// Returns the default engine and system parameter information for the specified database
    /// engine.
    /// </summary>
    public partial class DescribeEngineDefaultParametersRequest : AmazonRDSRequest
    {
        private string _dbParameterGroupFamily;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeEngineDefaultParametersRequest() { }

        /// <summary>
        /// Instantiates DescribeEngineDefaultParametersRequest with the parameterized properties
        /// </summary>
        /// <param name="dbParameterGroupFamily">The name of the DB parameter group family. Valid Values: <ul> <li>  <c>aurora-mysql5.7</c>  </li> <li>  <c>aurora-mysql8.0</c>  </li> <li>  <c>aurora-postgresql10</c>  </li> <li>  <c>aurora-postgresql11</c>  </li> <li>  <c>aurora-postgresql12</c>  </li> <li>  <c>aurora-postgresql13</c>  </li> <li>  <c>aurora-postgresql14</c>  </li> <li>  <c>custom-oracle-ee-19</c>  </li> <li>  <c>custom-oracle-ee-cdb-19</c>  </li> <li>  <c>db2-ae</c>  </li> <li>  <c>db2-se</c>  </li> <li>  <c>mariadb10.2</c>  </li> <li>  <c>mariadb10.3</c>  </li> <li>  <c>mariadb10.4</c>  </li> <li>  <c>mariadb10.5</c>  </li> <li>  <c>mariadb10.6</c>  </li> <li>  <c>mysql5.7</c>  </li> <li>  <c>mysql8.0</c>  </li> <li>  <c>oracle-ee-19</c>  </li> <li>  <c>oracle-ee-cdb-19</c>  </li> <li>  <c>oracle-ee-cdb-21</c>  </li> <li>  <c>oracle-se2-19</c>  </li> <li>  <c>oracle-se2-cdb-19</c>  </li> <li>  <c>oracle-se2-cdb-21</c>  </li> <li>  <c>postgres10</c>  </li> <li>  <c>postgres11</c>  </li> <li>  <c>postgres12</c>  </li> <li>  <c>postgres13</c>  </li> <li>  <c>postgres14</c>  </li> <li>  <c>sqlserver-ee-11.0</c>  </li> <li>  <c>sqlserver-ee-12.0</c>  </li> <li>  <c>sqlserver-ee-13.0</c>  </li> <li>  <c>sqlserver-ee-14.0</c>  </li> <li>  <c>sqlserver-ee-15.0</c>  </li> <li>  <c>sqlserver-ex-11.0</c>  </li> <li>  <c>sqlserver-ex-12.0</c>  </li> <li>  <c>sqlserver-ex-13.0</c>  </li> <li>  <c>sqlserver-ex-14.0</c>  </li> <li>  <c>sqlserver-ex-15.0</c>  </li> <li>  <c>sqlserver-se-11.0</c>  </li> <li>  <c>sqlserver-se-12.0</c>  </li> <li>  <c>sqlserver-se-13.0</c>  </li> <li>  <c>sqlserver-se-14.0</c>  </li> <li>  <c>sqlserver-se-15.0</c>  </li> <li>  <c>sqlserver-web-11.0</c>  </li> <li>  <c>sqlserver-web-12.0</c>  </li> <li>  <c>sqlserver-web-13.0</c>  </li> <li>  <c>sqlserver-web-14.0</c>  </li> <li>  <c>sqlserver-web-15.0</c>  </li> </ul></param>
        public DescribeEngineDefaultParametersRequest(string dbParameterGroupFamily)
        {
            _dbParameterGroupFamily = dbParameterGroupFamily;
        }

        /// <summary>
        /// Gets and sets the property DBParameterGroupFamily. 
        /// <para>
        /// The name of the DB parameter group family.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aurora-mysql5.7</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-mysql8.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-postgresql10</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-postgresql11</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-postgresql12</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-postgresql13</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-postgresql14</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-oracle-ee-19</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-oracle-ee-cdb-19</c> 
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
        ///  <c>mariadb10.2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mariadb10.3</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mariadb10.4</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mariadb10.5</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mariadb10.6</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mysql5.7</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mysql8.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-ee-19</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-ee-cdb-19</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-ee-cdb-21</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se2-19</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se2-cdb-19</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se2-cdb-21</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>postgres10</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>postgres11</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>postgres12</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>postgres13</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>postgres14</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ee-11.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ee-12.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ee-13.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ee-14.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ee-15.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ex-11.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ex-12.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ex-13.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ex-14.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ex-15.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-se-11.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-se-12.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-se-13.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-se-14.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-se-15.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-web-11.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-web-12.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-web-13.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-web-14.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-web-15.0</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Filters. 
        /// <para>
        /// A filter that specifies one or more parameters to describe.
        /// </para>
        ///  
        /// <para>
        /// The only supported filter is <c>parameter-name</c>. The results list only includes
        /// information about the parameters with these names.
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
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <c>DescribeEngineDefaultParameters</c>
        /// request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by <c>MaxRecords</c>.
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
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <c>MaxRecords</c> value, a pagination token called a marker is included
        /// in the response so you can retrieve the remaining results.
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