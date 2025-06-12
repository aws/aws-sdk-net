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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the PutSlotType operation.
    /// Creates a custom slot type or replaces an existing custom slot type.
    /// 
    ///  
    /// <para>
    /// To create a custom slot type, specify a name for the slot type and a set of enumeration
    /// values, which are the values that a slot of this type can assume. For more information,
    /// see <a>how-it-works</a>.
    /// </para>
    ///  
    /// <para>
    /// If you specify the name of an existing slot type, the fields in the request replace
    /// the existing values in the <c>$LATEST</c> version of the slot type. Amazon Lex removes
    /// the fields that you don't provide in the request. If you don't specify required fields,
    /// Amazon Lex throws an exception. When you update the <c>$LATEST</c> version of a slot
    /// type, if a bot uses the <c>$LATEST</c> version of an intent that contains the slot
    /// type, the bot's <c>status</c> field is set to <c>NOT_BUILT</c>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions for the <c>lex:PutSlotType</c> action.
    /// </para>
    /// </summary>
    public partial class PutSlotTypeRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _checksum;
        private bool? _createVersion;
        private string _description;
        private List<EnumerationValue> _enumerationValues = AWSConfigs.InitializeCollections ? new List<EnumerationValue>() : null;
        private string _name;
        private string _parentSlotTypeSignature;
        private List<SlotTypeConfiguration> _slotTypeConfigurations = AWSConfigs.InitializeCollections ? new List<SlotTypeConfiguration>() : null;
        private SlotValueSelectionStrategy _valueSelectionStrategy;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// Identifies a specific revision of the <c>$LATEST</c> version.
        /// </para>
        ///  
        /// <para>
        /// When you create a new slot type, leave the <c>checksum</c> field blank. If you specify
        /// a checksum you get a <c>BadRequestException</c> exception.
        /// </para>
        ///  
        /// <para>
        /// When you want to update a slot type, set the <c>checksum</c> field to the checksum
        /// of the most recent revision of the <c>$LATEST</c> version. If you don't specify the
        /// <c> checksum</c> field, or if the checksum does not match the <c>$LATEST</c> version,
        /// you get a <c>PreconditionFailedException</c> exception.
        /// </para>
        /// </summary>
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

        /// <summary>
        /// Gets and sets the property CreateVersion. 
        /// <para>
        /// When set to <c>true</c> a new numbered version of the slot type is created. This is
        /// the same as calling the <c>CreateSlotTypeVersion</c> operation. If you do not specify
        /// <c>createVersion</c>, the default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? CreateVersion
        {
            get { return this._createVersion; }
            set { this._createVersion = value; }
        }

        // Check to see if CreateVersion property is set
        internal bool IsSetCreateVersion()
        {
            return this._createVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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
        /// Gets and sets the property EnumerationValues. 
        /// <para>
        /// A list of <c>EnumerationValue</c> objects that defines the values that the slot type
        /// can take. Each value can have a list of <c>synonyms</c>, which are additional values
        /// that help train the machine learning model about the values that it resolves for a
        /// slot. 
        /// </para>
        ///  
        /// <para>
        /// A regular expression slot type doesn't require enumeration values. All other slot
        /// types require a list of enumeration values.
        /// </para>
        ///  
        /// <para>
        /// When Amazon Lex resolves a slot value, it generates a resolution list that contains
        /// up to five possible values for the slot. If you are using a Lambda function, this
        /// resolution list is passed to the function. If you are not using a Lambda function
        /// you can choose to return the value that the user entered or the first value in the
        /// resolution list as the slot value. The <c>valueSelectionStrategy</c> field indicates
        /// the option to use. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public List<EnumerationValue> EnumerationValues
        {
            get { return this._enumerationValues; }
            set { this._enumerationValues = value; }
        }

        // Check to see if EnumerationValues property is set
        internal bool IsSetEnumerationValues()
        {
            return this._enumerationValues != null && (this._enumerationValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the slot type. The name is <i>not</i> case sensitive. 
        /// </para>
        ///  
        /// <para>
        /// The name can't match a built-in slot type name, or a built-in slot type name with
        /// "AMAZON." removed. For example, because there is a built-in slot type called <c>AMAZON.DATE</c>,
        /// you can't create a custom slot type called <c>DATE</c>.
        /// </para>
        ///  
        /// <para>
        /// For a list of built-in slot types, see <a href="https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/built-in-intent-ref/slot-type-reference">Slot
        /// Type Reference</a> in the <i>Alexa Skills Kit</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property ParentSlotTypeSignature. 
        /// <para>
        /// The built-in slot type used as the parent of the slot type. When you define a parent
        /// slot type, the new slot type has all of the same configuration as the parent.
        /// </para>
        ///  
        /// <para>
        /// Only <c>AMAZON.AlphaNumeric</c> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ParentSlotTypeSignature
        {
            get { return this._parentSlotTypeSignature; }
            set { this._parentSlotTypeSignature = value; }
        }

        // Check to see if ParentSlotTypeSignature property is set
        internal bool IsSetParentSlotTypeSignature()
        {
            return this._parentSlotTypeSignature != null;
        }

        /// <summary>
        /// Gets and sets the property SlotTypeConfigurations. 
        /// <para>
        /// Configuration information that extends the parent built-in slot type. The configuration
        /// is added to the settings for the parent slot type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<SlotTypeConfiguration> SlotTypeConfigurations
        {
            get { return this._slotTypeConfigurations; }
            set { this._slotTypeConfigurations = value; }
        }

        // Check to see if SlotTypeConfigurations property is set
        internal bool IsSetSlotTypeConfigurations()
        {
            return this._slotTypeConfigurations != null && (this._slotTypeConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValueSelectionStrategy. 
        /// <para>
        /// Determines the slot resolution strategy that Amazon Lex uses to return slot type values.
        /// The field can be set to one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ORIGINAL_VALUE</c> - Returns the value entered by the user, if the user value
        /// is similar to the slot value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TOP_RESOLUTION</c> - If there is a resolution list for the slot, return the first
        /// value in the resolution list as the slot type value. If there is no resolution list,
        /// null is returned.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify the <c>valueSelectionStrategy</c>, the default is <c>ORIGINAL_VALUE</c>.
        /// </para>
        /// </summary>
        public SlotValueSelectionStrategy ValueSelectionStrategy
        {
            get { return this._valueSelectionStrategy; }
            set { this._valueSelectionStrategy = value; }
        }

        // Check to see if ValueSelectionStrategy property is set
        internal bool IsSetValueSelectionStrategy()
        {
            return this._valueSelectionStrategy != null;
        }

    }
}