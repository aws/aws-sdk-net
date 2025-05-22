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
    /// Contains summary information about the flow definition.
    /// </summary>
    public partial class FlowDefinitionSummary
    {
        private DateTime? _creationTime;
        private string _failureReason;
        private string _flowDefinitionArn;
        private string _flowDefinitionName;
        private FlowDefinitionStatus _flowDefinitionStatus;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when SageMaker created the flow definition.
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason why the flow definition creation failed. A failure reason is returned only
        /// when the flow definition status is <c>Failed</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// The Amazon Resource Name (ARN) of the flow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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
        /// Gets and sets the property FlowDefinitionName. 
        /// <para>
        /// The name of the flow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string FlowDefinitionName
        {
            get { return this._flowDefinitionName; }
            set { this._flowDefinitionName = value; }
        }

        // Check to see if FlowDefinitionName property is set
        internal bool IsSetFlowDefinitionName()
        {
            return this._flowDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property FlowDefinitionStatus. 
        /// <para>
        /// The status of the flow definition. Valid values:
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlowDefinitionStatus FlowDefinitionStatus
        {
            get { return this._flowDefinitionStatus; }
            set { this._flowDefinitionStatus = value; }
        }

        // Check to see if FlowDefinitionStatus property is set
        internal bool IsSetFlowDefinitionStatus()
        {
            return this._flowDefinitionStatus != null;
        }

    }
}