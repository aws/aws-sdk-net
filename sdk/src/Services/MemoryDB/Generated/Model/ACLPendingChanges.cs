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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Returns the updates being applied to the ACL.
    /// </summary>
    public partial class ACLPendingChanges
    {
        private List<string> _userNamesToAdd = new List<string>();
        private List<string> _userNamesToRemove = new List<string>();

        /// <summary>
        /// Gets and sets the property UserNamesToAdd. 
        /// <para>
        /// A list of users being added to the ACL
        /// </para>
        /// </summary>
        public List<string> UserNamesToAdd
        {
            get { return this._userNamesToAdd; }
            set { this._userNamesToAdd = value; }
        }

        // Check to see if UserNamesToAdd property is set
        internal bool IsSetUserNamesToAdd()
        {
            return this._userNamesToAdd != null && this._userNamesToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserNamesToRemove. 
        /// <para>
        /// A list of user names being removed from the ACL
        /// </para>
        /// </summary>
        public List<string> UserNamesToRemove
        {
            get { return this._userNamesToRemove; }
            set { this._userNamesToRemove = value; }
        }

        // Check to see if UserNamesToRemove property is set
        internal bool IsSetUserNamesToRemove()
        {
            return this._userNamesToRemove != null && this._userNamesToRemove.Count > 0; 
        }

    }
}