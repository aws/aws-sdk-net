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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Assigns tags to resources. A tag is a label that you assign to an Amazon Web Services
    /// resource. Each tag consists of a key and an optional value, both of which you define.
    /// Tags enable you to categorize your Amazon Web Services resources by attributes such
    /// as purpose, owner, or environment. When you have many resources of the same type,
    /// you can quickly identify a specific resource based on the tags you've assigned to
    /// it. For example, you can define a set of tags for your Amazon EMR on EKS clusters
    /// to help you track each cluster's owner and stack level. We recommend that you devise
    /// a consistent set of tag keys for each resource type. You can then search and filter
    /// the resources based on the tags that you add.
    /// </summary>
    public partial class TagResourceRequest : AmazonEMRContainersRequest
    {
        private string _resourceArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=500)]
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
        /// The tags assigned to resources.
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