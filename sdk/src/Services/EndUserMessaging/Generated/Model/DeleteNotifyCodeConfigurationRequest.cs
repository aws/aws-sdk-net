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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
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
namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteNotifyCodeConfiguration operation.
    /// Deletes a notify code configuration. Verifications that are already in progress are
    /// not affected, because they capture the policy at the time that the passcode was sent.
    /// </summary>
    public partial class DeleteNotifyCodeConfigurationRequest : AmazonEndUserMessagingRequest
    {
        private string _notifyCodeConfigurationId;

        /// <summary>
        /// Gets and sets the property NotifyCodeConfigurationId. 
        /// <para>
        /// The unique identifier of the notify code configuration. You can specify either the
        /// bare ID or the full Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string NotifyCodeConfigurationId
        {
            get { return this._notifyCodeConfigurationId; }
            set { this._notifyCodeConfigurationId = value; }
        }

        // Check to see if NotifyCodeConfigurationId property is set
        internal bool IsSetNotifyCodeConfigurationId()
        {
            return this._notifyCodeConfigurationId != null;
        }

    }
}