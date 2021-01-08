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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// A resource tag.
    /// </summary>
    public partial class ResourceTag
    {
        private string _resourceId;
        private List<Tag> _tagsList = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Specifies the ARN of the resource.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TagsList. 
        /// <para>
        /// A list of tags.
        /// </para>
        /// </summary>
        public List<Tag> TagsList
        {
            get { return this._tagsList; }
            set { this._tagsList = value; }
        }

        // Check to see if TagsList property is set
        internal bool IsSetTagsList()
        {
            return this._tagsList != null && this._tagsList.Count > 0; 
        }

    }
}