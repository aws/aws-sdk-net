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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAllEntitySessions operation. Deletes all
    /// active sessions for the specified entity in the specified Connect Customer instance.
    /// The operation supports only the <c>USER</c> entity type, so you can use it to sign
    /// out all of a user's active sessions. Use it when you need to end a user's access right
    /// away, for example when they leave your organization or you suspect that their credentials
    /// are compromised.
    /// </summary>
    public partial class DeleteAllEntitySessionsRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The identifier of the entity whose sessions you want to delete. For <c>USER</c>, use
        /// the user ID or the user ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of entity whose sessions you want to delete.
        /// </para>
        ///  <note> 
        /// <para>
        /// The only valid value is <c>USER</c>, which signs out a user in your Connect Customer
        /// instance.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionEntityType EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;
    }
}
