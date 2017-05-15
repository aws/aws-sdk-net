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
    /// Container for the parameters to the DescribeDocumentPermission operation.
    /// Describes the permissions for a Systems Manager document. If you created the document,
    /// you are the owner. If a document is shared, it can either be shared privately (by
    /// specifying a user's AWS account ID) or publicly (<i>All</i>).
    /// </summary>
    public partial class DescribeDocumentPermissionRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _name;
        private DocumentPermissionType _permissionType;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the document for which you are the owner.
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