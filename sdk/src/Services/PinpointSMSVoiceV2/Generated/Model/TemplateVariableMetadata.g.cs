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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Contains metadata about a template variable.
    /// </summary>
    public partial class TemplateVariableMetadata
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value for the variable.
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
        /// A description of the variable.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// The maximum length for string variables.
        /// </para>
        /// </summary>
        public int? MaxLength { get; set; }

        /// <summary>
        /// Checks to see if the MaxLength property is set.
        /// </summary>
        internal bool IsSetMaxLength() => this.MaxLength.HasValue;

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maximum value for numeric variables.
        /// </para>
        /// </summary>
        public int? MaxValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxValue property is set.
        /// </summary>
        internal bool IsSetMaxValue() => this.MaxValue.HasValue;

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The minimum value for numeric variables.
        /// </para>
        /// </summary>
        public int? MinValue { get; set; }

        /// <summary>
        /// Checks to see if the MinValue property is set.
        /// </summary>
        internal bool IsSetMinValue() => this.MinValue.HasValue;

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// The regex pattern the variable value must match.
        /// </para>
        /// </summary>
        public string Pattern { get; set; }

        /// <summary>
        /// Checks to see if the Pattern property is set.
        /// </summary>
        internal bool IsSetPattern() => this.Pattern != null;

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Whether the variable is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;

        /// <summary>
        /// Gets and sets the property Sample. 
        /// <para>
        /// A sample value for the variable.
        /// </para>
        /// </summary>
        public string Sample { get; set; }

        /// <summary>
        /// Checks to see if the Sample property is set.
        /// </summary>
        internal bool IsSetSample() => this.Sample != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the variable, either <c>CUSTOMER</c> or <c>SYSTEM</c>.
        /// </para>
        /// </summary>
        public TemplateVariableSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the variable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TemplateVariableType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
