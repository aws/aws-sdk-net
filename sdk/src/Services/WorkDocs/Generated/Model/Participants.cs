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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Describes the users and/or user groups.
    /// </summary>
    public partial class Participants
    {
        private List<GroupMetadata> _groups = new List<GroupMetadata>();
        private List<UserMetadata> _users = new List<UserMetadata>();

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The list of user groups.
        /// </para>
        /// </summary>
        public List<GroupMetadata> Groups
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
        /// Gets and sets the property Users. 
        /// <para>
        /// The list of users.
        /// </para>
        /// </summary>
        public List<UserMetadata> Users
        {
            get { return this._users; }
            set { this._users = value; }
        }

        // Check to see if Users property is set
        internal bool IsSetUsers()
        {
            return this._users != null && this._users.Count > 0; 
        }

    }
}