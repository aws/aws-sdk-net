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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
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
namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Container for the parameters to the TagResources operation.
    /// Applies one or more tags to the specified resources. Note the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Not all resources can have tags. For a list of services with resources that support
    /// tagging using this operation, see <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/supported-services.html">Services
    /// that support the Resource Groups Tagging API</a>. If the resource doesn't yet support
    /// this operation, the resource's service might support tagging using its own API operations.
    /// For more information, refer to the documentation for that service.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each resource can have up to 50 tags. For other limits, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html#tag-conventions">Tag
    /// Naming and Usage Conventions</a> in the <i>Amazon Web Services General Reference.</i>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can only tag resources that are located in the specified Amazon Web Services Region
    /// for the Amazon Web Services account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To add tags to a resource, you need the necessary permissions for the service that
    /// the resource belongs to as well as permissions for adding tags. For more information,
    /// see the documentation for each service.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// Do not store personally identifiable information (PII) or other confidential or sensitive
    /// information in tags. We use tags to provide you with billing and administration services.
    /// Tags are not intended to be used for private or sensitive data.
    /// </para>
    ///  </important> 
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// In addition to the <c>tag:TagResources</c> permission required by this operation,
    /// you must also have the tagging permission defined by the service that created the
    /// resource. For example, to tag an Amazon EC2 instance using the <c>TagResources</c>
    /// operation, you must have both of the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>tag:TagResource</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ec2:CreateTags</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TagResourcesRequest : AmazonResourceGroupsTaggingAPIRequest
    {
        private List<string> _resourceARNList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceARNList. 
        /// <para>
        /// Specifies the list of ARNs of the resources that you want to apply tags to.
        /// </para>
        ///  
        /// <para>
        /// An ARN (Amazon Resource Name) uniquely identifies a resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a> in the <i>Amazon
        /// Web Services General Reference</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> ResourceARNList
        {
            get { return this._resourceARNList; }
            set { this._resourceARNList = value; }
        }

        // Check to see if ResourceARNList property is set
        internal bool IsSetResourceARNList()
        {
            return this._resourceARNList != null && (this._resourceARNList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies a list of tags that you want to add to the specified resources. A tag consists
        /// of a key and a value that you define.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public Dictionary<string, string> Tags
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