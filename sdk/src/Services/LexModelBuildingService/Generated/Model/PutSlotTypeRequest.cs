/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
    /// the existing values in the <code>$LATEST</code> version of the slot type. Amazon Lex
    /// removes the fields that you don't provide in the request. If you don't specify required
    /// fields, Amazon Lex throws an exception. When you update the <code>$LATEST</code> version
    /// of a slot type, if a bot uses the <code>$LATEST</code> version of an intent that contains
    /// the slot type, the bot's <code>status</code> field is set to <code>NOT_BUILT</code>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions for the <code>lex:PutSlotType</code> action.
    /// </para>
    /// </summary>
    public partial class PutSlotTypeRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _checksum;
        private bool? _createVersion;
        private string _description;
        private List<EnumerationValue> _enumerationValues = new List<EnumerationValue>();
        private string _name;
        private SlotValueSelectionStrategy _valueSelectionStrategy;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// Identifies a specific revision of the <code>$LATEST</code> version.
        /// </para>
        ///  
        /// <para>
        /// When you create a new slot type, leave the <code>checksum</code> field blank. If you
        /// specify a checksum you get a <code>BadRequestException</code> exception.
        /// </para>
        ///  
        /// <para>
        /// When you want to update a slot type, set the <code>checksum</code> field to the checksum
        /// of the most recent revision of the <code>$LATEST</code> version. If you don't specify
        /// the <code> checksum</code> field, or if the checksum does not match the <code>$LATEST</code>
        /// version, you get a <code>PreconditionFailedException</code> exception.
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
        /// </summary>
        public bool CreateVersion
        {
            get { return this._createVersion.GetValueOrDefault(); }
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
        /// A list of <code>EnumerationValue</code> objects that defines the values that the slot
        /// type can take. Each value can have a list of <code>synonyms</code>, which are additional
        /// values that help train the machine learning model about the values that it resolves
        /// for a slot. 
        /// </para>
        ///  
        /// <para>
        /// When Amazon Lex resolves a slot value, it generates a resolution list that contains
        /// up to five possible values for the slot. If you are using a Lambda function, this
        /// resolution list is passed to the function. If you are not using a Lambda function
        /// you can choose to return the value that the user entered or the first value in the
        /// resolution list as the slot value. The <code>valueSelectionStrategy</code> field indicates
        /// the option to use. 
        /// </para>
        /// </summary>
        public List<EnumerationValue> EnumerationValues
        {
            get { return this._enumerationValues; }
            set { this._enumerationValues = value; }
        }

        // Check to see if EnumerationValues property is set
        internal bool IsSetEnumerationValues()
        {
            return this._enumerationValues != null && this._enumerationValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the slot type. The name is <i>not</i> case sensitive. 
        /// </para>
        ///  
        /// <para>
        /// The name can't match a built-in slot type name, or a built-in slot type name with
        /// "AMAZON." removed. For example, because there is a built-in slot type called <code>AMAZON.DATE</code>,
        /// you can't create a custom slot type called <code>DATE</code>.
        /// </para>
        ///  
        /// <para>
        /// For a list of built-in slot types, see <a href="https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/built-in-intent-ref/slot-type-reference">Slot
        /// Type Reference</a> in the <i>Alexa Skills Kit</i>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ValueSelectionStrategy. 
        /// <para>
        /// Determines the slot resolution strategy that Amazon Lex uses to return slot type values.
        /// The field can be set to one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ORIGINAL_VALUE</code> - Returns the value entered by the user, if the user
        /// value is similar to the slot value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TOP_RESOLUTION</code> - If there is a resolution list for the slot, return
        /// the first value in the resolution list as the slot type value. If there is no resolution
        /// list, null is returned.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify the <code>valueSelectionStrategy</code>, the default is <code>ORIGINAL_VALUE</code>.
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