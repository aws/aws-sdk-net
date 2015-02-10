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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTags operation.
    /// Deletes the specified set of tags from the specified set of resources. This call is
    /// designed to follow a <code>DescribeTags</code> request.
    /// 
    ///  
    /// <para>
    /// For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
    /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class DeleteTagsRequest : AmazonEC2Request
    {
        private List<string> _resources = new List<string>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteTagsRequest() { }

        /// <summary>
        /// Instantiates DeleteTagsRequest with the parameterized properties
        /// </summary>
        /// <param name="resources">The ID of the resource. For example, ami-1a2b3c4d. You can specify more than one resource ID.</param>
        public DeleteTagsRequest(List<string> resources)
        {
            _resources = resources;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The ID of the resource. For example, ami-1a2b3c4d. You can specify more than one resource
        /// ID.
        /// </para>
        /// </summary>
        public List<string> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to delete. If you omit the <code>value</code> parameter, we delete
        /// the tag regardless of its value. If you specify this parameter with an empty string
        /// as the value, we delete the key only if its value is an empty string.
        /// </para>
        /// </summary>
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