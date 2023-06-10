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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a request to create or edit the <code>StopInstanceOnIdle</code> add-on.
    /// 
    ///  <important> 
    /// <para>
    /// This add-on only applies to Lightsail for Research resources.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class StopInstanceOnIdleRequest
    {
        private string _duration;
        private string _threshold;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The amount of idle time in minutes after which your virtual computer will automatically
        /// stop.
        /// </para>
        /// </summary>
        public string Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The value to compare with the duration.
        /// </para>
        /// </summary>
        public string Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold != null;
        }

    }
}