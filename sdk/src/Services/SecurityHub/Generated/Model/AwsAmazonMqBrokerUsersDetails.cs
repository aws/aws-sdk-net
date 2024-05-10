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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about the broker usernames for the specified broker. Doesn't apply
    /// to RabbitMQ brokers.
    /// </summary>
    public partial class AwsAmazonMqBrokerUsersDetails
    {
        private string _pendingChange;
        private string _username;

        /// <summary>
        /// Gets and sets the property PendingChange. 
        /// <para>
        ///  The type of change pending for the broker user. 
        /// </para>
        /// </summary>
        public string PendingChange
        {
            get { return this._pendingChange; }
            set { this._pendingChange = value; }
        }

        // Check to see if PendingChange property is set
        internal bool IsSetPendingChange()
        {
            return this._pendingChange != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        ///  The username of the broker user. 
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}