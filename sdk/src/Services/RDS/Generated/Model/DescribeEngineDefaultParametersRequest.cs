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
    /// Container for the parameters to the DescribeEngineDefaultParameters operation.
    /// Returns the default engine and system parameter information for the specified database
    /// engine.
    /// </summary>
    public partial class DescribeEngineDefaultParametersRequest : AmazonRDSRequest
    {
        private string _dbParameterGroupFamily;
        private List<Filter> _filters = new List<Filter>();
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeEngineDefaultParametersRequest() { }

        /// <summary>
        /// Instantiates DescribeEngineDefaultParametersRequest with the parameterized properties
        /// </summary>
        /// <param name="dbParameterGroupFamily">The name of the DB parameter group family. Valid Values: <ul> <li>  <code>aurora5.6</code>  </li> <li>  <code>aurora-mysql5.7</code>  </li> <li>  <code>aurora-mysql8.0</code>  </li> <li>  <code>aurora-postgresql10</code>  </li> <li>  <code>aurora-postgresql11</code>  </li> <li>  <code>aurora-postgresql12</code>  </li> <li>  <code>aurora-postgresql13</code>  </li> <li>  <code>aurora-postgresql14</code>  </li> <li>  <code>custom-oracle-ee-19</code>  </li> <li>  <code>mariadb10.2</code>  </li> <li>  <code>mariadb10.3</code>  </li> <li>  <code>mariadb10.4</code>  </li> <li>  <code>mariadb10.5</code>  </li> <li>  <code>mariadb10.6</code>  </li> <li>  <code>mysql5.7</code>  </li> <li>  <code>mysql8.0</code>  </li> <li>  <code>oracle-ee-19</code>  </li> <li>  <code>oracle-ee-cdb-19</code>  </li> <li>  <code>oracle-ee-cdb-21</code>  </li> <li>  <code>oracle-se2-19</code>  </li> <li>  <code>oracle-se2-cdb-19</code>  </li> <li>  <code>oracle-se2-cdb-21</code>  </li> <li>  <code>postgres10</code>  </li> <li>  <code>postgres11</code>  </li> <li>  <code>postgres12</code>  </li> <li>  <code>postgres13</code>  </li> <li>  <code>postgres14</code>  </li> <li>  <code>sqlserver-ee-11.0</code>  </li> <li>  <code>sqlserver-ee-12.0</code>  </li> <li>  <code>sqlserver-ee-13.0</code>  </li> <li>  <code>sqlserver-ee-14.0</code>  </li> <li>  <code>sqlserver-ee-15.0</code>  </li> <li>  <code>sqlserver-ex-11.0</code>  </li> <li>  <code>sqlserver-ex-12.0</code>  </li> <li>  <code>sqlserver-ex-13.0</code>  </li> <li>  <code>sqlserver-ex-14.0</code>  </li> <li>  <code>sqlserver-ex-15.0</code>  </li> <li>  <code>sqlserver-se-11.0</code>  </li> <li>  <code>sqlserver-se-12.0</code>  </li> <li>  <code>sqlserver-se-13.0</code>  </li> <li>  <code>sqlserver-se-14.0</code>  </li> <li>  <code>sqlserver-se-15.0</code>  </li> <li>  <code>sqlserver-web-11.0</code>  </li> <li>  <code>sqlserver-web-12.0</code>  </li> <li>  <code>sqlserver-web-13.0</code>  </li> <li>  <code>sqlserver-web-14.0</code>  </li> <li>  <code>sqlserver-web-15.0</code>  </li> </ul></param>
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
        ///  <code>aurora5.6</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-mysql5.7</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-mysql8.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-postgresql10</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-postgresql11</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-postgresql12</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-postgresql13</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-postgresql14</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>custom-oracle-ee-19</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mariadb10.2</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mariadb10.3</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mariadb10.4</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mariadb10.5</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mariadb10.6</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mysql5.7</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mysql8.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-ee-19</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-ee-cdb-19</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-ee-cdb-21</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-se2-19</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-se2-cdb-19</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-se2-cdb-21</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>postgres10</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>postgres11</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>postgres12</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>postgres13</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>postgres14</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ee-11.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ee-12.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ee-13.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ee-14.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ee-15.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ex-11.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ex-12.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ex-13.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ex-14.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ex-15.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-se-11.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-se-12.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-se-13.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-se-14.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-se-15.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-web-11.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-web-12.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-web-13.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-web-14.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-web-15.0</code> 
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
        /// This parameter isn't currently supported.
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
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <code>DescribeEngineDefaultParameters</code>
        /// request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by <code>MaxRecords</code>.
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
        /// the specified <code>MaxRecords</code> value, a pagination token called a marker is
        /// included in the response so you can retrieve the remaining results.
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