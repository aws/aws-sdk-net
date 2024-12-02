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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This structure contains information about the OpenSearch Service collection used for
    /// this integration. An OpenSearch Service collection is a logical grouping of one or
    /// more indexes that represent an analytics workload. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-collections.html">Creating
    /// and managing OpenSearch Service Serverless collections</a>.
    /// </summary>
    public partial class OpenSearchCollection
    {
        private string _collectionArn;
        private string _collectionEndpoint;
        private OpenSearchResourceStatus _status;

        /// <summary>
        /// Gets and sets the property CollectionArn. 
        /// <para>
        /// The ARN of the collection.
        /// </para>
        /// </summary>
        public string CollectionArn
        {
            get { return this._collectionArn; }
            set { this._collectionArn = value; }
        }

        // Check to see if CollectionArn property is set
        internal bool IsSetCollectionArn()
        {
            return this._collectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property CollectionEndpoint. 
        /// <para>
        /// The endpoint of the collection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string CollectionEndpoint
        {
            get { return this._collectionEndpoint; }
            set { this._collectionEndpoint = value; }
        }

        // Check to see if CollectionEndpoint property is set
        internal bool IsSetCollectionEndpoint()
        {
            return this._collectionEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// This structure contains information about the status of this OpenSearch Service resource.
        /// </para>
        /// </summary>
        public OpenSearchResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}