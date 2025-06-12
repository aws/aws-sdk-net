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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResourceGroup operation.
    /// Creates a resource group using the specified set of tags (key and value pairs) that
    /// are used to select the EC2 instances to be included in an Amazon Inspector assessment
    /// target. The created resource group is then used to create an Amazon Inspector assessment
    /// target. For more information, see <a>CreateAssessmentTarget</a>.
    /// </summary>
    public partial class CreateResourceGroupRequest : AmazonInspectorRequest
    {
        private List<ResourceGroupTag> _resourceGroupTags = AWSConfigs.InitializeCollections ? new List<ResourceGroupTag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceGroupTags. 
        /// <para>
        /// A collection of keys and an array of possible values, '[{"key":"key1","values":["Value1","Value2"]},{"key":"Key2","values":["Value3"]}]'.
        /// </para>
        ///  
        /// <para>
        /// For example,'[{"key":"Name","values":["TestEC2Instance"]}]'.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<ResourceGroupTag> ResourceGroupTags
        {
            get { return this._resourceGroupTags; }
            set { this._resourceGroupTags = value; }
        }

        // Check to see if ResourceGroupTags property is set
        internal bool IsSetResourceGroupTags()
        {
            return this._resourceGroupTags != null && (this._resourceGroupTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}