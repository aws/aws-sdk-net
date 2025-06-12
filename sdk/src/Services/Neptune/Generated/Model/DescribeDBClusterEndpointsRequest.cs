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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBClusterEndpoints operation.
    /// Returns information about endpoints for an Amazon Neptune DB cluster.
    /// 
    ///  <note> 
    /// <para>
    /// This operation can also return information for Amazon RDS clusters and Amazon DocDB
    /// clusters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeDBClusterEndpointsRequest : AmazonNeptuneRequest
    {
        private string _dbClusterEndpointIdentifier;
        private string _dbClusterIdentifier;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Gets and sets the property DBClusterEndpointIdentifier. 
        /// <para>
        /// The identifier of the endpoint to describe. This parameter is stored as a lowercase
        /// string.
        /// </para>
        /// </summary>
        public string DBClusterEndpointIdentifier
        {
            get { return this._dbClusterEndpointIdentifier; }
            set { this._dbClusterEndpointIdentifier = value; }
        }

        // Check to see if DBClusterEndpointIdentifier property is set
        internal bool IsSetDBClusterEndpointIdentifier()
        {
            return this._dbClusterEndpointIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier of the DB cluster associated with the endpoint. This parameter
        /// is stored as a lowercase string.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A set of name-value pairs that define which endpoints to include in the output. The
        /// filters are specified as name-value pairs, in the format <c>Name=<i>endpoint_type</i>,Values=<i>endpoint_type1</i>,<i>endpoint_type2</i>,...</c>.
        /// <c>Name</c> can be one of: <c>db-cluster-endpoint-type</c>, <c>db-cluster-endpoint-custom-type</c>,
        /// <c>db-cluster-endpoint-id</c>, <c>db-cluster-endpoint-status</c>. <c>Values</c> for
        /// the <c> db-cluster-endpoint-type</c> filter can be one or more of: <c>reader</c>,
        /// <c>writer</c>, <c>custom</c>. <c>Values</c> for the <c>db-cluster-endpoint-custom-type</c>
        /// filter can be one or more of: <c>reader</c>, <c>any</c>. <c>Values</c> for the <c>db-cluster-endpoint-status</c>
        /// filter can be one or more of: <c>available</c>, <c>creating</c>, <c>deleting</c>,
        /// <c>inactive</c>, <c>modifying</c>. 
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
        /// An optional pagination token provided by a previous <c>DescribeDBClusterEndpoints</c>
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