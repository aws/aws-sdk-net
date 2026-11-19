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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a launch permission.
    /// </summary>
    public partial class LaunchPermission
    {
        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name of the group.
        /// </para>
        /// </summary>
        public PermissionGroup Group { get; set; }

        /// <summary>
        /// Checks to see if the Group property is set.
        /// </summary>
        internal bool IsSetGroup() => this.Group != null;

        /// <summary>
        /// Gets and sets the property OrganizationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an organization.
        /// </para>
        /// </summary>
        public string OrganizationArn { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationArn property is set.
        /// </summary>
        internal bool IsSetOrganizationArn() => this.OrganizationArn != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an organizational unit (OU).
        /// </para>
        /// </summary>
        public string OrganizationalUnitArn { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnitArn property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitArn() => this.OrganizationalUnitArn != null;

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
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
