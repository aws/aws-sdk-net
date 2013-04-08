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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> Option Group option settings are used to display settings available for each option with their default values and other information.
    /// These values are used with the DescribeOptionGroupOptions action. </para>
    /// </summary>
    public class OptionGroupOptionSetting
    {
        
        private string settingName;
        private string settingDescription;
        private string defaultValue;
        private string applyType;
        private string allowedValues;
        private bool? isModifiable;

        /// <summary>
        /// The name of the option group option.
        ///  
        /// </summary>
        public string SettingName
        {
            get { return this.settingName; }
            set { this.settingName = value; }
        }

        /// <summary>
        /// Sets the SettingName property
        /// </summary>
        /// <param name="settingName">The value to set for the SettingName property </param>
        /// <returns>this instance</returns>
        public OptionGroupOptionSetting WithSettingName(string settingName)
        {
            this.settingName = settingName;
            return this;
        }
            

        // Check to see if SettingName property is set
        internal bool IsSetSettingName()
        {
            return this.settingName != null;
        }

        /// <summary>
        /// The description of the option group option.
        ///  
        /// </summary>
        public string SettingDescription
        {
            get { return this.settingDescription; }
            set { this.settingDescription = value; }
        }

        /// <summary>
        /// Sets the SettingDescription property
        /// </summary>
        /// <param name="settingDescription">The value to set for the SettingDescription property </param>
        /// <returns>this instance</returns>
        public OptionGroupOptionSetting WithSettingDescription(string settingDescription)
        {
            this.settingDescription = settingDescription;
            return this;
        }
            

        // Check to see if SettingDescription property is set
        internal bool IsSetSettingDescription()
        {
            return this.settingDescription != null;
        }

        /// <summary>
        /// The default value for the option group option.
        ///  
        /// </summary>
        public string DefaultValue
        {
            get { return this.defaultValue; }
            set { this.defaultValue = value; }
        }

        /// <summary>
        /// Sets the DefaultValue property
        /// </summary>
        /// <param name="defaultValue">The value to set for the DefaultValue property </param>
        /// <returns>this instance</returns>
        public OptionGroupOptionSetting WithDefaultValue(string defaultValue)
        {
            this.defaultValue = defaultValue;
            return this;
        }
            

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this.defaultValue != null;
        }

        /// <summary>
        /// The DB engine specific parameter type for the option group option.
        ///  
        /// </summary>
        public string ApplyType
        {
            get { return this.applyType; }
            set { this.applyType = value; }
        }

        /// <summary>
        /// Sets the ApplyType property
        /// </summary>
        /// <param name="applyType">The value to set for the ApplyType property </param>
        /// <returns>this instance</returns>
        public OptionGroupOptionSetting WithApplyType(string applyType)
        {
            this.applyType = applyType;
            return this;
        }
            

        // Check to see if ApplyType property is set
        internal bool IsSetApplyType()
        {
            return this.applyType != null;
        }

        /// <summary>
        /// Indicates the acceptable values for the option group option.
        ///  
        /// </summary>
        public string AllowedValues
        {
            get { return this.allowedValues; }
            set { this.allowedValues = value; }
        }

        /// <summary>
        /// Sets the AllowedValues property
        /// </summary>
        /// <param name="allowedValues">The value to set for the AllowedValues property </param>
        /// <returns>this instance</returns>
        public OptionGroupOptionSetting WithAllowedValues(string allowedValues)
        {
            this.allowedValues = allowedValues;
            return this;
        }
            

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this.allowedValues != null;
        }

        /// <summary>
        /// Boolean value where true indicates that this option group option can be changed from the default value.
        ///  
        /// </summary>
        public bool IsModifiable
        {
            get { return this.isModifiable ?? default(bool); }
            set { this.isModifiable = value; }
        }

        /// <summary>
        /// Sets the IsModifiable property
        /// </summary>
        /// <param name="isModifiable">The value to set for the IsModifiable property </param>
        /// <returns>this instance</returns>
        public OptionGroupOptionSetting WithIsModifiable(bool isModifiable)
        {
            this.isModifiable = isModifiable;
            return this;
        }
            

        // Check to see if IsModifiable property is set
        internal bool IsSetIsModifiable()
        {
            return this.isModifiable.HasValue;
        }
    }
}
