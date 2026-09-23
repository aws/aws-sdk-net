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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Settings related to the Amazon Chime account. This includes settings that start or
    /// stop remote control of shared screens, or start or stop the dial-out option in the
    /// Amazon Chime web application. For more information about these settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/policies.html">Use
    /// the Policies Page</a> in the <i>Amazon Chime Administration Guide</i>.
    /// </summary>
    public partial class AccountSettings
    {
        /// <summary>
        /// Gets and sets the property DisableRemoteControl. 
        /// <para>
        /// Setting that stops or starts remote control of shared screens during meetings.
        /// </para>
        /// </summary>
        public bool? DisableRemoteControl { get; set; }

        /// <summary>
        /// Checks to see if the DisableRemoteControl property is set.
        /// </summary>
        internal bool IsSetDisableRemoteControl() => this.DisableRemoteControl.HasValue;

        /// <summary>
        /// Gets and sets the property EnableDialOut. 
        /// <para>
        /// Setting that allows meeting participants to choose the <b>Call me at a phone number</b>
        /// option. For more information, see <a href="https://docs.aws.amazon.com/chime/latest/ug/chime-join-meeting.html">Join
        /// a Meeting without the Amazon Chime App</a>.
        /// </para>
        /// </summary>
        public bool? EnableDialOut { get; set; }

        /// <summary>
        /// Checks to see if the EnableDialOut property is set.
        /// </summary>
        internal bool IsSetEnableDialOut() => this.EnableDialOut.HasValue;
    }
}
