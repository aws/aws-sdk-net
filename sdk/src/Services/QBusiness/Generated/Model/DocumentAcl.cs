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
    /// Represents the Access Control List (ACL) for a document, containing both allowlist
    /// and denylist conditions.
    /// </summary>
    public partial class DocumentAcl
    {
        private DocumentAclMembership _allowlist;
        private DocumentAclMembership _denyList;

        /// <summary>
        /// Gets and sets the property Allowlist. 
        /// <para>
        /// The allowlist conditions for the document. Users or groups matching these conditions
        /// are granted access to the document.
        /// </para>
        /// </summary>
        public DocumentAclMembership Allowlist
        {
            get { return this._allowlist; }
            set { this._allowlist = value; }
        }

        // Check to see if Allowlist property is set
        internal bool IsSetAllowlist()
        {
            return this._allowlist != null;
        }

        /// <summary>
        /// Gets and sets the property DenyList. 
        /// <para>
        /// The denylist conditions for the document. Users or groups matching these conditions
        /// are denied access to the document, overriding allowlist permissions.
        /// </para>
        /// </summary>
        public DocumentAclMembership DenyList
        {
            get { return this._denyList; }
            set { this._denyList = value; }
        }

        // Check to see if DenyList property is set
        internal bool IsSetDenyList()
        {
            return this._denyList != null;
        }

    }
}