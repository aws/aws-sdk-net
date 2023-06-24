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
    /// Container for the parameters to the Unsubscribe operation.
    /// Removes an association between a notification rule and an Chatbot topic so that subscribers
    /// to that topic stop receiving notifications when the events described in the rule are
    /// triggered.
    /// </summary>
    public partial class UnsubscribeRequest : AmazonCodeStarNotificationsRequest
    {
        private string _arn;
        private string _targetAddress;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the notification rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAddress. 
        /// <para>
        /// The ARN of the Chatbot topic to unsubscribe from the notification rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=320)]
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

    }
}