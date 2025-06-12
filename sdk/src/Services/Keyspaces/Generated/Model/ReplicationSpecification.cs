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
    /// The replication specification of the keyspace includes:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>regionList</c> - the Amazon Web Services Regions where the keyspace is replicated
    /// in.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>replicationStrategy</c> - the required value is <c>SINGLE_REGION</c> or <c>MULTI_REGION</c>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ReplicationSpecification
    {
        private List<string> _regionList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Rs _replicationStrategy;

        /// <summary>
        /// Gets and sets the property RegionList. 
        /// <para>
        ///  The <c>regionList</c> contains the Amazon Web Services Regions where the keyspace
        /// is replicated in. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2)]
        public List<string> RegionList
        {
            get { return this._regionList; }
            set { this._regionList = value; }
        }

        // Check to see if RegionList property is set
        internal bool IsSetRegionList()
        {
            return this._regionList != null && (this._regionList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicationStrategy. 
        /// <para>
        ///  The <c>replicationStrategy</c> of a keyspace, the required value is <c>SINGLE_REGION</c>
        /// or <c>MULTI_REGION</c>. 
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

    }
}