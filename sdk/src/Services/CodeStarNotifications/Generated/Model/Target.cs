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
 * Do not modify this file. This file is generated from the codestar-notifications-2019-10-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStarNotifications.Model
{
    /// <summary>
    /// Information about the Chatbot topics or Chatbot clients associated with a notification
    /// rule.
    /// </summary>
    public partial class Target
    {
        private string _targetAddress;
        private string _targetType;

        /// <summary>
        /// Gets and sets the property TargetAddress. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Chatbot topic or Chatbot client.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=320)]
        public string TargetAddress
        {
            get { return this._targetAddress; }
            set { this._targetAddress = value; }
        }

        // Check to see if TargetAddress property is set
        internal bool IsSetTargetAddress()
        {
            return this._targetAddress != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The target type. Can be an Chatbot topic or Chatbot client.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Chatbot topics are specified as <code>SNS</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Chatbot clients are specified as <code>AWSChatbotSlack</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

    }
}