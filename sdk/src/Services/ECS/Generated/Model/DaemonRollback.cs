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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Information about a daemon deployment rollback.
    /// </summary>
    public partial class DaemonRollback
    {
        private string _reason;
        private List<string> _rollbackCapacityProviders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _rollbackTargetDaemonRevisionArn;
        private DateTime? _startedAt;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason the rollback happened. For example, the circuit breaker initiated the rollback
        /// operation.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackCapacityProviders. 
        /// <para>
        /// The capacity providers involved in the rollback.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RollbackCapacityProviders
        {
            get { return this._rollbackCapacityProviders; }
            set { this._rollbackCapacityProviders = value; }
        }

        // Check to see if RollbackCapacityProviders property is set
        internal bool IsSetRollbackCapacityProviders()
        {
            return this._rollbackCapacityProviders != null && (this._rollbackCapacityProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RollbackTargetDaemonRevisionArn. 
        /// <para>
        /// The ARN of the daemon revision deployed as part of the rollback.
        /// </para>
        /// </summary>
        public string RollbackTargetDaemonRevisionArn
        {
            get { return this._rollbackTargetDaemonRevisionArn; }
            set { this._rollbackTargetDaemonRevisionArn = value; }
        }

        // Check to see if RollbackTargetDaemonRevisionArn property is set
        internal bool IsSetRollbackTargetDaemonRevisionArn()
        {
            return this._rollbackTargetDaemonRevisionArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time that the rollback started. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

    }
}