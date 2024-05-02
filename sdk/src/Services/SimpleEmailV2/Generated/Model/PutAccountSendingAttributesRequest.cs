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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutAccountSendingAttributes operation.
    /// Enable or disable the ability of your account to send email.
    /// </summary>
    public partial class PutAccountSendingAttributesRequest : AmazonSimpleEmailServiceV2Request
    {
        private bool? _sendingEnabled;

        /// <summary>
        /// Gets and sets the property SendingEnabled. 
        /// <para>
        /// Enables or disables your account's ability to send email. Set to <c>true</c> to enable
        /// email sending, or set to <c>false</c> to disable email sending.
        /// </para>
        ///  <note> 
        /// <para>
        /// If Amazon Web Services paused your account's ability to send email, you can't use
        /// this operation to resume your account's ability to send email.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? SendingEnabled
        {
            get { return this._sendingEnabled; }
            set { this._sendingEnabled = value; }
        }

        // Check to see if SendingEnabled property is set
        internal bool IsSetSendingEnabled()
        {
            return this._sendingEnabled.HasValue; 
        }

    }
}