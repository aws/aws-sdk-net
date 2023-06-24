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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// These are the details of the specified hypervisor. A hypervisor is hardware, software,
    /// or firmware that creates and manages virtual machines, and allocates resources to
    /// them.
    /// </summary>
    public partial class HypervisorDetails
    {
        private string _host;
        private string _hypervisorArn;
        private string _kmsKeyArn;
        private DateTime? _lastSuccessfulMetadataSyncTime;
        private SyncMetadataStatus _latestMetadataSyncStatus;
        private string _latestMetadataSyncStatusMessage;
        private string _logGroupArn;
        private string _name;
        private HypervisorState _state;

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// The server host of the hypervisor. This can be either an IP address or a fully-qualified
        /// domain name (FQDN).
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
        public string Host
        {
            get { return this._host; }
            set { this._host = value; }
        }

        // Check to see if Host property is set
        internal bool IsSetHost()
        {
            return this._host != null;
        }

        /// <summary>
        /// Gets and sets the property HypervisorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hypervisor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string HypervisorArn
        {
            get { return this._hypervisorArn; }
            set { this._hypervisorArn = value; }
        }

        // Check to see if HypervisorArn property is set
        internal bool IsSetHypervisorArn()
        {
            return this._hypervisorArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS used to encrypt the hypervisor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulMetadataSyncTime. 
        /// <para>
        /// This is the time when the most recent successful sync of metadata occurred.
        /// </para>
        /// </summary>
        public DateTime LastSuccessfulMetadataSyncTime
        {
            get { return this._lastSuccessfulMetadataSyncTime.GetValueOrDefault(); }
            set { this._lastSuccessfulMetadataSyncTime = value; }
        }

        // Check to see if LastSuccessfulMetadataSyncTime property is set
        internal bool IsSetLastSuccessfulMetadataSyncTime()
        {
            return this._lastSuccessfulMetadataSyncTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestMetadataSyncStatus. 
        /// <para>
        /// This is the most recent status for the indicated metadata sync.
        /// </para>
        /// </summary>
        public SyncMetadataStatus LatestMetadataSyncStatus
        {
            get { return this._latestMetadataSyncStatus; }
            set { this._latestMetadataSyncStatus = value; }
        }

        // Check to see if LatestMetadataSyncStatus property is set
        internal bool IsSetLatestMetadataSyncStatus()
        {
            return this._latestMetadataSyncStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LatestMetadataSyncStatusMessage. 
        /// <para>
        /// This is the most recent status for the indicated metadata sync.
        /// </para>
        /// </summary>
        public string LatestMetadataSyncStatusMessage
        {
            get { return this._latestMetadataSyncStatusMessage; }
            set { this._latestMetadataSyncStatusMessage = value; }
        }

        // Check to see if LatestMetadataSyncStatusMessage property is set
        internal bool IsSetLatestMetadataSyncStatusMessage()
        {
            return this._latestMetadataSyncStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the group of gateways within the requested log.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string LogGroupArn
        {
            get { return this._logGroupArn; }
            set { this._logGroupArn = value; }
        }

        // Check to see if LogGroupArn property is set
        internal bool IsSetLogGroupArn()
        {
            return this._logGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// This is the name of the specified hypervisor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// This is the current state of the specified hypervisor.
        /// </para>
        ///  
        /// <para>
        /// The possible states are <code>PENDING</code>, <code>ONLINE</code>, <code>OFFLINE</code>,
        /// or <code>ERROR</code>.
        /// </para>
        /// </summary>
        public HypervisorState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}