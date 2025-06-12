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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// An API operation for adding one or more tags (key-value pairs) to a resource.
    /// 
    ///  
    /// <para>
    /// You can use the <c>TagResource</c> operation with a resource that already has tags.
    /// If you specify a new tag key for the resource, this tag is appended to the list of
    /// tags associated with the resource. If you specify a tag key that is already associated
    /// with the resource, the new tag value you specify replaces the previous value for that
    /// tag.
    /// </para>
    ///  
    /// <para>
    /// Although the maximum number of array members is 200, user-tag maximum is 50. The remaining
    /// are reserved for Amazon Web Services use.
    /// </para>
    /// </summary>
    public partial class TagResourceRequest : AmazonCostExplorerRequest
    {
        private string _resourceArn;
        private List<ResourceTag> _resourceTags = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource. For a list of supported resources,
        /// see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_ResourceTag.html">ResourceTag</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        ///  A list of tag key-value pairs to be added to the resource.
        /// </para>
        ///  
        /// <para>
        /// Each tag consists of a key and a value, and each key must be unique for the resource.
        /// The following restrictions apply to resource tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Although the maximum number of array members is 200, you can assign a maximum of 50
        /// user-tags to one resource. The remaining are reserved for Amazon Web Services use
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum length of a key is 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum length of a value is 256 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys and values can only contain alphanumeric characters, spaces, and any of the following:
        /// <c>_.:/=+@-</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys and values are case sensitive
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys and values are trimmed for any leading or trailing whitespaces
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Don’t use <c>aws:</c> as a prefix for your keys. This prefix is reserved for Amazon
        /// Web Services use
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public List<ResourceTag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}