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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
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
namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Adds tags to the specified AWS Elemental MediaStore container. Tags are key:value
    /// pairs that you can associate with AWS resources. For example, the tag key might be
    /// "customer" and the tag value might be "companyA." You can specify one or more tags
    /// to add to each container. You can add up to 50 tags to each container. For more information
    /// about tagging, including naming and usage conventions, see <a href="https://docs.aws.amazon.com/mediastore/latest/ug/tagging.html">Tagging
    /// Resources in MediaStore</a>.
    /// </summary>
    public partial class TagResourceRequest : AmazonMediaStoreRequest
    {
        private string _resource;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the container. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key:value pairs that you want to add to the container. You need to specify
        /// only the tags that you want to add or update. For example, suppose a container already
        /// has two tags (customer:CompanyA and priority:High). You want to change the priority
        /// tag and also add a third tag (type:Contract). For TagResource, you specify the following
        /// tags: priority:Medium, type:Contract. The result is that your container has three
        /// tags: customer:CompanyA, priority:Medium, and type:Contract.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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