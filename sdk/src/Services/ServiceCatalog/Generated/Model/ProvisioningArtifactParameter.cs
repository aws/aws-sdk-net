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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about a parameter used to provision a product.
    /// </summary>
    public partial class ProvisioningArtifactParameter
    {
        private string _defaultValue;
        private string _description;
        private bool? _isNoEcho;
        private ParameterConstraints _parameterConstraints;
        private string _parameterKey;
        private string _parameterType;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value.
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
        /// The description of the parameter.
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
        /// Gets and sets the property IsNoEcho. 
        /// <para>
        /// If this value is true, the value for this parameter is obfuscated from view when the
        /// parameter is retrieved. This parameter is used to hide sensitive information.
        /// </para>
        /// </summary>
        public bool? IsNoEcho
        {
            get { return this._isNoEcho; }
            set { this._isNoEcho = value; }
        }

        // Check to see if IsNoEcho property is set
        internal bool IsSetIsNoEcho()
        {
            return this._isNoEcho.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParameterConstraints. 
        /// <para>
        /// Constraints that the administrator has put on a parameter.
        /// </para>
        /// </summary>
        public ParameterConstraints ParameterConstraints
        {
            get { return this._parameterConstraints; }
            set { this._parameterConstraints = value; }
        }

        // Check to see if ParameterConstraints property is set
        internal bool IsSetParameterConstraints()
        {
            return this._parameterConstraints != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterKey. 
        /// <para>
        /// The parameter key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string ParameterKey
        {
            get { return this._parameterKey; }
            set { this._parameterKey = value; }
        }

        // Check to see if ParameterKey property is set
        internal bool IsSetParameterKey()
        {
            return this._parameterKey != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterType. 
        /// <para>
        /// The parameter type.
        /// </para>
        /// </summary>
        public string ParameterType
        {
            get { return this._parameterType; }
            set { this._parameterType = value; }
        }

        // Check to see if ParameterType property is set
        internal bool IsSetParameterType()
        {
            return this._parameterType != null;
        }

    }
}