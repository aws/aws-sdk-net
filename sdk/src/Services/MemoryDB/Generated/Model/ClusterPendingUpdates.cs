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
    /// A list of updates being applied to the cluster
    /// </summary>
    public partial class ClusterPendingUpdates
    {
        private ACLsUpdateStatus _acLs;
        private ReshardingStatus _resharding;
        private List<PendingModifiedServiceUpdate> _serviceUpdates = AWSConfigs.InitializeCollections ? new List<PendingModifiedServiceUpdate>() : null;

        /// <summary>
        /// Gets and sets the property ACLs. 
        /// <para>
        /// A list of ACLs associated with the cluster that are being updated
        /// </para>
        /// </summary>
        public ACLsUpdateStatus ACLs
        {
            get { return this._acLs; }
            set { this._acLs = value; }
        }

        // Check to see if ACLs property is set
        internal bool IsSetACLs()
        {
            return this._acLs != null;
        }

        /// <summary>
        /// Gets and sets the property Resharding. 
        /// <para>
        /// The status of an online resharding operation.
        /// </para>
        /// </summary>
        public ReshardingStatus Resharding
        {
            get { return this._resharding; }
            set { this._resharding = value; }
        }

        // Check to see if Resharding property is set
        internal bool IsSetResharding()
        {
            return this._resharding != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdates. 
        /// <para>
        /// A list of service updates being applied to the cluster
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PendingModifiedServiceUpdate> ServiceUpdates
        {
            get { return this._serviceUpdates; }
            set { this._serviceUpdates = value; }
        }

        // Check to see if ServiceUpdates property is set
        internal bool IsSetServiceUpdates()
        {
            return this._serviceUpdates != null && (this._serviceUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}