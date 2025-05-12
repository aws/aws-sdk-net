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
    /// This is the response object from the DescribeDataQualityJobDefinition operation.
    /// </summary>
    public partial class DescribeDataQualityJobDefinitionResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private DataQualityAppSpecification _dataQualityAppSpecification;
        private DataQualityBaselineConfig _dataQualityBaselineConfig;
        private DataQualityJobInput _dataQualityJobInput;
        private MonitoringOutputConfig _dataQualityJobOutputConfig;
        private string _jobDefinitionArn;
        private string _jobDefinitionName;
        private MonitoringResources _jobResources;
        private MonitoringNetworkConfig _networkConfig;
        private string _roleArn;
        private MonitoringStoppingCondition _stoppingCondition;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the data quality monitoring job definition was created.
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
        /// Gets and sets the property DataQualityAppSpecification. 
        /// <para>
        /// Information about the container that runs the data quality monitoring job.
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
        /// The constraints and baselines for the data quality monitoring job definition.
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
        /// The list of inputs for the data quality monitoring job. Currently endpoints are supported.
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
        /// Gets and sets the property JobDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data quality monitoring job definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string JobDefinitionArn
        {
            get { return this._jobDefinitionArn; }
            set { this._jobDefinitionArn = value; }
        }

        // Check to see if JobDefinitionArn property is set
        internal bool IsSetJobDefinitionArn()
        {
            return this._jobDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobDefinitionName. 
        /// <para>
        /// The name of the data quality monitoring job definition.
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
        /// The networking configuration for the data quality monitoring job.
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

    }
}