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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDocumentPermission operation.
    /// Shares a Amazon Web Services Systems Manager document (SSM document)publicly or privately.
    /// If you share a document privately, you must specify the Amazon Web Services user IDs
    /// for those people who can use the document. If you share a document publicly, you must
    /// specify <i>All</i> as the account ID.
    /// </summary>
    public partial class ModifyDocumentPermissionRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<string> _accountIdsToAdd = new List<string>();
        private List<string> _accountIdsToRemove = new List<string>();
        private string _name;
        private DocumentPermissionType _permissionType;
        private string _sharedDocumentVersion;

        /// <summary>
        /// Gets and sets the property AccountIdsToAdd. 
        /// <para>
        /// The Amazon Web Services users that should have access to the document. The account
        /// IDs can either be a group of account IDs or <i>All</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public List<string> AccountIdsToAdd
        {
            get { return this._accountIdsToAdd; }
            set { this._accountIdsToAdd = value; }
        }

        // Check to see if AccountIdsToAdd property is set
        internal bool IsSetAccountIdsToAdd()
        {
            return this._accountIdsToAdd != null && this._accountIdsToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AccountIdsToRemove. 
        /// <para>
        /// The Amazon Web Services users that should no longer have access to the document. The
        /// Amazon Web Services user can either be a group of account IDs or <i>All</i>. This
        /// action has a higher priority than <i>AccountIdsToAdd</i>. If you specify an ID to
        /// add and the same ID to remove, the system removes access to the document.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public List<string> AccountIdsToRemove
        {
            get { return this._accountIdsToRemove; }
            set { this._accountIdsToRemove = value; }
        }

        // Check to see if AccountIdsToRemove property is set
        internal bool IsSetAccountIdsToRemove()
        {
            return this._accountIdsToRemove != null && this._accountIdsToRemove.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the document that you want to share.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property PermissionType. 
        /// <para>
        /// The permission type for the document. The permission type can be <i>Share</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DocumentPermissionType PermissionType
        {
            get { return this._permissionType; }
            set { this._permissionType = value; }
        }

        // Check to see if PermissionType property is set
        internal bool IsSetPermissionType()
        {
            return this._permissionType != null;
        }

        /// <summary>
        /// Gets and sets the property SharedDocumentVersion. 
        /// <para>
        /// (Optional) The version of the document to share. If it isn't specified, the system
        /// choose the <code>Default</code> version to share.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8)]
        public string SharedDocumentVersion
        {
            get { return this._sharedDocumentVersion; }
            set { this._sharedDocumentVersion = value; }
        }

        // Check to see if SharedDocumentVersion property is set
        internal bool IsSetSharedDocumentVersion()
        {
            return this._sharedDocumentVersion != null;
        }

    }
}