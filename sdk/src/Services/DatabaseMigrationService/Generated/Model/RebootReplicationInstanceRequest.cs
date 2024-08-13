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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the RebootReplicationInstance operation.
    /// Reboots a replication instance. Rebooting results in a momentary outage, until the
    /// replication instance becomes available again.
    /// </summary>
    public partial class RebootReplicationInstanceRequest : AmazonDatabaseMigrationServiceRequest
    {
        private bool? _forceFailover;
        private bool? _forcePlannedFailover;
        private string _replicationInstanceArn;

        /// <summary>
        /// Gets and sets the property ForceFailover. 
        /// <para>
        /// If this parameter is <c>true</c>, the reboot is conducted through a Multi-AZ failover.
        /// If the instance isn't configured for Multi-AZ, then you can't specify <c>true</c>.
        /// ( <c>--force-planned-failover</c> and <c>--force-failover</c> can't both be set to
        /// <c>true</c>.)
        /// </para>
        /// </summary>
        public bool? ForceFailover
        {
            get { return this._forceFailover; }
            set { this._forceFailover = value; }
        }

        // Check to see if ForceFailover property is set
        internal bool IsSetForceFailover()
        {
            return this._forceFailover.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForcePlannedFailover. 
        /// <para>
        /// If this parameter is <c>true</c>, the reboot is conducted through a planned Multi-AZ
        /// failover where resources are released and cleaned up prior to conducting the failover.
        /// If the instance isn''t configured for Multi-AZ, then you can't specify <c>true</c>.
        /// ( <c>--force-planned-failover</c> and <c>--force-failover</c> can't both be set to
        /// <c>true</c>.)
        /// </para>
        /// </summary>
        public bool? ForcePlannedFailover
        {
            get { return this._forcePlannedFailover; }
            set { this._forcePlannedFailover = value; }
        }

        // Check to see if ForcePlannedFailover property is set
        internal bool IsSetForcePlannedFailover()
        {
            return this._forcePlannedFailover.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationInstanceArn
        {
            get { return this._replicationInstanceArn; }
            set { this._replicationInstanceArn = value; }
        }

        // Check to see if ReplicationInstanceArn property is set
        internal bool IsSetReplicationInstanceArn()
        {
            return this._replicationInstanceArn != null;
        }

    }
}