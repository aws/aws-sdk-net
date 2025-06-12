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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Provides information on any <c>TranscriptFilterType</c> categories that matched your
    /// transcription output. Matches are identified for each segment upon completion of that
    /// segment.
    /// </summary>
    public partial class CategoryEvent
        : IEventStreamEvent
    {
        private List<string> _matchedCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, PointsOfInterest> _matchedDetails = AWSConfigs.InitializeCollections ? new Dictionary<string, PointsOfInterest>() : null;

        /// <summary>
        /// Gets and sets the property MatchedCategories. 
        /// <para>
        /// Lists the categories that were matched in your audio segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchedCategories
        {
            get { return this._matchedCategories; }
            set { this._matchedCategories = value; }
        }

        // Check to see if MatchedCategories property is set
        internal bool IsSetMatchedCategories()
        {
            return this._matchedCategories != null && (this._matchedCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatchedDetails. 
        /// <para>
        /// Contains information about the matched categories, including category names and timestamps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PointsOfInterest> MatchedDetails
        {
            get { return this._matchedDetails; }
            set { this._matchedDetails = value; }
        }

        // Check to see if MatchedDetails property is set
        internal bool IsSetMatchedDetails()
        {
            return this._matchedDetails != null && (this._matchedDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}