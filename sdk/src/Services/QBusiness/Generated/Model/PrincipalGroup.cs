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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides information about a group associated with the principal.
    /// </summary>
    public partial class PrincipalGroup
    {
        private ReadAccessType _access;
        private MembershipType _membershipType;
        private string _name;

        /// <summary>
        /// Gets and sets the property Access. 
        /// <para>
        /// Provides information about whether to allow or deny access to the principal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReadAccessType Access
        {
            get { return this._access; }
            set { this._access = value; }
        }

        // Check to see if Access property is set
        internal bool IsSetAccess()
        {
            return this._access != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipType. 
        /// <para>
        /// The type of group.
        /// </para>
        /// </summary>
        public MembershipType MembershipType
        {
            get { return this._membershipType; }
            set { this._membershipType = value; }
        }

        // Check to see if MembershipType property is set
        internal bool IsSetMembershipType()
        {
            return this._membershipType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}