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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The value that the service uses for the parameter when you do not supply one.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Immutable. 
        /// <para>
        /// Specifies whether you can change the parameter value after you create the role.
        /// </para>
        /// </summary>
        public bool? Immutable { get; set; }

        /// <summary>
        /// Checks to see if the Immutable property is set.
        /// </summary>
        internal bool IsSetImmutable() => this.Immutable.HasValue;

        /// <summary>
        /// Gets and sets the property IsRequired. 
        /// <para>
        /// Specifies whether you must supply a value for the parameter when you create a role
        /// from the template.
        /// </para>
        /// </summary>
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Checks to see if the IsRequired property is set.
        /// </summary>
        internal bool IsSetIsRequired() => this.IsRequired.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SubType. 
        /// <para>
        /// An optional subtype that further constrains the values that are allowed for the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SubType { get; set; }

        /// <summary>
        /// Checks to see if the SubType property is set.
        /// </summary>
        internal bool IsSetSubType() => this.SubType != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the parameter. Valid values are <c>String</c>, <c>StringList</c>,
        /// <c>Number</c>, <c>NumberList</c>, <c>Arn</c>, and <c>ArnList</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ParameterTypeType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
