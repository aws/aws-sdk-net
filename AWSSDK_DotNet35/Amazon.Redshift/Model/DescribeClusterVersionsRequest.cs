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
    /// Container for the parameters to the DescribeClusterVersions operation.
    /// Returns  descriptions of the available Amazon Redshift cluster versions. You can
    /// call this     operation even before creating any clusters to learn more about the
    /// Amazon Redshift versions.     For more information about managing clusters, go to
    /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
    /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>
    /// </summary>
    public partial class DescribeClusterVersionsRequest : AmazonRedshiftRequest
    {
        private string _clusterParameterGroupFamily;
        private string _clusterVersion;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Gets and sets the property ClusterParameterGroupFamily. 
        /// <para>
        ///     The name of a specific cluster parameter group family to return details for. 
        ///   
        /// </para>
        ///        
        /// <para>
        /// Constraints:
        /// </para>
        ///        <ul>           <li>Must be 1 to 255 alphanumeric characters</li>          
        /// <li>First character must be a letter</li>           <li>Cannot end with a hyphen or
        /// contain two consecutive hyphens</li>       </ul>
        /// </summary>
        public string ClusterParameterGroupFamily
        {
            get { return this._clusterParameterGroupFamily; }
            set { this._clusterParameterGroupFamily = value; }
        }

        // Check to see if ClusterParameterGroupFamily property is set
        internal bool IsSetClusterParameterGroupFamily()
        {
            return this._clusterParameterGroupFamily != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        ///     The specific cluster version to return.    
        /// </para>
        ///        
        /// <para>
        /// Example: <code>1.0</code>
        /// </para>
        /// </summary>
        public string ClusterVersion
        {
            get { return this._clusterVersion; }
            set { this._clusterVersion = value; }
        }

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this._clusterVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///            An optional parameter that specifies the starting point to return a set
        /// of response records.            When the results of a <a>DescribeClusterVersions</a>
        /// request exceed the value specified in <code>MaxRecords</code>,            AWS returns
        /// a value in the <code>Marker</code> field of the response. You can retrieve the next
        /// set of            response records by providing the returned marker value in the <code>Marker</code>
        /// parameter and            retrying the request.       
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
        ///            The maximum number of response records to return in each call.        
        ///    If the number of remaining response records exceeds the specified <code>MaxRecords</code>
        /// value,            a value is returned in a <code>marker</code> field of the response.
        ///            You can retrieve the next set of records by retrying the command with the
        /// returned marker value.       
        /// </para>
        ///        
        /// <para>
        /// Default: <code>100</code>
        /// </para>
        ///        
        /// <para>
        /// Constraints: minimum 20, maximum 100.
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