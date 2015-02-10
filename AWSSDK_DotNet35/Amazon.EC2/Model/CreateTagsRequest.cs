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
    /// Container for the parameters to the CreateTags operation.
    /// Adds or overwrites one or more tags for the specified Amazon EC2 resource or resources.
    /// Each resource can have a maximum of 10 tags. Each tag consists of a key and optional
    /// value. Tag keys must be unique per resource.
    /// 
    ///  
    /// <para>
    /// For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
    /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class CreateTagsRequest : AmazonEC2Request
    {
        private List<string> _resources = new List<string>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateTagsRequest() { }

        /// <summary>
        /// Instantiates CreateTagsRequest with the parameterized properties
        /// </summary>
        /// <param name="resources">The IDs of one or more resources to tag. For example, ami-1a2b3c4d.</param>
        /// <param name="tags">One or more tags. The <code>value</code> parameter is required, but if you don't want the tag to have a value, specify the parameter with no value, and we set the value to an empty string. </param>
        public CreateTagsRequest(List<string> resources, List<Tag> tags)
        {
            _resources = resources;
            _tags = tags;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The IDs of one or more resources to tag. For example, ami-1a2b3c4d.
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
        /// One or more tags. The <code>value</code> parameter is required, but if you don't want
        /// the tag to have a value, specify the parameter with no value, and we set the value
        /// to an empty string. 
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