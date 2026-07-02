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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for integer-second duration normalization. When this preprocessor is present,
    /// the output duration will be adjusted to an exact integer-second boundary. If the input
    /// is within the trim threshold of an integer second, trailing frames are dropped. If
    /// within the compression threshold and less than 500ms over the previous integer second,
    /// the output is sped up slightly. Otherwise, black frames are padded to the next integer
    /// second.
    /// </summary>
    public partial class DurationControl
    {
        private int? _integerDurationMaximumCompressionDenominator;
        private int? _integerDurationMaximumCompressionNumerator;
        private int? _integerDurationTrimThresholdMilliseconds;

        /// <summary>
        /// Gets and sets the property IntegerDurationMaximumCompressionDenominator. Required.
        /// Denominator of the maximum allowed compression ratio.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int? IntegerDurationMaximumCompressionDenominator
        {
            get { return this._integerDurationMaximumCompressionDenominator; }
            set { this._integerDurationMaximumCompressionDenominator = value; }
        }

        // Check to see if IntegerDurationMaximumCompressionDenominator property is set
        internal bool IsSetIntegerDurationMaximumCompressionDenominator()
        {
            return this._integerDurationMaximumCompressionDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntegerDurationMaximumCompressionNumerator. Required. Numerator
        /// of the maximum allowed compression ratio, defined as overrun divided by target duration.
        /// For example, numerator 5 with denominator 100 means max 5% compression. Set to 0 to
        /// disable compression entirely (only trim or pad will be used).
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? IntegerDurationMaximumCompressionNumerator
        {
            get { return this._integerDurationMaximumCompressionNumerator; }
            set { this._integerDurationMaximumCompressionNumerator = value; }
        }

        // Check to see if IntegerDurationMaximumCompressionNumerator property is set
        internal bool IsSetIntegerDurationMaximumCompressionNumerator()
        {
            return this._integerDurationMaximumCompressionNumerator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntegerDurationTrimThresholdMilliseconds. Maximum number
        /// of fractional milliseconds past an integer second that qualify for the trim path (frame
        /// dropping). Default is 0 (trimming disabled).
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public int? IntegerDurationTrimThresholdMilliseconds
        {
            get { return this._integerDurationTrimThresholdMilliseconds; }
            set { this._integerDurationTrimThresholdMilliseconds = value; }
        }

        // Check to see if IntegerDurationTrimThresholdMilliseconds property is set
        internal bool IsSetIntegerDurationTrimThresholdMilliseconds()
        {
            return this._integerDurationTrimThresholdMilliseconds.HasValue; 
        }

    }
}