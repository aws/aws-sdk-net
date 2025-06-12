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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Adds or updates one or more tags that are associated with an Amazon Security Lake
    /// resource: a subscriber, or the data lake configuration for your Amazon Web Services
    /// account in a particular Amazon Web Services Region. A <i>tag</i> is a label that you
    /// can define and associate with Amazon Web Services resources. Each tag consists of
    /// a required <i>tag key</i> and an associated <i>tag value</i>. A <i>tag key</i> is
    /// a general label that acts as a category for a more specific tag value. A <i>tag value</i>
    /// acts as a descriptor for a tag key. Tags can help you identify, categorize, and manage
    /// resources in different ways, such as by owner, environment, or other criteria. For
    /// more information, see <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/tagging-resources.html">Tagging
    /// Amazon Security Lake resources</a> in the <i>Amazon Security Lake User Guide</i>.
    /// </summary>
    public partial class TagResourceRequest : AmazonSecurityLakeRequest
    {
        private string _resourceArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Security Lake resource to add or update
        /// the tags for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects, one for each tag (key and value) to associate with the Amazon
        /// Security Lake resource. For each tag, you must specify both a tag key and a tag value.
        /// A tag value cannot be null, but it can be an empty string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}