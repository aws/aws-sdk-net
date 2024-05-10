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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details about a project member.
    /// </summary>
    public partial class Member
    {
        private string _groupIdentifier;
        private string _userIdentifier;

        /// <summary>
        /// Gets and sets the property GroupIdentifier. 
        /// <para>
        /// The ID of the group of a project member.
        /// </para>
        /// </summary>
        public string GroupIdentifier
        {
            get { return this._groupIdentifier; }
            set { this._groupIdentifier = value; }
        }

        // Check to see if GroupIdentifier property is set
        internal bool IsSetGroupIdentifier()
        {
            return this._groupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property UserIdentifier. 
        /// <para>
        /// The user ID of a project member.
        /// </para>
        /// </summary>
        public string UserIdentifier
        {
            get { return this._userIdentifier; }
            set { this._userIdentifier = value; }
        }

        // Check to see if UserIdentifier property is set
        internal bool IsSetUserIdentifier()
        {
            return this._userIdentifier != null;
        }

    }
}