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
    /// <para>Represents a virtual tape that is archived in the virtual tape shelf (VTS).</para>
    /// </summary>
    public partial class TapeArchive
    {
        
        private string tapeARN;
        private string tapeBarcode;
        private long? tapeSizeInBytes;
        private DateTime? completionTime;
        private string retrievedTo;
        private string tapeStatus;

        /// <summary>
        /// The Amazon Resource Name (ARN) of an archived virtual tape.
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
        public TapeArchive WithTapeARN(string tapeARN)
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
        /// The barcode that identifies the archived virtual tape.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>8 - 16</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^[A-Z0-9]*$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TapeBarcode
        {
            get { return this.tapeBarcode; }
            set { this.tapeBarcode = value; }
        }

        /// <summary>
        /// Sets the TapeBarcode property
        /// </summary>
        /// <param name="tapeBarcode">The value to set for the TapeBarcode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TapeArchive WithTapeBarcode(string tapeBarcode)
        {
            this.tapeBarcode = tapeBarcode;
            return this;
        }
            

        // Check to see if TapeBarcode property is set
        internal bool IsSetTapeBarcode()
        {
            return this.tapeBarcode != null;
        }

        /// <summary>
        /// The size, in bytes, of the archived virtual tape.
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
        public TapeArchive WithTapeSizeInBytes(long tapeSizeInBytes)
        {
            this.tapeSizeInBytes = tapeSizeInBytes;
            return this;
        }
            

        // Check to see if TapeSizeInBytes property is set
        internal bool IsSetTapeSizeInBytes()
        {
            return this.tapeSizeInBytes.HasValue;
        }

        /// <summary>
        /// The time that the archiving of the virtual tape was completed. The string format of the completion time is in the ISO8601 extended
        /// YYYY-MM-DD'T'HH:MM:SS'Z' format.
        ///  
        /// </summary>
        public DateTime CompletionTime
        {
            get { return this.completionTime ?? default(DateTime); }
            set { this.completionTime = value; }
        }

        /// <summary>
        /// Sets the CompletionTime property
        /// </summary>
        /// <param name="completionTime">The value to set for the CompletionTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TapeArchive WithCompletionTime(DateTime completionTime)
        {
            this.completionTime = completionTime;
            return this;
        }
            

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this.completionTime.HasValue;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway-VTL that the virtual tape is being retrieved to. The virtual tape is retrieved from the
        /// virtual tape shelf (VTS).
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
        public string RetrievedTo
        {
            get { return this.retrievedTo; }
            set { this.retrievedTo = value; }
        }

        /// <summary>
        /// Sets the RetrievedTo property
        /// </summary>
        /// <param name="retrievedTo">The value to set for the RetrievedTo property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TapeArchive WithRetrievedTo(string retrievedTo)
        {
            this.retrievedTo = retrievedTo;
            return this;
        }
            

        // Check to see if RetrievedTo property is set
        internal bool IsSetRetrievedTo()
        {
            return this.retrievedTo != null;
        }

        /// <summary>
        /// The current state of the archived virtual tape.
        ///  
        /// </summary>
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
        public TapeArchive WithTapeStatus(string tapeStatus)
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
