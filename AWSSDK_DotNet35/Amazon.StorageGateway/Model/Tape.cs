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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Describes a virtual tape object.
    /// </summary>
    public partial class Tape
    {
        private double? _progress;
        private string _tapeARN;
        private string _tapeBarcode;
        private long? _tapeSizeInBytes;
        private string _tapeStatus;
        private string _vtlDevice;

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// For archiving virtual tapes, indicates how much data remains to be uploaded before
        /// archiving is complete.
        /// </para>
        ///  
        /// <para>
        /// Range: 0 (not started) to 100 (complete).
        /// </para>
        /// </summary>
        public double Progress
        {
            get { return this._progress.GetValueOrDefault(); }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TapeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the virtual tape.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TapeBarcode. 
        /// <para>
        /// The barcode that identifies a specific virtual tape.
        /// </para>
        /// </summary>
        public string TapeBarcode
        {
            get { return this._tapeBarcode; }
            set { this._tapeBarcode = value; }
        }

        // Check to see if TapeBarcode property is set
        internal bool IsSetTapeBarcode()
        {
            return this._tapeBarcode != null;
        }

        /// <summary>
        /// Gets and sets the property TapeSizeInBytes. 
        /// <para>
        /// The size, in bytes, of the virtual tape.
        /// </para>
        /// </summary>
        public long TapeSizeInBytes
        {
            get { return this._tapeSizeInBytes.GetValueOrDefault(); }
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
        /// The current state of the virtual tape. 
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

        /// <summary>
        /// Gets and sets the property VTLDevice. 
        /// <para>
        /// The virtual tape library (VTL) device that the virtual tape is associated with.
        /// </para>
        /// </summary>
        public string VTLDevice
        {
            get { return this._vtlDevice; }
            set { this._vtlDevice = value; }
        }

        // Check to see if VTLDevice property is set
        internal bool IsSetVTLDevice()
        {
            return this._vtlDevice != null;
        }

    }
}