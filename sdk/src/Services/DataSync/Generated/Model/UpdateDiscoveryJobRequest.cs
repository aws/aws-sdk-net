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
    /// Container for the parameters to the UpdateDiscoveryJob operation.
    /// Edits a DataSync discovery job configuration.
    /// </summary>
    public partial class UpdateDiscoveryJobRequest : AmazonDataSyncRequest
    {
        private int? _collectionDurationMinutes;
        private string _discoveryJobArn;

        /// <summary>
        /// Gets and sets the property CollectionDurationMinutes. 
        /// <para>
        /// Specifies in minutes how long that you want the discovery job to run. (You can't set
        /// this parameter to less than the number of minutes that the job has already run for.)
        /// </para>
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
        /// Gets and sets the property DiscoveryJobArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the discovery job that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string DiscoveryJobArn
        {
            get { return this._discoveryJobArn; }
            set { this._discoveryJobArn = value; }
        }

        // Check to see if DiscoveryJobArn property is set
        internal bool IsSetDiscoveryJobArn()
        {
            return this._discoveryJobArn != null;
        }

    }
}