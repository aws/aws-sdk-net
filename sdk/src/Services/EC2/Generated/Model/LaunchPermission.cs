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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a launch permission.
    /// </summary>
    public partial class LaunchPermission
    {
        private PermissionGroup _group;
        private string _organizationalUnitArn;
        private string _organizationArn;
        private string _userId;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name of the group.
        /// </para>
        /// </summary>
        public PermissionGroup Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an organizational unit (OU).
        /// </para>
        /// </summary>
        public string OrganizationalUnitArn
        {
            get { return this._organizationalUnitArn; }
            set { this._organizationalUnitArn = value; }
        }

        // Check to see if OrganizationalUnitArn property is set
        internal bool IsSetOrganizationalUnitArn()
        {
            return this._organizationalUnitArn != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an organization.
        /// </para>
        /// </summary>
        public string OrganizationArn
        {
            get { return this._organizationArn; }
            set { this._organizationArn = value; }
        }

        // Check to see if OrganizationArn property is set
        internal bool IsSetOrganizationArn()
        {
            return this._organizationArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 10 000 account IDs can be specified in a single request.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}