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
    /// Container for the parameters to the DescribeOrderableClusterOptions operation.
    /// Returns a list of orderable cluster options. Before you create a         new cluster
    /// you can use this operation to find what options are         available, such as the
    /// EC2 Availability Zones (AZ) in the specific         AWS region that you can specify,
    ///         and the node types you can request. The node types differ by available   
    ///      storage, memory, CPU and price. With the cost involved you might want to    
    ///     obtain a list of cluster options in the specific region and specify values   
    ///      when creating a cluster.         For more information about managing clusters,
    /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
    /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>
    /// </summary>
    public partial class DescribeOrderableClusterOptionsRequest : AmazonRedshiftRequest
    {
        private string _clusterVersion;
        private string _marker;
        private int? _maxRecords;
        private string _nodeType;


        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        ///  The version filter value. Specify this parameter to show only             the available
        /// offerings matching the specified version. 
        /// </para>
        ///         
        /// <para>
        /// Default: All versions.
        /// </para>
        ///         
        /// <para>
        /// Constraints: Must be one of the version returned from <a>DescribeClusterVersions</a>.
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
        ///             An optional parameter that specifies the starting point to return a set
        /// of response records.             When the results of a <a>DescribeOrderableClusterOptions</a>
        /// request exceed the value specified in <code>MaxRecords</code>,             AWS returns
        /// a value in the <code>Marker</code> field of the response. You can retrieve the next
        /// set of             response records by providing the returned marker value in the
        /// <code>Marker</code> parameter and             retrying the request.        
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
        ///             The maximum number of response records to return in each call.       
        ///      If the number of remaining response records exceeds the specified <code>MaxRecords</code>
        /// value,             a value is returned in a <code>marker</code> field of the response.
        ///             You can retrieve the next set of records by retrying the command with
        /// the returned marker value.        
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


        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        ///  The node type filter value. Specify this parameter to show only the available offerings
        /// matching the specified node type. 
        /// </para>
        /// </summary>
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

    }
}