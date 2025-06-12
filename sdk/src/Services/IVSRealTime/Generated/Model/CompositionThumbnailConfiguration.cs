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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// An object representing a configuration of thumbnails for recorded video for a <a>Composition</a>.
    /// </summary>
    public partial class CompositionThumbnailConfiguration
    {
        private List<string> _storage = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _targetIntervalSeconds;

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// Indicates the format in which thumbnails are recorded. <c>SEQUENTIAL</c> records all
        /// generated thumbnails in a serial manner, to the media/thumbnails/(width)x(height)
        /// directory, where (width) and (height) are the width and height of the thumbnail. <c>LATEST</c>
        /// saves the latest thumbnail in media/latest_thumbnail/(width)x(height)/thumb.jpg and
        /// overwrites it at the interval specified by <c>targetIntervalSeconds</c>. You can enable
        /// both <c>SEQUENTIAL</c> and <c>LATEST</c>. Default: <c>SEQUENTIAL</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> Storage
        {
            get { return this._storage; }
            set { this._storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this._storage != null && (this._storage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetIntervalSeconds. 
        /// <para>
        /// The targeted thumbnail-generation interval in seconds. Default: 60.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=86400)]
        public int? TargetIntervalSeconds
        {
            get { return this._targetIntervalSeconds; }
            set { this._targetIntervalSeconds = value; }
        }

        // Check to see if TargetIntervalSeconds property is set
        internal bool IsSetTargetIntervalSeconds()
        {
            return this._targetIntervalSeconds.HasValue; 
        }

    }
}