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
    /// This is the response object from the DescribeFlowDefinition operation.
    /// </summary>
    public partial class DescribeFlowDefinitionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the flow definition was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason your flow definition failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property FlowDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow defintion.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string FlowDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowDefinitionArn property is set.
        /// </summary>
        internal bool IsSetFlowDefinitionArn() => this.FlowDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property FlowDefinitionName. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string FlowDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the FlowDefinitionName property is set.
        /// </summary>
        internal bool IsSetFlowDefinitionName() => this.FlowDefinitionName != null;

        /// <summary>
        /// Gets and sets the property FlowDefinitionStatus. 
        /// <para>
        /// The status of the flow definition. Valid values are listed below.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlowDefinitionStatus FlowDefinitionStatus { get; set; }

        /// <summary>
        /// Checks to see if the FlowDefinitionStatus property is set.
        /// </summary>
        internal bool IsSetFlowDefinitionStatus() => this.FlowDefinitionStatus != null;

        /// <summary>
        /// Gets and sets the property HumanLoopActivationConfig. 
        /// <para>
        /// An object containing information about what triggers a human review workflow.
        /// </para>
        /// </summary>
        public HumanLoopActivationConfig HumanLoopActivationConfig { get; set; }

        /// <summary>
        /// Checks to see if the HumanLoopActivationConfig property is set.
        /// </summary>
        internal bool IsSetHumanLoopActivationConfig() => this.HumanLoopActivationConfig != null;

        /// <summary>
        /// Gets and sets the property HumanLoopConfig. 
        /// <para>
        /// An object containing information about who works on the task, the workforce task price,
        /// and other task details.
        /// </para>
        /// </summary>
        public HumanLoopConfig HumanLoopConfig { get; set; }

        /// <summary>
        /// Checks to see if the HumanLoopConfig property is set.
        /// </summary>
        internal bool IsSetHumanLoopConfig() => this.HumanLoopConfig != null;

        /// <summary>
        /// Gets and sets the property HumanLoopRequestSource. 
        /// <para>
        /// Container for configuring the source of human task requests. Used to specify if Amazon
        /// Rekognition or Amazon Textract is used as an integration source.
        /// </para>
        /// </summary>
        public HumanLoopRequestSource HumanLoopRequestSource { get; set; }

        /// <summary>
        /// Checks to see if the HumanLoopRequestSource property is set.
        /// </summary>
        internal bool IsSetHumanLoopRequestSource() => this.HumanLoopRequestSource != null;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// An object containing information about the output file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlowDefinitionOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Identity and Access Management
        /// (IAM) execution role for the flow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
