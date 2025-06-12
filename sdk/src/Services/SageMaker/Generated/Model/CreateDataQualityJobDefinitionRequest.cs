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
    /// Container for the parameters to the CreateDataQualityJobDefinition operation.
    /// Creates a definition for a job that monitors data quality and drift. For information
    /// about model monitor, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html">Amazon
    /// SageMaker AI Model Monitor</a>.
    /// </summary>
    public partial class CreateDataQualityJobDefinitionRequest : AmazonSageMakerRequest
    {
        private DataQualityAppSpecification _dataQualityAppSpecification;
        private DataQualityBaselineConfig _dataQualityBaselineConfig;
        private DataQualityJobInput _dataQualityJobInput;
        private MonitoringOutputConfig _dataQualityJobOutputConfig;
        private string _jobDefinitionName;
        private MonitoringResources _jobResources;
        private MonitoringNetworkConfig _networkConfig;
        private string _roleArn;
        private MonitoringStoppingCondition _stoppingCondition;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DataQualityAppSpecification. 
        /// <para>
        /// Specifies the container that runs the monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataQualityAppSpecification DataQualityAppSpecification
        {
            get { return this._dataQualityAppSpecification; }
            set { this._dataQualityAppSpecification = value; }
        }

        // Check to see if DataQualityAppSpecification property is set
        internal bool IsSetDataQualityAppSpecification()
        {
            return this._dataQualityAppSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property DataQualityBaselineConfig. 
        /// <para>
        /// Configures the constraints and baselines for the monitoring job.
        /// </para>
        /// </summary>
        public DataQualityBaselineConfig DataQualityBaselineConfig
        {
            get { return this._dataQualityBaselineConfig; }
            set { this._dataQualityBaselineConfig = value; }
        }

        // Check to see if DataQualityBaselineConfig property is set
        internal bool IsSetDataQualityBaselineConfig()
        {
            return this._dataQualityBaselineConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DataQualityJobInput. 
        /// <para>
        /// A list of inputs for the monitoring job. Currently endpoints are supported as monitoring
        /// inputs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataQualityJobInput DataQualityJobInput
        {
            get { return this._dataQualityJobInput; }
            set { this._dataQualityJobInput = value; }
        }

        // Check to see if DataQualityJobInput property is set
        internal bool IsSetDataQualityJobInput()
        {
            return this._dataQualityJobInput != null;
        }

        /// <summary>
        /// Gets and sets the property DataQualityJobOutputConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitoringOutputConfig DataQualityJobOutputConfig
        {
            get { return this._dataQualityJobOutputConfig; }
            set { this._dataQualityJobOutputConfig = value; }
        }

        // Check to see if DataQualityJobOutputConfig property is set
        internal bool IsSetDataQualityJobOutputConfig()
        {
            return this._dataQualityJobOutputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobDefinitionName. 
        /// <para>
        /// The name for the monitoring job definition.
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
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// Specifies networking configuration for the monitoring job.
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