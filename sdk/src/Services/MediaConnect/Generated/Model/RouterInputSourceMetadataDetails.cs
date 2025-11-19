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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
        private RouterInputMetadata _routerInputMetadata;
        private List<RouterInputMessage> _sourceMetadataMessages = AWSConfigs.InitializeCollections ? new List<RouterInputMessage>() : null;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property RouterInputMetadata. 
        /// <para>
        /// Metadata information specific to the router input configuration and state.
        /// </para>
        /// </summary>
        public RouterInputMetadata RouterInputMetadata
        {
            get { return this._routerInputMetadata; }
            set { this._routerInputMetadata = value; }
        }

        // Check to see if RouterInputMetadata property is set
        internal bool IsSetRouterInputMetadata()
        {
            return this._routerInputMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property SourceMetadataMessages. 
        /// <para>
        /// Collection of metadata messages associated with the router input source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouterInputMessage> SourceMetadataMessages
        {
            get { return this._sourceMetadataMessages; }
            set { this._sourceMetadataMessages = value; }
        }

        // Check to see if SourceMetadataMessages property is set
        internal bool IsSetSourceMetadataMessages()
        {
            return this._sourceMetadataMessages != null && (this._sourceMetadataMessages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp when the metadata was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}