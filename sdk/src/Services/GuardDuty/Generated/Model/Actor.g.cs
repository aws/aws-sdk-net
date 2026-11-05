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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the actors involved in an attack sequence.
    /// </summary>
    public partial class Actor
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// ID of the threat actor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Process. 
        /// <para>
        /// Contains information about the process associated with the threat actor. This includes
        /// details such as process name, path, execution time, and unique identifiers that help
        /// track the actor's activities within the system.
        /// </para>
        /// </summary>
        public ActorProcess Process { get; set; }

        /// <summary>
        /// Checks to see if the Process property is set.
        /// </summary>
        internal bool IsSetProcess() => this.Process != null;

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// Contains information about the user session where the activity initiated.
        /// </para>
        /// </summary>
        public Session Session { get; set; }

        /// <summary>
        /// Checks to see if the Session property is set.
        /// </summary>
        internal bool IsSetSession() => this.Session != null;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// Contains information about the user credentials used by the threat actor.
        /// </para>
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
