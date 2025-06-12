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
    /// This data type is used as a request parameter in the <c>ModifyDBParameterGroup</c>
    /// and <c>ResetDBParameterGroup</c> actions.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <c>DescribeEngineDefaultParameters</c>
    /// and <c>DescribeDBParameters</c> actions.
    /// </para>
    /// </summary>
    public partial class Parameter
    {
        private string _allowedValues;
        private ApplyMethod _applyMethod;
        private string _applyType;
        private string _dataType;
        private string _description;
        private bool? _isModifiable;
        private string _minimumEngineVersion;
        private string _parameterName;
        private string _parameterValue;
        private string _source;
        private List<string> _supportedEngineModes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Parameter() { }

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
        /// Indicates when to apply parameter updates.
        /// </para>
        /// </summary>
        public ApplyMethod ApplyMethod
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
        /// Specifies the engine specific parameters type.
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
        /// Indicates whether (<c>true</c>) or not (<c>false</c>) the parameter can be modified.
        /// Some parameters have security or operational implications that prevent them from being
        /// changed.
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
        /// Gets and sets the property MinimumEngineVersion. 
        /// <para>
        /// The earliest engine version to which the parameter can apply.
        /// </para>
        /// </summary>
        public string MinimumEngineVersion
        {
            get { return this._minimumEngineVersion; }
            set { this._minimumEngineVersion = value; }
        }

        // Check to see if MinimumEngineVersion property is set
        internal bool IsSetMinimumEngineVersion()
        {
            return this._minimumEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The name of the parameter.
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
        /// The value of the parameter.
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

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the parameter value.
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedEngineModes. 
        /// <para>
        /// The valid DB engine modes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedEngineModes
        {
            get { return this._supportedEngineModes; }
            set { this._supportedEngineModes = value; }
        }

        // Check to see if SupportedEngineModes property is set
        internal bool IsSetSupportedEngineModes()
        {
            return this._supportedEngineModes != null && (this._supportedEngineModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}