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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Settings for one clip in a composition. All jobs in a playlist must have the same
    /// clip settings.
    /// </summary>
    public partial class Clip
    {
        private TimeSpan _timeSpan;


        /// <summary>
        /// Gets and sets the property TimeSpan. 
        /// <para>
        /// Settings that determine when a clip begins and how long it lasts.
        /// </para>
        /// </summary>
        public TimeSpan TimeSpan
        {
            get { return this._timeSpan; }
            set { this._timeSpan = value; }
        }

        // Check to see if TimeSpan property is set
        internal bool IsSetTimeSpan()
        {
            return this._timeSpan != null;
        }

    }
}