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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Associate a set of tags with an Amazon DynamoDB resource. You can then activate these
    /// user-defined tags so that they appear on the Billing and Cost Management console for
    /// cost allocation tracking. You can call TagResource up to five times per second, per
    /// account. 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>TagResource</c> is an asynchronous operation. If you issue a <a>ListTagsOfResource</a>
    /// request immediately after a <c>TagResource</c> request, DynamoDB might return your
    /// previous tag set, if there was one, or an empty tag set. This is because <c>ListTagsOfResource</c>
    /// uses an eventually consistent query, and the metadata for your tags or table might
    /// not be available at that moment. Wait for a few seconds, and then try the <c>ListTagsOfResource</c>
    /// request again.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The application or removal of tags using <c>TagResource</c> and <c>UntagResource</c>
    /// APIs is eventually consistent. <c>ListTagsOfResource</c> API will only reflect the
    /// changes after a few seconds.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For an overview on tagging DynamoDB resources, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Tagging.html">Tagging
    /// for DynamoDB</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class TagResourceRequest : AmazonDynamoDBRequest
    {
        private string _resourceArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Identifies the Amazon DynamoDB resource to which tags should be added. This value
        /// is an Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1283)]
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
        /// The tags to be assigned to the Amazon DynamoDB resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}