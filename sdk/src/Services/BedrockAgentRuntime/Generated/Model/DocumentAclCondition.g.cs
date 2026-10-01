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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// A condition within a document access control list (ACL) membership, specifying users
    /// and groups that are evaluated together.
    /// </summary>
    public partial class DocumentAclCondition
    {
        /// <summary>
        /// Gets and sets the property ConditionOperator. 
        /// <para>
        /// The logical operator for combining users and groups within this condition. Valid values:
        /// <c>AND</c> – Both a user match and a group match are required. <c>OR</c> – Either
        /// a user match or a group match is sufficient.
        /// </para>
        /// </summary>
        public DocumentAclMemberRelation ConditionOperator { get; set; }

        /// <summary>
        /// Checks to see if the ConditionOperator property is set.
        /// </summary>
        internal bool IsSetConditionOperator() => this.ConditionOperator != null;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The list of group entries in this condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 3000)]
        public List<DocumentAclGroup> Groups { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentAclGroup>() : null;

        /// <summary>
        /// Checks to see if the Groups property is set.
        /// </summary>
        internal bool IsSetGroups() => this.Groups != null && (this.Groups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Users. 
        /// <para>
        /// The list of user entries in this condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 3000)]
        public List<DocumentAclUser> Users { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentAclUser>() : null;

        /// <summary>
        /// Checks to see if the Users property is set.
        /// </summary>
        internal bool IsSetUsers() => this.Users != null && (this.Users.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
