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
    /// The metadata and analysis results for a media file.
    /// </summary>
    public partial class ProbeResult
    {
        private Container _container;
        private Metadata _metadata;
        private List<TrackMapping> _trackMappings = AWSConfigs.InitializeCollections ? new List<TrackMapping>() : null;

        /// <summary>
        /// Gets and sets the property Container. Information about the container format of the
        /// media file.
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
        /// Gets and sets the property Metadata. Metadata about the file.
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
        /// Gets and sets the property TrackMappings. List of Track mapping objects.
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