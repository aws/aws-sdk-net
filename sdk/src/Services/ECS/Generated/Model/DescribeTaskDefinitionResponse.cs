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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// This is the response object from the DescribeTaskDefinition operation.
    /// </summary>
    public partial class DescribeTaskDefinitionResponse : AmazonWebServiceResponse
    {
        private List<Tag> _tags = new List<Tag>();
        private TaskDefinition _taskDefinition;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that is applied to the task definition to help you categorize and organize
        /// them. Each tag consists of a key and an optional value, both of which you define.
        /// Tag keys can have a maximum character length of 128 characters, and tag values can
        /// have a maximum length of 256 characters.
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

        /// <summary>
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The full task definition description.
        /// </para>
        /// </summary>
        public TaskDefinition TaskDefinition
        {
            get { return this._taskDefinition; }
            set { this._taskDefinition = value; }
        }

        // Check to see if TaskDefinition property is set
        internal bool IsSetTaskDefinition()
        {
            return this._taskDefinition != null;
        }

    }
}