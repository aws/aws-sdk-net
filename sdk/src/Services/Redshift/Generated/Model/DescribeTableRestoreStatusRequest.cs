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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTableRestoreStatus operation.
    /// Lists the status of one or more table restore requests made using the <a>RestoreTableFromClusterSnapshot</a>
    /// API action. If you don't specify a value for the <c>TableRestoreRequestId</c> parameter,
    /// then <c>DescribeTableRestoreStatus</c> returns the status of all table restore requests
    /// ordered by the date and time of the request in ascending order. Otherwise <c>DescribeTableRestoreStatus</c>
    /// returns the status of the table specified by <c>TableRestoreRequestId</c>.
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
        [AWSProperty(Max=2147483647)]
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
        /// An optional pagination token provided by a previous <c>DescribeTableRestoreStatus</c>
        /// request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by the <c>MaxRecords</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// in the response so that the remaining results can be retrieved.
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

        /// <summary>
        /// Gets and sets the property TableRestoreRequestId. 
        /// <para>
        /// The identifier of the table restore request to return status for. If you don't specify
        /// a <c>TableRestoreRequestId</c> value, then <c>DescribeTableRestoreStatus</c> returns
        /// the status of all in-progress table restore requests.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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