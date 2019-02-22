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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Removes tags from a resource.
    /// </summary>
    public partial class UntagResourceRequest : AmazonGlueRequest
    {
        private string _resourceArn;
        private List<string> _tagsToRemove = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource from which to remove the tags.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TagsToRemove. 
        /// <para>
        /// Tags to remove from this resource.
        /// </para>
        /// </summary>
        public List<string> TagsToRemove
        {
            get { return this._tagsToRemove; }
            set { this._tagsToRemove = value; }
        }

        // Check to see if TagsToRemove property is set
        internal bool IsSetTagsToRemove()
        {
            return this._tagsToRemove != null && this._tagsToRemove.Count > 0; 
        }

    }
}