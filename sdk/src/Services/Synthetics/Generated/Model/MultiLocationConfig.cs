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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// A structure that contains information about the multi-location configuration of a
    /// canary, including whether it is a primary or replica, the primary location, and the
    /// list of replicas.
    /// </summary>
    public partial class MultiLocationConfig
    {
        private LocationType _locationType;
        private string _primaryLocation;
        private List<Replica> _replicas = AWSConfigs.InitializeCollections ? new List<Replica>() : null;
        private ReplicationState _replicationState;

        /// <summary>
        /// Gets and sets the property LocationType. 
        /// <para>
        /// Indicates whether this canary is the <c>Primary</c> or a <c>Replica</c> in the multi-location
        /// configuration.
        /// </para>
        /// </summary>
        public LocationType LocationType
        {
            get { return this._locationType; }
            set { this._locationType = value; }
        }

        // Check to see if LocationType property is set
        internal bool IsSetLocationType()
        {
            return this._locationType != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryLocation. 
        /// <para>
        /// The Amazon Web Services Region where the primary canary is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string PrimaryLocation
        {
            get { return this._primaryLocation; }
            set { this._primaryLocation = value; }
        }

        // Check to see if PrimaryLocation property is set
        internal bool IsSetPrimaryLocation()
        {
            return this._primaryLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Replicas. 
        /// <para>
        /// A list of replicas for this canary. This field is present only for the primary location
        /// canary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Replica> Replicas
        {
            get { return this._replicas; }
            set { this._replicas = value; }
        }

        // Check to see if Replicas property is set
        internal bool IsSetReplicas()
        {
            return this._replicas != null && (this._replicas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicationState. 
        /// <para>
        /// The overall replication state of the canary across all replica locations. This field
        /// is present only for the primary location canary. Valid values are <c>InProgress</c>,
        /// <c>InSync</c>, and <c>Inconsistent</c>.
        /// </para>
        /// </summary>
        public ReplicationState ReplicationState
        {
            get { return this._replicationState; }
            set { this._replicationState = value; }
        }

        // Check to see if ReplicationState property is set
        internal bool IsSetReplicationState()
        {
            return this._replicationState != null;
        }

    }
}