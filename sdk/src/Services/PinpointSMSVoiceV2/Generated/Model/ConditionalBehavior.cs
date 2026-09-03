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
    /// The set of conditional rules that determine a field's resolved requirement based on
    /// the values of other fields in the same registration form. Attached to fields whose
    /// <b>FieldRequirement</b> is <b>CONDITIONAL</b>.
    /// 
    ///  
    /// <para>
    /// Evaluation proceeds top-to-bottom through <b>Rules</b>. The first rule whose conditions
    /// all evaluate to true wins and its behavior is returned. If no rule matches, the <b>DefaultBehavior</b>
    /// is returned.
    /// </para>
    /// </summary>
    public partial class ConditionalBehavior
    {
        private string _defaultBehavior;
        private List<ConditionalRule> _rules = AWSConfigs.InitializeCollections ? new List<ConditionalRule>() : null;

        /// <summary>
        /// Gets and sets the property DefaultBehavior. 
        /// <para>
        /// The field behavior that applies when no conditional rule in <b>Rules</b> matches.
        /// Valid values are <b>REQUIRED</b>, <b>OPTIONAL</b>, and <b>DISALLOWED</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DefaultBehavior
        {
            get { return this._defaultBehavior; }
            set { this._defaultBehavior = value; }
        }

        // Check to see if DefaultBehavior property is set
        internal bool IsSetDefaultBehavior()
        {
            return this._defaultBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// An ordered list of conditional rules. Rules are evaluated top-to-bottom and the first
        /// rule whose conditions all evaluate to true determines the field's behavior. Rules
        /// whose conditions do not all match are skipped and evaluation continues to the next
        /// rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<ConditionalRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}