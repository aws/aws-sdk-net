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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Represents the properties of a keyspace.
    /// </summary>
    public partial class KeyspaceSummary
    {
        private string _keyspaceName;
        private List<string> _replicationRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Rs _replicationStrategy;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        /// The name of the keyspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string KeyspaceName
        {
            get { return this._keyspaceName; }
            set { this._keyspaceName = value; }
        }

        // Check to see if KeyspaceName property is set
        internal bool IsSetKeyspaceName()
        {
            return this._keyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationRegions. 
        /// <para>
        ///  If the <c>replicationStrategy</c> of the keyspace is <c>MULTI_REGION</c>, a list
        /// of replication Regions is returned. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2)]
        public List<string> ReplicationRegions
        {
            get { return this._replicationRegions; }
            set { this._replicationRegions = value; }
        }

        // Check to see if ReplicationRegions property is set
        internal bool IsSetReplicationRegions()
        {
            return this._replicationRegions != null && (this._replicationRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicationStrategy. 
        /// <para>
        ///  This property specifies if a keyspace is a single Region keyspace or a multi-Region
        /// keyspace. The available values are <c>SINGLE_REGION</c> or <c>MULTI_REGION</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public Rs ReplicationStrategy
        {
            get { return this._replicationStrategy; }
            set { this._replicationStrategy = value; }
        }

        // Check to see if ReplicationStrategy property is set
        internal bool IsSetReplicationStrategy()
        {
            return this._replicationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The unique identifier of the keyspace in the format of an Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1000)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}