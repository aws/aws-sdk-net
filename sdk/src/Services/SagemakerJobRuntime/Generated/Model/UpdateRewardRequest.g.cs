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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateReward operation. Updates the reward values
    /// for a trajectory and transitions it to reward-received status, signaling that it is
    /// eligible for processing. Call this operation after CompleteRollout to provide the
    /// computed reward scores.
    /// </summary>
    public partial class UpdateRewardRequest : AmazonSagemakerJobRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. A unique, case-sensitive identifier that you
        /// provide to ensure the idempotency of the request.
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property JobArn. The job ARN.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property Rewards. The list of reward values to assign to this trajectory.
        /// Provide one reward value per turn in the trajectory.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<double> Rewards { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Rewards property is set.
        /// </summary>
        internal bool IsSetRewards() => this.Rewards != null && (this.Rewards.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrajectoryId. The trajectory ID to update with reward values.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TrajectoryId { get; set; }

        /// <summary>
        /// Checks to see if the TrajectoryId property is set.
        /// </summary>
        internal bool IsSetTrajectoryId() => this.TrajectoryId != null;
    }
}
