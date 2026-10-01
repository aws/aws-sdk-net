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
    /// Container for the parameters to the CreateSequenceStore operation. Creates a sequence
    /// store and returns its metadata. Sequence stores are used to store sequence data files
    /// called read sets that are saved in FASTQ, BAM, uBAM, or CRAM formats. For aligned
    /// formats (BAM and CRAM), a sequence store can only use one reference genome. For unaligned
    /// formats (FASTQ and uBAM), a reference genome is not required. You can create multiple
    /// sequence stores per region per account. <para> The following are optional parameters
    /// you can specify for your sequence store: </para> <ul> <li> <para> Use <c>s3AccessConfig</c>
    /// to configure your sequence store with S3 access logs (recommended). </para> </li>
    /// <li> <para> Use <c>sseConfig</c> to define your own KMS key for encryption. </para>
    /// </li> <li> <para> Use <c>eTagAlgorithmFamily</c> to define which algorithm to use
    /// for the HealthOmics eTag on objects. </para> </li> <li> <para> Use <c>fallbackLocation</c>
    /// to define a backup location for storing files that have failed a direct upload. </para>
    /// </li> <li> <para> Use <c>propagatedSetLevelTags</c> to configure tags that propagate
    /// to all objects in your store. </para> </li> </ul> <para> For more information, see
    /// <a href="https://docs.aws.amazon.com/omics/latest/dev/create-sequence-store.html">Creating
    /// a HealthOmics sequence store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateSequenceStoreRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An idempotency token used to dedupe retry requests so that duplicate runs are not
        /// created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ETagAlgorithmFamily. 
        /// <para>
        /// The ETag algorithm family to use for ingested read sets. The default value is MD5up.
        /// For more information on ETags, see <a href="https://docs.aws.amazon.com/omics/latest/dev/etags-and-provenance.html">ETags
        /// and data provenance</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        public ETagAlgorithmFamily ETagAlgorithmFamily { get; set; }

        /// <summary>
        /// Checks to see if the ETagAlgorithmFamily property is set.
        /// </summary>
        internal bool IsSetETagAlgorithmFamily() => this.ETagAlgorithmFamily != null;

        /// <summary>
        /// Gets and sets the property FallbackLocation. 
        /// <para>
        /// An S3 location that is used to store files that have failed a direct upload. You can
        /// add or change the <c>fallbackLocation</c> after creating a sequence store. This is
        /// not required if you are uploading files from a different S3 bucket.
        /// </para>
        /// </summary>
        public string FallbackLocation { get; set; }

        /// <summary>
        /// Checks to see if the FallbackLocation property is set.
        /// </summary>
        internal bool IsSetFallbackLocation() => this.FallbackLocation != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PropagatedSetLevelTags. 
        /// <para>
        /// The tags keys to propagate to the S3 objects associated with read sets in the sequence
        /// store. These tags can be used as input to add metadata to your read sets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> PropagatedSetLevelTags { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PropagatedSetLevelTags property is set.
        /// </summary>
        internal bool IsSetPropagatedSetLevelTags() => this.PropagatedSetLevelTags != null && (this.PropagatedSetLevelTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3AccessConfig. 
        /// <para>
        /// S3 access configuration parameters. This specifies the parameters needed to access
        /// logs stored in S3 buckets. The S3 bucket must be in the same region and account as
        /// the sequence store. 
        /// </para>
        /// </summary>
        public S3AccessConfig S3AccessConfig { get; set; }

        /// <summary>
        /// Checks to see if the S3AccessConfig property is set.
        /// </summary>
        internal bool IsSetS3AccessConfig() => this.S3AccessConfig != null;

        /// <summary>
        /// Gets and sets the property SseConfig. 
        /// <para>
        /// Server-side encryption (SSE) settings for the store.
        /// </para>
        /// </summary>
        public SseConfig SseConfig { get; set; }

        /// <summary>
        /// Checks to see if the SseConfig property is set.
        /// </summary>
        internal bool IsSetSseConfig() => this.SseConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the store. You can configure up to 50 tags.
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
