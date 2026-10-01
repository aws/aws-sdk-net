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

namespace Amazon.CloudFrontKeyValueStore.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateKeys operation. Puts or Deletes multiple
    /// key value pairs in a single, all-or-nothing operation.
    /// </summary>
    public partial class UpdateKeysRequest : AmazonCloudFrontKeyValueStoreRequest
    {
        /// <summary>
        /// Gets and sets the property Deletes. 
        /// <para>
        /// List of keys to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeleteKeyRequestListItem> Deletes { get; set; } = AWSConfigs.InitializeCollections ? new List<DeleteKeyRequestListItem>() : null;

        /// <summary>
        /// Checks to see if the Deletes property is set.
        /// </summary>
        internal bool IsSetDeletes() => this.Deletes != null && (this.Deletes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (ETag) of the Key Value Store that you are updating keys of, which
        /// you can get using DescribeKeyValueStore.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IfMatch { get; set; }

        /// <summary>
        /// Checks to see if the IfMatch property is set.
        /// </summary>
        internal bool IsSetIfMatch() => this.IfMatch != null;

        /// <summary>
        /// Gets and sets the property KvsARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Key Value Store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string KvsARN { get; set; }

        /// <summary>
        /// Checks to see if the KvsARN property is set.
        /// </summary>
        internal bool IsSetKvsARN() => this.KvsARN != null;

        /// <summary>
        /// Gets and sets the property Puts. 
        /// <para>
        /// List of key value pairs to put.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PutKeyRequestListItem> Puts { get; set; } = AWSConfigs.InitializeCollections ? new List<PutKeyRequestListItem>() : null;

        /// <summary>
        /// Checks to see if the Puts property is set.
        /// </summary>
        internal bool IsSetPuts() => this.Puts != null && (this.Puts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
