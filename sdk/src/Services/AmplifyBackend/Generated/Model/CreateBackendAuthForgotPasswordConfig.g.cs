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

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// <b>(DEPRECATED)</b> Describes the forgot password policy for authenticating into the
    /// Amplify app.
    /// </summary>
    public partial class CreateBackendAuthForgotPasswordConfig
    {
        /// <summary>
        /// Gets and sets the property DeliveryMethod. 
        /// <para>
        /// <b>(DEPRECATED)</b> Describes which mode to use (either SMS or email) to deliver messages
        /// to app users who want to recover their password.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeliveryMethod DeliveryMethod { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryMethod property is set.
        /// </summary>
        internal bool IsSetDeliveryMethod() => this.DeliveryMethod != null;

        /// <summary>
        /// Gets and sets the property EmailSettings. 
        /// <para>
        /// <b>(DEPRECATED)</b> The configuration for the email sent when an app user forgets
        /// their password.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public EmailSettings EmailSettings { get; set; }

        /// <summary>
        /// Checks to see if the EmailSettings property is set.
        /// </summary>
        internal bool IsSetEmailSettings() => this.EmailSettings != null;

        /// <summary>
        /// Gets and sets the property SmsSettings. 
        /// <para>
        /// <b>(DEPRECATED)</b> The configuration for the SMS message sent when an app user forgets
        /// their password.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public SmsSettings SmsSettings { get; set; }

        /// <summary>
        /// Checks to see if the SmsSettings property is set.
        /// </summary>
        internal bool IsSetSmsSettings() => this.SmsSettings != null;
    }
}
