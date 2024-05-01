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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
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
namespace Amazon.AugmentedAIRuntime.Model
{
    /// <summary>
    /// Summary information about the human loop.
    /// </summary>
    public partial class HumanLoopSummary
    {
        private DateTime? _creationTime;
        private string _failureReason;
        private string _flowDefinitionArn;
        private string _humanLoopName;
        private HumanLoopStatus _humanLoopStatus;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When Amazon Augmented AI created the human loop.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason why the human loop failed. A failure reason is returned when the status
        /// of the human loop is <c>Failed</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property FlowDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow definition used to configure the human
        /// loop.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FlowDefinitionArn
        {
            get { return this._flowDefinitionArn; }
            set { this._flowDefinitionArn = value; }
        }

        // Check to see if FlowDefinitionArn property is set
        internal bool IsSetFlowDefinitionArn()
        {
            return this._flowDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopName. 
        /// <para>
        /// The name of the human loop.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string HumanLoopName
        {
            get { return this._humanLoopName; }
            set { this._humanLoopName = value; }
        }

        // Check to see if HumanLoopName property is set
        internal bool IsSetHumanLoopName()
        {
            return this._humanLoopName != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopStatus. 
        /// <para>
        /// The status of the human loop. 
        /// </para>
        /// </summary>
        public HumanLoopStatus HumanLoopStatus
        {
            get { return this._humanLoopStatus; }
            set { this._humanLoopStatus = value; }
        }

        // Check to see if HumanLoopStatus property is set
        internal bool IsSetHumanLoopStatus()
        {
            return this._humanLoopStatus != null;
        }

    }
}