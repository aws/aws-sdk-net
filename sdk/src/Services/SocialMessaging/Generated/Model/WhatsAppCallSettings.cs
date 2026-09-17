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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
        private string _callbackPermissionStatus;
        private bool? _callEnabled;
        private WhatsAppCallHours _callHours;
        private string _callIconVisibility;

        /// <summary>
        /// Gets and sets the property CallbackPermissionStatus. 
        /// <para>
        /// The callback permission status for the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string CallbackPermissionStatus
        {
            get { return this._callbackPermissionStatus; }
            set { this._callbackPermissionStatus = value; }
        }

        // Check to see if CallbackPermissionStatus property is set
        internal bool IsSetCallbackPermissionStatus()
        {
            return this._callbackPermissionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CallEnabled. 
        /// <para>
        /// Specifies whether calling is enabled for the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? CallEnabled
        {
            get { return this._callEnabled; }
            set { this._callEnabled = value; }
        }

        // Check to see if CallEnabled property is set
        internal bool IsSetCallEnabled()
        {
            return this._callEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CallHours. 
        /// <para>
        /// The hours during which the business accepts calls on the phone number.
        /// </para>
        /// </summary>
        public WhatsAppCallHours CallHours
        {
            get { return this._callHours; }
            set { this._callHours = value; }
        }

        // Check to see if CallHours property is set
        internal bool IsSetCallHours()
        {
            return this._callHours != null;
        }

        /// <summary>
        /// Gets and sets the property CallIconVisibility. 
        /// <para>
        /// The visibility setting for the call icon shown to end users in WhatsApp.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string CallIconVisibility
        {
            get { return this._callIconVisibility; }
            set { this._callIconVisibility = value; }
        }

        // Check to see if CallIconVisibility property is set
        internal bool IsSetCallIconVisibility()
        {
            return this._callIconVisibility != null;
        }

    }
}