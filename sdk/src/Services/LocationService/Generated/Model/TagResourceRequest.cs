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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Assigns one or more tags (key-value pairs) to the specified Amazon Location Service
    /// resource.
    /// 
    ///  <pre><code> &lt;p&gt;Tags can help you organize and categorize your resources. You
    /// can also use them to scope user permissions, by granting a user permission to access
    /// or change only resources with certain tag values.&lt;/p&gt; &lt;p&gt;Tags don't have
    /// any semantic meaning to AWS and are interpreted strictly as strings of characters.&lt;/p&gt;
    /// &lt;p&gt;You can use the &lt;code&gt;TagResource&lt;/code&gt; action with an Amazon
    /// Location Service resource that already has tags. If you specify a new tag key for
    /// the resource, this tag is appended to the tags already associated with the resource.
    /// If you specify a tag key that is already associated with the resource, the new tag
    /// value that you specify replaces the previous value for that tag. &lt;/p&gt; &lt;p&gt;You
    /// can associate as many as 50 tags with a resource.&lt;/p&gt; </code></pre>
    /// </summary>
    public partial class TagResourceRequest : AmazonLocationServiceRequest
    {
        private string _resourceArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource whose tags you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1600)]
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
        /// The mapping from tag key to tag value for each tag associated with the specified resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public Dictionary<string, string> Tags
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