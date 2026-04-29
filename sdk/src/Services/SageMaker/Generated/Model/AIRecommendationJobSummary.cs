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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private string _aiRecommendationJobArn;
        private string _aiRecommendationJobName;
        private AIRecommendationJobStatus _aiRecommendationJobStatus;
        private DateTime? _creationTime;
        private DateTime? _endTime;

        /// <summary>
        /// Gets and sets the property AIRecommendationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string AIRecommendationJobArn
        {
            get { return this._aiRecommendationJobArn; }
            set { this._aiRecommendationJobArn = value; }
        }

        // Check to see if AIRecommendationJobArn property is set
        internal bool IsSetAIRecommendationJobArn()
        {
            return this._aiRecommendationJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property AIRecommendationJobName. 
        /// <para>
        /// The name of the recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string AIRecommendationJobName
        {
            get { return this._aiRecommendationJobName; }
            set { this._aiRecommendationJobName = value; }
        }

        // Check to see if AIRecommendationJobName property is set
        internal bool IsSetAIRecommendationJobName()
        {
            return this._aiRecommendationJobName != null;
        }

        /// <summary>
        /// Gets and sets the property AIRecommendationJobStatus. 
        /// <para>
        /// The status of the recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIRecommendationJobStatus AIRecommendationJobStatus
        {
            get { return this._aiRecommendationJobStatus; }
            set { this._aiRecommendationJobStatus = value; }
        }

        // Check to see if AIRecommendationJobStatus property is set
        internal bool IsSetAIRecommendationJobStatus()
        {
            return this._aiRecommendationJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that indicates when the recommendation job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A timestamp that indicates when the recommendation job completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

    }
}