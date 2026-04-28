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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Context object for additional message metadata
    /// </summary>
    public partial class SendMessageContext
    {
        private string _currentPage;
        private string _lastMessage;
        private string _userActionResponse;

        /// <summary>
        /// Gets and sets the property CurrentPage. 
        /// <para>
        /// The current page or view the user is on
        /// </para>
        /// </summary>
        public string CurrentPage
        {
            get { return this._currentPage; }
            set { this._currentPage = value; }
        }

        // Check to see if CurrentPage property is set
        internal bool IsSetCurrentPage()
        {
            return this._currentPage != null;
        }

        /// <summary>
        /// Gets and sets the property LastMessage. 
        /// <para>
        /// The ID of the last message in the conversation
        /// </para>
        /// </summary>
        public string LastMessage
        {
            get { return this._lastMessage; }
            set { this._lastMessage = value; }
        }

        // Check to see if LastMessage property is set
        internal bool IsSetLastMessage()
        {
            return this._lastMessage != null;
        }

        /// <summary>
        /// Gets and sets the property UserActionResponse. 
        /// <para>
        /// Response to a UI prompt (not a text conversation message)
        /// </para>
        /// </summary>
        public string UserActionResponse
        {
            get { return this._userActionResponse; }
            set { this._userActionResponse = value; }
        }

        // Check to see if UserActionResponse property is set
        internal bool IsSetUserActionResponse()
        {
            return this._userActionResponse != null;
        }

    }
}