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
    /// A map of user or group profiles to designations that need to be assigned in the project.
    /// </summary>
    public partial class ProjectMembershipAssignment
    {
        private UserDesignation _designation;
        private Member _member;

        /// <summary>
        /// Gets and sets the property Designation. 
        /// <para>
        /// The designation of the project membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserDesignation Designation
        {
            get { return this._designation; }
            set { this._designation = value; }
        }

        // Check to see if Designation property is set
        internal bool IsSetDesignation()
        {
            return this._designation != null;
        }

        /// <summary>
        /// Gets and sets the property Member. 
        /// <para>
        /// The details about a project member.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Member Member
        {
            get { return this._member; }
            set { this._member = value; }
        }

        // Check to see if Member property is set
        internal bool IsSetMember()
        {
            return this._member != null;
        }

    }
}