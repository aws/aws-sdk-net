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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the AddTagsToResource operation.
    /// Adds one or more tags to the specified resource. You use tags to add metadata to resources,
    /// which you can use to categorize these resources. For example, you can categorize resources
    /// by purpose, owner, environment, or team. Each tag consists of a key and a value, which
    /// you define. You can add tags to the following Storage Gateway resources:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Storage gateways of all types
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Storage volumes
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Virtual tapes
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// NFS and SMB file shares
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// File System associations
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can create a maximum of 50 tags for each resource. Virtual tapes and storage volumes
    /// that are recovered to a new gateway maintain their tags.
    /// </para>
    /// </summary>
    public partial class AddTagsToResourceRequest : AmazonStorageGatewayRequest
    {
        private string _resourceARN;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource you want to add tags to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pair that represents the tag you want to add to the resource. The value
        /// can be an empty string.
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid characters for key and value are letters, spaces, and numbers representable
        /// in UTF-8 format, and the following special characters: + - = . _ : / @. The maximum
        /// length of a tag's key is 128 characters, and the maximum length for a tag's value
        /// is 256.
        /// </para>
        ///  </note>
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