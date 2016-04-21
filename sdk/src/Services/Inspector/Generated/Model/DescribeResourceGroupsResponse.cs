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
    /// <zonbook/> <xhtml/>
    /// </summary>
    public partial class DescribeResourceGroupsResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, FailedItemDetails> _failedItems = new Dictionary<string, FailedItemDetails>();
        private List<ResourceGroup> _resourceGroups = new List<ResourceGroup>();

        /// <summary>
        /// Gets and sets the property FailedItems. 
        /// <para>
        /// Resource group details that cannot be described. An error code is provided for each
        /// failed item.
        /// </para>
        /// </summary>
        public Dictionary<string, FailedItemDetails> FailedItems
        {
            get { return this._failedItems; }
            set { this._failedItems = value; }
        }

        // Check to see if FailedItems property is set
        internal bool IsSetFailedItems()
        {
            return this._failedItems != null && this._failedItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceGroups. 
        /// <para>
        /// Information about a resource group.
        /// </para>
        /// </summary>
        public List<ResourceGroup> ResourceGroups
        {
            get { return this._resourceGroups; }
            set { this._resourceGroups = value; }
        }

        // Check to see if ResourceGroups property is set
        internal bool IsSetResourceGroups()
        {
            return this._resourceGroups != null && this._resourceGroups.Count > 0; 
        }

    }
}