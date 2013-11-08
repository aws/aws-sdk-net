/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>Settings for one clip in a composition. All jobs in a playlist must have the same clip settings.</para>
    /// </summary>
    public class Clip
    {
        
        private TimeSpan timeSpan;


        /// <summary>
        /// Settings that determine when a clip begins and how long it lasts.
        ///  
        /// </summary>
        public TimeSpan TimeSpan
        {
            get { return this.timeSpan; }
            set { this.timeSpan = value; }
        }

        // Check to see if TimeSpan property is set
        internal bool IsSetTimeSpan()
        {
            return this.timeSpan != null;
        }
    }
}
