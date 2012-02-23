/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOrUpdateTags operation.
    /// <para> Creates new tags or updates existing tags for an Auto Scaling group. </para> <para><b>NOTE:</b> A tag's definition is composed of a
    /// resource ID, resource type, key and value, and the propagate flag. Value and the propagate flag are optional parameters. See the Request
    /// Parameters for more information. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.CreateOrUpdateTags"/>
    public class CreateOrUpdateTagsRequest : AmazonWebServiceRequest
    {
        private List<Tag> tags = new List<Tag>();

        /// <summary>
        /// The tag to be created or updated. Each tag should be defined by its resource type, resource ID, key, value, and a propagate flag. The
        /// resource type and resource ID identify the type and name of resource for which the tag is created. Currently, <c>auto-scaling-group</c> is
        /// the only supported resource type. The valid value for the resource ID is <i>groupname</i>. The <c>PropagateAtLaunch</c> flag defines whether
        /// the new tag will be applied to instances launched by the Auto Scaling group. Valid values are <c>true</c> or <c>false</c>. However,
        /// instances that are already running will not get the new or updated tag. Likewise, when you modify a tag, the updated version will be applied
        /// only to new instances launched by the Auto Scaling group after the change. Running instances that had the previous version of the tag will
        /// continue to have the older tag. When you create a tag and a tag of the same name already exists, the operation overwrites the previous tag
        /// definition, but you will not get an error message.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }
        /// <summary>
        /// Adds elements to the Tags collection
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        public CreateOrUpdateTagsRequest WithTags(params Tag[] tags)
        {
            foreach (Tag element in tags)
            {
                this.tags.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Tags collection
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        public CreateOrUpdateTagsRequest WithTags(IEnumerable<Tag> tags)
        {
            foreach (Tag element in tags)
            {
                this.tags.Add(element);
            }

            return this;
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;       
        }
    }
}
    
