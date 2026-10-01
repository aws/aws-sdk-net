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
    /// An annotation store.
    /// </summary>
    public partial class AnnotationStoreItem
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The store's creation time.
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
        [AWSProperty(Required = true, Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The store's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Reference. 
        /// <para>
        /// The store's genome reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReferenceItem Reference { get; set; }

        /// <summary>
        /// Checks to see if the Reference property is set.
        /// </summary>
        internal bool IsSetReference() => this.Reference != null;

        /// <summary>
        /// Gets and sets the property SseConfig. 
        /// <para>
        /// The store's server-side encryption (SSE) settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SseConfig SseConfig { get; set; }

        /// <summary>
        /// Checks to see if the SseConfig property is set.
        /// </summary>
        internal bool IsSetSseConfig() => this.SseConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The store's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StoreStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The store's status message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StoreArn. 
        /// <para>
        /// The store's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string StoreArn { get; set; }

        /// <summary>
        /// Checks to see if the StoreArn property is set.
        /// </summary>
        internal bool IsSetStoreArn() => this.StoreArn != null;

        /// <summary>
        /// Gets and sets the property StoreFormat. 
        /// <para>
        /// The store's file format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StoreFormat StoreFormat { get; set; }

        /// <summary>
        /// Checks to see if the StoreFormat property is set.
        /// </summary>
        internal bool IsSetStoreFormat() => this.StoreFormat != null;

        /// <summary>
        /// Gets and sets the property StoreSizeBytes. 
        /// <para>
        /// The store's size in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? StoreSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the StoreSizeBytes property is set.
        /// </summary>
        internal bool IsSetStoreSizeBytes() => this.StoreSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// When the store was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
