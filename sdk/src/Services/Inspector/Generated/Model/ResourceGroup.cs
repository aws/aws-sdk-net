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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
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
    /// Contains information about a resource group. The resource group defines a set of tags
    /// that, when queried, identify the AWS resources that comprise the application.
    /// 
    ///  
    /// <para>
    /// This data type is used as the response element in the <a>DescribeResourceGroup</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class ResourceGroup
    {
        private string _resourceGroupArn;
        private string _resourceGroupTags;

        /// <summary>
        /// Gets and sets the property ResourceGroupArn. 
        /// <para>
        /// The ARN of the resource group. 
        /// </para>
        /// </summary>
        public string ResourceGroupArn
        {
            get { return this._resourceGroupArn; }
            set { this._resourceGroupArn = value; }
        }

        // Check to see if ResourceGroupArn property is set
        internal bool IsSetResourceGroupArn()
        {
            return this._resourceGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGroupTags. 
        /// <para>
        /// The tags (key and value pairs) of the resource group.
        /// </para>
        ///  
        /// <para>
        /// This data type property is used in the <a>CreateResourceGroup</a> action.
        /// </para>
        ///  
        /// <para>
        /// A collection of keys and an array of possible values in JSON format.
        /// </para>
        ///  
        /// <para>
        /// For example, [{ "key1" : ["Value1","Value2"]},{"Key2": ["Value3"]}]
        /// </para>
        /// </summary>
        public string ResourceGroupTags
        {
            get { return this._resourceGroupTags; }
            set { this._resourceGroupTags = value; }
        }

        // Check to see if ResourceGroupTags property is set
        internal bool IsSetResourceGroupTags()
        {
            return this._resourceGroupTags != null;
        }

    }
}