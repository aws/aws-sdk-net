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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
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
namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResources operation.
    /// Removes the specified tags from the specified resources. When you specify a tag key,
    /// the action removes both that key and its associated value. The operation succeeds
    /// even if you attempt to remove tags from a resource that were already removed. Note
    /// the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// To remove tags from a resource, you need the necessary permissions for the service
    /// that the resource belongs to as well as permissions for removing tags. For more information,
    /// see the documentation for the service whose resource you want to untag.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can only tag resources that are located in the specified Amazon Web Services Region
    /// for the calling Amazon Web Services account.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// In addition to the <c>tag:UntagResources</c> permission required by this operation,
    /// you must also have the remove tags permission defined by the service that created
    /// the resource. For example, to remove the tags from an Amazon EC2 instance using the
    /// <c>UntagResources</c> operation, you must have both of the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>tag:UntagResource</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ec2:DeleteTags</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UntagResourcesRequest : AmazonResourceGroupsTaggingAPIRequest
    {
        private List<string> _resourceARNList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _tagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceARNList. 
        /// <para>
        /// Specifies a list of ARNs of the resources that you want to remove tags from.
        /// </para>
        ///  
        /// <para>
        /// An ARN (Amazon Resource Name) uniquely identifies a resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a> in the <i>Amazon
        /// Web Services General Reference</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> ResourceARNList
        {
            get { return this._resourceARNList; }
            set { this._resourceARNList = value; }
        }

        // Check to see if ResourceARNList property is set
        internal bool IsSetResourceARNList()
        {
            return this._resourceARNList != null && (this._resourceARNList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// Specifies a list of tag keys that you want to remove from the specified resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && (this._tagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}