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
    /// A list of principals. Each principal can be either a <c>USER</c> or a <c>GROUP</c>
    /// and can be designated document access permissions of either <c>ALLOW</c> or <c>DENY</c>.
    /// </summary>
    public partial class AccessControl
    {
        private MemberRelation _memberRelation;
        private List<Principal> _principals = AWSConfigs.InitializeCollections ? new List<Principal>() : null;

        /// <summary>
        /// Gets and sets the property MemberRelation. 
        /// <para>
        /// Describes the member relation within a principal list.
        /// </para>
        /// </summary>
        public MemberRelation MemberRelation
        {
            get { return this._memberRelation; }
            set { this._memberRelation = value; }
        }

        // Check to see if MemberRelation property is set
        internal bool IsSetMemberRelation()
        {
            return this._memberRelation != null;
        }

        /// <summary>
        /// Gets and sets the property Principals. 
        /// <para>
        /// Contains a list of principals, where a principal can be either a <c>USER</c> or a
        /// <c>GROUP</c>. Each principal can be have the following type of document access: <c>ALLOW</c>
        /// or <c>DENY</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Principal> Principals
        {
            get { return this._principals; }
            set { this._principals = value; }
        }

        // Check to see if Principals property is set
        internal bool IsSetPrincipals()
        {
            return this._principals != null && (this._principals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}