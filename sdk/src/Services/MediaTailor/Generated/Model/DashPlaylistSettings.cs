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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Dash manifest configuration parameters.
    /// </summary>
    public partial class DashPlaylistSettings
    {
        private int? _manifestWindowSeconds;
        private int? _minBufferTimeSeconds;
        private int? _minUpdatePeriodSeconds;
        private int? _suggestedPresentationDelaySeconds;

        /// <summary>
        /// Gets and sets the property ManifestWindowSeconds. 
        /// <para>
        /// The total duration (in seconds) of each manifest. Minimum value: <c>30</c> seconds.
        /// Maximum value: <c>3600</c> seconds.
        /// </para>
        /// </summary>
        public int? ManifestWindowSeconds
        {
            get { return this._manifestWindowSeconds; }
            set { this._manifestWindowSeconds = value; }
        }

        // Check to see if ManifestWindowSeconds property is set
        internal bool IsSetManifestWindowSeconds()
        {
            return this._manifestWindowSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinBufferTimeSeconds. 
        /// <para>
        /// Minimum amount of content (measured in seconds) that a player must keep available
        /// in the buffer. Minimum value: <c>2</c> seconds. Maximum value: <c>60</c> seconds.
        /// </para>
        /// </summary>
        public int? MinBufferTimeSeconds
        {
            get { return this._minBufferTimeSeconds; }
            set { this._minBufferTimeSeconds = value; }
        }

        // Check to see if MinBufferTimeSeconds property is set
        internal bool IsSetMinBufferTimeSeconds()
        {
            return this._minBufferTimeSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinUpdatePeriodSeconds. 
        /// <para>
        /// Minimum amount of time (in seconds) that the player should wait before requesting
        /// updates to the manifest. Minimum value: <c>2</c> seconds. Maximum value: <c>60</c>
        /// seconds.
        /// </para>
        /// </summary>
        public int? MinUpdatePeriodSeconds
        {
            get { return this._minUpdatePeriodSeconds; }
            set { this._minUpdatePeriodSeconds = value; }
        }

        // Check to see if MinUpdatePeriodSeconds property is set
        internal bool IsSetMinUpdatePeriodSeconds()
        {
            return this._minUpdatePeriodSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuggestedPresentationDelaySeconds. 
        /// <para>
        /// Amount of time (in seconds) that the player should be from the live point at the end
        /// of the manifest. Minimum value: <c>2</c> seconds. Maximum value: <c>60</c> seconds.
        /// </para>
        /// </summary>
        public int? SuggestedPresentationDelaySeconds
        {
            get { return this._suggestedPresentationDelaySeconds; }
            set { this._suggestedPresentationDelaySeconds = value; }
        }

        // Check to see if SuggestedPresentationDelaySeconds property is set
        internal bool IsSetSuggestedPresentationDelaySeconds()
        {
            return this._suggestedPresentationDelaySeconds.HasValue; 
        }

    }
}