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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the configuration for an input field on a form. Use <c>FormInputValueProperty</c>
    /// to specify the values to render or bind by default.
    /// </summary>
    public partial class FormInputValueProperty
    {
        /// <summary>
        /// Gets and sets the property BindingProperties. 
        /// <para>
        /// The information to bind fields to data at runtime.
        /// </para>
        /// </summary>
        public FormInputValuePropertyBindingProperties BindingProperties { get; set; }

        /// <summary>
        /// Checks to see if the BindingProperties property is set.
        /// </summary>
        internal bool IsSetBindingProperties() => this.BindingProperties != null;

        /// <summary>
        /// Gets and sets the property Concat. 
        /// <para>
        /// A list of form properties to concatenate to create the value to assign to this field
        /// property.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FormInputValueProperty> Concat { get; set; } = AWSConfigs.InitializeCollections ? new List<FormInputValueProperty>() : null;

        /// <summary>
        /// Checks to see if the Concat property is set.
        /// </summary>
        internal bool IsSetConcat() => this.Concat != null && (this.Concat.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value to assign to the input field.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
