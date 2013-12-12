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
    /// <para> option group option settings are used to display settings available for each option with their default values and other information.
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

        // Check to see if IsModifiable property is set
        internal bool IsSetIsModifiable()
        {
            return this.isModifiable.HasValue;
        }
    }
}
