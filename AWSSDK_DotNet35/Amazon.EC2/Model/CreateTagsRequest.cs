/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Adds or overwrites tags for the specified resources. Each resource can have a maximum of 10 tags. Each tag consists of a key-value
    /// pair. Tag keys must be unique per resource. </para>
    /// </summary>
    public partial class CreateTagsRequest : AmazonEC2Request
    {
        private List<string> resources = new List<string>();
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// One or more IDs of resources to tag. This could be the ID of an AMI, an instance, an EBS volume, or snapshot, etc.
        ///  
        /// </summary>
        public List<string> Resources
        {
            get { return this.resources; }
            set { this.resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this.resources.Count > 0;
        }

        /// <summary>
        /// The tags to add or overwrite for the specified resources. Each tag item consists of a key-value pair.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

    }
}
    
