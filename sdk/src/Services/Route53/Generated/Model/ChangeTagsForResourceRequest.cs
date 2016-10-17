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
    /// Container for the parameters to the ChangeTagsForResource operation.
    /// Adds, edits, or deletes tags for a health check or a hosted zone.
    /// 
    ///  
    /// <para>
    /// For information about using tags for cost allocation, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
    /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ChangeTagsForResourceRequest : AmazonRoute53Request
    {
        private TagResourceType _resourceType;
        private string _resourceId;
        private List<Tag> _addTags = new List<Tag>();
        private List<string> _removeTagKeys = new List<string>();

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
        /// The ID of the resource for which you want to add, change, or delete tags.
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
        /// Gets and sets the property AddTags. 
        /// <para>
        /// A complex type that contains a list of the tags that you want to add to the specified
        /// health check or hosted zone and/or the tags for which you want to edit the <code>Value</code>
        /// element.
        /// </para>
        ///  
        /// <para>
        /// You can add a maximum of 10 tags to a health check or a hosted zone.
        /// </para>
        /// </summary>
        public List<Tag> AddTags
        {
            get { return this._addTags; }
            set { this._addTags = value; }
        }

        // Check to see if AddTags property is set
        internal bool IsSetAddTags()
        {
            return this._addTags != null && this._addTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoveTagKeys. 
        /// <para>
        /// A complex type that contains a list of the tags that you want to delete from the specified
        /// health check or hosted zone. You can specify up to 10 keys.
        /// </para>
        /// </summary>
        public List<string> RemoveTagKeys
        {
            get { return this._removeTagKeys; }
            set { this._removeTagKeys = value; }
        }

        // Check to see if RemoveTagKeys property is set
        internal bool IsSetRemoveTagKeys()
        {
            return this._removeTagKeys != null && this._removeTagKeys.Count > 0; 
        }

    }
}