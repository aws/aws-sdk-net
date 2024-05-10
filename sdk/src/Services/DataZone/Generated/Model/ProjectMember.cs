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
    /// The details of a project member.
    /// </summary>
    public partial class ProjectMember
    {
        private UserDesignation _designation;
        private MemberDetails _memberDetails;

        /// <summary>
        /// Gets and sets the property Designation. 
        /// <para>
        /// The designated role of a project member.
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
        /// Gets and sets the property MemberDetails. 
        /// <para>
        /// The membership details of a project member.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemberDetails MemberDetails
        {
            get { return this._memberDetails; }
            set { this._memberDetails = value; }
        }

        // Check to see if MemberDetails property is set
        internal bool IsSetMemberDetails()
        {
            return this._memberDetails != null;
        }

    }
}