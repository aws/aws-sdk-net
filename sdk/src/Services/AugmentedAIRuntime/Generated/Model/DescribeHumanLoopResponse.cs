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
    /// This is the response object from the DescribeHumanLoop operation.
    /// </summary>
    public partial class DescribeHumanLoopResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _failureCode;
        private string _failureReason;
        private string _flowDefinitionArn;
        private string _humanLoopArn;
        private string _humanLoopName;
        private HumanLoopOutput _humanLoopOutput;
        private HumanLoopStatus _humanLoopStatus;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time when Amazon Augmented AI created the human loop.
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
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// A failure code that identifies the type of failure.
        /// </para>
        ///  
        /// <para>
        /// Possible values: <c>ValidationError</c>, <c>Expired</c>, <c>InternalError</c> 
        /// </para>
        /// </summary>
        public string FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason why a human loop failed. The failure reason is returned when the status
        /// of the human loop is <c>Failed</c>.
        /// </para>
        /// </summary>
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
        [AWSProperty(Required=true, Max=1024)]
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
        /// Gets and sets the property HumanLoopArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the human loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string HumanLoopArn
        {
            get { return this._humanLoopArn; }
            set { this._humanLoopArn = value; }
        }

        // Check to see if HumanLoopArn property is set
        internal bool IsSetHumanLoopArn()
        {
            return this._humanLoopArn != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopName. 
        /// <para>
        /// The name of the human loop. The name must be lowercase, unique within the Region in
        /// your account, and can have up to 63 characters. Valid characters: a-z, 0-9, and -
        /// (hyphen).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property HumanLoopOutput. 
        /// <para>
        /// An object that contains information about the output of the human loop.
        /// </para>
        /// </summary>
        public HumanLoopOutput HumanLoopOutput
        {
            get { return this._humanLoopOutput; }
            set { this._humanLoopOutput = value; }
        }

        // Check to see if HumanLoopOutput property is set
        internal bool IsSetHumanLoopOutput()
        {
            return this._humanLoopOutput != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopStatus. 
        /// <para>
        /// The status of the human loop. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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