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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
        private Annotation _annotations;
        private string _description;
        private Amazon.Runtime.Documents.Document _inputSchema;
        private ToolInstruction _instruction;
        private List<ToolOutputFilter> _outputFilters = AWSConfigs.InitializeCollections ? new List<ToolOutputFilter>() : null;
        private Amazon.Runtime.Documents.Document _outputSchema;
        private List<ToolOverrideInputValue> _overrideInputValues = AWSConfigs.InitializeCollections ? new List<ToolOverrideInputValue>() : null;
        private string _title;
        private string _toolId;
        private string _toolName;
        private ToolType _toolType;
        private UserInteractionConfiguration _userInteractionConfiguration;

        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// Annotations for the tool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Annotation Annotations
        {
            get { return this._annotations; }
            set { this._annotations = value; }
        }

        // Check to see if Annotations property is set
        internal bool IsSetAnnotations()
        {
            return this._annotations != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the tool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InputSchema. 
        /// <para>
        /// The input schema for the tool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Amazon.Runtime.Documents.Document InputSchema
        {
            get { return this._inputSchema; }
            set { this._inputSchema = value; }
        }

        // Check to see if InputSchema property is set
        internal bool IsSetInputSchema()
        {
            return !this._inputSchema.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Instruction. 
        /// <para>
        /// Instructions for using the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ToolInstruction Instruction
        {
            get { return this._instruction; }
            set { this._instruction = value; }
        }

        // Check to see if Instruction property is set
        internal bool IsSetInstruction()
        {
            return this._instruction != null;
        }

        /// <summary>
        /// Gets and sets the property OutputFilters. 
        /// <para>
        /// Output filters applies to the tool result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<ToolOutputFilter> OutputFilters
        {
            get { return this._outputFilters; }
            set { this._outputFilters = value; }
        }

        // Check to see if OutputFilters property is set
        internal bool IsSetOutputFilters()
        {
            return this._outputFilters != null && (this._outputFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutputSchema. 
        /// <para>
        /// The output schema for the tool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Amazon.Runtime.Documents.Document OutputSchema
        {
            get { return this._outputSchema; }
            set { this._outputSchema = value; }
        }

        // Check to see if OutputSchema property is set
        internal bool IsSetOutputSchema()
        {
            return !this._outputSchema.IsNull();
        }

        /// <summary>
        /// Gets and sets the property OverrideInputValues. 
        /// <para>
        /// Override input values for the tool configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<ToolOverrideInputValue> OverrideInputValues
        {
            get { return this._overrideInputValues; }
            set { this._overrideInputValues = value; }
        }

        // Check to see if OverrideInputValues property is set
        internal bool IsSetOverrideInputValues()
        {
            return this._overrideInputValues != null && (this._overrideInputValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the tool configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property ToolId. 
        /// <para>
        /// The identifier of the tool, for example toolName from Model Context Provider server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string ToolId
        {
            get { return this._toolId; }
            set { this._toolId = value; }
        }

        // Check to see if ToolId property is set
        internal bool IsSetToolId()
        {
            return this._toolId != null;
        }

        /// <summary>
        /// Gets and sets the property ToolName. 
        /// <para>
        /// The name of the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string ToolName
        {
            get { return this._toolName; }
            set { this._toolName = value; }
        }

        // Check to see if ToolName property is set
        internal bool IsSetToolName()
        {
            return this._toolName != null;
        }

        /// <summary>
        /// Gets and sets the property ToolType. 
        /// <para>
        /// The type of the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ToolType ToolType
        {
            get { return this._toolType; }
            set { this._toolType = value; }
        }

        // Check to see if ToolType property is set
        internal bool IsSetToolType()
        {
            return this._toolType != null;
        }

        /// <summary>
        /// Gets and sets the property UserInteractionConfiguration. 
        /// <para>
        /// Configuration for user interaction with the tool.
        /// </para>
        /// </summary>
        public UserInteractionConfiguration UserInteractionConfiguration
        {
            get { return this._userInteractionConfiguration; }
            set { this._userInteractionConfiguration = value; }
        }

        // Check to see if UserInteractionConfiguration property is set
        internal bool IsSetUserInteractionConfiguration()
        {
            return this._userInteractionConfiguration != null;
        }

    }
}