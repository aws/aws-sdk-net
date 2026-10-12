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
    /// Per-rule validation constraints that override the field's default validation when
    /// the containing rule matches. All fields are optional; only the constraints that need
    /// to differ from the field's default validation are provided.
    /// </summary>
    public partial class ConditionalValidation
    {
        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// The allowed values for a select field when this rule applies. A subset of the field's
        /// full option list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> AllowedValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedValues property is set.
        /// </summary>
        internal bool IsSetAllowedValues() => this.AllowedValues != null && (this.AllowedValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// The maximum length for the field value when this rule applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Checks to see if the MaxLength property is set.
        /// </summary>
        internal bool IsSetMaxLength() => this.MaxLength.HasValue;

        /// <summary>
        /// Gets and sets the property MinLength. 
        /// <para>
        /// The minimum length for the field value when this rule applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MinLength { get; set; }

        /// <summary>
        /// Checks to see if the MinLength property is set.
        /// </summary>
        internal bool IsSetMinLength() => this.MinLength.HasValue;

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// A regular expression that the field value must match when this rule applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Pattern { get; set; }

        /// <summary>
        /// Checks to see if the Pattern property is set.
        /// </summary>
        internal bool IsSetPattern() => this.Pattern != null;
    }
}
