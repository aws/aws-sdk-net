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
    /// Container for the parameters to the DescribeClusterDbRevisions operation.
    /// Returns an array of <c>ClusterDbRevision</c> objects.
    /// </summary>
    public partial class DescribeClusterDbRevisionsRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// A unique identifier for a cluster whose <c>ClusterDbRevisions</c> you are requesting.
        /// This parameter is case sensitive. All clusters defined for an account are returned
        /// by default.
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
        /// An optional parameter that specifies the starting point for returning a set of response
        /// records. When the results of a <c>DescribeClusterDbRevisions</c> request exceed the
        /// value specified in <c>MaxRecords</c>, Amazon Redshift returns a value in the <c>marker</c>
        /// field of the response. You can retrieve the next set of response records by providing
        /// the returned <c>marker</c> value in the <c>marker</c> parameter and retrying the request.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Constraints: You can specify either the <c>ClusterIdentifier</c> parameter, or the
        /// <c>marker</c> parameter, but not both.
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
        /// The maximum number of response records to return in each call. If the number of remaining
        /// response records exceeds the specified MaxRecords value, a value is returned in the
        /// <c>marker</c> field of the response. You can retrieve the next set of response records
        /// by providing the returned <c>marker</c> value in the <c>marker</c> parameter and retrying
        /// the request. 
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 20, maximum 100.
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