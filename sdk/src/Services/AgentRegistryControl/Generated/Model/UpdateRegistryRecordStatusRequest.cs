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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRegistryRecordStatus operation.
    /// Updates the status of a registry record as part of the registry's curation workflow,
    /// for example to approve or reject a record that is pending approval, or to deprecate
    /// an approved record so that it is no longer discoverable
    /// </summary>
    public partial class UpdateRegistryRecordStatusRequest : AmazonAgentRegistryControlRequest
    {
        private string _recordId;
        private string _registryId;
        private RegistryRecordStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The identifier of the registry record to update the status of (ARN or ID)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RecordId
        {
            get { return this._recordId; }
            set { this._recordId = value; }
        }

        // Check to see if RecordId property is set
        internal bool IsSetRecordId()
        {
            return this._recordId != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The identifier of the registry containing the record (ARN or ID)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The target status for the registry record
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegistryRecordStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the status change, for example why the record was approved, rejected,
        /// or deprecated
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}