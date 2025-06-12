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
    /// Container for the parameters to the DescribeNodeConfigurationOptions operation.
    /// Returns properties of possible node configurations such as node type, number of nodes,
    /// and disk usage for the specified action type.
    /// </summary>
    public partial class DescribeNodeConfigurationOptionsRequest : AmazonRedshiftRequest
    {
        private ActionType _actionType;
        private string _clusterIdentifier;
        private List<NodeConfigurationOptionsFilter> _filters = AWSConfigs.InitializeCollections ? new List<NodeConfigurationOptionsFilter>() : null;
        private string _marker;
        private int? _maxRecords;
        private string _ownerAccount;
        private string _snapshotArn;
        private string _snapshotIdentifier;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The action type to evaluate for possible node configurations. Specify "restore-cluster"
        /// to get configuration combinations based on an existing snapshot. Specify "recommend-node-config"
        /// to get configuration recommendations based on an existing cluster or snapshot. Specify
        /// "resize-cluster" to get configuration combinations for elastic resize based on an
        /// existing cluster. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionType ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster to evaluate for possible node configurations.
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
        /// Gets and sets the property Filters. 
        /// <para>
        /// A set of name, operator, and value items to filter the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeConfigurationOptionsFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <a>DescribeNodeConfigurationOptions</a> request exceed
        /// the value specified in <c>MaxRecords</c>, Amazon Web Services returns a value in the
        /// <c>Marker</c> field of the response. You can retrieve the next set of response records
        /// by providing the returned marker value in the <c>Marker</c> parameter and retrying
        /// the request. 
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
        /// Default: <c>500</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 100, maximum 500.
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
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The Amazon Web Services account used to create or copy the snapshot. Required if you
        /// are restoring a snapshot you do not own, optional if you own the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot associated with the message to describe
        /// node configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotArn
        {
            get { return this._snapshotArn; }
            set { this._snapshotArn = value; }
        }

        // Check to see if SnapshotArn property is set
        internal bool IsSetSnapshotArn()
        {
            return this._snapshotArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// The identifier of the snapshot to evaluate for possible node configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotIdentifier
        {
            get { return this._snapshotIdentifier; }
            set { this._snapshotIdentifier = value; }
        }

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this._snapshotIdentifier != null;
        }

    }
}