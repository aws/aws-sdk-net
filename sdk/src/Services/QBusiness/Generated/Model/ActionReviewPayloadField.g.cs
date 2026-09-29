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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// A user input field in an plugin action review payload.
    /// </summary>
    public partial class ActionReviewPayloadField
    {
        /// <summary>
        /// Gets and sets the property AllowedFormat. 
        /// <para>
        /// The expected data format for the action review input field value. For example, in
        /// PTO request, <c>from</c> and <c>to</c> would be of <c>datetime</c> allowed format.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AllowedFormat { get; set; }

        /// <summary>
        /// Checks to see if the AllowedFormat property is set.
        /// </summary>
        internal bool IsSetAllowedFormat() => this.AllowedFormat != null;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// Information about the field values that an end user can use to provide to Amazon Q
        /// Business for Amazon Q Business to perform the requested plugin action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ActionReviewPayloadFieldAllowedValue> AllowedValues { get; set; } = AWSConfigs.InitializeCollections ? new List<ActionReviewPayloadFieldAllowedValue>() : null;

        /// <summary>
        /// Checks to see if the AllowedValues property is set.
        /// </summary>
        internal bool IsSetAllowedValues() => this.AllowedValues != null && (this.AllowedValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ArrayItemJsonSchema. 
        /// <para>
        /// Use to create a custom form with array fields (fields with nested objects inside an
        /// array).
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ArrayItemJsonSchema { get; set; }

        /// <summary>
        /// Checks to see if the ArrayItemJsonSchema property is set.
        /// </summary>
        internal bool IsSetArrayItemJsonSchema() => !this.ArrayItemJsonSchema.IsNull();

        /// <summary>
        /// Gets and sets the property DisplayDescription. 
        /// <para>
        /// The field level description of each action review input field. This could be an explanation
        /// of the field. In the Amazon Q Business web experience, these descriptions could be
        /// used to display as tool tips to help users understand the field. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DisplayDescription { get; set; }

        /// <summary>
        /// Checks to see if the DisplayDescription property is set.
        /// </summary>
        internal bool IsSetDisplayDescription() => this.DisplayDescription != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        ///  The name of the field. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property DisplayOrder. 
        /// <para>
        /// The display order of fields in a payload.
        /// </para>
        /// </summary>
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Checks to see if the DisplayOrder property is set.
        /// </summary>
        internal bool IsSetDisplayOrder() => this.DisplayOrder.HasValue;

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Information about whether the field is required.
        /// </para>
        /// </summary>
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of field. 
        /// </para>
        /// </summary>
        public ActionPayloadFieldType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The field value.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => !this.Value.IsNull();
    }
}
