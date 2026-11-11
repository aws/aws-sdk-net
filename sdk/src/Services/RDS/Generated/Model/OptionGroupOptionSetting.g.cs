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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Option group option settings are used to display settings available for each option
    /// with their default values and other information. These values are used with the DescribeOptionGroupOptions
    /// action.
    /// </summary>
    public partial class OptionGroupOptionSetting
    {
        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// Indicates the acceptable values for the option group option.
        /// </para>
        /// </summary>
        public string AllowedValues { get; set; }

        /// <summary>
        /// Checks to see if the AllowedValues property is set.
        /// </summary>
        internal bool IsSetAllowedValues() => this.AllowedValues != null;

        /// <summary>
        /// Gets and sets the property ApplyType. 
        /// <para>
        /// The DB engine specific parameter type for the option group option.
        /// </para>
        /// </summary>
        public string ApplyType { get; set; }

        /// <summary>
        /// Checks to see if the ApplyType property is set.
        /// </summary>
        internal bool IsSetApplyType() => this.ApplyType != null;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value for the option group option.
        /// </para>
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property IsModifiable. 
        /// <para>
        /// Indicates whether this option group option can be changed from the default value.
        /// </para>
        /// </summary>
        public bool? IsModifiable { get; set; }

        /// <summary>
        /// Checks to see if the IsModifiable property is set.
        /// </summary>
        internal bool IsSetIsModifiable() => this.IsModifiable.HasValue;

        /// <summary>
        /// Gets and sets the property IsRequired. 
        /// <para>
        /// Indicates whether a value must be specified for this option setting of the option
        /// group option.
        /// </para>
        /// </summary>
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Checks to see if the IsRequired property is set.
        /// </summary>
        internal bool IsSetIsRequired() => this.IsRequired.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumEngineVersionPerAllowedValue. 
        /// <para>
        /// The minimum DB engine version required for the corresponding allowed value for this
        /// option setting.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MinimumEngineVersionPerAllowedValue> MinimumEngineVersionPerAllowedValue { get; set; } = AWSConfigs.InitializeCollections ? new List<MinimumEngineVersionPerAllowedValue>() : null;

        /// <summary>
        /// Checks to see if the MinimumEngineVersionPerAllowedValue property is set.
        /// </summary>
        internal bool IsSetMinimumEngineVersionPerAllowedValue() => this.MinimumEngineVersionPerAllowedValue != null && (this.MinimumEngineVersionPerAllowedValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SettingDescription. 
        /// <para>
        /// The description of the option group option.
        /// </para>
        /// </summary>
        public string SettingDescription { get; set; }

        /// <summary>
        /// Checks to see if the SettingDescription property is set.
        /// </summary>
        internal bool IsSetSettingDescription() => this.SettingDescription != null;

        /// <summary>
        /// Gets and sets the property SettingName. 
        /// <para>
        /// The name of the option group option.
        /// </para>
        /// </summary>
        public string SettingName { get; set; }

        /// <summary>
        /// Checks to see if the SettingName property is set.
        /// </summary>
        internal bool IsSetSettingName() => this.SettingName != null;
    }
}
