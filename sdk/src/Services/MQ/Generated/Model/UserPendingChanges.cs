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
    /// Returns information about the status of the changes pending for the ActiveMQ user.
    /// </summary>
    public partial class UserPendingChanges
    {
        private bool? _consoleAccess;
        private List<string> _groups = new List<string>();
        private ChangeType _pendingChange;

        /// <summary>
        /// Gets and sets the property ConsoleAccess. Enables access to the the ActiveMQ Web Console
        /// for the ActiveMQ user.
        /// </summary>
        public bool ConsoleAccess
        {
            get { return this._consoleAccess.GetValueOrDefault(); }
            set { this._consoleAccess = value; }
        }

        // Check to see if ConsoleAccess property is set
        internal bool IsSetConsoleAccess()
        {
            return this._consoleAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Groups. The list of groups (20 maximum) to which the ActiveMQ
        /// user belongs. This value can contain only alphanumeric characters, dashes, periods,
        /// underscores, and tildes (- . _ ~). This value must be 2-100 characters long.
        /// </summary>
        public List<string> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && this._groups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PendingChange. Required. The type of change pending for
        /// the ActiveMQ user.
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

    }
}