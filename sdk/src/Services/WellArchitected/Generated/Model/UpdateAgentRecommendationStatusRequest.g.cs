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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAgentRecommendationStatus operation. Updates
    /// the status of a recommendation to track its progress through the implementation lifecycle.
    /// </summary>
    public partial class UpdateAgentRecommendationStatusRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property RecommendationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommendation to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string RecommendationArn { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationArn property is set.
        /// </summary>
        internal bool IsSetRecommendationArn() => this.RecommendationArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status to assign to the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdateReason. 
        /// <para>
        /// A free-text reason explaining this status update.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string UpdateReason { get; set; }

        /// <summary>
        /// Checks to see if the UpdateReason property is set.
        /// </summary>
        internal bool IsSetUpdateReason() => this.UpdateReason != null;
    }
}
