/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AgentConfiguration
    {
        private int? _periodInSeconds;
        private bool? _shouldProfile;

        /// <summary>
        /// Gets and sets the property PeriodInSeconds.
        /// </summary>
        [AWSProperty(Required=true)]
        public int PeriodInSeconds
        {
            get { return this._periodInSeconds.GetValueOrDefault(); }
            set { this._periodInSeconds = value; }
        }

        // Check to see if PeriodInSeconds property is set
        internal bool IsSetPeriodInSeconds()
        {
            return this._periodInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShouldProfile.
        /// </summary>
        [AWSProperty(Required=true)]
        public bool ShouldProfile
        {
            get { return this._shouldProfile.GetValueOrDefault(); }
            set { this._shouldProfile = value; }
        }

        // Check to see if ShouldProfile property is set
        internal bool IsSetShouldProfile()
        {
            return this._shouldProfile.HasValue; 
        }

    }
}