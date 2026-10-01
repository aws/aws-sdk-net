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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ConsoleAccess. 
        /// <para>
        /// Enables access to the ActiveMQ Web Console for the ActiveMQ user. Does not apply to
        /// RabbitMQ brokers.
        /// </para>
        /// </summary>
        public bool? ConsoleAccess { get; set; }

        /// <summary>
        /// Checks to see if the ConsoleAccess property is set.
        /// </summary>
        internal bool IsSetConsoleAccess() => this.ConsoleAccess.HasValue;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The list of groups (20 maximum) to which the ActiveMQ user belongs. This value can
        /// contain only alphanumeric characters, dashes, periods, underscores, and tildes (-
        /// . _ ~). This value must be 2-100 characters long. Does not apply to RabbitMQ brokers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Groups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Groups property is set.
        /// </summary>
        internal bool IsSetGroups() => this.Groups != null && (this.Groups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Required. The password of the user. This value must be at least 12 characters long,
        /// must contain at least 4 unique characters, and must not contain commas, colons, or
        /// equal signs (,:=).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property ReplicationUser. 
        /// <para>
        /// Defines if this user is intended for CRDR replication purposes.
        /// </para>
        /// </summary>
        public bool? ReplicationUser { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationUser property is set.
        /// </summary>
        internal bool IsSetReplicationUser() => this.ReplicationUser.HasValue;

        /// <summary>
        /// Gets and sets the property Username. 
        /// &lt;para&gt;
        /// The username of the broker user. The following restrictions apply to broker usernames:
        /// &lt;/para&gt;
        ///  <ul><li>
        /// &lt;para&gt;
        /// For Amazon MQ for ActiveMQ brokers, this value can contain only alphanumeric characters,
        /// dashes, periods, underscores, and tildes (- . _ ~). This value must be 2-100 characters
        /// long.
        /// &lt;/para&gt;
        /// </li> <li>
        /// &lt;para&gt;
        /// para>For Amazon MQ for RabbitMQ brokers, this value can contain only alphanumeric
        /// characters, dashes, periods, underscores (- . _). This value must not contain a tilde
        /// (~) character. Amazon MQ prohibts using guest as a valid usename. This value must
        /// be 2-100 characters long.
        /// &lt;/para&gt;
        /// &lt;/para&gt;</li></ul> <important>
        /// &lt;para&gt;
        /// Do not add personally identifiable information (PII) or other confidential or sensitive
        /// information in broker usernames. Broker usernames are accessible to other Amazon Web
        /// Services services, including CloudWatch Logs. Broker usernames are not intended to
        /// be used for private or sensitive data.
        /// &lt;/para&gt;
        /// </important>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
