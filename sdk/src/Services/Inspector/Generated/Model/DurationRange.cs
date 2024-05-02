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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This data type is used in the <a>AssessmentTemplateFilter</a> data type.
    /// </summary>
    public partial class DurationRange
    {
        private int? _maxSeconds;
        private int? _minSeconds;

        /// <summary>
        /// Gets and sets the property MaxSeconds. 
        /// <para>
        /// The maximum value of the duration range. Must be less than or equal to 604800 seconds
        /// (1 week).
        /// </para>
        /// </summary>
        [AWSProperty(Min=180, Max=86400)]
        public int? MaxSeconds
        {
            get { return this._maxSeconds; }
            set { this._maxSeconds = value; }
        }

        // Check to see if MaxSeconds property is set
        internal bool IsSetMaxSeconds()
        {
            return this._maxSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSeconds. 
        /// <para>
        /// The minimum value of the duration range. Must be greater than zero.
        /// </para>
        /// </summary>
        [AWSProperty(Min=180, Max=86400)]
        public int? MinSeconds
        {
            get { return this._minSeconds; }
            set { this._minSeconds = value; }
        }

        // Check to see if MinSeconds property is set
        internal bool IsSetMinSeconds()
        {
            return this._minSeconds.HasValue; 
        }

    }
}