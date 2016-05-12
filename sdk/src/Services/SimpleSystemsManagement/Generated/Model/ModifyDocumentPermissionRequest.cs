/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDocumentPermission operation.
    /// Share a document publicly or privately. If you share a document privately, you must
    /// specify the AWS user account IDs for those people who can use the document. If you
    /// share a document publicly, you must specify <i>All</i> as the account ID.
    /// </summary>
    public partial class ModifyDocumentPermissionRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<string> _accountIdsToAdd = new List<string>();
        private List<string> _accountIdsToRemove = new List<string>();
        private string _name;
        private DocumentPermissionType _permissionType;

        /// <summary>
        /// Gets and sets the property AccountIdsToAdd. 
        /// <para>
        /// The AWS user accounts that should have access to the document. The account IDs can
        /// either be a group of account IDs or <i>All</i>.
        /// </para>
        /// </summary>
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
        /// The AWS user accounts that should no longer have access to the document. The AWS user
        /// account can either be a group of account IDs or <i>All</i>. This action has a higher
        /// priority than <i>AccountIdsToAdd</i>. If you specify an account ID to add and the
        /// same ID to remove, the system removes access to the document.
        /// </para>
        /// </summary>
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

    }
}