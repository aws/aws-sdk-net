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
    /// This is the response object from the CheckDocumentAccess operation.
    /// </summary>
    public partial class CheckDocumentAccessResponse : AmazonWebServiceResponse
    {
        private DocumentAcl _documentAcl;
        private bool? _hasAccess;
        private List<AssociatedUser> _userAliases = AWSConfigs.InitializeCollections ? new List<AssociatedUser>() : null;
        private List<AssociatedGroup> _userGroups = AWSConfigs.InitializeCollections ? new List<AssociatedGroup>() : null;

        /// <summary>
        /// Gets and sets the property DocumentAcl. 
        /// <para>
        /// The Access Control List (ACL) associated with the document. Includes allowlist and
        /// denylist conditions that determine user access.
        /// </para>
        /// </summary>
        public DocumentAcl DocumentAcl
        {
            get { return this._documentAcl; }
            set { this._documentAcl = value; }
        }

        // Check to see if DocumentAcl property is set
        internal bool IsSetDocumentAcl()
        {
            return this._documentAcl != null;
        }

        /// <summary>
        /// Gets and sets the property HasAccess. 
        /// <para>
        /// A boolean value indicating whether the specified user has access to the document,
        /// either direct access or transitive access via groups and aliases attached to the document.
        /// </para>
        /// </summary>
        public bool? HasAccess
        {
            get { return this._hasAccess; }
            set { this._hasAccess = value; }
        }

        // Check to see if HasAccess property is set
        internal bool IsSetHasAccess()
        {
            return this._hasAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserAliases. 
        /// <para>
        /// An array of aliases associated with the user. This includes both global and local
        /// aliases, each with a name and type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssociatedUser> UserAliases
        {
            get { return this._userAliases; }
            set { this._userAliases = value; }
        }

        // Check to see if UserAliases property is set
        internal bool IsSetUserAliases()
        {
            return this._userAliases != null && (this._userAliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserGroups. 
        /// <para>
        /// An array of groups the user is part of for the specified data source. Each group has
        /// a name and type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssociatedGroup> UserGroups
        {
            get { return this._userGroups; }
            set { this._userGroups = value; }
        }

        // Check to see if UserGroups property is set
        internal bool IsSetUserGroups()
        {
            return this._userGroups != null && (this._userGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}