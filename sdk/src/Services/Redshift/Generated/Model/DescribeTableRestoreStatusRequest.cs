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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTableRestoreStatus operation.
    /// Lists the status of one or more table restore requests made using the <a>RestoreTableFromClusterSnapshot</a>
    /// API action. If you don't specify a value for the <code>TableRestoreRequestId</code>
    /// parameter, then <code>DescribeTableRestoreStatus</code> returns the status of all
    /// in-progress table restore requests. Otherwise <code>DescribeTableRestoreStatus</code>
    /// returns the status of the table specified by <code>TableRestoreRequestId</code>.
    /// </summary>
    public partial class DescribeTableRestoreStatusRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private string _marker;
        private int? _maxRecords;
        private string _tableRestoreRequestId;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The Amazon Redshift cluster that the table is being restored to.
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <code>DescribeTableRestoreStatus</code>
        /// request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by the <code>MaxRecords</code> parameter.
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
        /// included in the response so that the remaining results can be retrieved.
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

        /// <summary>
        /// Gets and sets the property TableRestoreRequestId. 
        /// <para>
        /// The identifier of the table restore request to return status for. If you don't specify
        /// a <code>TableRestoreRequestId</code> value, then <code>DescribeTableRestoreStatus</code>
        /// returns the status of all in-progress table restore requests.
        /// </para>
        /// </summary>
        public string TableRestoreRequestId
        {
            get { return this._tableRestoreRequestId; }
            set { this._tableRestoreRequestId = value; }
        }

        // Check to see if TableRestoreRequestId property is set
        internal bool IsSetTableRestoreRequestId()
        {
            return this._tableRestoreRequestId != null;
        }

    }
}