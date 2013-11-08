/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para> Describes the possible values for a configuration option. </para>
    /// </summary>
    public class ConfigurationOptionDescription
    {
        
        private string namespaceValue;
        private string name;
        private string defaultValue;
        private string changeSeverity;
        private bool? userDefined;
        private ConfigurationOptionValueType valueType;
        private List<string> valueOptions = new List<string>();
        private int? minValue;
        private int? maxValue;
        private int? maxLength;
        private OptionRestrictionRegex regex;

        /// <summary>
        /// A unique namespace identifying the option's associated AWS resource.
        ///  
        /// </summary>
        public string Namespace
        {
            get { return this.namespaceValue; }
            set { this.namespaceValue = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this.namespaceValue != null;
        }

        /// <summary>
        /// The name of the configuration option.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The default value for this configuration option.
        ///  
        /// </summary>
        public string DefaultValue
        {
            get { return this.defaultValue; }
            set { this.defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this.defaultValue != null;
        }

        /// <summary>
        /// An indication of which action is required if the value for this configuration option changes: <enumValues> <value name="NoInterruption">
        /// NoInterruption - There is no interruption to the environment or application availability. </value> <value name="RestartEnvironment">
        /// RestartEnvironment - The environment is restarted, all AWS resources are deleted and recreated, and the environment is unavailable during
        /// the process. </value> <value name="RestartApplicationServer"> RestartApplicationServer - The environment is available the entire time.
        /// However, a short application outage occurs when the application servers on the running Amazon EC2 instances are restarted. </value>
        /// </enumValues> <ul> <li> <c>NoInterruption</c> : There is no interruption to the environment or application availability. </li> <li>
        /// <c>RestartEnvironment</c> : The environment is entirely restarted, all AWS resources are deleted and recreated, and the environment is
        /// unavailable during the process. </li> <li> <c>RestartApplicationServer</c> : The environment is available the entire time. However, a short
        /// application outage occurs when the application servers on the running Amazon EC2 instances are restarted. </li> </ul>
        ///  
        /// </summary>
        public string ChangeSeverity
        {
            get { return this.changeSeverity; }
            set { this.changeSeverity = value; }
        }

        // Check to see if ChangeSeverity property is set
        internal bool IsSetChangeSeverity()
        {
            return this.changeSeverity != null;
        }

        /// <summary>
        /// An indication of whether the user defined this configuration option: <enumValues> <value name="true"> <c>true</c> : This configuration
        /// option was defined by the user. It is a valid choice for specifying this as an Option to Remove when updating configuration settings.
        /// </value> <value name="false"> <c>false</c> : This configuration was not defined by the user. </value> </enumValues> <ul> <li> <c>true</c> :
        /// This configuration option was defined by the user. It is a valid choice for specifying if this as an <c>Option to Remove</c> when updating
        /// configuration settings. </li> <li> <c>false</c> : This configuration was not defined by the user. </li> </ul> Constraint: You can remove
        /// only <c>UserDefined</c> options from a configuration. Valid Values: <c>true</c> | <c>false</c>
        ///  
        /// </summary>
        public bool UserDefined
        {
            get { return this.userDefined ?? default(bool); }
            set { this.userDefined = value; }
        }

        // Check to see if UserDefined property is set
        internal bool IsSetUserDefined()
        {
            return this.userDefined.HasValue;
        }

        /// <summary>
        /// An indication of which type of values this option has and whether it is allowable to select one or more than one of the possible values:
        /// <enumValues> <value name="Scalar"> <c>Scalar</c> : Values for this option are a single selection from the possible values, or a unformatted
        /// string or numeric value governed by the MIN/MAX/Regex constraints: </value> <value name="List"> <c>List</c> : Values for this option are
        /// multiple selections of the possible values. </value> <value name="Boolean"> <c>Boolean</c> : Values for this option are either <c>true</c>
        /// or <c>false</c> . </value> </enumValues> <ul> <li> <c>Scalar</c> : Values for this option are a single selection from the possible values,
        /// or an unformatted string, or numeric value governed by the <c>MIN/MAX/Regex</c> constraints. </li> <li> <c>List</c> : Values for this option
        /// are multiple selections from the possible values. </li> <li> <c>Boolean</c> : Values for this option are either <c>true</c> or <c>false</c>
        /// . </li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Scalar, List</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ConfigurationOptionValueType ValueType
        {
            get { return this.valueType; }
            set { this.valueType = value; }
        }

        // Check to see if ValueType property is set
        internal bool IsSetValueType()
        {
            return this.valueType != null;
        }

        /// <summary>
        /// If specified, values for the configuration option are selected from this list.
        ///  
        /// </summary>
        public List<string> ValueOptions
        {
            get { return this.valueOptions; }
            set { this.valueOptions = value; }
        }

        // Check to see if ValueOptions property is set
        internal bool IsSetValueOptions()
        {
            return this.valueOptions.Count > 0;
        }

        /// <summary>
        /// If specified, the configuration option must be a numeric value greater than this value.
        ///  
        /// </summary>
        public int MinValue
        {
            get { return this.minValue ?? default(int); }
            set { this.minValue = value; }
        }

        // Check to see if MinValue property is set
        internal bool IsSetMinValue()
        {
            return this.minValue.HasValue;
        }

        /// <summary>
        /// If specified, the configuration option must be a numeric value less than this value.
        ///  
        /// </summary>
        public int MaxValue
        {
            get { return this.maxValue ?? default(int); }
            set { this.maxValue = value; }
        }

        // Check to see if MaxValue property is set
        internal bool IsSetMaxValue()
        {
            return this.maxValue.HasValue;
        }

        /// <summary>
        /// If specified, the configuration option must be a string value no longer than this value.
        ///  
        /// </summary>
        public int MaxLength
        {
            get { return this.maxLength ?? default(int); }
            set { this.maxLength = value; }
        }

        // Check to see if MaxLength property is set
        internal bool IsSetMaxLength()
        {
            return this.maxLength.HasValue;
        }

        /// <summary>
        /// If specified, the configuration option must be a string value that satisfies this regular expression.
        ///  
        /// </summary>
        public OptionRestrictionRegex Regex
        {
            get { return this.regex; }
            set { this.regex = value; }
        }

        // Check to see if Regex property is set
        internal bool IsSetRegex()
        {
            return this.regex != null;
        }
    }
}
