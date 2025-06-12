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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Probe results for your media file.
    /// </summary>
    public partial class ProbeResult
    {
        private Container _container;
        private Metadata _metadata;
        private List<TrackMapping> _trackMappings = AWSConfigs.InitializeCollections ? new List<TrackMapping>() : null;

        /// <summary>
        /// Gets and sets the property Container. The container of your media file. This information
        /// helps you understand the overall structure and details of your media, including format,
        /// duration, and track layout.
        /// </summary>
        public Container Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. Metadata and other file information.
        /// </summary>
        public Metadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property TrackMappings. An array containing track mapping information.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TrackMapping> TrackMappings
        {
            get { return this._trackMappings; }
            set { this._trackMappings = value; }
        }

        // Check to see if TrackMappings property is set
        internal bool IsSetTrackMappings()
        {
            return this._trackMappings != null && (this._trackMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}