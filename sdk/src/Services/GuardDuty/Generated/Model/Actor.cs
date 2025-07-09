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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
        private string _id;
        private ActorProcess _process;
        private Session _session;
        private User _user;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// ID of the threat actor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Process. 
        /// <para>
        /// Contains information about the process associated with the threat actor. This includes
        /// details such as process name, path, execution time, and unique identifiers that help
        /// track the actor's activities within the system.
        /// </para>
        /// </summary>
        public ActorProcess Process
        {
            get { return this._process; }
            set { this._process = value; }
        }

        // Check to see if Process property is set
        internal bool IsSetProcess()
        {
            return this._process != null;
        }

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// Contains information about the user session where the activity initiated.
        /// </para>
        /// </summary>
        public Session Session
        {
            get { return this._session; }
            set { this._session = value; }
        }

        // Check to see if Session property is set
        internal bool IsSetSession()
        {
            return this._session != null;
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// Contains information about the user credentials used by the threat actor.
        /// </para>
        /// </summary>
        public User User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}