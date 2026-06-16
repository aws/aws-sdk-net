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
    /// Container for the parameters to the UpdateReward operation.
    /// Updates the reward values for a trajectory and transitions it to reward-received status,
    /// signaling that it is eligible for processing. Call this operation after CompleteRollout
    /// to provide the computed reward scores.
    /// </summary>
    public partial class UpdateRewardRequest : AmazonSagemakerJobRuntimeRequest
    {
        private string _clientToken;
        private string _jobArn;
        private List<double> _rewards = AWSConfigs.InitializeCollections ? new List<double>() : null;
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
        /// Gets and sets the property Rewards. 
        /// <para>
        /// The list of reward values to assign to this trajectory. Provide one reward value per
        /// turn in the trajectory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<double> Rewards
        {
            get { return this._rewards; }
            set { this._rewards = value; }
        }

        // Check to see if Rewards property is set
        internal bool IsSetRewards()
        {
            return this._rewards != null && (this._rewards.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrajectoryId. 
        /// <para>
        /// The trajectory ID to update with reward values.
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