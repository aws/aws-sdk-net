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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Specifies the elicitation setting details eliciting a slot.
    /// </summary>
    public partial class SlotValueElicitationSetting
    {
        private SlotDefaultValueSpecification _defaultValueSpecification;
        private PromptSpecification _promptSpecification;
        private List<SampleUtterance> _sampleUtterances = AWSConfigs.InitializeCollections ? new List<SampleUtterance>() : null;
        private SlotCaptureSetting _slotCaptureSetting;
        private SlotConstraint _slotConstraint;
        private SlotResolutionSetting _slotResolutionSetting;
        private WaitAndContinueSpecification _waitAndContinueSpecification;

        /// <summary>
        /// Gets and sets the property DefaultValueSpecification. 
        /// <para>
        /// A list of default values for a slot. Default values are used when Amazon Lex hasn't
        /// determined a value for a slot. You can specify default values from context variables,
        /// session attributes, and defined values.
        /// </para>
        /// </summary>
        public SlotDefaultValueSpecification DefaultValueSpecification
        {
            get { return this._defaultValueSpecification; }
            set { this._defaultValueSpecification = value; }
        }

        // Check to see if DefaultValueSpecification property is set
        internal bool IsSetDefaultValueSpecification()
        {
            return this._defaultValueSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property PromptSpecification. 
        /// <para>
        /// The prompt that Amazon Lex uses to elicit the slot value from the user.
        /// </para>
        /// </summary>
        public PromptSpecification PromptSpecification
        {
            get { return this._promptSpecification; }
            set { this._promptSpecification = value; }
        }

        // Check to see if PromptSpecification property is set
        internal bool IsSetPromptSpecification()
        {
            return this._promptSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property SampleUtterances. 
        /// <para>
        /// If you know a specific pattern that users might respond to an Amazon Lex request for
        /// a slot value, you can provide those utterances to improve accuracy. This is optional.
        /// In most cases, Amazon Lex is capable of understanding user utterances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SampleUtterance> SampleUtterances
        {
            get { return this._sampleUtterances; }
            set { this._sampleUtterances = value; }
        }

        // Check to see if SampleUtterances property is set
        internal bool IsSetSampleUtterances()
        {
            return this._sampleUtterances != null && (this._sampleUtterances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SlotCaptureSetting. 
        /// <para>
        /// Specifies the settings that Amazon Lex uses when a slot value is successfully entered
        /// by a user.
        /// </para>
        /// </summary>
        public SlotCaptureSetting SlotCaptureSetting
        {
            get { return this._slotCaptureSetting; }
            set { this._slotCaptureSetting = value; }
        }

        // Check to see if SlotCaptureSetting property is set
        internal bool IsSetSlotCaptureSetting()
        {
            return this._slotCaptureSetting != null;
        }

        /// <summary>
        /// Gets and sets the property SlotConstraint. 
        /// <para>
        /// Specifies whether the slot is required or optional.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SlotConstraint SlotConstraint
        {
            get { return this._slotConstraint; }
            set { this._slotConstraint = value; }
        }

        // Check to see if SlotConstraint property is set
        internal bool IsSetSlotConstraint()
        {
            return this._slotConstraint != null;
        }

        /// <summary>
        /// Gets and sets the property SlotResolutionSetting. 
        /// <para>
        /// An object containing information about whether assisted slot resolution is turned
        /// on for the slot or not.
        /// </para>
        /// </summary>
        public SlotResolutionSetting SlotResolutionSetting
        {
            get { return this._slotResolutionSetting; }
            set { this._slotResolutionSetting = value; }
        }

        // Check to see if SlotResolutionSetting property is set
        internal bool IsSetSlotResolutionSetting()
        {
            return this._slotResolutionSetting != null;
        }

        /// <summary>
        /// Gets and sets the property WaitAndContinueSpecification.
        /// </summary>
        public WaitAndContinueSpecification WaitAndContinueSpecification
        {
            get { return this._waitAndContinueSpecification; }
            set { this._waitAndContinueSpecification = value; }
        }

        // Check to see if WaitAndContinueSpecification property is set
        internal bool IsSetWaitAndContinueSpecification()
        {
            return this._waitAndContinueSpecification != null;
        }

    }
}