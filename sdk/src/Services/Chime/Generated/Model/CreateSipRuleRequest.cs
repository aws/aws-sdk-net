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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSipRule operation.
    /// Creates a SIP rule which can be used to run a SIP media application as a target for
    /// a specific trigger type.
    /// </summary>
    public partial class CreateSipRuleRequest : AmazonChimeRequest
    {
        private bool? _disabled;
        private string _name;
        private List<SipRuleTargetApplication> _targetApplications = new List<SipRuleTargetApplication>();
        private SipRuleTriggerType _triggerType;
        private string _triggerValue;

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// Enables or disables a rule. You must disable rules before you can delete them.
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
        /// The name of the SIP rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property TargetApplications. 
        /// <para>
        /// List of SIP media applications with priority and AWS Region. Only one SIP application
        /// per AWS Region can be used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
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
        /// The type of trigger whose value is assigned to the SIP rule in <code>TriggerValue</code>.
        /// Allowed trigger values are <code>RequestUriHostname</code> and <code>ToPhoneNumber</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// If <code>TriggerType</code> is <code>RequestUriHostname</code> then the value can
        /// be the outbound host name of an Amazon Chime Voice Connector. If <code>TriggerType</code>
        /// is <code>ToPhoneNumber</code> then the value can be a customer-owned phone number
        /// in E164 format. <code>SipRule</code> is triggered if the SIP application requests
        /// a host name, or a If <code>TriggerType</code> is <code>RequestUriHostname</code>,
        /// then the value can be the outbound hostname of an Amazon Chime Voice Connector. If
        /// <code>TriggerType</code> is <code>ToPhoneNumber</code>, then the value can be a customer-owned
        /// phone number in E164 format. <code>SipRule</code> is triggered if the SIP application
        /// requests a host name, or a <code>ToPhoneNumber</code> value matches the incoming SIP
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}