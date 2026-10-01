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
    /// Container for the parameters to the DeleteKey operation. Deletes the key value pair
    /// specified by the key.
    /// </summary>
    public partial class DeleteKeyRequest : AmazonCloudFrontKeyValueStoreRequest
    {
        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (ETag) of the Key Value Store that you are deleting keys from,
        /// which you can get using DescribeKeyValueStore.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IfMatch { get; set; }

        /// <summary>
        /// Checks to see if the IfMatch property is set.
        /// </summary>
        internal bool IsSetIfMatch() => this.IfMatch != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

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
    }
}
