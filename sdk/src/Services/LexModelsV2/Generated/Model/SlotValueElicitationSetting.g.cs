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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Specifies the elicitation setting details eliciting a slot.
    /// </summary>
    public partial class SlotValueElicitationSetting
    {
        /// <summary>
        /// Gets and sets the property DefaultValueSpecification. 
        /// <para>
        /// A list of default values for a slot. Default values are used when Amazon Lex hasn't
        /// determined a value for a slot. You can specify default values from context variables,
        /// session attributes, and defined values.
        /// </para>
        /// </summary>
        public SlotDefaultValueSpecification DefaultValueSpecification { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValueSpecification property is set.
        /// </summary>
        internal bool IsSetDefaultValueSpecification() => this.DefaultValueSpecification != null;

        /// <summary>
        /// Gets and sets the property PromptSpecification. 
        /// <para>
        /// The prompt that Amazon Lex uses to elicit the slot value from the user.
        /// </para>
        /// </summary>
        public PromptSpecification PromptSpecification { get; set; }

        /// <summary>
        /// Checks to see if the PromptSpecification property is set.
        /// </summary>
        internal bool IsSetPromptSpecification() => this.PromptSpecification != null;

        /// <summary>
        /// Gets and sets the property SampleUtterances. 
        /// <para>
        /// If you know a specific pattern that users might respond to an Amazon Lex request for
        /// a slot value, you can provide those utterances to improve accuracy. This is optional.
        /// In most cases, Amazon Lex is capable of understanding user utterances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SampleUtterance> SampleUtterances { get; set; } = AWSConfigs.InitializeCollections ? new List<SampleUtterance>() : null;

        /// <summary>
        /// Checks to see if the SampleUtterances property is set.
        /// </summary>
        internal bool IsSetSampleUtterances() => this.SampleUtterances != null && (this.SampleUtterances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SlotCaptureSetting. 
        /// <para>
        /// Specifies the settings that Amazon Lex uses when a slot value is successfully entered
        /// by a user.
        /// </para>
        /// </summary>
        public SlotCaptureSetting SlotCaptureSetting { get; set; }

        /// <summary>
        /// Checks to see if the SlotCaptureSetting property is set.
        /// </summary>
        internal bool IsSetSlotCaptureSetting() => this.SlotCaptureSetting != null;

        /// <summary>
        /// Gets and sets the property SlotConstraint. 
        /// <para>
        /// Specifies whether the slot is required or optional.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SlotConstraint SlotConstraint { get; set; }

        /// <summary>
        /// Checks to see if the SlotConstraint property is set.
        /// </summary>
        internal bool IsSetSlotConstraint() => this.SlotConstraint != null;

        /// <summary>
        /// Gets and sets the property SlotResolutionSetting. 
        /// <para>
        /// An object containing information about whether assisted slot resolution is turned
        /// on for the slot or not.
        /// </para>
        /// </summary>
        public SlotResolutionSetting SlotResolutionSetting { get; set; }

        /// <summary>
        /// Checks to see if the SlotResolutionSetting property is set.
        /// </summary>
        internal bool IsSetSlotResolutionSetting() => this.SlotResolutionSetting != null;

        /// <summary>
        /// Gets and sets the property WaitAndContinueSpecification.
        /// </summary>
        public WaitAndContinueSpecification WaitAndContinueSpecification { get; set; }

        /// <summary>
        /// Checks to see if the WaitAndContinueSpecification property is set.
        /// </summary>
        internal bool IsSetWaitAndContinueSpecification() => this.WaitAndContinueSpecification != null;
    }
}
