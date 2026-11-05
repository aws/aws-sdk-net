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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteServerlessCache operation. Deletes a specified
    /// existing serverless cache. <note> <para> <c>CreateServerlessCacheSnapshot</c> permission
    /// is required to create a final snapshot. Without this permission, the API call will
    /// fail with an <c>Access Denied</c> exception. </para> </note>
    /// </summary>
    public partial class DeleteServerlessCacheRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property FinalSnapshotName. 
        /// <para>
        /// Name of the final snapshot to be taken before the serverless cache is deleted. Available
        /// for Valkey, Redis OSS and Serverless Memcached only. Default: NULL, i.e. a final snapshot
        /// is not taken.
        /// </para>
        /// </summary>
        public string FinalSnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the FinalSnapshotName property is set.
        /// </summary>
        internal bool IsSetFinalSnapshotName() => this.FinalSnapshotName != null;

        /// <summary>
        /// Gets and sets the property ServerlessCacheName. 
        /// <para>
        /// The identifier of the serverless cache to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServerlessCacheName { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessCacheName property is set.
        /// </summary>
        internal bool IsSetServerlessCacheName() => this.ServerlessCacheName != null;
    }
}
