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
    /// Summary information about an AI benchmark job.
    /// </summary>
    public partial class AIBenchmarkJobSummary
    {
        private string _aiBenchmarkJobArn;
        private string _aiBenchmarkJobName;
        private AIBenchmarkJobStatus _aiBenchmarkJobStatus;
        private string _aiWorkloadConfigName;
        private DateTime? _creationTime;
        private DateTime? _endTime;

        /// <summary>
        /// Gets and sets the property AIBenchmarkJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string AIBenchmarkJobArn
        {
            get { return this._aiBenchmarkJobArn; }
            set { this._aiBenchmarkJobArn = value; }
        }

        // Check to see if AIBenchmarkJobArn property is set
        internal bool IsSetAIBenchmarkJobArn()
        {
            return this._aiBenchmarkJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property AIBenchmarkJobName. 
        /// <para>
        /// The name of the benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string AIBenchmarkJobName
        {
            get { return this._aiBenchmarkJobName; }
            set { this._aiBenchmarkJobName = value; }
        }

        // Check to see if AIBenchmarkJobName property is set
        internal bool IsSetAIBenchmarkJobName()
        {
            return this._aiBenchmarkJobName != null;
        }

        /// <summary>
        /// Gets and sets the property AIBenchmarkJobStatus. 
        /// <para>
        /// The status of the benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIBenchmarkJobStatus AIBenchmarkJobStatus
        {
            get { return this._aiBenchmarkJobStatus; }
            set { this._aiBenchmarkJobStatus = value; }
        }

        // Check to see if AIBenchmarkJobStatus property is set
        internal bool IsSetAIBenchmarkJobStatus()
        {
            return this._aiBenchmarkJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AIWorkloadConfigName. 
        /// <para>
        /// The name of the AI workload configuration used by the benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string AIWorkloadConfigName
        {
            get { return this._aiWorkloadConfigName; }
            set { this._aiWorkloadConfigName = value; }
        }

        // Check to see if AIWorkloadConfigName property is set
        internal bool IsSetAIWorkloadConfigName()
        {
            return this._aiWorkloadConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that indicates when the benchmark job was created.
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
        /// A timestamp that indicates when the benchmark job completed.
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