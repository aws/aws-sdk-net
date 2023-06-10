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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// This is the response object from the ListStorageSystems operation.
    /// </summary>
    public partial class ListStorageSystemsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<StorageSystemListEntry> _storageSystems = new List<StorageSystemListEntry>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The opaque string that indicates the position to begin the next list of results in
        /// the response.
        /// </para>
        /// </summary>
        [AWSProperty(Max=65535)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StorageSystems. 
        /// <para>
        /// The Amazon Resource Names ARNs) of the on-premises storage systems that you're using
        /// with DataSync Discovery.
        /// </para>
        /// </summary>
        public List<StorageSystemListEntry> StorageSystems
        {
            get { return this._storageSystems; }
            set { this._storageSystems = value; }
        }

        // Check to see if StorageSystems property is set
        internal bool IsSetStorageSystems()
        {
            return this._storageSystems != null && this._storageSystems.Count > 0; 
        }

    }
}