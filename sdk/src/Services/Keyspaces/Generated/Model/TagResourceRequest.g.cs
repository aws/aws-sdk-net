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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation. Associates a set of tags
    /// with a Amazon Keyspaces resource. You can then activate these user-defined tags so
    /// that they appear on the Cost Management Console for cost allocation tracking. For
    /// more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/tagging-keyspaces.html">Adding
    /// tags and labels to Amazon Keyspaces resources</a> in the <i>Amazon Keyspaces Developer
    /// Guide</i>. <para> For IAM policy examples that show how to control access to Amazon
    /// Keyspaces resources based on tags, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/security_iam_id-based-policy-examples.html#security_iam_id-based-policy-examples-tags">Amazon
    /// Keyspaces resource access based on tags</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class TagResourceRequest : AmazonKeyspacesRequest
    {
        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Keyspaces resource to which to add tags.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1000)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be assigned to the Amazon Keyspaces resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 60)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
