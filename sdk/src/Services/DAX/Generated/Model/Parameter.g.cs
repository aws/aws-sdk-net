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

namespace Amazon.DAX.Model
{
    /// <summary>
    /// Describes an individual setting that controls some aspect of DAX behavior.
    /// </summary>
    public partial class Parameter
    {
        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// A range of values within which the parameter can be set.
        /// </para>
        /// </summary>
        public string AllowedValues { get; set; }

        /// <summary>
        /// Checks to see if the AllowedValues property is set.
        /// </summary>
        internal bool IsSetAllowedValues() => this.AllowedValues != null;

        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// The conditions under which changes to this parameter can be applied. For example,
        /// <c>requires-reboot</c> indicates that a new value for this parameter will only take
        /// effect if a node is rebooted.
        /// </para>
        /// </summary>
        public ChangeType ChangeType { get; set; }

        /// <summary>
        /// Checks to see if the ChangeType property is set.
        /// </summary>
        internal bool IsSetChangeType() => this.ChangeType != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the parameter. For example, <c>integer</c>:
        /// </para>
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the parameter
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsModifiable. 
        /// <para>
        /// Whether the customer is allowed to modify the parameter.
        /// </para>
        /// </summary>
        public IsModifiable IsModifiable { get; set; }

        /// <summary>
        /// Checks to see if the IsModifiable property is set.
        /// </summary>
        internal bool IsSetIsModifiable() => this.IsModifiable != null;

        /// <summary>
        /// Gets and sets the property NodeTypeSpecificValues. 
        /// <para>
        /// A list of node types, and specific parameter values for each node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeTypeSpecificValue> NodeTypeSpecificValues { get; set; } = AWSConfigs.InitializeCollections ? new List<NodeTypeSpecificValue>() : null;

        /// <summary>
        /// Checks to see if the NodeTypeSpecificValues property is set.
        /// </summary>
        internal bool IsSetNodeTypeSpecificValues() => this.NodeTypeSpecificValues != null && (this.NodeTypeSpecificValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The name of the parameter.
        /// </para>
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterName property is set.
        /// </summary>
        internal bool IsSetParameterName() => this.ParameterName != null;

        /// <summary>
        /// Gets and sets the property ParameterType. 
        /// <para>
        /// Determines whether the parameter can be applied to any nodes, or only nodes of a particular
        /// type.
        /// </para>
        /// </summary>
        public ParameterType ParameterType { get; set; }

        /// <summary>
        /// Checks to see if the ParameterType property is set.
        /// </summary>
        internal bool IsSetParameterType() => this.ParameterType != null;

        /// <summary>
        /// Gets and sets the property ParameterValue. 
        /// <para>
        /// The value for the parameter.
        /// </para>
        /// </summary>
        public string ParameterValue { get; set; }

        /// <summary>
        /// Checks to see if the ParameterValue property is set.
        /// </summary>
        internal bool IsSetParameterValue() => this.ParameterValue != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// How the parameter is defined. For example, <c>system</c> denotes a system-defined
        /// parameter.
        /// </para>
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
