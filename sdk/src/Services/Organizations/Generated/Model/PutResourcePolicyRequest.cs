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
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Creates or updates a resource policy.
    /// 
    ///  
    /// <para>
    /// You can only call this operation from the organization's management account.
    /// </para>
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonOrganizationsRequest
    {
        private string _content;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// If provided, the new content for the resource policy. The text must be correctly formatted
        /// JSON that complies with the syntax for the resource policy's type. For more information,
        /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_scp-syntax.html">Service
        /// Control Policy Syntax</a> in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40000)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Updates the list of tags that you want to attach to the newly-created resource policy.
        /// For each tag in the list, you must specify both a tag key and a value. You can set
        /// the value to an empty string, but you can't set it to <code>null</code>. For more
        /// information about tagging, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_tagging.html">Tagging
        /// Organizations resources</a> in the Organizations User Guide.
        /// </para>
        ///  <note> 
        /// <para>
        /// Calls with tags apply to the initial creation of the resource policy, otherwise an
        /// exception is thrown. If any one of the tags is invalid or if you exceed the allowed
        /// number of tags for the resource policy, then the entire request fails and the resource
        /// policy is not created. 
        /// </para>
        ///  </note>
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