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
    /// Container for the parameters to the DescribeClusters operation.
    /// Returns properties of provisioned clusters including general cluster properties,
    /// cluster database properties,            maintenance and backup properties, and security
    /// and access properties. This operation supports pagination.             For more information
    /// about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
    /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>.
    /// </summary>
    public partial class DescribeClustersRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private string _marker;
        private int? _maxRecords;


        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        ///             The unique identifier of a cluster whose properties you are requesting.
        ///            This parameter is case sensitive.        
        /// </para>
        ///                 
        /// <para>
        /// The default is that all clusters defined for an account are returned.        
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
        ///             An optional parameter that specifies the starting point to return a set
        /// of response records.             When the results of a <a>DescribeClusters</a> request
        /// exceed the value specified in <code>MaxRecords</code>,             AWS returns a value
        /// in the <code>Marker</code> field of the response. You can retrieve the next set of
        ///             response records by providing the returned marker value in the <code>Marker</code>
        /// parameter and             retrying the request.        
        /// </para>
        ///         
        /// <para>
        ///             Constraints: You can specify either the <b>ClusterIdentifier</b> parameter
        /// or the <b>Marker</b> parameter, but not both.        
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

    }
}