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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Defines a parameter that a role template accepts. You supply values for these parameters
    /// when you create a role with <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AcquireRole.html">AcquireRole</a>.
    /// </summary>
    public partial class ParameterDefinition
    {
        private string _defaultValue;
        private string _description;
        private bool? _immutable;
        private bool? _isRequired;
        private string _name;
        private string _subType;
        private ParameterTypeType _type;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The value that the service uses for the parameter when you do not supply one.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// A description of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
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
        /// Gets and sets the property Immutable. 
        /// <para>
        /// Specifies whether you can change the parameter value after you create the role.
        /// </para>
        /// </summary>
        public bool? Immutable
        {
            get { return this._immutable; }
            set { this._immutable = value; }
        }

        // Check to see if Immutable property is set
        internal bool IsSetImmutable()
        {
            return this._immutable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsRequired. 
        /// <para>
        /// Specifies whether you must supply a value for the parameter when you create a role
        /// from the template.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property SubType. 
        /// <para>
        /// An optional subtype that further constrains the values that are allowed for the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SubType
        {
            get { return this._subType; }
            set { this._subType = value; }
        }

        // Check to see if SubType property is set
        internal bool IsSetSubType()
        {
            return this._subType != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the parameter. Valid values are <c>String</c>, <c>StringList</c>,
        /// <c>Number</c>, <c>NumberList</c>, <c>Arn</c>, and <c>ArnList</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParameterTypeType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}