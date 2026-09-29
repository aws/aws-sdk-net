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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// List entry for one run cache.
    /// </summary>
    public partial class RunCacheListItem
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Unique resource identifier for the run cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CacheBehavior. 
        /// <para>
        /// Default cache behavior for the run cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public CacheBehavior CacheBehavior { get; set; }

        /// <summary>
        /// Checks to see if the CacheBehavior property is set.
        /// </summary>
        internal bool IsSetCacheBehavior() => this.CacheBehavior != null;

        /// <summary>
        /// Gets and sets the property CacheS3Uri. 
        /// <para>
        /// The S3 uri for the run cache data.
        /// </para>
        /// </summary>
        public string CacheS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the CacheS3Uri property is set.
        /// </summary>
        internal bool IsSetCacheS3Uri() => this.CacheS3Uri != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that this run cache was created (an ISO 8601 formatted string).
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for this run cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the run cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The run cache status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public RunCacheStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
