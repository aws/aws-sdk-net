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

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// The replication specification of the keyspace includes:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>regionList</code> - up to six Amazon Web Services Regions where the keyspace
    /// is replicated in.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>replicationStrategy</code> - the required value is <code>SINGLE_REGION</code>
    /// or <code>MULTI_REGION</code>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ReplicationSpecification
    {
        private List<string> _regionList = new List<string>();
        private Rs _replicationStrategy;

        /// <summary>
        /// Gets and sets the property RegionList. 
        /// <para>
        ///  The <code>regionList</code> can contain up to six Amazon Web Services Regions where
        /// the keyspace is replicated in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=6)]
        public List<string> RegionList
        {
            get { return this._regionList; }
            set { this._regionList = value; }
        }

        // Check to see if RegionList property is set
        internal bool IsSetRegionList()
        {
            return this._regionList != null && this._regionList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationStrategy. 
        /// <para>
        ///  The <code>replicationStrategy</code> of a keyspace, the required value is <code>SINGLE_REGION</code>
        /// or <code>MULTI_REGION</code>. 
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