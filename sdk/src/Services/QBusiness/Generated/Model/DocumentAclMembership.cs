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
    /// Represents membership rules in the document's ACL, defining how users or groups are
    /// associated with access permissions.
    /// </summary>
    public partial class DocumentAclMembership
    {
        private List<DocumentAclCondition> _conditions = AWSConfigs.InitializeCollections ? new List<DocumentAclCondition>() : null;
        private MemberRelation _memberRelation;

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// An array of conditions that define the membership rules. Each condition specifies
        /// criteria for users or groups to be included in this membership.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentAclCondition> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null && (this._conditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MemberRelation. 
        /// <para>
        /// The logical relation between members in the membership rule, determining how multiple
        /// conditions are combined.
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

    }
}