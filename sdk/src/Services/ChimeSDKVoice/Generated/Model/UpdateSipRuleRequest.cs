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
    /// Container for the parameters to the UpdateSipRule operation.
    /// Updates the details of the specified SIP rule.
    /// </summary>
    public partial class UpdateSipRuleRequest : AmazonChimeSDKVoiceRequest
    {
        private bool? _disabled;
        private string _name;
        private string _sipRuleId;
        private List<SipRuleTargetApplication> _targetApplications = new List<SipRuleTargetApplication>();

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// The new value that indicates whether the rule is disabled.
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
        /// The new name for the specified SIP rule.
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
        /// Gets and sets the property SipRuleId. 
        /// <para>
        /// The SIP rule ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The new list of target applications.
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

    }
}