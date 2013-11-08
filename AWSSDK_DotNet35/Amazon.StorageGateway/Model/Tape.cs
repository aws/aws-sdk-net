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
    /// <para>Describes a virtual tape object.</para>
    /// </summary>
    public class Tape
    {
        
        private string tapeARN;
        private string tapeBarcode;
        private long? tapeSizeInBytes;
        private string tapeStatus;
        private string vTLDevice;
        private double? progress;


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

        // Check to see if TapeARN property is set
        internal bool IsSetTapeARN()
        {
            return this.tapeARN != null;
        }

        /// <summary>
        /// The barcode that identifies a specific virtual tape.
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
        /// The size, in bytes, of the virtual tape.
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
        /// The current state of the virtual tape.
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

        /// <summary>
        /// The virtual tape library (VTL) device that the virtual tape is associated with.
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
        public string VTLDevice
        {
            get { return this.vTLDevice; }
            set { this.vTLDevice = value; }
        }

        // Check to see if VTLDevice property is set
        internal bool IsSetVTLDevice()
        {
            return this.vTLDevice != null;
        }

        /// <summary>
        /// For archiving virtual tapes, indicates how much data remains to be uploaded before archiving is complete. Range: 0 (not started) to 100
        /// (complete).
        ///  
        /// </summary>
        public double Progress
        {
            get { return this.progress ?? default(double); }
            set { this.progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this.progress.HasValue;
        }
    }
}
