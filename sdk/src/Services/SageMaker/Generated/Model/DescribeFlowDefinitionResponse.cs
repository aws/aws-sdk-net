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
    /// This is the response object from the DescribeFlowDefinition operation.
    /// </summary>
    public partial class DescribeFlowDefinitionResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _failureReason;
        private string _flowDefinitionArn;
        private string _flowDefinitionName;
        private FlowDefinitionStatus _flowDefinitionStatus;
        private HumanLoopActivationConfig _humanLoopActivationConfig;
        private HumanLoopConfig _humanLoopConfig;
        private HumanLoopRequestSource _humanLoopRequestSource;
        private FlowDefinitionOutputConfig _outputConfig;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the flow definition was created.
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
        /// The reason your flow definition failed.
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
        /// The Amazon Resource Name (ARN) of the flow defintion.
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
        /// The Amazon Resource Name (ARN) of the flow definition.
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
        /// The status of the flow definition. Valid values are listed below.
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

        /// <summary>
        /// Gets and sets the property HumanLoopActivationConfig. 
        /// <para>
        /// An object containing information about what triggers a human review workflow.
        /// </para>
        /// </summary>
        public HumanLoopActivationConfig HumanLoopActivationConfig
        {
            get { return this._humanLoopActivationConfig; }
            set { this._humanLoopActivationConfig = value; }
        }

        // Check to see if HumanLoopActivationConfig property is set
        internal bool IsSetHumanLoopActivationConfig()
        {
            return this._humanLoopActivationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopConfig. 
        /// <para>
        /// An object containing information about who works on the task, the workforce task price,
        /// and other task details.
        /// </para>
        /// </summary>
        public HumanLoopConfig HumanLoopConfig
        {
            get { return this._humanLoopConfig; }
            set { this._humanLoopConfig = value; }
        }

        // Check to see if HumanLoopConfig property is set
        internal bool IsSetHumanLoopConfig()
        {
            return this._humanLoopConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopRequestSource. 
        /// <para>
        /// Container for configuring the source of human task requests. Used to specify if Amazon
        /// Rekognition or Amazon Textract is used as an integration source.
        /// </para>
        /// </summary>
        public HumanLoopRequestSource HumanLoopRequestSource
        {
            get { return this._humanLoopRequestSource; }
            set { this._humanLoopRequestSource = value; }
        }

        // Check to see if HumanLoopRequestSource property is set
        internal bool IsSetHumanLoopRequestSource()
        {
            return this._humanLoopRequestSource != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// An object containing information about the output file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlowDefinitionOutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Identity and Access Management
        /// (IAM) execution role for the flow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}