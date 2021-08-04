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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// An object that enables you to configure your category to be applied to call analytics
    /// jobs where either the customer or agent was interrupted.
    /// </summary>
    public partial class NonTalkTimeFilter
    {
        private AbsoluteTimeRange _absoluteTimeRange;
        private bool? _negate;
        private RelativeTimeRange _relativeTimeRange;
        private long? _threshold;

        /// <summary>
        /// Gets and sets the property AbsoluteTimeRange. 
        /// <para>
        /// An object you can use to specify a time range (in milliseconds) for when no one is
        /// talking. For example, you could specify a time period between the 30,000 millisecond
        /// mark and the 45,000 millisecond mark. You could also specify the time period as the
        /// first 15,000 milliseconds or the last 15,000 milliseconds.
        /// </para>
        /// </summary>
        public AbsoluteTimeRange AbsoluteTimeRange
        {
            get { return this._absoluteTimeRange; }
            set { this._absoluteTimeRange = value; }
        }

        // Check to see if AbsoluteTimeRange property is set
        internal bool IsSetAbsoluteTimeRange()
        {
            return this._absoluteTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property Negate. 
        /// <para>
        /// Set to <code>TRUE</code> to look for a time period when people were talking.
        /// </para>
        /// </summary>
        public bool Negate
        {
            get { return this._negate.GetValueOrDefault(); }
            set { this._negate = value; }
        }

        // Check to see if Negate property is set
        internal bool IsSetNegate()
        {
            return this._negate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelativeTimeRange. 
        /// <para>
        /// An object that allows percentages to specify the proportion of the call where there
        /// was silence. For example, you can specify the first half of the call. You can also
        /// specify the period of time between halfway through to three-quarters of the way through
        /// the call. Because the length of conversation can vary between calls, you can apply
        /// relative time ranges across all calls.
        /// </para>
        /// </summary>
        public RelativeTimeRange RelativeTimeRange
        {
            get { return this._relativeTimeRange; }
            set { this._relativeTimeRange = value; }
        }

        // Check to see if RelativeTimeRange property is set
        internal bool IsSetRelativeTimeRange()
        {
            return this._relativeTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The duration of the period when neither the customer nor agent was talking.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=14400000)]
        public long Threshold
        {
            get { return this._threshold.GetValueOrDefault(); }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

    }
}