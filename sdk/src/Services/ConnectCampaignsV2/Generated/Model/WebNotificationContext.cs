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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Context metadata for the web notification type channel
    /// </summary>
    public partial class WebNotificationContext
    {
        private string _browserId;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property BrowserId.
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string BrowserId
        {
            get { return this._browserId; }
            set { this._browserId = value; }
        }

        // Check to see if BrowserId property is set
        internal bool IsSetBrowserId()
        {
            return this._browserId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId.
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}