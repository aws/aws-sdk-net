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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
        private string _allowedFormat;
        private List<ActionReviewPayloadFieldAllowedValue> _allowedValues = AWSConfigs.InitializeCollections ? new List<ActionReviewPayloadFieldAllowedValue>() : null;
        private Amazon.Runtime.Documents.Document _arrayItemJsonSchema;
        private string _displayDescription;
        private string _displayName;
        private int? _displayOrder;
        private bool? _required;
        private ActionPayloadFieldType _type;
        private Amazon.Runtime.Documents.Document _value;

        /// <summary>
        /// Gets and sets the property AllowedFormat. 
        /// <para>
        /// The expected data format for the action review input field value. For example, in
        /// PTO request, <c>from</c> and <c>to</c> would be of <c>datetime</c> allowed format.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AllowedFormat
        {
            get { return this._allowedFormat; }
            set { this._allowedFormat = value; }
        }

        // Check to see if AllowedFormat property is set
        internal bool IsSetAllowedFormat()
        {
            return this._allowedFormat != null;
        }

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// Information about the field values that an end user can use to provide to Amazon Q
        /// Business for Amazon Q Business to perform the requested plugin action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ActionReviewPayloadFieldAllowedValue> AllowedValues
        {
            get { return this._allowedValues; }
            set { this._allowedValues = value; }
        }

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this._allowedValues != null && (this._allowedValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ArrayItemJsonSchema. 
        /// <para>
        /// Use to create a custom form with array fields (fields with nested objects inside an
        /// array).
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ArrayItemJsonSchema
        {
            get { return this._arrayItemJsonSchema; }
            set { this._arrayItemJsonSchema = value; }
        }

        // Check to see if ArrayItemJsonSchema property is set
        internal bool IsSetArrayItemJsonSchema()
        {
            return !this._arrayItemJsonSchema.IsNull();
        }

        /// <summary>
        /// Gets and sets the property DisplayDescription. 
        /// <para>
        /// The field level description of each action review input field. This could be an explanation
        /// of the field. In the Amazon Q Business web experience, these descriptions could be
        /// used to display as tool tips to help users understand the field. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DisplayDescription
        {
            get { return this._displayDescription; }
            set { this._displayDescription = value; }
        }

        // Check to see if DisplayDescription property is set
        internal bool IsSetDisplayDescription()
        {
            return this._displayDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        ///  The name of the field. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayOrder. 
        /// <para>
        /// The display order of fields in a payload.
        /// </para>
        /// </summary>
        public int? DisplayOrder
        {
            get { return this._displayOrder; }
            set { this._displayOrder = value; }
        }

        // Check to see if DisplayOrder property is set
        internal bool IsSetDisplayOrder()
        {
            return this._displayOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Information about whether the field is required.
        /// </para>
        /// </summary>
        public bool? Required
        {
            get { return this._required; }
            set { this._required = value; }
        }

        // Check to see if Required property is set
        internal bool IsSetRequired()
        {
            return this._required.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of field. 
        /// </para>
        /// </summary>
        public ActionPayloadFieldType Type
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The field value.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return !this._value.IsNull();
        }

    }
}