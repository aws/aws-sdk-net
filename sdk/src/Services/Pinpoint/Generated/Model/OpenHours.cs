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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the times when message are allowed to be sent to endpoints.
    /// </summary>
    public partial class OpenHours
    {
        private Dictionary<string, List<OpenHoursRule>> _custom = new Dictionary<string, List<OpenHoursRule>>();
        private Dictionary<string, List<OpenHoursRule>> _email = new Dictionary<string, List<OpenHoursRule>>();
        private Dictionary<string, List<OpenHoursRule>> _push = new Dictionary<string, List<OpenHoursRule>>();
        private Dictionary<string, List<OpenHoursRule>> _sms = new Dictionary<string, List<OpenHoursRule>>();
        private Dictionary<string, List<OpenHoursRule>> _voice = new Dictionary<string, List<OpenHoursRule>>();

        /// <summary>
        /// Gets and sets the property CUSTOM. 
        /// <para>
        /// Specifies the schedule settings for the custom channel.
        /// </para>
        /// </summary>
        public Dictionary<string, List<OpenHoursRule>> CUSTOM
        {
            get { return this._custom; }
            set { this._custom = value; }
        }

        // Check to see if CUSTOM property is set
        internal bool IsSetCUSTOM()
        {
            return this._custom != null && this._custom.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EMAIL. 
        /// <para>
        /// Specifies the schedule settings for the email channel.
        /// </para>
        /// </summary>
        public Dictionary<string, List<OpenHoursRule>> EMAIL
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if EMAIL property is set
        internal bool IsSetEMAIL()
        {
            return this._email != null && this._email.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PUSH. 
        /// <para>
        /// Specifies the schedule settings for the push channel.
        /// </para>
        /// </summary>
        public Dictionary<string, List<OpenHoursRule>> PUSH
        {
            get { return this._push; }
            set { this._push = value; }
        }

        // Check to see if PUSH property is set
        internal bool IsSetPUSH()
        {
            return this._push != null && this._push.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SMS. 
        /// <para>
        /// Specifies the schedule settings for the SMS channel.
        /// </para>
        /// </summary>
        public Dictionary<string, List<OpenHoursRule>> SMS
        {
            get { return this._sms; }
            set { this._sms = value; }
        }

        // Check to see if SMS property is set
        internal bool IsSetSMS()
        {
            return this._sms != null && this._sms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VOICE. 
        /// <para>
        /// Specifies the schedule settings for the voice channel.
        /// </para>
        /// </summary>
        public Dictionary<string, List<OpenHoursRule>> VOICE
        {
            get { return this._voice; }
            set { this._voice = value; }
        }

        // Check to see if VOICE property is set
        internal bool IsSetVOICE()
        {
            return this._voice != null && this._voice.Count > 0; 
        }

    }
}