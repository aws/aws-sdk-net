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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes the possible values for a configuration option.
    /// </summary>
    public partial class ConfigurationOptionDescription
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
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
        ///  <c>RestartEnvironment</c> : The environment is entirely restarted, all A resources
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
        public string ChangeSeverity { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSeverity property is set.
        /// </summary>
        internal bool IsSetChangeSeverity() => this.ChangeSeverity != null;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value for this configuration option.
        /// </para>
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// If specified, the configuration option must be a string value no longer than this
        /// value.
        /// </para>
        /// </summary>
        public int? MaxLength { get; set; }

        /// <summary>
        /// Checks to see if the MaxLength property is set.
        /// </summary>
        internal bool IsSetMaxLength() => this.MaxLength.HasValue;

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// If specified, the configuration option must be a numeric value less than this value.
        /// </para>
        /// </summary>
        public int? MaxValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxValue property is set.
        /// </summary>
        internal bool IsSetMaxValue() => this.MaxValue.HasValue;

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// If specified, the configuration option must be a numeric value greater than this value.
        /// </para>
        /// </summary>
        public int? MinValue { get; set; }

        /// <summary>
        /// Checks to see if the MinValue property is set.
        /// </summary>
        internal bool IsSetMinValue() => this.MinValue.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configuration option.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// A unique namespace identifying the option's associated Amazon Web Services resource.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// If specified, the configuration option must be a string value that satisfies this
        /// regular expression.
        /// </para>
        /// </summary>
        public OptionRestrictionRegex Regex { get; set; }

        /// <summary>
        /// Checks to see if the Regex property is set.
        /// </summary>
        internal bool IsSetRegex() => this.Regex != null;

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
        public bool? UserDefined { get; set; }

        /// <summary>
        /// Checks to see if the UserDefined property is set.
        /// </summary>
        internal bool IsSetUserDefined() => this.UserDefined.HasValue;

        /// <summary>
        /// Gets and sets the property ValueOptions. 
        /// <para>
        /// If specified, values for the configuration option are selected from this list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValueOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ValueOptions property is set.
        /// </summary>
        internal bool IsSetValueOptions() => this.ValueOptions != null && (this.ValueOptions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public ConfigurationOptionValueType ValueType { get; set; }

        /// <summary>
        /// Checks to see if the ValueType property is set.
        /// </summary>
        internal bool IsSetValueType() => this.ValueType != null;
    }
}
