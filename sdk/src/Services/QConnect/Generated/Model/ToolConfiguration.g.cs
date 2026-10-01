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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Configuration settings for a tool used by AI Agents.
    /// </summary>
    public partial class ToolConfiguration
    {
        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// Annotations for the tool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Annotation Annotations { get; set; }

        /// <summary>
        /// Checks to see if the Annotations property is set.
        /// </summary>
        internal bool IsSetAnnotations() => this.Annotations != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the tool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InputSchema. 
        /// <para>
        /// The input schema for the tool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Amazon.Runtime.Documents.Document InputSchema { get; set; }

        /// <summary>
        /// Checks to see if the InputSchema property is set.
        /// </summary>
        internal bool IsSetInputSchema() => !this.InputSchema.IsNull();

        /// <summary>
        /// Gets and sets the property Instruction. 
        /// <para>
        /// Instructions for using the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ToolInstruction Instruction { get; set; }

        /// <summary>
        /// Checks to see if the Instruction property is set.
        /// </summary>
        internal bool IsSetInstruction() => this.Instruction != null;

        /// <summary>
        /// Gets and sets the property OutputFilters. 
        /// <para>
        /// Output filters applies to the tool result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<ToolOutputFilter> OutputFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<ToolOutputFilter>() : null;

        /// <summary>
        /// Checks to see if the OutputFilters property is set.
        /// </summary>
        internal bool IsSetOutputFilters() => this.OutputFilters != null && (this.OutputFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputSchema. 
        /// <para>
        /// The output schema for the tool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Amazon.Runtime.Documents.Document OutputSchema { get; set; }

        /// <summary>
        /// Checks to see if the OutputSchema property is set.
        /// </summary>
        internal bool IsSetOutputSchema() => !this.OutputSchema.IsNull();

        /// <summary>
        /// Gets and sets the property OverrideInputValues. 
        /// <para>
        /// Override input values for the tool configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<ToolOverrideInputValue> OverrideInputValues { get; set; } = AWSConfigs.InitializeCollections ? new List<ToolOverrideInputValue>() : null;

        /// <summary>
        /// Checks to see if the OverrideInputValues property is set.
        /// </summary>
        internal bool IsSetOverrideInputValues() => this.OverrideInputValues != null && (this.OverrideInputValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the tool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property ToolId. 
        /// <para>
        /// The identifier of the tool, for example toolName from Model Context Provider server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string ToolId { get; set; }

        /// <summary>
        /// Checks to see if the ToolId property is set.
        /// </summary>
        internal bool IsSetToolId() => this.ToolId != null;

        /// <summary>
        /// Gets and sets the property ToolName. 
        /// <para>
        /// The name of the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string ToolName { get; set; }

        /// <summary>
        /// Checks to see if the ToolName property is set.
        /// </summary>
        internal bool IsSetToolName() => this.ToolName != null;

        /// <summary>
        /// Gets and sets the property ToolType. 
        /// <para>
        /// The type of the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ToolType ToolType { get; set; }

        /// <summary>
        /// Checks to see if the ToolType property is set.
        /// </summary>
        internal bool IsSetToolType() => this.ToolType != null;

        /// <summary>
        /// Gets and sets the property UserInteractionConfiguration. 
        /// <para>
        /// Configuration for user interaction with the tool.
        /// </para>
        /// </summary>
        public UserInteractionConfiguration UserInteractionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the UserInteractionConfiguration property is set.
        /// </summary>
        internal bool IsSetUserInteractionConfiguration() => this.UserInteractionConfiguration != null;
    }
}
