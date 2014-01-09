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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTags operation.
    /// <para>Removes the specified tags or a set of tags from a set of resources.</para>
    /// </summary>
    public partial class DeleteTagsRequest : AmazonAutoScalingRequest
    {
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// Each tag should be defined by its resource type, resource ID, key, value, and a propagate flag. Valid values are: Resource type =
        /// <i>auto-scaling-group</i>, Resource ID = <i>AutoScalingGroupName</i>, key=<i>value</i>, value=<i>value</i>, propagate=<i>true</i> or
        /// <i>false</i>.
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
    
