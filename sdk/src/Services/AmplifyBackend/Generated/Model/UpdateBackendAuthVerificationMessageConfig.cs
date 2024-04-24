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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
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
namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// Updates the configuration of the email or SMS message for the auth resource configured
    /// for your Amplify project.
    /// </summary>
    public partial class UpdateBackendAuthVerificationMessageConfig
    {
        private DeliveryMethod _deliveryMethod;
        private EmailSettings _emailSettings;
        private SmsSettings _smsSettings;

        /// <summary>
        /// Gets and sets the property DeliveryMethod. 
        /// <para>
        /// The type of verification message to send.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeliveryMethod DeliveryMethod
        {
            get { return this._deliveryMethod; }
            set { this._deliveryMethod = value; }
        }

        // Check to see if DeliveryMethod property is set
        internal bool IsSetDeliveryMethod()
        {
            return this._deliveryMethod != null;
        }

        /// <summary>
        /// Gets and sets the property EmailSettings. 
        /// <para>
        /// The settings for the email message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public EmailSettings EmailSettings
        {
            get { return this._emailSettings; }
            set { this._emailSettings = value; }
        }

        // Check to see if EmailSettings property is set
        internal bool IsSetEmailSettings()
        {
            return this._emailSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SmsSettings. 
        /// <para>
        /// The settings for the SMS message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public SmsSettings SmsSettings
        {
            get { return this._smsSettings; }
            set { this._smsSettings = value; }
        }

        // Check to see if SmsSettings property is set
        internal bool IsSetSmsSettings()
        {
            return this._smsSettings != null;
        }

    }
}