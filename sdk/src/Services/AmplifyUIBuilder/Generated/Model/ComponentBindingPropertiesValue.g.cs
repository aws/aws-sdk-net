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
    /// Represents the data binding configuration for a component at runtime. You can use
    /// <c>ComponentBindingPropertiesValue</c> to add exposed properties to a component to
    /// allow different values to be entered when a component is reused in different places
    /// in an app.
    /// </summary>
    public partial class ComponentBindingPropertiesValue
    {
        /// <summary>
        /// Gets and sets the property BindingProperties. 
        /// <para>
        /// Describes the properties to customize with data at runtime.
        /// </para>
        /// </summary>
        public ComponentBindingPropertiesValueProperties BindingProperties { get; set; }

        /// <summary>
        /// Checks to see if the BindingProperties property is set.
        /// </summary>
        internal bool IsSetBindingProperties() => this.BindingProperties != null;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of the property.
        /// </para>
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The property type.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
