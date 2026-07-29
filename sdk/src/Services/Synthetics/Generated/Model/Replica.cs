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
    /// A structure that contains information about a canary replica in a specific location.
    /// </summary>
    public partial class Replica
    {
        private CanaryState _canaryState;
        private DateTime? _lastModified;
        private string _location;
        private ReplicationStatus _replicationStatus;
        private VpcConfigOutput _vpcConfig;

        /// <summary>
        /// Gets and sets the property CanaryState. 
        /// <para>
        /// The current state of the canary in this replica location.
        /// </para>
        /// </summary>
        public CanaryState CanaryState
        {
            get { return this._canaryState; }
            set { this._canaryState = value; }
        }

        // Check to see if CanaryState property is set
        internal bool IsSetCanaryState()
        {
            return this._canaryState != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time that the replica was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The Amazon Web Services Region where this replica is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// A structure that contains information about the replication status of this replica.
        /// </para>
        /// </summary>
        public ReplicationStatus ReplicationStatus
        {
            get { return this._replicationStatus; }
            set { this._replicationStatus = value; }
        }

        // Check to see if ReplicationStatus property is set
        internal bool IsSetReplicationStatus()
        {
            return this._replicationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration for the canary replica in this location.
        /// </para>
        /// </summary>
        public VpcConfigOutput VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}