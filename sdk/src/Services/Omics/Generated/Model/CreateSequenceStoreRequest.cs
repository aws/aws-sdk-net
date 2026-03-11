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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
    /// Container for the parameters to the CreateSequenceStore operation.
    /// Creates a sequence store and returns its metadata. Sequence stores are used to store
    /// sequence data files called read sets that are saved in FASTQ, BAM, uBAM, or CRAM formats.
    /// For aligned formats (BAM and CRAM), a sequence store can only use one reference genome.
    /// For unaligned formats (FASTQ and uBAM), a reference genome is not required. You can
    /// create multiple sequence stores per region per account. 
    /// 
    ///  
    /// <para>
    /// The following are optional parameters you can specify for your sequence store:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use <c>s3AccessConfig</c> to configure your sequence store with S3 access logs (recommended).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>sseConfig</c> to define your own KMS key for encryption.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>eTagAlgorithmFamily</c> to define which algorithm to use for the HealthOmics
    /// eTag on objects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>fallbackLocation</c> to define a backup location for storing files that have
    /// failed a direct upload.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>propagatedSetLevelTags</c> to configure tags that propagate to all objects
    /// in your store.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/create-sequence-store.html">Creating
    /// a HealthOmics sequence store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateSequenceStoreRequest : AmazonOmicsRequest
    {
        private string _clientToken;
        private string _description;
        private ETagAlgorithmFamily _eTagAlgorithmFamily;
        private string _fallbackLocation;
        private string _name;
        private List<string> _propagatedSetLevelTags = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private S3AccessConfig _s3AccessConfig;
        private SseConfig _sseConfig;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An idempotency token used to dedupe retry requests so that duplicate runs are not
        /// created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ETagAlgorithmFamily. 
        /// <para>
        /// The ETag algorithm family to use for ingested read sets. The default value is MD5up.
        /// For more information on ETags, see <a href="https://docs.aws.amazon.com/omics/latest/dev/etags-and-provenance.html">ETags
        /// and data provenance</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        public ETagAlgorithmFamily ETagAlgorithmFamily
        {
            get { return this._eTagAlgorithmFamily; }
            set { this._eTagAlgorithmFamily = value; }
        }

        // Check to see if ETagAlgorithmFamily property is set
        internal bool IsSetETagAlgorithmFamily()
        {
            return this._eTagAlgorithmFamily != null;
        }

        /// <summary>
        /// Gets and sets the property FallbackLocation. 
        /// <para>
        /// An S3 location that is used to store files that have failed a direct upload. You can
        /// add or change the <c>fallbackLocation</c> after creating a sequence store. This is
        /// not required if you are uploading files from a different S3 bucket.
        /// </para>
        /// </summary>
        public string FallbackLocation
        {
            get { return this._fallbackLocation; }
            set { this._fallbackLocation = value; }
        }

        // Check to see if FallbackLocation property is set
        internal bool IsSetFallbackLocation()
        {
            return this._fallbackLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PropagatedSetLevelTags. 
        /// <para>
        /// The tags keys to propagate to the S3 objects associated with read sets in the sequence
        /// store. These tags can be used as input to add metadata to your read sets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> PropagatedSetLevelTags
        {
            get { return this._propagatedSetLevelTags; }
            set { this._propagatedSetLevelTags = value; }
        }

        // Check to see if PropagatedSetLevelTags property is set
        internal bool IsSetPropagatedSetLevelTags()
        {
            return this._propagatedSetLevelTags != null && (this._propagatedSetLevelTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3AccessConfig. 
        /// <para>
        /// S3 access configuration parameters. This specifies the parameters needed to access
        /// logs stored in S3 buckets. The S3 bucket must be in the same region and account as
        /// the sequence store. 
        /// </para>
        /// </summary>
        public S3AccessConfig S3AccessConfig
        {
            get { return this._s3AccessConfig; }
            set { this._s3AccessConfig = value; }
        }

        // Check to see if S3AccessConfig property is set
        internal bool IsSetS3AccessConfig()
        {
            return this._s3AccessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SseConfig. 
        /// <para>
        /// Server-side encryption (SSE) settings for the store.
        /// </para>
        /// </summary>
        public SseConfig SseConfig
        {
            get { return this._sseConfig; }
            set { this._sseConfig = value; }
        }

        // Check to see if SseConfig property is set
        internal bool IsSetSseConfig()
        {
            return this._sseConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the store. You can configure up to 50 tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}