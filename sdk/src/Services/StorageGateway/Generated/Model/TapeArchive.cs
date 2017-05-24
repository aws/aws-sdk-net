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
    /// Represents a virtual tape that is archived in the virtual tape shelf (VTS).
    /// </summary>
    public partial class TapeArchive
    {
        private DateTime? _completionTime;
        private string _retrievedTo;
        private string _tapeARN;
        private string _tapeBarcode;
        private DateTime? _tapeCreatedDate;
        private long? _tapeSizeInBytes;
        private string _tapeStatus;
        private long? _tapeUsedInBytes;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The time that the archiving of the virtual tape was completed.
        /// </para>
        ///  
        /// <para>
        /// The string format of the completion time is in the ISO8601 extended YYYY-MM-DD'T'HH:MM:SS'Z'
        /// format.
        /// </para>
        /// </summary>
        public DateTime CompletionTime
        {
            get { return this._completionTime.GetValueOrDefault(); }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetrievedTo. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the tape gateway that the virtual tape is being
        /// retrieved to.
        /// </para>
        ///  
        /// <para>
        /// The virtual tape is retrieved from the virtual tape shelf (VTS).
        /// </para>
        /// </summary>
        public string RetrievedTo
        {
            get { return this._retrievedTo; }
            set { this._retrievedTo = value; }
        }

        // Check to see if RetrievedTo property is set
        internal bool IsSetRetrievedTo()
        {
            return this._retrievedTo != null;
        }

        /// <summary>
        /// Gets and sets the property TapeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an archived virtual tape.
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
        /// The barcode that identifies the archived virtual tape.
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
        /// Gets and sets the property TapeCreatedDate.
        /// </summary>
        public DateTime TapeCreatedDate
        {
            get { return this._tapeCreatedDate.GetValueOrDefault(); }
            set { this._tapeCreatedDate = value; }
        }

        // Check to see if TapeCreatedDate property is set
        internal bool IsSetTapeCreatedDate()
        {
            return this._tapeCreatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TapeSizeInBytes. 
        /// <para>
        /// The size, in bytes, of the archived virtual tape.
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
        /// The current state of the archived virtual tape.
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
        /// Gets and sets the property TapeUsedInBytes. 
        /// <para>
        /// The size, in bytes, of data written to the virtual tape.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value is not available for tapes created prior to May,13 2015.
        /// </para>
        ///  </note>
        /// </summary>
        public long TapeUsedInBytes
        {
            get { return this._tapeUsedInBytes.GetValueOrDefault(); }
            set { this._tapeUsedInBytes = value; }
        }

        // Check to see if TapeUsedInBytes property is set
        internal bool IsSetTapeUsedInBytes()
        {
            return this._tapeUsedInBytes.HasValue; 
        }

    }
}