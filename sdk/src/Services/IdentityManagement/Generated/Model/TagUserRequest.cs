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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the TagUser operation.
    /// Adds one or more tags to an IAM user. If a tag with the same key name already exists,
    /// then that tag is overwritten with the new value.
    /// 
    ///  
    /// <para>
    /// A tag consists of a key name and an associated value. By assigning tags to your resources,
    /// you can do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
    /// organization and search. For example, you could search for all resources with the
    /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
    /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Access control</b> - Include tags in IAM identity-based and resource-based policies.
    /// You can use tags to restrict access to only an IAM requesting user that has a specified
    /// tag attached. You can also restrict access to only those resources that have a certain
    /// tag attached. For examples of policies that show how to use tags to control access,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
    /// access using IAM tags</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Cost allocation</b> - Use tags to help track which individuals and teams are using
    /// which Amazon Web Services resources.
    /// </para>
    ///  </li> </ul> <note> <ul> <li> 
    /// <para>
    /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
    /// then the entire request fails and the resource is not created. For more information
    /// about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
    /// IAM resources</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Web Services always interprets the tag <code>Value</code> as a single string.
    /// If you need to store an array, you can store comma-separated values in the string.
    /// However, you must interpret the value in your code.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
    /// IAM identities</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TagUserRequest : AmazonIdentityManagementServiceRequest
    {
        private List<Tag> _tags = new List<Tag>();
        private string _userName;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags that you want to attach to the IAM user. Each tag consists of a key
        /// name and an associated value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=50)]
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the IAM user to which you want to add tags.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}