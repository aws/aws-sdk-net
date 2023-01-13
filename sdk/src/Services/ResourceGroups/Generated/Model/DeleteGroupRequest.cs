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
    /// Container for the parameters to the DeleteGroup operation.
    /// Deletes the specified resource group. Deleting a resource group does not delete any
    /// resources that are members of the group; it only deletes the group structure.
    /// 
    ///  
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>resource-groups:DeleteGroup</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteGroupRequest : AmazonResourceGroupsRequest
    {
        private string _group;
        private string _groupName;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name or the ARN of the resource group to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string Group
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
        /// Gets and sets the property GroupName. 
        /// <para>
        /// Deprecated - don't use this parameter. Use <code>Group</code> instead.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated, use Group instead.")]
        [AWSProperty(Min=1, Max=300)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

    }
}