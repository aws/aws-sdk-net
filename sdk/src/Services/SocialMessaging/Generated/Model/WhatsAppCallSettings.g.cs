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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// The calling configuration for a WhatsApp business phone number.
    /// </summary>
    public partial class WhatsAppCallSettings
    {
        /// <summary>
        /// Gets and sets the property CallEnabled. 
        /// <para>
        /// Specifies whether calling is enabled for the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? CallEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CallEnabled property is set.
        /// </summary>
        internal bool IsSetCallEnabled() => this.CallEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property CallHours. 
        /// <para>
        /// The hours during which the business accepts calls on the phone number.
        /// </para>
        /// </summary>
        public WhatsAppCallHours CallHours { get; set; }

        /// <summary>
        /// Checks to see if the CallHours property is set.
        /// </summary>
        internal bool IsSetCallHours() => this.CallHours != null;

        /// <summary>
        /// Gets and sets the property CallIconVisibility. 
        /// <para>
        /// The visibility setting for the call icon shown to end users in WhatsApp.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string CallIconVisibility { get; set; }

        /// <summary>
        /// Checks to see if the CallIconVisibility property is set.
        /// </summary>
        internal bool IsSetCallIconVisibility() => this.CallIconVisibility != null;

        /// <summary>
        /// Gets and sets the property CallbackPermissionStatus. 
        /// <para>
        /// The callback permission status for the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string CallbackPermissionStatus { get; set; }

        /// <summary>
        /// Checks to see if the CallbackPermissionStatus property is set.
        /// </summary>
        internal bool IsSetCallbackPermissionStatus() => this.CallbackPermissionStatus != null;
    }
}
