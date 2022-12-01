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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Assigns one or more tags (key-value pairs) to the specified pipe. Tags can help you
    /// organize and categorize your resources. You can also use them to scope user permissions
    /// by granting a user permission to access or change only resources with certain tag
    /// values.
    /// 
    ///  
    /// <para>
    /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
    /// as strings of characters.
    /// </para>
    ///  
    /// <para>
    /// You can use the <code>TagResource</code> action with a pipe that already has tags.
    /// If you specify a new tag key, this tag is appended to the list of tags associated
    /// with the pipe. If you specify a tag key that is already associated with the pipe,
    /// the new tag value that you specify replaces the previous value for that tag.
    /// </para>
    ///  
    /// <para>
    /// You can associate as many as 50 tags with a pipe.
    /// </para>
    /// </summary>
    public partial class TagResourceRequest : AmazonPipesRequest
    {
        private string _resourceArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the pipe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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
        /// The list of key-value pairs associated with the pipe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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