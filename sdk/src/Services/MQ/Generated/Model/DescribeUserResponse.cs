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
    /// This is the response object from the DescribeUser operation.
    /// </summary>
    public partial class DescribeUserResponse : AmazonWebServiceResponse
    {
        private string _brokerId;
        private bool? _consoleAccess;
        private List<string> _groups = new List<string>();
        private UserPendingChanges _pending;
        private string _username;

        /// <summary>
        /// Gets and sets the property BrokerId. Required. The unique ID that Amazon MQ generates
        /// for the broker.
        /// </summary>
        public string BrokerId
        {
            get { return this._brokerId; }
            set { this._brokerId = value; }
        }

        // Check to see if BrokerId property is set
        internal bool IsSetBrokerId()
        {
            return this._brokerId != null;
        }

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
        /// Gets and sets the property Pending. The status of the changes pending for the ActiveMQ
        /// user.
        /// </summary>
        public UserPendingChanges Pending
        {
            get { return this._pending; }
            set { this._pending = value; }
        }

        // Check to see if Pending property is set
        internal bool IsSetPending()
        {
            return this._pending != null;
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