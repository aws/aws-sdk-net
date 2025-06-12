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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Associates the specified tags to a resource with the specified <c>ResourceArn</c>.
    /// If existing tags on a resource are not specified in the request parameters, they are
    /// not changed. If existing tags are specified, however, then their values will be updated.
    /// When a resource is deleted, the tags associated with that resource are deleted as
    /// well.
    /// </summary>
    public partial class TagResourceRequest : AmazonConfigServiceRequest
    {
        private string _resourceArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the resource for which to list the
        /// tags. The following resources are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ConfigurationRecorder</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConfigRule</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OrganizationConfigRule</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConformancePack</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OrganizationConformancePack</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConfigurationAggregator</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AggregationAuthorization</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StoredQuery</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
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
        /// An array of tag object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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