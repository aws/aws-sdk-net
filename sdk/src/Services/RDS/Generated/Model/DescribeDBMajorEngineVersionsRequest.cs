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
    /// Container for the parameters to the DescribeDBMajorEngineVersions operation.
    /// Describes the properties of specific major versions of DB engines.
    /// </summary>
    public partial class DescribeDBMajorEngineVersionsRequest : AmazonRDSRequest
    {
        private string _engine;
        private string _majorEngineVersion;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine to return major version details for.
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
        ///  <c>custom-sqlserver-ee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-sqlserver-se</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>custom-sqlserver-web</c> 
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
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property MajorEngineVersion. 
        /// <para>
        /// A specific database major engine version to return details for.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>8.4</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string MajorEngineVersion
        {
            get { return this._majorEngineVersion; }
            set { this._majorEngineVersion = value; }
        }

        // Check to see if MajorEngineVersion property is set
        internal bool IsSetMajorEngineVersion()
        {
            return this._majorEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <c>MaxRecords</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=340)]
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
        /// </summary>
        [AWSProperty(Min=20, Max=100)]
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