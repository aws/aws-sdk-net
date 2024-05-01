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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateDelegateFromResource operation.
    /// Removes a member from the resource's set of delegates.
    /// </summary>
    public partial class DisassociateDelegateFromResourceRequest : AmazonWorkMailRequest
    {
        private string _entityId;
        private string _organizationId;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The identifier for the member (user, group) to be removed from the resource's delegates.
        /// </para>
        ///  
        /// <para>
        /// The entity ID can accept <i>UserId or GroupID</i>, <i>Username or Groupname</i>, or
        /// <i>email</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Entity: 12345678-1234-1234-1234-123456789012 or S-1-1-12-1234567890-123456789-123456789-1234
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Email address: entity@domain.tld
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Entity: entity
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier for the organization under which the resource exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the resource from which delegates' set members are removed. 
        /// </para>
        ///  
        /// <para>
        /// The identifier can accept <i>ResourceId</i>, <i>Resourcename</i>, or <i>email</i>.
        /// The following identity formats are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Resource ID: r-0123456789a0123456789b0123456789
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Email address: resource@domain.tld
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resource name: resource
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}