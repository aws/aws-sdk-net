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

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// Container for the parameters to the GetGroup operation. Returns information about
    /// a specified resource group. <para> <b>Minimum permissions</b> </para> <para> To run
    /// this command, you must have the following permissions: </para> <ul> <li> <para> <c>resource-groups:GetGroup</c>
    /// </para> </li> </ul>
    /// </summary>
    public partial class GetGroupRequest : AmazonResourceGroupsRequest
    {
        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name or the Amazon resource name (ARN) of the resource group to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string Group { get; set; }

        /// <summary>
        /// Checks to see if the Group property is set.
        /// </summary>
        internal bool IsSetGroup() => this.Group != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// Deprecated - don't use this parameter. Use <c>Group</c> instead.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated, use Group instead.")]
        [AWSProperty(Min = 1, Max = 300)]
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;
    }
}
