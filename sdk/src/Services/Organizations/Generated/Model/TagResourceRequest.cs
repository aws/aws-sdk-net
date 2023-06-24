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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Adds one or more tags to the specified resource.
    /// 
    ///  
    /// <para>
    /// Currently, you can attach tags to the following resources in Organizations.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon Web Services account
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Organization root
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Organizational unit (OU)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Policy (any type)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation can be called only from the organization's management account.
    /// </para>
    /// </summary>
    public partial class TagResourceRequest : AmazonOrganizationsRequest
    {
        private string _resourceId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource to add a tag to.
        /// </para>
        ///  
        /// <para>
        /// You can specify any of the following taggable resources.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services account – specify the account ID number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Organizational unit – specify the OU ID that begins with <code>ou-</code> and looks
        /// similar to: <code>ou-<i>1a2b-34uvwxyz</i> </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Root – specify the root ID that begins with <code>r-</code> and looks similar to:
        /// <code>r-<i>1a2b</i> </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Policy – specify the policy ID that begins with <code>p-</code> andlooks similar to:
        /// <code>p-<i>12abcdefg3</i> </code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=130)]
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
        /// A list of tags to add to the specified resource.
        /// </para>
        ///  
        /// <para>
        /// For each tag in the list, you must specify both a tag key and a value. The value can
        /// be an empty string, but you can't set it to <code>null</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If any one of the tags is not valid or if you exceed the maximum allowed number of
        /// tags for a resource, then the entire request fails.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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