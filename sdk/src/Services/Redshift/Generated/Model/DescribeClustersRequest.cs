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
    /// Container for the parameters to the DescribeClusters operation.
    /// Returns properties of provisioned clusters including general cluster properties, cluster
    /// database properties, maintenance and backup properties, and security and access properties.
    /// This operation supports pagination. For more information about managing clusters,
    /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
    /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// 
    ///  
    /// <para>
    /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
    /// all clusters that match any combination of the specified keys and values. For example,
    /// if you have <c>owner</c> and <c>environment</c> for tag keys, and <c>admin</c> and
    /// <c>test</c> for tag values, all clusters that have any combination of those values
    /// are returned.
    /// </para>
    ///  
    /// <para>
    /// If both tag keys and values are omitted from the request, clusters are returned regardless
    /// of whether they have tag keys or values associated with them.
    /// </para>
    /// </summary>
    public partial class DescribeClustersRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private string _marker;
        private int? _maxRecords;
        private List<string> _tagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _tagValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of a cluster whose properties you are requesting. This parameter
        /// is case sensitive.
        /// </para>
        ///  
        /// <para>
        /// The default is that all clusters defined for an account are returned.
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
        /// An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <a>DescribeClusters</a> request exceed the value specified
        /// in <c>MaxRecords</c>, Amazon Web Services returns a value in the <c>Marker</c> field
        /// of the response. You can retrieve the next set of response records by providing the
        /// returned marker value in the <c>Marker</c> parameter and retrying the request. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: You can specify either the <b>ClusterIdentifier</b> parameter or the
        /// <b>Marker</b> parameter, but not both. 
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
        /// response records exceeds the specified <c>MaxRecords</c> value, a value is returned
        /// in a <c>marker</c> field of the response. You can retrieve the next set of records
        /// by retrying the command with the returned marker value. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>100</c> 
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

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// A tag key or keys for which you want to return all matching clusters that are associated
        /// with the specified key or keys. For example, suppose that you have clusters that are
        /// tagged with keys called <c>owner</c> and <c>environment</c>. If you specify both of
        /// these tag keys in the request, Amazon Redshift returns a response with the clusters
        /// that have either or both of these tag keys associated with them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && (this._tagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagValues. 
        /// <para>
        /// A tag value or values for which you want to return all matching clusters that are
        /// associated with the specified tag value or values. For example, suppose that you have
        /// clusters that are tagged with values called <c>admin</c> and <c>test</c>. If you specify
        /// both of these tag values in the request, Amazon Redshift returns a response with the
        /// clusters that have either or both of these tag values associated with them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TagValues
        {
            get { return this._tagValues; }
            set { this._tagValues = value; }
        }

        // Check to see if TagValues property is set
        internal bool IsSetTagValues()
        {
            return this._tagValues != null && (this._tagValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}