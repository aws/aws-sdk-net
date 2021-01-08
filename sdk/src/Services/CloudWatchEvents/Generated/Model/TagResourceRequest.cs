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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Assigns one or more tags (key-value pairs) to the specified EventBridge resource.
    /// Tags can help you organize and categorize your resources. You can also use them to
    /// scope user permissions by granting a user permission to access or change only resources
    /// with certain tag values. In EventBridge, rules and event buses can be tagged.
    /// 
    ///  
    /// <para>
    /// Tags don't have any semantic meaning to AWS and are interpreted strictly as strings
    /// of characters.
    /// </para>
    ///  
    /// <para>
    /// You can use the <code>TagResource</code> action with a resource that already has tags.
    /// If you specify a new tag key, this tag is appended to the list of tags associated
    /// with the resource. If you specify a tag key that is already associated with the resource,
    /// the new tag value that you specify replaces the previous value for that tag.
    /// </para>
    ///  
    /// <para>
    /// You can associate as many as 50 tags with a resource.
    /// </para>
    /// </summary>
    public partial class TagResourceRequest : AmazonCloudWatchEventsRequest
    {
        private string _resourceARN;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The ARN of the EventBridge resource that you're adding tags to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key-value pairs to associate with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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