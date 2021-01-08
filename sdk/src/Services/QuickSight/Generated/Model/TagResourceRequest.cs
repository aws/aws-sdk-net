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
    /// with certain tag values. You can use the <code>TagResource</code> operation with a
    /// resource that already has tags. If you specify a new tag key for the resource, this
    /// tag is appended to the list of tags associated with the resource. If you specify a
    /// tag key that is already associated with the resource, the new tag value that you specify
    /// replaces the previous value for that tag.
    /// </para>
    ///  
    /// <para>
    /// You can associate as many as 50 tags with a resource. QuickSight supports tagging
    /// on data set, data source, dashboard, and template. 
    /// </para>
    ///  
    /// <para>
    /// Tagging for QuickSight works in a similar way to tagging for other AWS services, except
    /// for the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can't use tags to track AWS costs for QuickSight. This restriction is because
    /// QuickSight costs are based on users and SPICE capacity, which aren't taggable resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// QuickSight doesn't currently support the Tag Editor for AWS Resource Groups.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TagResourceRequest : AmazonQuickSightRequest
    {
        private string _resourceArn;
        private List<Tag> _tags = new List<Tag>();

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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}