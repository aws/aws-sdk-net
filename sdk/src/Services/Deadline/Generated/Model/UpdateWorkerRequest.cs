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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorker operation.
    /// Updates a worker.
    /// </summary>
    public partial class UpdateWorkerRequest : AmazonDeadlineRequest
    {
        private WorkerCapabilities _capabilities;
        private string _farmId;
        private string _fleetId;
        private HostPropertiesRequest _hostProperties;
        private UpdatedWorkerStatus _status;
        private string _workerId;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The worker capabilities to update.
        /// </para>
        /// </summary>
        public WorkerCapabilities Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null;
        }

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The fleet ID to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property HostProperties. 
        /// <para>
        /// The host properties to update.
        /// </para>
        /// </summary>
        public HostPropertiesRequest HostProperties
        {
            get { return this._hostProperties; }
            set { this._hostProperties = value; }
        }

        // Check to see if HostProperties property is set
        internal bool IsSetHostProperties()
        {
            return this._hostProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The worker status to update.
        /// </para>
        /// </summary>
        public UpdatedWorkerStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        /// The worker ID to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkerId
        {
            get { return this._workerId; }
            set { this._workerId = value; }
        }

        // Check to see if WorkerId property is set
        internal bool IsSetWorkerId()
        {
            return this._workerId != null;
        }

    }
}