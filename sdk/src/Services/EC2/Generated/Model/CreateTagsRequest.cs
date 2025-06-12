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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTags operation.
    /// Adds or overwrites only the specified tags for the specified Amazon EC2 resource or
    /// resources. When you specify an existing tag key, the value is overwritten with the
    /// new value. Each resource can have a maximum of 50 tags. Each tag consists of a key
    /// and optional value. Tag keys must be unique per resource.
    /// 
    ///  
    /// <para>
    /// For more information about tags, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tag
    /// your Amazon EC2 resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// For more information about creating IAM policies that control users' access to resources
    /// based on tags, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-supported-iam-actions-resources.html">Supported
    /// resource-level permissions for Amazon EC2 API actions</a> in the <i>Amazon Elastic
    /// Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateTagsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<string> _resources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateTagsRequest() { }

        /// <summary>
        /// Instantiates CreateTagsRequest with the parameterized properties
        /// </summary>
        /// <param name="resources">The IDs of the resources, separated by spaces. Constraints: Up to 1000 resource IDs. We recommend breaking up this request into smaller batches.</param>
        /// <param name="tags">The tags. The <c>value</c> parameter is required, but if you don't want the tag to have a value, specify the parameter with no value, and we set the value to an empty string.</param>
        public CreateTagsRequest(List<string> resources, List<Tag> tags)
        {
            _resources = resources;
            _tags = tags;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The IDs of the resources, separated by spaces.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 1000 resource IDs. We recommend breaking up this request into smaller
        /// batches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags. The <c>value</c> parameter is required, but if you don't want the tag to
        /// have a value, specify the parameter with no value, and we set the value to an empty
        /// string.
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