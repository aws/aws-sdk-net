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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the AddTags operation.
    /// Adds one or more tags to a trail, up to a limit of 10. Tags must be unique per trail.
    /// Overwrites an existing tag's value when a new value is specified for an existing tag
    /// key. If you specify a key without a value, the tag will be created with the specified
    /// key and a value of null. You can tag a trail that applies to all regions only from
    /// the region in which the trail was created (that is, from its home region).
    /// </summary>
    public partial class AddTagsRequest : AmazonCloudTrailRequest
    {
        private string _resourceId;
        private List<Tag> _tagsList = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Specifies the ARN of the trail to which one or more tags will be added. The format
        /// of a trail ARN is:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:cloudtrail:us-east-1:123456789012:trail/MyTrail</code> 
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
        /// Contains a list of CloudTrail tags, up to a limit of 10.
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