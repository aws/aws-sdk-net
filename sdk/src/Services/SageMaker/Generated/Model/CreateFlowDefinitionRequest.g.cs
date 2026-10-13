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
    /// Container for the parameters to the CreateFlowDefinition operation. Creates a flow
    /// definition.
    /// </summary>
    public partial class CreateFlowDefinitionRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property FlowDefinitionName. 
        /// <para>
        /// The name of your flow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string FlowDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the FlowDefinitionName property is set.
        /// </summary>
        internal bool IsSetFlowDefinitionName() => this.FlowDefinitionName != null;

        /// <summary>
        /// Gets and sets the property HumanLoopActivationConfig. 
        /// <para>
        /// An object containing information about the events that trigger a human workflow.
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
        /// An object containing information about the tasks the human reviewers will perform.
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
        /// Container for configuring the source of human task requests. Use to specify if Amazon
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
        /// An object containing information about where the human review results will be uploaded.
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
        /// The Amazon Resource Name (ARN) of the role needed to call other services on your behalf.
        /// For example, <c>arn:aws:iam::1234567890:role/service-role/AmazonSageMaker-ExecutionRole-20180111T151298</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs that contain metadata to help you categorize and organize
        /// a flow definition. Each tag consists of a key and a value, both of which you define.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
