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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Container for the parameters to the TagResources operation.
    /// Applies one or more tags to the specified resources. Note the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Not all resources can have tags. For a list of resources that support tagging, see
    /// <a href="http://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/supported-resources.html">Supported
    /// Resources</a> in the <i>AWS Resource Groups and Tag Editor User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each resource can have up to 50 tags. For other limits, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html#tag-restrictions">Tag
    /// Restrictions</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can only tag resources that are located in the specified region for the AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To add tags to a resource, you need the necessary permissions for the service that
    /// the resource belongs to as well as permissions for adding tags. For more information,
    /// see <a href="http://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/obtaining-permissions-for-tagging.html">Obtaining
    /// Permissions for Tagging</a> in the <i>AWS Resource Groups and Tag Editor User Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TagResourcesRequest : AmazonResourceGroupsTaggingAPIRequest
    {
        private List<string> _resourceARNList = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ResourceARNList. 
        /// <para>
        /// A list of ARNs. An ARN (Amazon Resource Name) uniquely identifies a resource. You
        /// can specify a minimum of 1 and a maximum of 20 ARNs (resources) to tag. An ARN can
        /// be set to a maximum of 1600 characters. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        public List<string> ResourceARNList
        {
            get { return this._resourceARNList; }
            set { this._resourceARNList = value; }
        }

        // Check to see if ResourceARNList property is set
        internal bool IsSetResourceARNList()
        {
            return this._resourceARNList != null && this._resourceARNList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you want to add to the specified resources. A tag consists of a key
        /// and a value that you define.
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