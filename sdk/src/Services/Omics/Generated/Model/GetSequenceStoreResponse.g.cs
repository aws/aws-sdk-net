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
    /// This is the response object from the GetSequenceStore operation.
    /// </summary>
    public partial class GetSequenceStoreResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The store's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the store was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The store's description.
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
        /// The algorithm family of the ETag.
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
        /// An S3 location that is used to store files that have failed a direct upload.
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
        /// The store's ID.
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
        /// The store's name.
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
        /// Gets and sets the property S3Access. 
        /// <para>
        /// The S3 metadata of a sequence store, including the ARN and S3 URI of the S3 bucket.
        /// </para>
        /// </summary>
        public SequenceStoreS3Access S3Access { get; set; }

        /// <summary>
        /// Checks to see if the S3Access property is set.
        /// </summary>
        internal bool IsSetS3Access() => this.S3Access != null;

        /// <summary>
        /// Gets and sets the property SseConfig. 
        /// <para>
        /// The store's server-side encryption (SSE) settings.
        /// </para>
        /// </summary>
        public SseConfig SseConfig { get; set; }

        /// <summary>
        /// Checks to see if the SseConfig property is set.
        /// </summary>
        internal bool IsSetSseConfig() => this.SseConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the sequence store.
        /// </para>
        /// </summary>
        public SequenceStoreStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message of the sequence store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The last-updated time of the sequence store.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
