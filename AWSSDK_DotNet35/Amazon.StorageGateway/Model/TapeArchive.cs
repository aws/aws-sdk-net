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
    public class TapeArchive
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

        // Check to see if TapeStatus property is set
        internal bool IsSetTapeStatus()
        {
            return this.tapeStatus != null;
        }
    }
}
