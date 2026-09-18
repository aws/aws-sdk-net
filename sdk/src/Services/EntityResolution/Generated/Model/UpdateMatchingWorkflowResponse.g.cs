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
    /// This is the response object from the UpdateMatchingWorkflow operation.
    /// </summary>
    public partial class UpdateMatchingWorkflowResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property IncrementalRunConfig. 
        /// <para>
        /// An object which defines an incremental run type and has only <c>incrementalRunType</c>
        /// as a field.
        /// </para>
        /// </summary>
        public IncrementalRunConfig IncrementalRunConfig { get; set; }

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
        public List<InputSource> InputSourceConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<InputSource>() : null;

        /// <summary>
        /// Checks to see if the InputSourceConfig property is set.
        /// </summary>
        internal bool IsSetInputSourceConfig() => this.InputSourceConfig != null && (this.InputSourceConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputSourceConfig. 
        /// <para>
        /// A list of <c>OutputSource</c> objects, each of which contains fields <c>outputS3Path</c>,
        /// <c>applyNormalization</c>, <c>KMSArn</c>, and <c>output</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<OutputSource> OutputSourceConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputSource>() : null;

        /// <summary>
        /// Checks to see if the OutputSourceConfig property is set.
        /// </summary>
        internal bool IsSetOutputSourceConfig() => this.OutputSourceConfig != null && (this.OutputSourceConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResolutionTechniques. 
        /// <para>
        /// An object which defines the <c>resolutionType</c> and the <c>ruleBasedProperties</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResolutionTechniques ResolutionTechniques { get; set; }

        /// <summary>
        /// Checks to see if the ResolutionTechniques property is set.
        /// </summary>
        internal bool IsSetResolutionTechniques() => this.ResolutionTechniques != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role. Entity Resolution assumes this role
        /// to create resources on your behalf as part of workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowName. 
        /// <para>
        /// The name of the workflow.
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
