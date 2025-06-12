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
 * Do not modify this file. This file is generated from the cloudfront-keyvaluestore-2022-07-26.normal.json service model.
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
    /// Container for the parameters to the UpdateKeys operation.
    /// Puts or Deletes multiple key value pairs in a single, all-or-nothing operation.
    /// </summary>
    public partial class UpdateKeysRequest : AmazonCloudFrontKeyValueStoreRequest
    {
        private List<DeleteKeyRequestListItem> _deletes = AWSConfigs.InitializeCollections ? new List<DeleteKeyRequestListItem>() : null;
        private string _ifMatch;
        private string _kvsARN;
        private List<PutKeyRequestListItem> _puts = AWSConfigs.InitializeCollections ? new List<PutKeyRequestListItem>() : null;

        /// <summary>
        /// Gets and sets the property Deletes. 
        /// <para>
        /// List of keys to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeleteKeyRequestListItem> Deletes
        {
            get { return this._deletes; }
            set { this._deletes = value; }
        }

        // Check to see if Deletes property is set
        internal bool IsSetDeletes()
        {
            return this._deletes != null && (this._deletes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (ETag) of the Key Value Store that you are updating keys of, which
        /// you can get using DescribeKeyValueStore.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property KvsARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Key Value Store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string KvsARN
        {
            get { return this._kvsARN; }
            set { this._kvsARN = value; }
        }

        // Check to see if KvsARN property is set
        internal bool IsSetKvsARN()
        {
            return this._kvsARN != null;
        }

        /// <summary>
        /// Gets and sets the property Puts. 
        /// <para>
        /// List of key value pairs to put.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PutKeyRequestListItem> Puts
        {
            get { return this._puts; }
            set { this._puts = value; }
        }

        // Check to see if Puts property is set
        internal bool IsSetPuts()
        {
            return this._puts != null && (this._puts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}