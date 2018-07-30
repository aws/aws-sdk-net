/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MQ.Model
{
    /// <summary>
    /// Returns a list of all ActiveMQ users.
    /// </summary>
    public partial class UserSummary
    {
        private ChangeType _pendingChange;
        private string _username;

        /// <summary>
        /// Gets and sets the property PendingChange. The type of change pending for the ActiveMQ
        /// user.
        /// </summary>
        public ChangeType PendingChange
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
        /// Gets and sets the property Username. Required. The username of the ActiveMQ user.
        /// This value can contain only alphanumeric characters, dashes, periods, underscores,
        /// and tildes (- . _ ~). This value must be 2-100 characters long.
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