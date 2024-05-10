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
    /// This is the response object from the DescribeTenantDatabases operation.
    /// </summary>
    public partial class DescribeTenantDatabasesResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<TenantDatabase> _tenantDatabases = AWSConfigs.InitializeCollections ? new List<TenantDatabase>() : null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <c>DescribeTenantDatabases</c>
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
        /// Gets and sets the property TenantDatabases. 
        /// <para>
        /// An array of the tenant databases requested by the <c>DescribeTenantDatabases</c> operation.
        /// </para>
        /// </summary>
        public List<TenantDatabase> TenantDatabases
        {
            get { return this._tenantDatabases; }
            set { this._tenantDatabases = value; }
        }

        // Check to see if TenantDatabases property is set
        internal bool IsSetTenantDatabases()
        {
            return this._tenantDatabases != null && (this._tenantDatabases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}