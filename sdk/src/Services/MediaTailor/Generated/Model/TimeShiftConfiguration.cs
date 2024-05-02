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
    /// The configuration for time-shifted viewing.
    /// </summary>
    public partial class TimeShiftConfiguration
    {
        private int? _maxTimeDelaySeconds;

        /// <summary>
        /// Gets and sets the property MaxTimeDelaySeconds. 
        /// <para>
        ///  The maximum time delay for time-shifted viewing. The minimum allowed maximum time
        /// delay is 0 seconds, and the maximum allowed maximum time delay is 21600 seconds (6
        /// hours). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaxTimeDelaySeconds
        {
            get { return this._maxTimeDelaySeconds; }
            set { this._maxTimeDelaySeconds = value; }
        }

        // Check to see if MaxTimeDelaySeconds property is set
        internal bool IsSetMaxTimeDelaySeconds()
        {
            return this._maxTimeDelaySeconds.HasValue; 
        }

    }
}