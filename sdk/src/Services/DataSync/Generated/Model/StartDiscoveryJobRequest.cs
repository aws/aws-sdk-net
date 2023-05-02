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
    /// Container for the parameters to the StartDiscoveryJob operation.
    /// Runs a DataSync discovery job on your on-premises storage system. If you haven't added
    /// the storage system to DataSync Discovery yet, do this first by using the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_AddStorageSystem.html">AddStorageSystem</a>
    /// operation.
    /// </summary>
    public partial class StartDiscoveryJobRequest : AmazonDataSyncRequest
    {
        private string _clientToken;
        private int? _collectionDurationMinutes;
        private string _storageSystemArn;
        private List<TagListEntry> _tags = new List<TagListEntry>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Specifies a client token to make sure requests with this API operation are idempotent.
        /// If you don't specify a client token, DataSync generates one for you automatically.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CollectionDurationMinutes. 
        /// <para>
        /// Specifies in minutes how long you want the discovery job to run.
        /// </para>
        ///  <note> 
        /// <para>
        /// For more accurate recommendations, we recommend a duration of at least 14 days. Longer
        /// durations allow time to collect a sufficient number of data points and provide a realistic
        /// representation of storage performance and utilization.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=44640)]
        public int CollectionDurationMinutes
        {
            get { return this._collectionDurationMinutes.GetValueOrDefault(); }
            set { this._collectionDurationMinutes = value; }
        }

        // Check to see if CollectionDurationMinutes property is set
        internal bool IsSetCollectionDurationMinutes()
        {
            return this._collectionDurationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageSystemArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the on-premises storage system that you
        /// want to run the discovery job on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string StorageSystemArn
        {
            get { return this._storageSystemArn; }
            set { this._storageSystemArn = value; }
        }

        // Check to see if StorageSystemArn property is set
        internal bool IsSetStorageSystemArn()
        {
            return this._storageSystemArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies labels that help you categorize, filter, and search for your Amazon Web
        /// Services resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TagListEntry> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}