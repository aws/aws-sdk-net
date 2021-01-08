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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeResourceGroups operation.
    /// Describes the resource groups that are specified by the ARNs of the resource groups.
    /// </summary>
    public partial class DescribeResourceGroupsRequest : AmazonInspectorRequest
    {
        private List<string> _resourceGroupArns = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceGroupArns. 
        /// <para>
        /// The ARN that specifies the resource group that you want to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> ResourceGroupArns
        {
            get { return this._resourceGroupArns; }
            set { this._resourceGroupArns = value; }
        }

        // Check to see if ResourceGroupArns property is set
        internal bool IsSetResourceGroupArns()
        {
            return this._resourceGroupArns != null && this._resourceGroupArns.Count > 0; 
        }

    }
}