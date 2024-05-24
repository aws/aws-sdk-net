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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the DisconnectRecoveryInstance operation.
    /// Disconnect a Recovery Instance from Elastic Disaster Recovery. Data replication is
    /// stopped immediately. All AWS resources created by Elastic Disaster Recovery for enabling
    /// the replication of the Recovery Instance will be terminated / deleted within 90 minutes.
    /// If the agent on the Recovery Instance has not been prevented from communicating with
    /// the Elastic Disaster Recovery service, then it will receive a command to uninstall
    /// itself (within approximately 10 minutes). The following properties of the Recovery
    /// Instance will be changed immediately: dataReplicationInfo.dataReplicationState will
    /// be set to DISCONNECTED; The totalStorageBytes property for each of dataReplicationInfo.replicatedDisks
    /// will be set to zero; dataReplicationInfo.lagDuration and dataReplicationInfo.lagDuration
    /// will be nullified.
    /// </summary>
    public partial class DisconnectRecoveryInstanceRequest : AmazonDrsRequest
    {
        private string _recoveryInstanceID;

        /// <summary>
        /// Gets and sets the property RecoveryInstanceID. 
        /// <para>
        /// The ID of the Recovery Instance to disconnect.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=19)]
        public string RecoveryInstanceID
        {
            get { return this._recoveryInstanceID; }
            set { this._recoveryInstanceID = value; }
        }

        // Check to see if RecoveryInstanceID property is set
        internal bool IsSetRecoveryInstanceID()
        {
            return this._recoveryInstanceID != null;
        }

    }
}