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
    /// <para> Option settings are the actual settings being applied or configured for that option. It is used when you modify an option group or
    /// describe option groups. For example, the NATIVE_NETWORK_ENCRYPTION option has a setting called SQLNET.ENCRYPTION_SERVER that can have
    /// several different values. </para>
    /// </summary>
    public class OptionSetting
    {
        
        private string name;
        private string value;
        private string defaultValue;
        private string description;
        private string applyType;
        private string dataType;
        private string allowedValues;
        private bool? isModifiable;
        private bool? isCollection;


        /// <summary>
        /// The name of the option that has settings that you can set.
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
        /// The current value of the option setting.
        ///  
        /// </summary>
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this.value != null;
        }

        /// <summary>
        /// The default value of the option setting.
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
        /// The description of the option setting.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The DB engine specific parameter type.
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
        /// The data type of the option setting.
        ///  
        /// </summary>
        public string DataType
        {
            get { return this.dataType; }
            set { this.dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this.dataType != null;
        }

        /// <summary>
        /// The allowed values of the option setting.
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
        /// A Boolean value that, when true, indicates the option setting can be modified from the default.
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

        /// <summary>
        /// Indicates if the option setting is part of a collection.
        ///  
        /// </summary>
        public bool IsCollection
        {
            get { return this.isCollection ?? default(bool); }
            set { this.isCollection = value; }
        }

        // Check to see if IsCollection property is set
        internal bool IsSetIsCollection()
        {
            return this.isCollection.HasValue;
        }
    }
}
