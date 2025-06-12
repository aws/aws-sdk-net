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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
        private string _allowedValues;
        private string _applyType;
        private string _defaultValue;
        private bool? _isModifiable;
        private bool? _isRequired;
        private List<MinimumEngineVersionPerAllowedValue> _minimumEngineVersionPerAllowedValue = AWSConfigs.InitializeCollections ? new List<MinimumEngineVersionPerAllowedValue>() : null;
        private string _settingDescription;
        private string _settingName;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// Indicates the acceptable values for the option group option.
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
        /// Gets and sets the property ApplyType. 
        /// <para>
        /// The DB engine specific parameter type for the option group option.
        /// </para>
        /// </summary>
        public string ApplyType
        {
            get { return this._applyType; }
            set { this._applyType = value; }
        }

        // Check to see if ApplyType property is set
        internal bool IsSetApplyType()
        {
            return this._applyType != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value for the option group option.
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
        /// Gets and sets the property IsModifiable. 
        /// <para>
        /// Indicates whether this option group option can be changed from the default value.
        /// </para>
        /// </summary>
        public bool? IsModifiable
        {
            get { return this._isModifiable; }
            set { this._isModifiable = value; }
        }

        // Check to see if IsModifiable property is set
        internal bool IsSetIsModifiable()
        {
            return this._isModifiable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsRequired. 
        /// <para>
        /// Indicates whether a value must be specified for this option setting of the option
        /// group option.
        /// </para>
        /// </summary>
        public bool? IsRequired
        {
            get { return this._isRequired; }
            set { this._isRequired = value; }
        }

        // Check to see if IsRequired property is set
        internal bool IsSetIsRequired()
        {
            return this._isRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumEngineVersionPerAllowedValue. 
        /// <para>
        /// The minimum DB engine version required for the corresponding allowed value for this
        /// option setting.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MinimumEngineVersionPerAllowedValue> MinimumEngineVersionPerAllowedValue
        {
            get { return this._minimumEngineVersionPerAllowedValue; }
            set { this._minimumEngineVersionPerAllowedValue = value; }
        }

        // Check to see if MinimumEngineVersionPerAllowedValue property is set
        internal bool IsSetMinimumEngineVersionPerAllowedValue()
        {
            return this._minimumEngineVersionPerAllowedValue != null && (this._minimumEngineVersionPerAllowedValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SettingDescription. 
        /// <para>
        /// The description of the option group option.
        /// </para>
        /// </summary>
        public string SettingDescription
        {
            get { return this._settingDescription; }
            set { this._settingDescription = value; }
        }

        // Check to see if SettingDescription property is set
        internal bool IsSetSettingDescription()
        {
            return this._settingDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SettingName. 
        /// <para>
        /// The name of the option group option.
        /// </para>
        /// </summary>
        public string SettingName
        {
            get { return this._settingName; }
            set { this._settingName = value; }
        }

        // Check to see if SettingName property is set
        internal bool IsSetSettingName()
        {
            return this._settingName != null;
        }

    }
}