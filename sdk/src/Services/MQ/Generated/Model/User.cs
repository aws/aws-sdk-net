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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MQ.Model
{
    /// <summary>
    /// A user associated with the broker. For Amazon MQ for RabbitMQ brokers, one and only
    /// one administrative user is accepted and created when a broker is first provisioned.
    /// All subsequent broker users are created by making RabbitMQ API calls directly to brokers
    /// or via the RabbitMQ web console.
    /// </summary>
    public partial class User
    {
        private bool? _consoleAccess;
        private List<string> _groups = new List<string>();
        private string _password;
        private bool? _replicationUser;
        private string _username;

        /// <summary>
        /// Gets and sets the property ConsoleAccess. 
        /// <para>
        /// Enables access to the ActiveMQ Web Console for the ActiveMQ user. Does not apply to
        /// RabbitMQ brokers.
        /// </para>
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
        /// Gets and sets the property Groups. 
        /// <para>
        /// The list of groups (20 maximum) to which the ActiveMQ user belongs. This value can
        /// contain only alphanumeric characters, dashes, periods, underscores, and tildes (-
        /// . _ ~). This value must be 2-100 characters long. Does not apply to RabbitMQ brokers.
        /// </para>
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
        /// Gets and sets the property Password. 
        /// <para>
        /// Required. The password of the user. This value must be at least 12 characters long,
        /// must contain at least 4 unique characters, and must not contain commas, colons, or
        /// equal signs (,:=).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationUser. 
        /// <para>
        /// Defines if this user is intended for CRDR replication purposes.
        /// </para>
        /// </summary>
        public bool ReplicationUser
        {
            get { return this._replicationUser.GetValueOrDefault(); }
            set { this._replicationUser = value; }
        }

        // Check to see if ReplicationUser property is set
        internal bool IsSetReplicationUser()
        {
            return this._replicationUser.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the broker user. The following restrictions apply to broker usernames:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// For Amazon MQ for ActiveMQ brokers, this value can contain only alphanumeric characters,
        /// dashes, periods, underscores, and tildes (- . _ ~). This value must be 2-100 characters
        /// long.
        /// </para>
        /// </li> <li>
        /// <para>
        /// para>For Amazon MQ for RabbitMQ brokers, this value can contain only alphanumeric
        /// characters, dashes, periods, underscores (- . _). This value must not contain a tilde
        /// (~) character. Amazon MQ prohibts using guest as a valid usename. This value must
        /// be 2-100 characters long.
        /// </para>
        /// </para></li></ul> <important>
        /// <para>
        /// Do not add personally identifiable information (PII) or other confidential or sensitive
        /// information in broker usernames. Broker usernames are accessible to other Amazon Web
        /// Services services, including CloudWatch Logs. Broker usernames are not intended to
        /// be used for private or sensitive data.
        /// </para>
        /// </important>
        /// </summary>
        [AWSProperty(Required=true)]
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