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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResourceGroup operation.
    /// Creates a resource group using the specified set of tags (key and value pairs) that
    /// are used to select the EC2 instances to be included in an Inspector assessment target.
    /// The created resource group is then used to create an Inspector assessment target.
    /// </summary>
    public partial class CreateResourceGroupRequest : AmazonInspectorRequest
    {
        private List<ResourceGroupTag> _resourceGroupTags = new List<ResourceGroupTag>();

        /// <summary>
        /// Gets and sets the property ResourceGroupTags. 
        /// <para>
        /// A collection of keys and an array of possible values, '[{"key":"key1","values":["Value1","Value2"]},{"key":"Key2","values":["Value3"]}]'.
        /// </para>
        ///  
        /// <para>
        /// For example,'[{"key":"Name","values":["TestEC2Instance"]}]'. 
        /// </para>
        /// </summary>
        public List<ResourceGroupTag> ResourceGroupTags
        {
            get { return this._resourceGroupTags; }
            set { this._resourceGroupTags = value; }
        }

        // Check to see if ResourceGroupTags property is set
        internal bool IsSetResourceGroupTags()
        {
            return this._resourceGroupTags != null && this._resourceGroupTags.Count > 0; 
        }

    }
}