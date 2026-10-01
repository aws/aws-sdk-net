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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the CheckDocumentAccess operation.
    /// </summary>
    public partial class CheckDocumentAccessResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DocumentAcl. 
        /// <para>
        /// The Access Control List (ACL) associated with the document. Includes allowlist and
        /// denylist conditions that determine user access.
        /// </para>
        /// </summary>
        public DocumentAcl DocumentAcl { get; set; }

        /// <summary>
        /// Checks to see if the DocumentAcl property is set.
        /// </summary>
        internal bool IsSetDocumentAcl() => this.DocumentAcl != null;

        /// <summary>
        /// Gets and sets the property HasAccess. 
        /// <para>
        /// A boolean value indicating whether the specified user has access to the document,
        /// either direct access or transitive access via groups and aliases attached to the document.
        /// </para>
        /// </summary>
        public bool? HasAccess { get; set; }

        /// <summary>
        /// Checks to see if the HasAccess property is set.
        /// </summary>
        internal bool IsSetHasAccess() => this.HasAccess.HasValue;

        /// <summary>
        /// Gets and sets the property UserAliases. 
        /// <para>
        /// An array of aliases associated with the user. This includes both global and local
        /// aliases, each with a name and type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssociatedUser> UserAliases { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociatedUser>() : null;

        /// <summary>
        /// Checks to see if the UserAliases property is set.
        /// </summary>
        internal bool IsSetUserAliases() => this.UserAliases != null && (this.UserAliases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserGroups. 
        /// <para>
        /// An array of groups the user is part of for the specified data source. Each group has
        /// a name and type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssociatedGroup> UserGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociatedGroup>() : null;

        /// <summary>
        /// Checks to see if the UserGroups property is set.
        /// </summary>
        internal bool IsSetUserGroups() => this.UserGroups != null && (this.UserGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
