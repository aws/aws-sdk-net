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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The configurations that control how Customer Profiles retrieves data from the source,
    /// Amazon AppFlow. Customer Profiles uses this information to create an AppFlow flow
    /// on behalf of customers.
    /// </summary>
    public partial class FlowDefinition
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the flow you want to create.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        /// The specified name of the flow. Use underscores (_) or hyphens (-) only. Spaces are
        /// not allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string FlowName { get; set; }

        /// <summary>
        /// Checks to see if the FlowName property is set.
        /// </summary>
        internal bool IsSetFlowName() => this.FlowName != null;

        /// <summary>
        /// Gets and sets the property KmsArn. 
        /// <para>
        /// The Amazon Resource Name of the AWS Key Management Service (KMS) key you provide for
        /// encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string KmsArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsArn property is set.
        /// </summary>
        internal bool IsSetKmsArn() => this.KmsArn != null;

        /// <summary>
        /// Gets and sets the property SourceFlowConfig. 
        /// <para>
        /// The configuration that controls how Customer Profiles retrieves data from the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceFlowConfig SourceFlowConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceFlowConfig property is set.
        /// </summary>
        internal bool IsSetSourceFlowConfig() => this.SourceFlowConfig != null;

        /// <summary>
        /// Gets and sets the property Tasks. 
        /// <para>
        /// A list of tasks that Customer Profiles performs while transferring the data in the
        /// flow run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Task> Tasks { get; set; } = AWSConfigs.InitializeCollections ? new List<Task>() : null;

        /// <summary>
        /// Checks to see if the Tasks property is set.
        /// </summary>
        internal bool IsSetTasks() => this.Tasks != null && (this.Tasks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TriggerConfig. 
        /// <para>
        /// The trigger settings that determine how and when the flow runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TriggerConfig TriggerConfig { get; set; }

        /// <summary>
        /// Checks to see if the TriggerConfig property is set.
        /// </summary>
        internal bool IsSetTriggerConfig() => this.TriggerConfig != null;
    }
}
