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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes the possible values for a configuration option.
    /// </summary>
    public partial class ConfigurationOptionDescription
    {
        private string _changeSeverity;
        private string _defaultValue;
        private int? _maxLength;
        private int? _maxValue;
        private int? _minValue;
        private string _name;
        private string _awsNamespace;
        private OptionRestrictionRegex _regex;
        private bool? _userDefined;
        private List<string> _valueOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ConfigurationOptionValueType _valueType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ConfigurationOptionDescription() { }

        /// <summary>
        /// Gets and sets the property ChangeSeverity. 
        /// <para>
        /// An indication of which action is required if the value for this configuration option
        /// changes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NoInterruption</c> : There is no interruption to the environment or application
        /// availability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RestartEnvironment</c> : The environment is entirely restarted, all AWS resources
        /// are deleted and recreated, and the environment is unavailable during the process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RestartApplicationServer</c> : The environment is available the entire time. However,
        /// a short application outage occurs when the application servers on the running Amazon
        /// EC2 instances are restarted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ChangeSeverity
        {
            get { return this._changeSeverity; }
            set { this._changeSeverity = value; }
        }

        // Check to see if ChangeSeverity property is set
        internal bool IsSetChangeSeverity()
        {
            return this._changeSeverity != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value for this configuration option.
        /// </para>
        /// </summary>
        public string DefaultValue
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
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// If specified, the configuration option must be a string value no longer than this
        /// value.
        /// </para>
        /// </summary>
        public int? MaxLength
        {
            get { return this._maxLength; }
            set { this._maxLength = value; }
        }

        // Check to see if MaxLength property is set
        internal bool IsSetMaxLength()
        {
            return this._maxLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// If specified, the configuration option must be a numeric value less than this value.
        /// </para>
        /// </summary>
        public int? MaxValue
        {
            get { return this._maxValue; }
            set { this._maxValue = value; }
        }

        // Check to see if MaxValue property is set
        internal bool IsSetMaxValue()
        {
            return this._maxValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// If specified, the configuration option must be a numeric value greater than this value.
        /// </para>
        /// </summary>
        public int? MinValue
        {
            get { return this._minValue; }
            set { this._minValue = value; }
        }

        // Check to see if MinValue property is set
        internal bool IsSetMinValue()
        {
            return this._minValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configuration option.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Namespace. 
        /// <para>
        /// A unique namespace identifying the option's associated AWS resource.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// If specified, the configuration option must be a string value that satisfies this
        /// regular expression.
        /// </para>
        /// </summary>
        public OptionRestrictionRegex Regex
        {
            get { return this._regex; }
            set { this._regex = value; }
        }

        // Check to see if Regex property is set
        internal bool IsSetRegex()
        {
            return this._regex != null;
        }

        /// <summary>
        /// Gets and sets the property UserDefined. 
        /// <para>
        /// An indication of whether the user defined this configuration option:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>true</c> : This configuration option was defined by the user. It is a valid choice
        /// for specifying if this as an <c>Option to Remove</c> when updating configuration settings.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c> : This configuration was not defined by the user.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Constraint: You can remove only <c>UserDefined</c> options from a configuration.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Valid Values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        public bool? UserDefined
        {
            get { return this._userDefined; }
            set { this._userDefined = value; }
        }

        // Check to see if UserDefined property is set
        internal bool IsSetUserDefined()
        {
            return this._userDefined.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValueOptions. 
        /// <para>
        /// If specified, values for the configuration option are selected from this list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValueOptions
        {
            get { return this._valueOptions; }
            set { this._valueOptions = value; }
        }

        // Check to see if ValueOptions property is set
        internal bool IsSetValueOptions()
        {
            return this._valueOptions != null && (this._valueOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValueType. 
        /// <para>
        /// An indication of which type of values this option has and whether it is allowable
        /// to select one or more than one of the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Scalar</c> : Values for this option are a single selection from the possible values,
        /// or an unformatted string, or numeric value governed by the <c>MIN/MAX/Regex</c> constraints.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>List</c> : Values for this option are multiple selections from the possible values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Boolean</c> : Values for this option are either <c>true</c> or <c>false</c> .
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Json</c> : Values for this option are a JSON representation of a <c>ConfigDocument</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConfigurationOptionValueType ValueType
        {
            get { return this._valueType; }
            set { this._valueType = value; }
        }

        // Check to see if ValueType property is set
        internal bool IsSetValueType()
        {
            return this._valueType != null;
        }

    }
}