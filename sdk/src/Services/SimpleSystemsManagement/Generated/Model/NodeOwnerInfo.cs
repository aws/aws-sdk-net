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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about ownership of a managed node.
    /// </summary>
    public partial class NodeOwnerInfo
    {
        private string _accountId;
        private string _organizationalUnitId;
        private string _organizationalUnitPath;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the managed node.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The ID of the organization unit (OU) that the account is part of.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=68)]
        public string OrganizationalUnitId
        {
            get { return this._organizationalUnitId; }
            set { this._organizationalUnitId = value; }
        }

        // Check to see if OrganizationalUnitId property is set
        internal bool IsSetOrganizationalUnitId()
        {
            return this._organizationalUnitId != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitPath. 
        /// <para>
        /// The path for the organizational unit (OU) that owns the managed node. The path for
        /// the OU is built using the IDs of the organization, root, and all OUs in the path down
        /// to and including the OU. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>o-a1b2c3d4e5/r-f6g7h8i9j0example/ou-ghi0-awsccccc/ou-jkl0-awsddddd/</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string OrganizationalUnitPath
        {
            get { return this._organizationalUnitPath; }
            set { this._organizationalUnitPath = value; }
        }

        // Check to see if OrganizationalUnitPath property is set
        internal bool IsSetOrganizationalUnitPath()
        {
            return this._organizationalUnitPath != null;
        }

    }
}