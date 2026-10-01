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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details of user parameters of an environment blueprint.
    /// </summary>
    public partial class CustomParameter
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of the parameter.
        /// </para>
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FieldType. 
        /// <para>
        /// The filed type of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FieldType { get; set; }

        /// <summary>
        /// Checks to see if the FieldType property is set.
        /// </summary>
        internal bool IsSetFieldType() => this.FieldType != null;

        /// <summary>
        /// Gets and sets the property IsEditable. 
        /// <para>
        /// Specifies whether the parameter is editable.
        /// </para>
        /// </summary>
        public bool? IsEditable { get; set; }

        /// <summary>
        /// Checks to see if the IsEditable property is set.
        /// </summary>
        internal bool IsSetIsEditable() => this.IsEditable.HasValue;

        /// <summary>
        /// Gets and sets the property IsOptional. 
        /// <para>
        /// Specifies whether the custom parameter is optional.
        /// </para>
        /// </summary>
        public bool? IsOptional { get; set; }

        /// <summary>
        /// Checks to see if the IsOptional property is set.
        /// </summary>
        internal bool IsSetIsOptional() => this.IsOptional.HasValue;

        /// <summary>
        /// Gets and sets the property IsUpdateSupported. 
        /// <para>
        /// Specifies whether a parameter value can be updated after creation. 
        /// </para>
        /// </summary>
        public bool? IsUpdateSupported { get; set; }

        /// <summary>
        /// Checks to see if the IsUpdateSupported property is set.
        /// </summary>
        internal bool IsSetIsUpdateSupported() => this.IsUpdateSupported.HasValue;

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The key name of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;
    }
}
