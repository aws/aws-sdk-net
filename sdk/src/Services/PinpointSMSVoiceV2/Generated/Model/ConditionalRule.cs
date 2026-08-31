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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
    /// A single conditional rule that resolves to a field behavior when all of its conditions
    /// evaluate to true. Conditions within a rule are combined with logical AND: all conditions
    /// must match for the rule to fire.
    /// </summary>
    public partial class ConditionalRule
    {
        private ConditionalValidation _conditionalValidation;
        private List<FieldCondition> _conditions = AWSConfigs.InitializeCollections ? new List<FieldCondition>() : null;
        private string _ruleBehavior;

        /// <summary>
        /// Gets and sets the property ConditionalValidation. 
        /// <para>
        /// Optional per-rule validation constraints (minimum length, maximum length, regex pattern,
        /// allowed select values) that override the field's default validation when this rule
        /// matches.
        /// </para>
        /// </summary>
        public ConditionalValidation ConditionalValidation
        {
            get { return this._conditionalValidation; }
            set { this._conditionalValidation = value; }
        }

        // Check to see if ConditionalValidation property is set
        internal bool IsSetConditionalValidation()
        {
            return this._conditionalValidation != null;
        }

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// The conditions that must all evaluate to true for this rule to match. Conditions are
        /// combined with logical AND. Use multiple rules with the same <b>RuleBehavior</b> to
        /// express logical OR.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<FieldCondition> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null && (this._conditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleBehavior. 
        /// <para>
        /// The field behavior that applies when all conditions in this rule match. Valid values
        /// are <b>REQUIRED</b>, <b>OPTIONAL</b>, and <b>DISALLOWED</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RuleBehavior
        {
            get { return this._ruleBehavior; }
            set { this._ruleBehavior = value; }
        }

        // Check to see if RuleBehavior property is set
        internal bool IsSetRuleBehavior()
        {
            return this._ruleBehavior != null;
        }

    }
}