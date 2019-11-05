/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstallationMedia operation.
    /// Describes the available installation media for a DB engine that requires an on-premises
    /// customer provided license, such as Microsoft SQL Server.
    /// </summary>
    public partial class DescribeInstallationMediaRequest : AmazonRDSRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private string _installationMediaId;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A filter that specifies one or more installation media to describe. Supported filters
        /// include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>custom-availability-zone-id</code> - Accepts custom Availability Zone (AZ)
        /// identifiers. The results list includes information about only the custom AZs identified
        /// by these identifiers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>engine</code> - Accepts database engines. The results list includes information
        /// about only the database engines identified by these identifiers.
        /// </para>
        ///  
        /// <para>
        /// For more information about the valid engines for installation media, see <a>ImportInstallationMedia</a>.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property InstallationMediaId. 
        /// <para>
        /// The installation medium ID.
        /// </para>
        /// </summary>
        public string InstallationMediaId
        {
            get { return this._installationMediaId; }
            set { this._installationMediaId = value; }
        }

        // Check to see if InstallationMediaId property is set
        internal bool IsSetInstallationMediaId()
        {
            return this._installationMediaId != null;
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
        /// An optional pagination token provided by a previous DescribeInstallationMedia request.
        /// If this parameter is specified, the response includes only records beyond the marker,
        /// up to the value specified by <code>MaxRecords</code>.
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