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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Assigns one or more tags (key-value pairs) to the specified QuickSight resource. 
    /// 
    ///  
    /// <para>
    /// Tags can help you organize and categorize your resources. You can also use them to
    /// scope user permissions, by granting a user permission to access or change only resources
    /// with certain tag values. You can use the <c>TagResource</c> operation with a resource
    /// that already has tags. If you specify a new tag key for the resource, this tag is
    /// appended to the list of tags associated with the resource. If you specify a tag key
    /// that is already associated with the resource, the new tag value that you specify replaces
    /// the previous value for that tag.
    /// </para>
    ///  
    /// <para>
    /// You can associate as many as 50 tags with a resource. QuickSight supports tagging
    /// on data set, data source, dashboard, template, topic, and user. 
    /// </para>
    ///  
    /// <para>
    /// Tagging for QuickSight works in a similar way to tagging for other Amazon Web Services
    /// services, except for the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Tags are used to track costs for users in QuickSight. You can't tag other resources
    /// that QuickSight costs are based on, such as storage capacoty (SPICE), session usage,
    /// alert consumption, or reporting units.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// QuickSight doesn't currently support the tag editor for Resource Groups.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TagResourceRequest : AmazonQuickSightRequest
    {
        private string _resourceArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that you want to tag.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Contains a map of the key-value pairs for the resource tag or tags assigned to the
        /// resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}