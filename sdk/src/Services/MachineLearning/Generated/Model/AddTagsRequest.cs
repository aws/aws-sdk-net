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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Container for the parameters to the AddTags operation.
    /// Adds one or more tags to an object, up to a limit of 10. Each tag consists of a key
    /// and an optional value. If you add a tag using a key that is already associated with
    /// the ML object, <code>AddTags</code> updates the tag's value.
    /// </summary>
    public partial class AddTagsRequest : AmazonMachineLearningRequest
    {
        private string _resourceId;
        private TaggableResourceType _resourceType;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the ML object to tag. For example, <code>exampleModelId</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the ML object to tag. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaggableResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pairs to use to create tags. If you specify a key without specifying
        /// a value, Amazon ML creates a tag with the specified key and a value of null.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
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