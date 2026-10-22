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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the detected threats associated with the generated finding.
    /// </summary>
    public partial class Threat
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of occurrences of this specific threat detected during the scan.
        /// </para>
        /// </summary>
        public long? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property Hash. 
        /// <para>
        /// The hash identifier of the detected malware threat.
        /// </para>
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// Checks to see if the Hash property is set.
        /// </summary>
        internal bool IsSetHash() => this.Hash != null;

        /// <summary>
        /// Gets and sets the property ItemDetails. 
        /// <para>
        /// Detailed information about the detected malware threat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ItemDetails> ItemDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<ItemDetails>() : null;

        /// <summary>
        /// Checks to see if the ItemDetails property is set.
        /// </summary>
        internal bool IsSetItemDetails() => this.ItemDetails != null && (this.ItemDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ItemPaths. 
        /// <para>
        /// Information about the nested item path and hash of the protected resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ItemPath> ItemPaths { get; set; } = AWSConfigs.InitializeCollections ? new List<ItemPath>() : null;

        /// <summary>
        /// Checks to see if the ItemPaths property is set.
        /// </summary>
        internal bool IsSetItemPaths() => this.ItemPaths != null && (this.ItemPaths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the detected threat that caused GuardDuty to generate this finding.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Source of the threat that generated this finding.
        /// </para>
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
