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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
        private string _tapeARN;
        private DateTime? _tapeRecoveryPointTime;
        private long? _tapeSizeInBytes;
        private string _tapeStatus;

        /// <summary>
        /// Gets and sets the property TapeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the virtual tape.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string TapeARN
        {
            get { return this._tapeARN; }
            set { this._tapeARN = value; }
        }

        // Check to see if TapeARN property is set
        internal bool IsSetTapeARN()
        {
            return this._tapeARN != null;
        }

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
        public DateTime? TapeRecoveryPointTime
        {
            get { return this._tapeRecoveryPointTime; }
            set { this._tapeRecoveryPointTime = value; }
        }

        // Check to see if TapeRecoveryPointTime property is set
        internal bool IsSetTapeRecoveryPointTime()
        {
            return this._tapeRecoveryPointTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TapeSizeInBytes. 
        /// <para>
        /// The size, in bytes, of the virtual tapes to recover.
        /// </para>
        /// </summary>
        public long? TapeSizeInBytes
        {
            get { return this._tapeSizeInBytes; }
            set { this._tapeSizeInBytes = value; }
        }

        // Check to see if TapeSizeInBytes property is set
        internal bool IsSetTapeSizeInBytes()
        {
            return this._tapeSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TapeStatus. 
        /// <para>
        /// The status of the virtual tapes.
        /// </para>
        /// </summary>
        public string TapeStatus
        {
            get { return this._tapeStatus; }
            set { this._tapeStatus = value; }
        }

        // Check to see if TapeStatus property is set
        internal bool IsSetTapeStatus()
        {
            return this._tapeStatus != null;
        }

    }
}