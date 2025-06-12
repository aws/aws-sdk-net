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
    /// Container for the parameters to the DescribeDBInstances operation.
    /// Describes provisioned RDS instances. This API supports pagination.
    /// 
    ///  <note> 
    /// <para>
    /// This operation can also return information for Amazon Neptune DB instances and Amazon
    /// DocumentDB instances.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeDBInstancesRequest : AmazonRDSRequest
    {
        private string _dbInstanceIdentifier;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeDBInstancesRequest() { }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The user-supplied instance identifier or the Amazon Resource Name (ARN) of the DB
        /// instance. If this parameter is specified, information from only the specific DB instance
        /// is returned. This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the identifier of an existing DB instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A filter that specifies one or more DB instances to describe.
        /// </para>
        ///  
        /// <para>
        /// Supported Filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>db-cluster-id</c> - Accepts DB cluster identifiers and DB cluster Amazon Resource
        /// Names (ARNs). The results list only includes information about the DB instances associated
        /// with the DB clusters identified by these ARNs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db-instance-id</c> - Accepts DB instance identifiers and DB instance Amazon Resource
        /// Names (ARNs). The results list only includes information about the DB instances identified
        /// by these ARNs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dbi-resource-id</c> - Accepts DB instance resource identifiers. The results list
        /// only includes information about the DB instances identified by these DB instance resource
        /// identifiers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>domain</c> - Accepts Active Directory directory IDs. The results list only includes
        /// information about the DB instances associated with these domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>engine</c> - Accepts engine names. The results list only includes information
        /// about the DB instances for these engines.
        /// </para>
        ///  </li> </ul>
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
        /// An optional pagination token provided by a previous <c>DescribeDBInstances</c> request.
        /// If this parameter is specified, the response includes only records beyond the marker,
        /// up to the value specified by <c>MaxRecords</c>.
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
        /// in the response so that you can retrieve the remaining results.
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