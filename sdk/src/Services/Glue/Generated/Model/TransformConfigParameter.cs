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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies the parameters in the config file of the dynamic transform.
    /// </summary>
    public partial class TransformConfigParameter
    {
        private bool? _isOptional;
        private ParamType _listType;
        private string _name;
        private ParamType _type;
        private string _validationMessage;
        private string _validationRule;
        private List<string> _value = new List<string>();

        /// <summary>
        /// Gets and sets the property IsOptional. 
        /// <para>
        /// Specifies whether the parameter is optional or not in the config file of the dynamic
        /// transform.
        /// </para>
        /// </summary>
        public bool IsOptional
        {
            get { return this._isOptional.GetValueOrDefault(); }
            set { this._isOptional = value; }
        }

        // Check to see if IsOptional property is set
        internal bool IsSetIsOptional()
        {
            return this._isOptional.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ListType. 
        /// <para>
        /// Specifies the list type of the parameter in the config file of the dynamic transform.
        /// </para>
        /// </summary>
        public ParamType ListType
        {
            get { return this._listType; }
            set { this._listType = value; }
        }

        // Check to see if ListType property is set
        internal bool IsSetListType()
        {
            return this._listType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the parameter in the config file of the dynamic transform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the parameter type in the config file of the dynamic transform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParamType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationMessage. 
        /// <para>
        /// Specifies the validation message in the config file of the dynamic transform.
        /// </para>
        /// </summary>
        public string ValidationMessage
        {
            get { return this._validationMessage; }
            set { this._validationMessage = value; }
        }

        // Check to see if ValidationMessage property is set
        internal bool IsSetValidationMessage()
        {
            return this._validationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationRule. 
        /// <para>
        /// Specifies the validation rule in the config file of the dynamic transform.
        /// </para>
        /// </summary>
        public string ValidationRule
        {
            get { return this._validationRule; }
            set { this._validationRule = value; }
        }

        // Check to see if ValidationRule property is set
        internal bool IsSetValidationRule()
        {
            return this._validationRule != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Specifies the value of the parameter in the config file of the dynamic transform.
        /// </para>
        /// </summary>
        public List<string> Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null && this._value.Count > 0; 
        }

    }
}