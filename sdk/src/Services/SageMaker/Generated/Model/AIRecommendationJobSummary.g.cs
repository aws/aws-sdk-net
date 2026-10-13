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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Summary information about an AI recommendation job.
    /// </summary>
    public partial class AIRecommendationJobSummary
    {
        /// <summary>
        /// Gets and sets the property AIRecommendationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string AIRecommendationJobArn { get; set; }

        /// <summary>
        /// Checks to see if the AIRecommendationJobArn property is set.
        /// </summary>
        internal bool IsSetAIRecommendationJobArn() => this.AIRecommendationJobArn != null;

        /// <summary>
        /// Gets and sets the property AIRecommendationJobName. 
        /// <para>
        /// The name of the recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string AIRecommendationJobName { get; set; }

        /// <summary>
        /// Checks to see if the AIRecommendationJobName property is set.
        /// </summary>
        internal bool IsSetAIRecommendationJobName() => this.AIRecommendationJobName != null;

        /// <summary>
        /// Gets and sets the property AIRecommendationJobStatus. 
        /// <para>
        /// The status of the recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AIRecommendationJobStatus AIRecommendationJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the AIRecommendationJobStatus property is set.
        /// </summary>
        internal bool IsSetAIRecommendationJobStatus() => this.AIRecommendationJobStatus != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that indicates when the recommendation job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A timestamp that indicates when the recommendation job completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;
    }
}
