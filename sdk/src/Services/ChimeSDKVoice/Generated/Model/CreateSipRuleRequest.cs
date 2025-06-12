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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSipRule operation.
    /// Creates a SIP rule, which can be used to run a SIP media application as a target for
    /// a specific trigger type. For more information about SIP rules, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/ag/manage-sip-applications.html">Managing
    /// SIP media applications and rules</a> in the <i>Amazon Chime SDK Administrator Guide</i>.
    /// </summary>
    public partial class CreateSipRuleRequest : AmazonChimeSDKVoiceRequest
    {
        private bool? _disabled;
        private string _name;
        private List<SipRuleTargetApplication> _targetApplications = AWSConfigs.InitializeCollections ? new List<SipRuleTargetApplication>() : null;
        private SipRuleTriggerType _triggerType;
        private string _triggerValue;

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// Disables or enables a SIP rule. You must disable SIP rules before you can delete them.
        /// </para>
        /// </summary>
        public bool? Disabled
        {
            get { return this._disabled; }
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
        /// List of SIP media applications, with priority and AWS Region. Only one SIP application
        /// per AWS Region can be used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._targetApplications != null && (this._targetApplications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TriggerType. 
        /// <para>
        /// The type of trigger assigned to the SIP rule in <c>TriggerValue</c>, currently <c>RequestUriHostname</c>
        /// or <c>ToPhoneNumber</c>.
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
        /// If <c>TriggerType</c> is <c>RequestUriHostname</c>, the value can be the outbound
        /// host name of a Voice Connector. If <c>TriggerType</c> is <c>ToPhoneNumber</c>, the
        /// value can be a customer-owned phone number in the E164 format. The <c>SipMediaApplication</c>
        /// specified in the <c>SipRule</c> is triggered if the request URI in an incoming SIP
        /// request matches the <c>RequestUriHostname</c>, or if the <c>To</c> header in the incoming
        /// SIP request matches the <c>ToPhoneNumber</c> value.
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