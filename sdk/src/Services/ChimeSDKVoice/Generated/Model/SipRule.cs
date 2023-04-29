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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The details of a SIP rule, including name, triggers, and target applications. An AWS
    /// account can have multiple SIP rules.
    /// </summary>
    public partial class SipRule
    {
        private DateTime? _createdTimestamp;
        private bool? _disabled;
        private string _name;
        private string _sipRuleId;
        private List<SipRuleTargetApplication> _targetApplications = new List<SipRuleTargetApplication>();
        private SipRuleTriggerType _triggerType;
        private string _triggerValue;
        private DateTime? _updatedTimestamp;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the SIP rule was created, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// Indicates whether the SIP rule is enabled or disabled. You must disable a rule before
        /// you can delete it.
        /// </para>
        /// </summary>
        public bool Disabled
        {
            get { return this._disabled.GetValueOrDefault(); }
            set { this._disabled = value; }
        }

        // Check to see if Disabled property is set
        internal bool IsSetDisabled()
        {
            return this._disabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A SIP rule's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property SipRuleId. 
        /// <para>
        /// A SIP rule's ID.
        /// </para>
        /// </summary>
        public string SipRuleId
        {
            get { return this._sipRuleId; }
            set { this._sipRuleId = value; }
        }

        // Check to see if SipRuleId property is set
        internal bool IsSetSipRuleId()
        {
            return this._sipRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetApplications. 
        /// <para>
        /// The target SIP media application and other details, such as priority and AWS Region,
        /// to be specified in the SIP rule. Only one SIP rule per AWS Region can be provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<SipRuleTargetApplication> TargetApplications
        {
            get { return this._targetApplications; }
            set { this._targetApplications = value; }
        }

        // Check to see if TargetApplications property is set
        internal bool IsSetTargetApplications()
        {
            return this._targetApplications != null && this._targetApplications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TriggerType. 
        /// <para>
        /// The type of trigger set for a SIP rule, either a phone number or a URI request host
        /// name.
        /// </para>
        /// </summary>
        public SipRuleTriggerType TriggerType
        {
            get { return this._triggerType; }
            set { this._triggerType = value; }
        }

        // Check to see if TriggerType property is set
        internal bool IsSetTriggerType()
        {
            return this._triggerType != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerValue. 
        /// <para>
        /// The value set for a SIP rule's trigger type. Either a phone number or a URI hostname.
        /// </para>
        /// </summary>
        public string TriggerValue
        {
            get { return this._triggerValue; }
            set { this._triggerValue = value; }
        }

        // Check to see if TriggerValue property is set
        internal bool IsSetTriggerValue()
        {
            return this._triggerValue != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The time at which the SIP rule was updated, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime UpdatedTimestamp
        {
            get { return this._updatedTimestamp.GetValueOrDefault(); }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

    }
}