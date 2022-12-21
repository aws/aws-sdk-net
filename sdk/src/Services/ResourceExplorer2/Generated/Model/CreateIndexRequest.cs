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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIndex operation.
    /// Turns on Amazon Web Services Resource Explorer in the Amazon Web Services Region in
    /// which you called this operation by creating an index. Resource Explorer begins discovering
    /// the resources in this Region and stores the details about the resources in the index
    /// so that they can be queried by using the <a>Search</a> operation. You can create only
    /// one index in a Region.
    /// 
    ///  <note> 
    /// <para>
    /// This operation creates only a <i>local</i> index. To promote the local index in one
    /// Amazon Web Services Region into the aggregator index for the Amazon Web Services account,
    /// use the <a>UpdateIndexType</a> operation. For more information, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/manage-aggregator-region.html">Turning
    /// on cross-Region search by creating an aggregator index</a> in the <i>Amazon Web Services
    /// Resource Explorer User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more details about what happens when you turn on Resource Explorer in an Amazon
    /// Web Services Region, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/manage-service-activate.html">Turn
    /// on Resource Explorer to index your resources in an Amazon Web Services Region</a>
    /// in the <i>Amazon Web Services Resource Explorer User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If this is the first Amazon Web Services Region in which you've created an index for
    /// Resource Explorer, then this operation also <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/security_iam_service-linked-roles.html">creates
    /// a service-linked role</a> in your Amazon Web Services account that allows Resource
    /// Explorer to enumerate your resources to populate the index.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Action</b>: <code>resource-explorer-2:CreateIndex</code> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Resource</b>: The ARN of the index (as it will exist after the operation completes)
    /// in the Amazon Web Services Region and account in which you're trying to create the
    /// index. Use the wildcard character (<code>*</code>) at the end of the string to match
    /// the eventual UUID. For example, the following <code>Resource</code> element restricts
    /// the role or user to creating an index in only the <code>us-east-2</code> Region of
    /// the specified account.
    /// </para>
    ///  
    /// <para>
    ///  <code>"Resource": "arn:aws:resource-explorer-2:us-west-2:<i>&lt;account-id&gt;</i>:index/*"</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// Alternatively, you can use <code>"Resource": "*"</code> to allow the role or user
    /// to create an index in any Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Action</b>: <code>iam:CreateServiceLinkedRole</code> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Resource</b>: No specific resource (*). 
    /// </para>
    ///  
    /// <para>
    /// This permission is required only the first time you create an index to turn on Resource
    /// Explorer in the account. Resource Explorer uses this to create the <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/security_iam_service-linked-roles.html">service-linked
    /// role needed to index the resources in your account</a>. Resource Explorer uses the
    /// same service-linked role for all additional indexes you create afterwards.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateIndexRequest : AmazonResourceExplorer2Request
    {
        private string _clientToken;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// This value helps ensure idempotency. Resource Explorer uses this value to prevent
        /// the accidental creation of duplicate versions. We recommend that you generate a <a
        /// href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID-type value</a>
        /// to ensure the uniqueness of your views.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The specified tags are attached only to the index created in this Amazon Web Services
        /// Region. The tags aren't attached to any of the resources listed in the index.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
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