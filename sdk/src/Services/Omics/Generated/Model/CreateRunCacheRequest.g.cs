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
    /// Container for the parameters to the CreateRunCache operation. Creates a run cache
    /// to store and reference task outputs from completed private runs. Specify an Amazon
    /// S3 location where Amazon Web Services HealthOmics saves the cached data. This data
    /// must be immediately accessible and not in an archived state. You can save intermediate
    /// task files to a run cache if they are declared as task outputs in the workflow definition
    /// file. <para> For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflows-call-caching.html">Call
    /// caching</a> and <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-cache-create.html">Creating
    /// a run cache</a> in the <i>Amazon Web Services HealthOmics User Guide</i>. </para>
    /// </summary>
    public partial class CreateRunCacheRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property CacheBehavior. 
        /// <para>
        /// Default cache behavior for runs that use this cache. Supported values are:
        /// </para>
        ///  
        /// <para>
        ///  <c>CACHE_ON_FAILURE</c>: Caches task outputs from completed tasks for runs that fail.
        /// This setting is useful if you're debugging a workflow that fails after several tasks
        /// completed successfully. The subsequent run uses the cache outputs for previously-completed
        /// tasks if the task definition, inputs, and container in ECR are identical to the prior
        /// run.
        /// </para>
        ///  
        /// <para>
        ///  <c>CACHE_ALWAYS</c>: Caches task outputs from completed tasks for all runs. This
        /// setting is useful in development mode, but do not use it in a production setting.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, the default behavior is CACHE_ON_FAILURE. When you start
        /// a run that uses this cache, you can override the default cache behavior.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/how-run-cache.html#run-cache-behavior">Run
        /// cache behavior</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public CacheBehavior CacheBehavior { get; set; }

        /// <summary>
        /// Checks to see if the CacheBehavior property is set.
        /// </summary>
        internal bool IsSetCacheBehavior() => this.CacheBehavior != null;

        /// <summary>
        /// Gets and sets the property CacheBucketOwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the expected owner of the S3 bucket for the
        /// run cache. If not provided, your account ID is set as the owner of the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string CacheBucketOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the CacheBucketOwnerId property is set.
        /// </summary>
        internal bool IsSetCacheBucketOwnerId() => this.CacheBucketOwnerId != null;

        /// <summary>
        /// Gets and sets the property CacheS3Location. 
        /// <para>
        /// Specify the S3 location for storing the cached task outputs. This data must be immediately
        /// accessible (not in an archived state).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CacheS3Location { get; set; }

        /// <summary>
        /// Checks to see if the CacheS3Location property is set.
        /// </summary>
        internal bool IsSetCacheS3Location() => this.CacheS3Location != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Enter a description of the run cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Enter a user-friendly name for the run cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// A unique request token, to ensure idempotency. If you don't specify a token, Amazon
        /// Web Services HealthOmics automatically generates a universally unique identifier (UUID)
        /// for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specify one or more tags to associate with this run cache.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
