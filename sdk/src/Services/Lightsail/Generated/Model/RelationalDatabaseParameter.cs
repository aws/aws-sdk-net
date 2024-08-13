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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the parameters of a database.
    /// </summary>
    public partial class RelationalDatabaseParameter
    {
        private string _allowedValues;
        private string _applyMethod;
        private string _applyType;
        private string _dataType;
        private string _description;
        private bool? _isModifiable;
        private string _parameterName;
        private string _parameterValue;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// Specifies the valid range of values for the parameter.
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
        /// Gets and sets the property ApplyMethod. 
        /// <para>
        /// Indicates when parameter updates are applied.
        /// </para>
        ///  
        /// <para>
        /// Can be <c>immediate</c> or <c>pending-reboot</c>.
        /// </para>
        /// </summary>
        public string ApplyMethod
        {
            get { return this._applyMethod; }
            set { this._applyMethod = value; }
        }

        // Check to see if ApplyMethod property is set
        internal bool IsSetApplyMethod()
        {
            return this._applyMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ApplyType. 
        /// <para>
        /// Specifies the engine-specific parameter type.
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
        /// Specifies the valid data type for the parameter.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Provides a description of the parameter.
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
        /// Gets and sets the property IsModifiable. 
        /// <para>
        /// A Boolean value indicating whether the parameter can be modified.
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
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// Specifies the name of the parameter.
        /// </para>
        /// </summary>
        public string ParameterName
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this._parameterName != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterValue. 
        /// <para>
        /// Specifies the value of the parameter.
        /// </para>
        /// </summary>
        public string ParameterValue
        {
            get { return this._parameterValue; }
            set { this._parameterValue = value; }
        }

        // Check to see if ParameterValue property is set
        internal bool IsSetParameterValue()
        {
            return this._parameterValue != null;
        }

    }
}