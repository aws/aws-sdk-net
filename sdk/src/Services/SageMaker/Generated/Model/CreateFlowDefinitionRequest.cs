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
    /// Container for the parameters to the CreateFlowDefinition operation.
    /// Creates a flow definition.
    /// </summary>
    public partial class CreateFlowDefinitionRequest : AmazonSageMakerRequest
    {
        private string _flowDefinitionName;
        private HumanLoopActivationConfig _humanLoopActivationConfig;
        private HumanLoopConfig _humanLoopConfig;
        private HumanLoopRequestSource _humanLoopRequestSource;
        private FlowDefinitionOutputConfig _outputConfig;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property FlowDefinitionName. 
        /// <para>
        /// The name of your flow definition.
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
        /// Gets and sets the property HumanLoopActivationConfig. 
        /// <para>
        /// An object containing information about the events that trigger a human workflow.
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
        /// An object containing information about the tasks the human reviewers will perform.
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
        /// Container for configuring the source of human task requests. Use to specify if Amazon
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
        /// An object containing information about where the human review results will be uploaded.
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
        /// The Amazon Resource Name (ARN) of the role needed to call other services on your behalf.
        /// For example, <c>arn:aws:iam::1234567890:role/service-role/AmazonSageMaker-ExecutionRole-20180111T151298</c>.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs that contain metadata to help you categorize and organize
        /// a flow definition. Each tag consists of a key and a value, both of which you define.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}