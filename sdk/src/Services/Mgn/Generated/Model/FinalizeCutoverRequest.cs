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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the FinalizeCutover operation.
    /// Finalizes the cutover immediately for specific Source Servers. All AWS resources created
    /// by Application Migration Service for enabling the replication of these source servers
    /// will be terminated / deleted within 90 minutes. Launched Test or Cutover instances
    /// will NOT be terminated. The AWS Replication Agent will receive a command to uninstall
    /// itself (within 10 minutes). The following properties of the SourceServer will be changed
    /// immediately: dataReplicationInfo.dataReplicationState will be changed to DISCONNECTED;
    /// The SourceServer.lifeCycle.state will be changed to CUTOVER; The totalStorageBytes
    /// property fo each of dataReplicationInfo.replicatedDisks will be set to zero; dataReplicationInfo.lagDuration
    /// and dataReplicationInfo.lagDuration will be nullified.
    /// </summary>
    public partial class FinalizeCutoverRequest : AmazonMgnRequest
    {
        private string _accountid;
        private string _sourceServerID;

        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// Request to finalize Cutover by Source Account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountID
        {
            get { return this._accountid; }
            set { this._accountid = value; }
        }

        // Check to see if AccountID property is set
        internal bool IsSetAccountID()
        {
            return this._accountid != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Request to finalize Cutover by Source Server ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string SourceServerID
        {
            get { return this._sourceServerID; }
            set { this._sourceServerID = value; }
        }

        // Check to see if SourceServerID property is set
        internal bool IsSetSourceServerID()
        {
            return this._sourceServerID != null;
        }

    }
}