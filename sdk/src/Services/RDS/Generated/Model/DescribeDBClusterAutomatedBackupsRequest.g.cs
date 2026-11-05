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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeDBClusterAutomatedBackups operation. Displays
    /// backups for both current and deleted DB clusters. For example, use this operation
    /// to find details about automated backups for previously deleted clusters. Current clusters
    /// are returned for both the <c>DescribeDBClusterAutomatedBackups</c> and <c>DescribeDBClusters</c>
    /// operations. <para> All parameters are optional. </para>
    /// </summary>
    public partial class DescribeDBClusterAutomatedBackupsRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// (Optional) The user-supplied DB cluster identifier. If this parameter is specified,
        /// it must match the identifier of an existing DB cluster. It returns information from
        /// the specific DB cluster's automated backup. This parameter isn't case-sensitive.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DbClusterResourceId. 
        /// <para>
        /// The resource ID of the DB cluster that is the source of the automated backup. This
        /// parameter isn't case-sensitive.
        /// </para>
        /// </summary>
        public string DbClusterResourceId { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterResourceId property is set.
        /// </summary>
        internal bool IsSetDbClusterResourceId() => this.DbClusterResourceId != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A filter that specifies which resources to return based on status.
        /// </para>
        ///  
        /// <para>
        /// Supported filters are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>status</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>retained</c> - Automated backups for deleted clusters and after backup replication
        /// is stopped.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>db-cluster-id</c> - Accepts DB cluster identifiers and Amazon Resource Names (ARNs).
        /// The results list includes only information about the DB cluster automated backups
        /// identified by these ARNs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db-cluster-resource-id</c> - Accepts DB resource identifiers and Amazon Resource
        /// Names (ARNs). The results list includes only information about the DB cluster resources
        /// identified by these ARNs.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Returns all resources by default. The status for each resource is specified in the
        /// response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token provided in the previous request. If this parameter is specified
        /// the response includes only records beyond the marker, up to <c>MaxRecords</c>.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <c>MaxRecords</c> value, a pagination token called a marker is included
        /// in the response so that you can retrieve the remaining results.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;
    }
}
