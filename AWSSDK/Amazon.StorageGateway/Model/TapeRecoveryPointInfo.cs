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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>Describes a recovery point. </para>
    /// </summary>
    public partial class TapeRecoveryPointInfo
    {
        
        private string tapeARN;
        private DateTime? tapeRecoveryPointTime;
        private long? tapeSizeInBytes;
        private string tapeStatus;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the virtual tape.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TapeARN
        {
            get { return this.tapeARN; }
            set { this.tapeARN = value; }
        }

        /// <summary>
        /// Sets the TapeARN property
        /// </summary>
        /// <param name="tapeARN">The value to set for the TapeARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TapeRecoveryPointInfo WithTapeARN(string tapeARN)
        {
            this.tapeARN = tapeARN;
            return this;
        }
            

        // Check to see if TapeARN property is set
        internal bool IsSetTapeARN()
        {
            return this.tapeARN != null;
        }

        /// <summary>
        /// The time when the point-in-time view of the virtual tape was replicated for later recovery. The string format of the tape recovery point
        /// time is in the ISO8601 extended YYYY-MM-DD'T'HH:MM:SS'Z' format.
        ///  
        /// </summary>
        public DateTime TapeRecoveryPointTime
        {
            get { return this.tapeRecoveryPointTime ?? default(DateTime); }
            set { this.tapeRecoveryPointTime = value; }
        }

        /// <summary>
        /// Sets the TapeRecoveryPointTime property
        /// </summary>
        /// <param name="tapeRecoveryPointTime">The value to set for the TapeRecoveryPointTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TapeRecoveryPointInfo WithTapeRecoveryPointTime(DateTime tapeRecoveryPointTime)
        {
            this.tapeRecoveryPointTime = tapeRecoveryPointTime;
            return this;
        }
            

        // Check to see if TapeRecoveryPointTime property is set
        internal bool IsSetTapeRecoveryPointTime()
        {
            return this.tapeRecoveryPointTime.HasValue;
        }

        /// <summary>
        /// The size, in bytes, of the virtual tapes to recover.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>107374182400 - 2748779069440</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public long TapeSizeInBytes
        {
            get { return this.tapeSizeInBytes ?? default(long); }
            set { this.tapeSizeInBytes = value; }
        }

        /// <summary>
        /// Sets the TapeSizeInBytes property
        /// </summary>
        /// <param name="tapeSizeInBytes">The value to set for the TapeSizeInBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TapeRecoveryPointInfo WithTapeSizeInBytes(long tapeSizeInBytes)
        {
            this.tapeSizeInBytes = tapeSizeInBytes;
            return this;
        }
            

        // Check to see if TapeSizeInBytes property is set
        internal bool IsSetTapeSizeInBytes()
        {
            return this.tapeSizeInBytes.HasValue;
        }
        public string TapeStatus
        {
            get { return this.tapeStatus; }
            set { this.tapeStatus = value; }
        }

        /// <summary>
        /// Sets the TapeStatus property
        /// </summary>
        /// <param name="tapeStatus">The value to set for the TapeStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TapeRecoveryPointInfo WithTapeStatus(string tapeStatus)
        {
            this.tapeStatus = tapeStatus;
            return this;
        }
            

        // Check to see if TapeStatus property is set
        internal bool IsSetTapeStatus()
        {
            return this.tapeStatus != null;
        }
    }
}
