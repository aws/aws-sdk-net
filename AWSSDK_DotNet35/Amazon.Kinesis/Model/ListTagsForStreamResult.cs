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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Represents the output for <code>ListTagsForStream</code>.
    /// </summary>
    public partial class ListTagsForStreamResult : AmazonWebServiceResponse
    {
        private bool? _hasMoreTags;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property HasMoreTags. 
        /// <para>
        /// If set to <code>true</code>, more tags are available. To request additional tags,
        /// set <code>ExclusiveStartTagKey</code> to the key of the last tag returned.
        /// </para>
        /// </summary>
        public bool HasMoreTags
        {
            get { return this._hasMoreTags.GetValueOrDefault(); }
            set { this._hasMoreTags = value; }
        }

        // Check to see if HasMoreTags property is set
        internal bool IsSetHasMoreTags()
        {
            return this._hasMoreTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with <code>StreamName</code>, starting with the first tag
        /// after <code>ExclusiveStartTagKey</code> and up to the specified <code>Limit</code>.
        /// 
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