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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type containing a resource and its associated tags.
    /// </summary>
    public partial class ResourceTagSet
    {
        private TagResourceType _resourceType;
        private string _resourceId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The resource type for health checks is <code>healthcheck</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The resource type for hosted zones is <code>hostedzone</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TagResourceType ResourceType
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID for the specified resource.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the specified resource.
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