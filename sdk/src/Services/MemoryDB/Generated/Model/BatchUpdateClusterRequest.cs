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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdateCluster operation.
    /// Apply the service update to a list of clusters supplied. For more information on service
    /// updates and applying them, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/managing-updates.html#applying-updates">Applying
    /// the service updates</a>.
    /// </summary>
    public partial class BatchUpdateClusterRequest : AmazonMemoryDBRequest
    {
        private List<string> _clusterNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ServiceUpdateRequest _serviceUpdate;

        /// <summary>
        /// Gets and sets the property ClusterNames. 
        /// <para>
        /// The cluster names to apply the updates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=20)]
        public List<string> ClusterNames
        {
            get { return this._clusterNames; }
            set { this._clusterNames = value; }
        }

        // Check to see if ClusterNames property is set
        internal bool IsSetClusterNames()
        {
            return this._clusterNames != null && (this._clusterNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdate. 
        /// <para>
        /// The unique ID of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateRequest ServiceUpdate
        {
            get { return this._serviceUpdate; }
            set { this._serviceUpdate = value; }
        }

        // Check to see if ServiceUpdate property is set
        internal bool IsSetServiceUpdate()
        {
            return this._serviceUpdate != null;
        }

    }
}