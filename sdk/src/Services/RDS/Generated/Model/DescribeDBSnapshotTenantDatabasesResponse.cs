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
    /// This is the response object from the DescribeDBSnapshotTenantDatabases operation.
    /// </summary>
    public partial class DescribeDBSnapshotTenantDatabasesResponse : AmazonWebServiceResponse
    {
        private List<DBSnapshotTenantDatabase> _dbSnapshotTenantDatabases = AWSConfigs.InitializeCollections ? new List<DBSnapshotTenantDatabase>() : null;
        private string _marker;

        /// <summary>
        /// Gets and sets the property DBSnapshotTenantDatabases. 
        /// <para>
        /// A list of DB snapshot tenant databases.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBSnapshotTenantDatabase> DBSnapshotTenantDatabases
        {
            get { return this._dbSnapshotTenantDatabases; }
            set { this._dbSnapshotTenantDatabases = value; }
        }

        // Check to see if DBSnapshotTenantDatabases property is set
        internal bool IsSetDBSnapshotTenantDatabases()
        {
            return this._dbSnapshotTenantDatabases != null && (this._dbSnapshotTenantDatabases.Count > 0 || !AWSConfigs.InitializeCollections); 
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

    }
}