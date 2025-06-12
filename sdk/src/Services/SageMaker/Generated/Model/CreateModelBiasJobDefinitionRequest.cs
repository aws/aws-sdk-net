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
    /// Container for the parameters to the CreateModelBiasJobDefinition operation.
    /// Creates the definition for a model bias job.
    /// </summary>
    public partial class CreateModelBiasJobDefinitionRequest : AmazonSageMakerRequest
    {
        private string _jobDefinitionName;
        private MonitoringResources _jobResources;
        private ModelBiasAppSpecification _modelBiasAppSpecification;
        private ModelBiasBaselineConfig _modelBiasBaselineConfig;
        private ModelBiasJobInput _modelBiasJobInput;
        private MonitoringOutputConfig _modelBiasJobOutputConfig;
        private MonitoringNetworkConfig _networkConfig;
        private string _roleArn;
        private MonitoringStoppingCondition _stoppingCondition;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property JobDefinitionName. 
        /// <para>
        /// The name of the bias job definition. The name must be unique within an Amazon Web
        /// Services Region in the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string JobDefinitionName
        {
            get { return this._jobDefinitionName; }
            set { this._jobDefinitionName = value; }
        }

        // Check to see if JobDefinitionName property is set
        internal bool IsSetJobDefinitionName()
        {
            return this._jobDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property JobResources.
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitoringResources JobResources
        {
            get { return this._jobResources; }
            set { this._jobResources = value; }
        }

        // Check to see if JobResources property is set
        internal bool IsSetJobResources()
        {
            return this._jobResources != null;
        }

        /// <summary>
        /// Gets and sets the property ModelBiasAppSpecification. 
        /// <para>
        /// Configures the model bias job to run a specified Docker container image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelBiasAppSpecification ModelBiasAppSpecification
        {
            get { return this._modelBiasAppSpecification; }
            set { this._modelBiasAppSpecification = value; }
        }

        // Check to see if ModelBiasAppSpecification property is set
        internal bool IsSetModelBiasAppSpecification()
        {
            return this._modelBiasAppSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ModelBiasBaselineConfig. 
        /// <para>
        /// The baseline configuration for a model bias job.
        /// </para>
        /// </summary>
        public ModelBiasBaselineConfig ModelBiasBaselineConfig
        {
            get { return this._modelBiasBaselineConfig; }
            set { this._modelBiasBaselineConfig = value; }
        }

        // Check to see if ModelBiasBaselineConfig property is set
        internal bool IsSetModelBiasBaselineConfig()
        {
            return this._modelBiasBaselineConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ModelBiasJobInput. 
        /// <para>
        /// Inputs for the model bias job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelBiasJobInput ModelBiasJobInput
        {
            get { return this._modelBiasJobInput; }
            set { this._modelBiasJobInput = value; }
        }

        // Check to see if ModelBiasJobInput property is set
        internal bool IsSetModelBiasJobInput()
        {
            return this._modelBiasJobInput != null;
        }

        /// <summary>
        /// Gets and sets the property ModelBiasJobOutputConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitoringOutputConfig ModelBiasJobOutputConfig
        {
            get { return this._modelBiasJobOutputConfig; }
            set { this._modelBiasJobOutputConfig = value; }
        }

        // Check to see if ModelBiasJobOutputConfig property is set
        internal bool IsSetModelBiasJobOutputConfig()
        {
            return this._modelBiasJobOutputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// Networking options for a model bias job.
        /// </para>
        /// </summary>
        public MonitoringNetworkConfig NetworkConfig
        {
            get { return this._networkConfig; }
            set { this._networkConfig = value; }
        }

        // Check to see if NetworkConfig property is set
        internal bool IsSetNetworkConfig()
        {
            return this._networkConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker AI can assume
        /// to perform tasks on your behalf.
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
        /// Gets and sets the property StoppingCondition.
        /// </summary>
        public MonitoringStoppingCondition StoppingCondition
        {
            get { return this._stoppingCondition; }
            set { this._stoppingCondition = value; }
        }

        // Check to see if StoppingCondition property is set
        internal bool IsSetStoppingCondition()
        {
            return this._stoppingCondition != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// (Optional) An array of key-value pairs. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-whatURL">
        /// Using Cost Allocation Tags</a> in the <i>Amazon Web Services Billing and Cost Management
        /// User Guide</i>.
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