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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// A structure returned by the <a>ListGroupResources</a> operation that contains identity
    /// and group membership status information for one of the resources in the group.
    /// </summary>
    public partial class ListGroupResourcesItem
    {
        private ResourceIdentifier _identifier;
        private ResourceStatus _status;

        /// <summary>
        /// Gets and sets the property Identifier.
        /// </summary>
        public ResourceIdentifier Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A structure that contains the status of this resource's membership in the group.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is present in the response only if the group is of type <code>AWS::EC2::HostManagement</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public ResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}