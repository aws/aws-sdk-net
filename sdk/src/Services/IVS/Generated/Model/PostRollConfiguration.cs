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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
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
namespace Amazon.IVS.Model
{
    /// <summary>
    /// Configuration for the post-roll ad break to use for this ad configuration.
    /// </summary>
    public partial class PostRollConfiguration
    {
        private int? _durationSeconds;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// Duration of the post-roll ad break, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public int? DurationSeconds
        {
            get { return this._durationSeconds; }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the post-roll ad configuration is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}