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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// A map of key-value pairs that describe the command.
    /// </summary>
    public partial class CommandParameter
    {
        private CommandParameterValue _defaultValue;
        private string _description;
        private string _name;
        private CommandParameterType _type;
        private CommandParameterValue _value;
        private List<CommandParameterValueCondition> _valueConditions = AWSConfigs.InitializeCollections ? new List<CommandParameterValueCondition>() : null;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value used to describe the command. This is the value assumed by the parameter
        /// if no other value is assigned to it.
        /// </para>
        /// </summary>
        public CommandParameterValue DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the command parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2028)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a specific parameter used in a command and command execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=192)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the command parameter.
        /// </para>
        /// </summary>
        public CommandParameterType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Parameter value that overrides the default value, if set.
        /// </para>
        /// </summary>
        public CommandParameterValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

        /// <summary>
        /// Gets and sets the property ValueConditions. 
        /// <para>
        /// The list of conditions that a command parameter value must satisfy to create a command
        /// execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<CommandParameterValueCondition> ValueConditions
        {
            get { return this._valueConditions; }
            set { this._valueConditions = value; }
        }

        // Check to see if ValueConditions property is set
        internal bool IsSetValueConditions()
        {
            return this._valueConditions != null && (this._valueConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}