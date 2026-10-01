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
    /// Container for the parameters to the UpdateSequenceStore operation. Update one or more
    /// parameters for the sequence store.
    /// </summary>
    public partial class UpdateSequenceStoreRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// To ensure that requests don't run multiple times, specify a unique token for each
        /// request.
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
        /// A description for the sequence store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FallbackLocation. 
        /// <para>
        /// The S3 URI of a bucket and folder to store Read Sets that fail to upload.
        /// </para>
        /// </summary>
        public string FallbackLocation { get; set; }

        /// <summary>
        /// Checks to see if the FallbackLocation property is set.
        /// </summary>
        internal bool IsSetFallbackLocation() => this.FallbackLocation != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the sequence store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the sequence store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PropagatedSetLevelTags. 
        /// <para>
        /// The tags keys to propagate to the S3 objects associated with read sets in the sequence
        /// store.
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
        /// S3 access configuration parameters.
        /// </para>
        /// </summary>
        public S3AccessConfig S3AccessConfig { get; set; }

        /// <summary>
        /// Checks to see if the S3AccessConfig property is set.
        /// </summary>
        internal bool IsSetS3AccessConfig() => this.S3AccessConfig != null;
    }
}
