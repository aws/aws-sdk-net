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
    /// Container for the parameters to the GroupResources operation.
    /// Adds the specified resources to the specified group.
    /// 
    ///  <important> 
    /// <para>
    /// You can use this operation with only resource groups that are configured with the
    /// following types:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>AWS::EC2::HostManagement</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AWS::EC2::CapacityReservationPool</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Other resource group type and resource types aren't currently supported by this operation.
    /// </para>
    ///  </important> 
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>resource-groups:GroupResources</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GroupResourcesRequest : AmazonResourceGroupsRequest
    {
        private string _group;
        private List<string> _resourceArns = new List<string>();

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name or the ARN of the resource group to add resources to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// The list of ARNs of the resources to be added to the group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && this._resourceArns.Count > 0; 
        }

    }
}