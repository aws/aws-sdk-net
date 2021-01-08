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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Represents the output of <a>DescribeDBSubnetGroups</a>.
    /// </summary>
    public partial class DescribeDBSubnetGroupsResponse : AmazonWebServiceResponse
    {
        private List<DBSubnetGroup> _dbSubnetGroups = new List<DBSubnetGroup>();
        private string _marker;

        /// <summary>
        /// Gets and sets the property DBSubnetGroups. 
        /// <para>
        /// Detailed information about one or more subnet groups.
        /// </para>
        /// </summary>
        public List<DBSubnetGroup> DBSubnetGroups
        {
            get { return this._dbSubnetGroups; }
            set { this._dbSubnetGroups = value; }
        }

        // Check to see if DBSubnetGroups property is set
        internal bool IsSetDBSubnetGroups()
        {
            return this._dbSubnetGroups != null && this._dbSubnetGroups.Count > 0; 
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

    }
}