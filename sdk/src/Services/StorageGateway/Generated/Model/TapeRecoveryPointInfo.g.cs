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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Describes a recovery point.
    /// </summary>
    public partial class TapeRecoveryPointInfo
    {
        /// <summary>
        /// Gets and sets the property TapeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the virtual tape.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string TapeARN { get; set; }

        /// <summary>
        /// Checks to see if the TapeARN property is set.
        /// </summary>
        internal bool IsSetTapeARN() => this.TapeARN != null;

        /// <summary>
        /// Gets and sets the property TapeRecoveryPointTime. 
        /// <para>
        /// The time when the point-in-time view of the virtual tape was replicated for later
        /// recovery.
        /// </para>
        ///  
        /// <para>
        /// The default timestamp format of the tape recovery point time is in the ISO8601 extended
        /// YYYY-MM-DD'T'HH:MM:SS'Z' format.
        /// </para>
        /// </summary>
        public DateTime? TapeRecoveryPointTime { get; set; }

        /// <summary>
        /// Checks to see if the TapeRecoveryPointTime property is set.
        /// </summary>
        internal bool IsSetTapeRecoveryPointTime() => this.TapeRecoveryPointTime.HasValue;

        /// <summary>
        /// Gets and sets the property TapeSizeInBytes. 
        /// <para>
        /// The size, in bytes, of the virtual tapes to recover.
        /// </para>
        /// </summary>
        public long? TapeSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the TapeSizeInBytes property is set.
        /// </summary>
        internal bool IsSetTapeSizeInBytes() => this.TapeSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property TapeStatus. 
        /// <para>
        /// The status of the virtual tapes.
        /// </para>
        /// </summary>
        public string TapeStatus { get; set; }

        /// <summary>
        /// Checks to see if the TapeStatus property is set.
        /// </summary>
        internal bool IsSetTapeStatus() => this.TapeStatus != null;
    }
}
