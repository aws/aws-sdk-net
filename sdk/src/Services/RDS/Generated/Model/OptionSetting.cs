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
    /// Option settings are the actual settings being applied or configured for that option.
    /// It is used when you modify an option group or describe option groups. For example,
    /// the NATIVE_NETWORK_ENCRYPTION option has a setting called SQLNET.ENCRYPTION_SERVER
    /// that can have several different values.
    /// </summary>
    public partial class OptionSetting
    {
        private string _allowedValues;
        private string _applyType;
        private string _dataType;
        private string _defaultValue;
        private string _description;
        private bool? _isCollection;
        private bool? _isModifiable;
        private string _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// The allowed values of the option setting.
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
        /// The DB engine specific parameter type.
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
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the option setting.
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
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of the option setting.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the option setting.
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
        /// Gets and sets the property IsCollection. 
        /// <para>
        /// Indicates whether the option setting is part of a collection.
        /// </para>
        /// </summary>
        public bool? IsCollection
        {
            get { return this._isCollection; }
            set { this._isCollection = value; }
        }

        // Check to see if IsCollection property is set
        internal bool IsSetIsCollection()
        {
            return this._isCollection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsModifiable. 
        /// <para>
        /// Indicates whether the option setting can be modified from the default.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the option that has settings that you can set.
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The current value of the option setting.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}