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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Status information returned by the <c>DeleteInventory</c> operation.
    /// </summary>
    public partial class InventoryDeletionStatusItem
    {
        private string _deletionId;
        private DateTime? _deletionStartTime;
        private InventoryDeletionSummary _deletionSummary;
        private InventoryDeletionStatus _lastStatus;
        private string _lastStatusMessage;
        private DateTime? _lastStatusUpdateTime;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property DeletionId. 
        /// <para>
        /// The deletion ID returned by the <c>DeleteInventory</c> operation.
        /// </para>
        /// </summary>
        public string DeletionId
        {
            get { return this._deletionId; }
            set { this._deletionId = value; }
        }

        // Check to see if DeletionId property is set
        internal bool IsSetDeletionId()
        {
            return this._deletionId != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionStartTime. 
        /// <para>
        /// The UTC timestamp when the delete operation started.
        /// </para>
        /// </summary>
        public DateTime? DeletionStartTime
        {
            get { return this._deletionStartTime; }
            set { this._deletionStartTime = value; }
        }

        // Check to see if DeletionStartTime property is set
        internal bool IsSetDeletionStartTime()
        {
            return this._deletionStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionSummary. 
        /// <para>
        /// Information about the delete operation. For more information about this summary, see
        /// <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/inventory-custom.html#delete-custom-inventory">Understanding
        /// the delete inventory summary</a> in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public InventoryDeletionSummary DeletionSummary
        {
            get { return this._deletionSummary; }
            set { this._deletionSummary = value; }
        }

        // Check to see if DeletionSummary property is set
        internal bool IsSetDeletionSummary()
        {
            return this._deletionSummary != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// The status of the operation. Possible values are InProgress and Complete.
        /// </para>
        /// </summary>
        public InventoryDeletionStatus LastStatus
        {
            get { return this._lastStatus; }
            set { this._lastStatus = value; }
        }

        // Check to see if LastStatus property is set
        internal bool IsSetLastStatus()
        {
            return this._lastStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatusMessage. 
        /// <para>
        /// Information about the status.
        /// </para>
        /// </summary>
        public string LastStatusMessage
        {
            get { return this._lastStatusMessage; }
            set { this._lastStatusMessage = value; }
        }

        // Check to see if LastStatusMessage property is set
        internal bool IsSetLastStatusMessage()
        {
            return this._lastStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatusUpdateTime. 
        /// <para>
        /// The UTC timestamp of when the last status report.
        /// </para>
        /// </summary>
        public DateTime? LastStatusUpdateTime
        {
            get { return this._lastStatusUpdateTime; }
            set { this._lastStatusUpdateTime = value; }
        }

        // Check to see if LastStatusUpdateTime property is set
        internal bool IsSetLastStatusUpdateTime()
        {
            return this._lastStatusUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the inventory data type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

    }
}