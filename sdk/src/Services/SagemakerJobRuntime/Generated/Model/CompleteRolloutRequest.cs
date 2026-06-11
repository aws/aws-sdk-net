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
 * Do not modify this file. This file is generated from the sagemakerjobruntime-2026-02-01.normal.json service model.
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
namespace Amazon.SagemakerJobRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the CompleteRollout operation.
    /// Marks a rollout as complete, indicating that no further turns will be appended to
    /// the trajectory. After calling this operation, the trajectory is sealed and eligible
    /// for reward submission via the UpdateReward operation.
    /// </summary>
    public partial class CompleteRolloutRequest : AmazonSagemakerJobRuntimeRequest
    {
        private string _clientToken;
        private string _jobArn;
        private CompletionStatus _status;
        private string _trajectoryId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The job ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The target status for the trajectory. Defaults to READY if not specified. Set to FAILED
        /// if the rollout encountered an error and the trajectory should not be used for processing.
        /// </para>
        /// </summary>
        public CompletionStatus Status
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
        /// Gets and sets the property TrajectoryId. 
        /// <para>
        /// The trajectory ID to mark as complete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TrajectoryId
        {
            get { return this._trajectoryId; }
            set { this._trajectoryId = value; }
        }

        // Check to see if TrajectoryId property is set
        internal bool IsSetTrajectoryId()
        {
            return this._trajectoryId != null;
        }

    }
}