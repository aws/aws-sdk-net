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
    /// Removes the specified tags or a set of tags from a set of resources.
    /// </summary>
    public partial class DeleteTagsRequest : AmazonWebServiceRequest
    {
        private List<Tag> _tags = new List<Tag>();


        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Each tag should be defined by its resource type, resource ID, key, value, and a propagate
        /// flag.             Valid values are: Resource type = <i>auto-scaling-group</i>, Resource
        /// ID = <i>AutoScalingGroupName</i>,             key=<i>value</i>, value=<i>value</i>,
        /// propagate=<i>true</i> or <i>false</i>.        
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        /// <summary>
        /// Sets the Tags property
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteTagsRequest WithTags(params Tag[] tags)
        {
            foreach (var element in tags)
            {
                this._tags.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Tags property
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteTagsRequest WithTags(IEnumerable<Tag> tags)
        {
            foreach (var element in tags)
            {
                this._tags.Add(element);
            }
            return this;
        }
        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}