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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Detailed metadata information about a router input source.
    /// </summary>
    public partial class RouterInputSourceMetadataDetails
    {
        /// <summary>
        /// Gets and sets the property RouterInputMetadata. 
        /// <para>
        /// Metadata information specific to the router input configuration and state.
        /// </para>
        /// </summary>
        public RouterInputMetadata RouterInputMetadata { get; set; }

        /// <summary>
        /// Checks to see if the RouterInputMetadata property is set.
        /// </summary>
        internal bool IsSetRouterInputMetadata() => this.RouterInputMetadata != null;

        /// <summary>
        /// Gets and sets the property SourceMetadataMessages. 
        /// <para>
        /// Collection of metadata messages associated with the router input source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouterInputMessage> SourceMetadataMessages { get; set; } = AWSConfigs.InitializeCollections ? new List<RouterInputMessage>() : null;

        /// <summary>
        /// Checks to see if the SourceMetadataMessages property is set.
        /// </summary>
        internal bool IsSetSourceMetadataMessages() => this.SourceMetadataMessages != null && (this.SourceMetadataMessages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp when the metadata was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
