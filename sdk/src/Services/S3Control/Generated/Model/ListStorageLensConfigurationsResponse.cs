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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// This is the response object from the ListStorageLensConfigurations operation.
    /// </summary>
    public partial class ListStorageLensConfigurationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ListStorageLensConfigurationEntry> _storageLensConfigurationList = new List<ListStorageLensConfigurationEntry>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the request produced more than the maximum number of S3 Storage Lens configuration
        /// results, you can pass this value into a subsequent request to retrieve the next page
        /// of results.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StorageLensConfigurationList. 
        /// <para>
        /// A list of S3 Storage Lens configurations.
        /// </para>
        /// </summary>
        public List<ListStorageLensConfigurationEntry> StorageLensConfigurationList
        {
            get { return this._storageLensConfigurationList; }
            set { this._storageLensConfigurationList = value; }
        }

        // Check to see if StorageLensConfigurationList property is set
        internal bool IsSetStorageLensConfigurationList()
        {
            return this._storageLensConfigurationList != null && this._storageLensConfigurationList.Count > 0; 
        }

    }
}