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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// Describes the time stamp range and time stamp origin of a range of fragments.
    /// </summary>
    public partial class FragmentSelector
    {
        private FragmentSelectorType _fragmentSelectorType;
        private TimestampRange _timestampRange;

        /// <summary>
        /// Gets and sets the property FragmentSelectorType. 
        /// <para>
        /// The origin of the time stamps to use (Server or Producer).
        /// </para>
        /// </summary>
        public FragmentSelectorType FragmentSelectorType
        {
            get { return this._fragmentSelectorType; }
            set { this._fragmentSelectorType = value; }
        }

        // Check to see if FragmentSelectorType property is set
        internal bool IsSetFragmentSelectorType()
        {
            return this._fragmentSelectorType != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampRange. 
        /// <para>
        /// The range of time stamps to return.
        /// </para>
        /// </summary>
        public TimestampRange TimestampRange
        {
            get { return this._timestampRange; }
            set { this._timestampRange = value; }
        }

        // Check to see if TimestampRange property is set
        internal bool IsSetTimestampRange()
        {
            return this._timestampRange != null;
        }

    }
}