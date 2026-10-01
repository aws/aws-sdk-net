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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIdMappingWorkflow operation. Creates an
    /// <c>IdMappingWorkflow</c> object which stores the configuration of the data processing
    /// job to be run. Each <c>IdMappingWorkflow</c> must have a unique workflow name. To
    /// modify an existing workflow, use the UpdateIdMappingWorkflow API. <important> <para>
    /// Incremental processing is not supported for ID mapping workflows. </para> </important>
    /// </summary>
    public partial class CreateIdMappingWorkflowRequest : AmazonEntityResolutionRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IdMappingTechniques. 
        /// <para>
        /// An object which defines the ID mapping technique and any additional configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdMappingTechniques IdMappingTechniques { get; set; }

        /// <summary>
        /// Checks to see if the IdMappingTechniques property is set.
        /// </summary>
        internal bool IsSetIdMappingTechniques() => this.IdMappingTechniques != null;

        /// <summary>
        /// Gets and sets the property IncrementalRunConfig. 
        /// <para>
        ///  The incremental run configuration for the ID mapping workflow.
        /// </para>
        /// </summary>
        public IdMappingIncrementalRunConfig IncrementalRunConfig { get; set; }

        /// <summary>
        /// Checks to see if the IncrementalRunConfig property is set.
        /// </summary>
        internal bool IsSetIncrementalRunConfig() => this.IncrementalRunConfig != null;

        /// <summary>
        /// Gets and sets the property InputSourceConfig. 
        /// <para>
        /// A list of <c>InputSource</c> objects, which have the fields <c>InputSourceARN</c>
        /// and <c>SchemaName</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public List<IdMappingWorkflowInputSource> InputSourceConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<IdMappingWorkflowInputSource>() : null;

        /// <summary>
        /// Checks to see if the InputSourceConfig property is set.
        /// </summary>
        internal bool IsSetInputSourceConfig() => this.InputSourceConfig != null && (this.InputSourceConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputSourceConfig. 
        /// <para>
        /// A list of <c>IdMappingWorkflowOutputSource</c> objects, each of which contains fields
        /// <c>outputS3Path</c> and <c>KMSArn</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<IdMappingWorkflowOutputSource> OutputSourceConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<IdMappingWorkflowOutputSource>() : null;

        /// <summary>
        /// Checks to see if the OutputSourceConfig property is set.
        /// </summary>
        internal bool IsSetOutputSourceConfig() => this.OutputSourceConfig != null && (this.OutputSourceConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role. Entity Resolution assumes this role
        /// to create resources on your behalf as part of workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkflowName. 
        /// <para>
        /// The name of the workflow. There can't be multiple <c>IdMappingWorkflows</c> with the
        /// same name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowName property is set.
        /// </summary>
        internal bool IsSetWorkflowName() => this.WorkflowName != null;
    }
}
