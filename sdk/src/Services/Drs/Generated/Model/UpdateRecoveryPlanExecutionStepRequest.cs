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
    /// Container for the parameters to the UpdateRecoveryPlanExecutionStep operation.
    /// Updates an execution step. Supports two actions: (1) skip a step that is in <c>NOT_STARTED</c>
    /// or <c>FAILED</c> status; (2) update the wait duration of a <c>WAIT</c> type step that
    /// is in <c>NOT_STARTED</c> status.
    /// </summary>
    public partial class UpdateRecoveryPlanExecutionStepRequest : AmazonDrsRequest
    {
        private string _recoveryPlanExecutionStepArn;
        private List<RecoveryPlanServer> _servers = AWSConfigs.InitializeCollections ? new List<RecoveryPlanServer>() : null;
        private RecoveryPlanExecutionStepStatus _status;
        private int? _waitDurationMinutes;

        /// <summary>
        /// Gets and sets the property RecoveryPlanExecutionStepArn. 
        /// <para>
        /// The ARN of the execution step to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RecoveryPlanExecutionStepArn
        {
            get { return this._recoveryPlanExecutionStepArn; }
            set { this._recoveryPlanExecutionStepArn = value; }
        }

        // Check to see if RecoveryPlanExecutionStepArn property is set
        internal bool IsSetRecoveryPlanExecutionStepArn()
        {
            return this._recoveryPlanExecutionStepArn != null;
        }

        /// <summary>
        /// Gets and sets the property Servers. 
        /// <para>
        /// Full replacement of the server list. Only allowed when the step is in NOT_STARTED
        /// status (Server type steps only).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<RecoveryPlanServer> Servers
        {
            get { return this._servers; }
            set { this._servers = value; }
        }

        // Check to see if Servers property is set
        internal bool IsSetServers()
        {
            return this._servers != null && (this._servers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Only SKIPPED is accepted. Step must be in NOT_STARTED or FAILED status.
        /// </para>
        /// </summary>
        public RecoveryPlanExecutionStepStatus Status
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
        /// Gets and sets the property WaitDurationMinutes. 
        /// <para>
        /// Updated wait duration. Only allowed when the step is in NOT_STARTED status (Wait type
        /// steps only).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public int? WaitDurationMinutes
        {
            get { return this._waitDurationMinutes; }
            set { this._waitDurationMinutes = value; }
        }

        // Check to see if WaitDurationMinutes property is set
        internal bool IsSetWaitDurationMinutes()
        {
            return this._waitDurationMinutes.HasValue; 
        }

    }
}