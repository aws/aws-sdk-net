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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
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
        private string _allowedValues;
        private ChangeType _changeType;
        private string _dataType;
        private string _description;
        private IsModifiable _isModifiable;
        private List<NodeTypeSpecificValue> _nodeTypeSpecificValues = AWSConfigs.InitializeCollections ? new List<NodeTypeSpecificValue>() : null;
        private string _parameterName;
        private ParameterType _parameterType;
        private string _parameterValue;
        private string _source;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// A range of values within which the parameter can be set.
        /// </para>
        /// </summary>
        public string AllowedValues
        {
            get { return this._allowedValues; }
            set { this._allowedValues = value; }
        }

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this._allowedValues != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// The conditions under which changes to this parameter can be applied. For example,
        /// <c>requires-reboot</c> indicates that a new value for this parameter will only take
        /// effect if a node is rebooted.
        /// </para>
        /// </summary>
        public ChangeType ChangeType
        {
            get { return this._changeType; }
            set { this._changeType = value; }
        }

        // Check to see if ChangeType property is set
        internal bool IsSetChangeType()
        {
            return this._changeType != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the parameter. For example, <c>integer</c>:
        /// </para>
        /// </summary>
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the parameter
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IsModifiable. 
        /// <para>
        /// Whether the customer is allowed to modify the parameter.
        /// </para>
        /// </summary>
        public IsModifiable IsModifiable
        {
            get { return this._isModifiable; }
            set { this._isModifiable = value; }
        }

        // Check to see if IsModifiable property is set
        internal bool IsSetIsModifiable()
        {
            return this._isModifiable != null;
        }

        /// <summary>
        /// Gets and sets the property NodeTypeSpecificValues. 
        /// <para>
        /// A list of node types, and specific parameter values for each node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeTypeSpecificValue> NodeTypeSpecificValues
        {
            get { return this._nodeTypeSpecificValues; }
            set { this._nodeTypeSpecificValues = value; }
        }

        // Check to see if NodeTypeSpecificValues property is set
        internal bool IsSetNodeTypeSpecificValues()
        {
            return this._nodeTypeSpecificValues != null && (this._nodeTypeSpecificValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The name of the parameter.
        /// </para>
        /// </summary>
        public string ParameterName
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this._parameterName != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterType. 
        /// <para>
        /// Determines whether the parameter can be applied to any nodes, or only nodes of a particular
        /// type.
        /// </para>
        /// </summary>
        public ParameterType ParameterType
        {
            get { return this._parameterType; }
            set { this._parameterType = value; }
        }

        // Check to see if ParameterType property is set
        internal bool IsSetParameterType()
        {
            return this._parameterType != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterValue. 
        /// <para>
        /// The value for the parameter.
        /// </para>
        /// </summary>
        public string ParameterValue
        {
            get { return this._parameterValue; }
            set { this._parameterValue = value; }
        }

        // Check to see if ParameterValue property is set
        internal bool IsSetParameterValue()
        {
            return this._parameterValue != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// How the parameter is defined. For example, <c>system</c> denotes a system-defined
        /// parameter.
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}